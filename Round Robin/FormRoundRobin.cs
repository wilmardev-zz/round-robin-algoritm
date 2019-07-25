using Round_Robin.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Round_Robin
{
    public partial class FormRoundRobin : Form
    {
        private List<Process> processList = new List<Process>();

        public FormRoundRobin()
        {
            InitializeComponent();
            lblIntercambio.Text = "Intercambio: ";
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarNombreProcesoDuplicado())
                return;

            if (!ValidarCamposObligatorios())
                return;

            Process process = new Process
            {
                Name = txtProceso.Text,
                Ncpu = Convert.ToInt32(txtNcpu.Text),
                SpendES = !string.IsNullOrEmpty(txtGastaES.Text) ? Convert.ToInt32(txtGastaES.Text) : 0,
                ArrivalTime = Convert.ToInt32(txtTLlegada.Text),
                QuantumRemaining = Convert.ToInt32(txtNcpu.Text),
                NCPUES = !string.IsNullOrEmpty(txtNCPUES.Text) ? Convert.ToInt32(txtNCPUES.Text) : 0,
                NCPUES2 = !string.IsNullOrEmpty(txtNCPUESdos.Text) ? Convert.ToInt32(txtNCPUESdos.Text) : 0,
                Gasta2 = !string.IsNullOrEmpty(txtGastados.Text) ? Convert.ToInt32(txtGastados.Text) : 0
            };
            processList.Add(process);
            tblPrincipal.Rows.Add(process.Name, process.ArrivalTime, process.Ncpu, process.SpendES, process.NCPUES, process.Gasta2, process.NCPUES2);
        }

        private bool ValidarNombreProcesoDuplicado()
        {
            if (processList.Any(x => x.Name.Equals(txtProceso.Text, StringComparison.InvariantCultureIgnoreCase)))
            {
                MessageBox.Show("Ya existe un proceso con el mismo nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidarCamposObligatorios()
        {
            if (string.IsNullOrEmpty(txtProceso.Text) || string.IsNullOrEmpty(txtTLlegada.Text) || string.IsNullOrEmpty(txtNcpu.Text) || string.IsNullOrEmpty(txtQuantum.Text))
            {
                MessageBox.Show("Los siguientes campos son obligatorios:\n- Proceso\n- Tiempo Llegada\n- NCPU\n- Tamaño Quantum", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            HabilitarBoton(false);

            try
            {
                if (!ValidarContenidoProcesos())
                    return;

                InstanciarListas(out List<Process> newProcessList, out List<ESProces> processesES, out List<Grantt> granttsList, out List<Process> colaListos);

                InstanciaVariables(out int quantum, out int intercambio, out int inicio, out int fin, out bool isFirst);

                do
                {
                    Process currentProcess = ObtenerProcesoActual(ref isFirst, ref newProcessList, ref colaListos);

                    inicio = fin;
                    fin += quantum;
                    currentProcess.restarQuantum();

                    //Agregamos proceso a diagrama de grantt y lo tachamos
                    granttsList.Add(new Grantt { Process = currentProcess, SumLeft = inicio, SumRight = fin });
                    currentProcess.Tachado = true;

                    //Se hace una E/S en caso de que aplique
                    if (currentProcess.QuantumRemaining == 0 && currentProcess.NCPUES != 0)
                    {
                        Process newProcess = AgregarEntradaSalida(ref currentProcess);
                        processesES.Add(new ESProces { Process = newProcess, Arrive = ((newProcess.SpendES * quantum) + (fin + intercambio)) });
                        tblES.Rows.Add(currentProcess.Name, ((currentProcess.SpendES * quantum) + (fin + intercambio)));
                    }

                    //Agregamos a cola de listos las E/S que ya pueden volver
                    List<Process> entranAListos = processesES.Where(t => t.Arrive <= fin).Select(j => j.Process).ToList();
                    List<Process> currentItems = AgregarProcesosEstadoListo(ref entranAListos, ref colaListos);
                    processesES.RemoveAll(t => currentItems.Contains(t.Process));

                    //Removemos proceso de lista inicial
                    newProcessList.Remove(currentProcess);

                    //Busca y agrega los procesos de la lista inicial que entraron durante la ejecución del proceso actual
                    entranAListos = newProcessList.Select(t => t).Where(j => j.ArrivalTime <= fin).ToList();
                    foreach (var item in entranAListos)
                    {
                        colaListos.Add(item);
                        newProcessList.Remove(item);
                    }

                    if (currentProcess.QuantumRemaining != 0)//Encolamos el proceso actual
                        EncolarProcesoActual(ref currentProcess, ref colaListos);

                    fin += intercambio;
                } while (colaListos.Select(t => t).Where(j => !j.Tachado).ToList().Count > 0);

                LlenarTblGranttListos(colaListos, granttsList);
                HabilitarBoton(true);
            }
            catch (Exception ex)
            {
                HabilitarBoton(true);
                MessageBox.Show("Ha ocurrido un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HabilitarBoton(bool estado)
        {
            btnAgregar.Enabled = estado;
            btnGo.Enabled = estado;
            btnClear.Enabled = estado;
        }

        private Process ObtenerProcesoActual(ref bool isFirst, ref List<Process> newProcessList, ref List<Process> colaListos)
        {
            Process currentProcess;
            if (isFirst)
            {
                currentProcess = newProcessList.First();
                isFirst = false;
                colaListos.Add(currentProcess);
            }
            else //Obtenemos el primer elemento que no esté tachado
                currentProcess = colaListos.FirstOrDefault(t => !t.Tachado);
            return currentProcess;
        }

        private void LlenarTblGranttListos(List<Process> colaListos, List<Grantt> granttsList)
        {
            foreach (var item in colaListos)
                tblListos.Rows.Add(item.Name);

            foreach (var item in granttsList)
                tblGrand.Rows.Add(item.SumLeft, item.Process.Name, item.SumRight);
        }

        private void EncolarProcesoActual(ref Process currentProcess, ref List<Process> colaListos)
        {
            Process newCurrentProcess = new Process
            {
                NCPUES2 = currentProcess.NCPUES2,
                Gasta2 = currentProcess.Gasta2,
                NCPUES = currentProcess.NCPUES,
                ArrivalTime = currentProcess.ArrivalTime,
                IsCurrent = currentProcess.IsCurrent,
                SpendES = currentProcess.SpendES,
                Ncpu = currentProcess.Ncpu,
                Quantum = currentProcess.Quantum,
                QuantumRemaining = currentProcess.QuantumRemaining,
                Name = currentProcess.Name,
                Tachado = false
            };
            colaListos.Add(newCurrentProcess);
        }

        private List<Process> AgregarProcesosEstadoListo(ref List<Process> entranAListos, ref List<Process> colaListos)
        {
            var currentItems = new List<Process>();
            foreach (var item in entranAListos)
            {
                item.Tachado = false;
                colaListos.Add(item);
                currentItems.Add(item);
            }
            return currentItems;
        }

        private Process AgregarEntradaSalida(ref Process currentProcess)
        {
            return new Process
            {
                Name = currentProcess.Name,
                Ncpu = currentProcess.NCPUES,
                NCPUES = currentProcess.NCPUES2,
                QuantumRemaining = currentProcess.NCPUES,
                SpendES = currentProcess.SpendES,
                NCPUES2 = 0
            };
        }

        private void InstanciaVariables(out int quantum, out int intercambio, out int inicio, out int fin, out bool isFirst)
        {
            quantum = Convert.ToInt32(txtQuantum.Text);
            intercambio = Convert.ToInt32(Convert.ToInt32(txtQuantum.Text) * 0.1);
            lblIntercambio.Text = $"{lblIntercambio.Text}{intercambio} (Q)";
            inicio = 0;
            fin = 0;
            isFirst = true;
        }

        private void InstanciarListas(out List<Process> newProcessList, out List<ESProces> processesES, out List<Grantt> granttsList, out List<Process> colaListos)
        {
            newProcessList = processList.OrderBy(t => t.ArrivalTime).ToList();
            processesES = new List<ESProces>();
            granttsList = new List<Grantt>();
            colaListos = new List<Process>();
        }

        private bool ValidarContenidoProcesos()
        {
            if (!processList.Any())
            {
                MessageBox.Show("Debe haber procesos agregados para iniciar el algoritmo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        #region Eventos

        private void txtTLlegada_KeyDown(object sender, KeyEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void txtNcpu_KeyDown(object sender, KeyEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void txtGastaES_KeyDown(object sender, KeyEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void txtNCPUES_KeyDown(object sender, KeyEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void txtGastados_KeyDown(object sender, KeyEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void txtNCPUESdos_KeyDown(object sender, KeyEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void OnlyNumbers(KeyEventArgs e)
        {
            string key = e.KeyData.ToString().Replace("NumPad", "").Replace("D", string.Empty);
            if (key.Equals("Back"))
            {
                e.SuppressKeyPress = false;
                return;
            }

            if (TextFunctions.isNumber(key) || TextFunctions.IsDefaultKey(key) || TextFunctions.IsDecimalSeparator(key))
                e.SuppressKeyPress = false;
            else
                e.SuppressKeyPress = true;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            tblListos.Rows.Clear();
            tblListos.DataSource = null;
            tblES.Rows.Clear();
            tblES.DataSource = null;
            tblGrand.Rows.Clear();
            tblGrand.DataSource = null;
            tblPrincipal.Rows.Clear();
            tblPrincipal.DataSource = null;
            processList.Clear();
            HabilitarBoton(true);
            lblIntercambio.Text = "Intercambio: ";
        }

        private void TxtQuantum_KeyDown(object sender, KeyEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void BtnValoresDefecto_Click(object sender, EventArgs e)
        {
            txtQuantum.Text = "200";
            Process process = new Process
            {
                Name = "P0",
                ArrivalTime = 0,
                QuantumRemaining = 4,
                SpendES = 3,
                NCPUES = 3
            };
            tblPrincipal.Rows.Add(process.Name, process.ArrivalTime, process.Ncpu, process.SpendES, process.NCPUES, process.Gasta2, process.NCPUES2);
            processList.Add(process);

            process = new Process
            {
                Name = "P1",
                ArrivalTime = 190,
                QuantumRemaining = 3,
                SpendES = 2,
                NCPUES = 2,
                Gasta2 = 2,
                NCPUES2 = 3
            };
            tblPrincipal.Rows.Add(process.Name, process.ArrivalTime, process.Ncpu, process.SpendES, process.NCPUES, process.Gasta2, process.NCPUES2);
            processList.Add(process);

            process = new Process
            {
                Name = "P2",
                ArrivalTime = 500,
                QuantumRemaining = 4,
                SpendES = 2,
                NCPUES = 2
            };
            tblPrincipal.Rows.Add(process.Name, process.ArrivalTime, process.Ncpu, process.SpendES, process.NCPUES, process.Gasta2, process.NCPUES2);
            processList.Add(process);

            process = new Process
            {
                Name = "P3",
                ArrivalTime = 700,
                QuantumRemaining = 2,
                SpendES = 3,
                NCPUES = 2
            };
            tblPrincipal.Rows.Add(process.Name, process.ArrivalTime, process.Ncpu, process.SpendES, process.NCPUES, process.Gasta2, process.NCPUES2);
            processList.Add(process);
            btnValoresDefecto.Enabled = false;
        }

        #endregion Eventos
    }
}