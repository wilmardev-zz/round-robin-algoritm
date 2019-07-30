namespace Round_Robin
{
    partial class FormRoundRobin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblPrincipal = new System.Windows.Forms.DataGridView();
            this.clmProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNCPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCPUES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GastaES2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCPUES2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblES = new System.Windows.Forms.DataGridView();
            this.clmProcesoES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRegresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProceso = new System.Windows.Forms.TextBox();
            this.lblProceso = new System.Windows.Forms.Label();
            this.txtTLlegada = new System.Windows.Forms.TextBox();
            this.txtNcpu = new System.Windows.Forms.TextBox();
            this.txtGastaES = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtNCPUES = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGastados = new System.Windows.Forms.TextBox();
            this.txtNCPUESdos = new System.Windows.Forms.TextBox();
            this.txtGasta2 = new System.Windows.Forms.Label();
            this.txtNCPUES2 = new System.Windows.Forms.Label();
            this.tblGrand = new System.Windows.Forms.DataGridView();
            this.grandIzquierda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grandProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grandDerecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblListos = new System.Windows.Forms.DataGridView();
            this.listoProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQuantum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblIntercambio = new System.Windows.Forms.Label();
            this.btnValoresDefecto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblListos)).BeginInit();
            this.SuspendLayout();
            // 
            // tblPrincipal
            // 
            this.tblPrincipal.AllowUserToAddRows = false;
            this.tblPrincipal.AllowUserToDeleteRows = false;
            this.tblPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProceso,
            this.clmTLlegada,
            this.clmNCPU,
            this.clmGasta,
            this.NCPUES,
            this.GastaES2,
            this.NCPUES2});
            this.tblPrincipal.Location = new System.Drawing.Point(42, 169);
            this.tblPrincipal.Name = "tblPrincipal";
            this.tblPrincipal.ReadOnly = true;
            this.tblPrincipal.Size = new System.Drawing.Size(975, 202);
            this.tblPrincipal.TabIndex = 0;
            // 
            // clmProceso
            // 
            this.clmProceso.HeaderText = "Proceso";
            this.clmProceso.Name = "clmProceso";
            this.clmProceso.ReadOnly = true;
            this.clmProceso.Width = 120;
            // 
            // clmTLlegada
            // 
            this.clmTLlegada.HeaderText = "Tiempo de llegada";
            this.clmTLlegada.Name = "clmTLlegada";
            this.clmTLlegada.ReadOnly = true;
            this.clmTLlegada.Width = 150;
            // 
            // clmNCPU
            // 
            this.clmNCPU.HeaderText = "NCPU en Quantum";
            this.clmNCPU.Name = "clmNCPU";
            this.clmNCPU.ReadOnly = true;
            this.clmNCPU.Width = 150;
            // 
            // clmGasta
            // 
            this.clmGasta.HeaderText = "Gasta en E/S";
            this.clmGasta.Name = "clmGasta";
            this.clmGasta.ReadOnly = true;
            this.clmGasta.Width = 120;
            // 
            // NCPUES
            // 
            this.NCPUES.HeaderText = "NCPU E/S";
            this.NCPUES.Name = "NCPUES";
            this.NCPUES.ReadOnly = true;
            this.NCPUES.Width = 120;
            // 
            // GastaES2
            // 
            this.GastaES2.HeaderText = "Gasta E/S 2";
            this.GastaES2.Name = "GastaES2";
            this.GastaES2.ReadOnly = true;
            this.GastaES2.Width = 120;
            // 
            // NCPUES2
            // 
            this.NCPUES2.HeaderText = "NCPU E/S 2";
            this.NCPUES2.Name = "NCPUES2";
            this.NCPUES2.ReadOnly = true;
            this.NCPUES2.Width = 120;
            // 
            // tblES
            // 
            this.tblES.AllowUserToAddRows = false;
            this.tblES.AllowUserToDeleteRows = false;
            this.tblES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblES.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProcesoES,
            this.clmRegresa});
            this.tblES.Location = new System.Drawing.Point(723, 408);
            this.tblES.Name = "tblES";
            this.tblES.ReadOnly = true;
            this.tblES.Size = new System.Drawing.Size(278, 383);
            this.tblES.TabIndex = 0;
            // 
            // clmProcesoES
            // 
            this.clmProcesoES.HeaderText = "Proceso";
            this.clmProcesoES.Name = "clmProcesoES";
            this.clmProcesoES.ReadOnly = true;
            // 
            // clmRegresa
            // 
            this.clmRegresa.HeaderText = "Regresa en tiempo";
            this.clmRegresa.Name = "clmRegresa";
            this.clmRegresa.ReadOnly = true;
            this.clmRegresa.Width = 120;
            // 
            // txtProceso
            // 
            this.txtProceso.Location = new System.Drawing.Point(106, 97);
            this.txtProceso.Name = "txtProceso";
            this.txtProceso.Size = new System.Drawing.Size(49, 20);
            this.txtProceso.TabIndex = 3;
            // 
            // lblProceso
            // 
            this.lblProceso.AutoSize = true;
            this.lblProceso.Location = new System.Drawing.Point(39, 100);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(46, 13);
            this.lblProceso.TabIndex = 4;
            this.lblProceso.Text = "Proceso";
            // 
            // txtTLlegada
            // 
            this.txtTLlegada.Location = new System.Drawing.Point(161, 124);
            this.txtTLlegada.Name = "txtTLlegada";
            this.txtTLlegada.Size = new System.Drawing.Size(57, 20);
            this.txtTLlegada.TabIndex = 5;
            this.txtTLlegada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTLlegada_KeyDown);
            // 
            // txtNcpu
            // 
            this.txtNcpu.Location = new System.Drawing.Point(279, 97);
            this.txtNcpu.Name = "txtNcpu";
            this.txtNcpu.Size = new System.Drawing.Size(47, 20);
            this.txtNcpu.TabIndex = 6;
            this.txtNcpu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNcpu_KeyDown);
            // 
            // txtGastaES
            // 
            this.txtGastaES.Location = new System.Drawing.Point(452, 93);
            this.txtGastaES.Name = "txtGastaES";
            this.txtGastaES.Size = new System.Drawing.Size(62, 20);
            this.txtGastaES.TabIndex = 7;
            this.txtGastaES.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGastaES_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tiempo de llegada (ms)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "NCPU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "E/S";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(942, 72);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(942, 101);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 13;
            this.btnGo.Text = "Iniciar";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // txtNCPUES
            // 
            this.txtNCPUES.Location = new System.Drawing.Point(601, 93);
            this.txtNCPUES.Name = "txtNCPUES";
            this.txtNCPUES.Size = new System.Drawing.Size(61, 20);
            this.txtNCPUES.TabIndex = 8;
            this.txtNCPUES.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNCPUES_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "NCPU E/S";
            // 
            // txtGastados
            // 
            this.txtGastados.Location = new System.Drawing.Point(453, 124);
            this.txtGastados.Name = "txtGastados";
            this.txtGastados.Size = new System.Drawing.Size(61, 20);
            this.txtGastados.TabIndex = 9;
            this.txtGastados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGastados_KeyDown);
            // 
            // txtNCPUESdos
            // 
            this.txtNCPUESdos.Location = new System.Drawing.Point(600, 124);
            this.txtNCPUESdos.Name = "txtNCPUESdos";
            this.txtNCPUESdos.Size = new System.Drawing.Size(62, 20);
            this.txtNCPUESdos.TabIndex = 10;
            this.txtNCPUESdos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNCPUESdos_KeyDown);
            // 
            // txtGasta2
            // 
            this.txtGasta2.AutoSize = true;
            this.txtGasta2.Location = new System.Drawing.Point(420, 127);
            this.txtGasta2.Name = "txtGasta2";
            this.txtGasta2.Size = new System.Drawing.Size(26, 13);
            this.txtGasta2.TabIndex = 17;
            this.txtGasta2.Text = "E/S";
            // 
            // txtNCPUES2
            // 
            this.txtNCPUES2.AutoSize = true;
            this.txtNCPUES2.Location = new System.Drawing.Point(535, 127);
            this.txtNCPUES2.Name = "txtNCPUES2";
            this.txtNCPUES2.Size = new System.Drawing.Size(59, 13);
            this.txtNCPUES2.TabIndex = 18;
            this.txtNCPUES2.Text = "NCPU E/S";
            // 
            // tblGrand
            // 
            this.tblGrand.AllowUserToAddRows = false;
            this.tblGrand.AllowUserToDeleteRows = false;
            this.tblGrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblGrand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grandIzquierda,
            this.grandProceso,
            this.grandDerecha});
            this.tblGrand.Location = new System.Drawing.Point(42, 408);
            this.tblGrand.Name = "tblGrand";
            this.tblGrand.ReadOnly = true;
            this.tblGrand.Size = new System.Drawing.Size(373, 383);
            this.tblGrand.TabIndex = 0;
            // 
            // grandIzquierda
            // 
            this.grandIzquierda.HeaderText = "Inicio";
            this.grandIzquierda.Name = "grandIzquierda";
            this.grandIzquierda.ReadOnly = true;
            // 
            // grandProceso
            // 
            this.grandProceso.HeaderText = "Proceso";
            this.grandProceso.Name = "grandProceso";
            this.grandProceso.ReadOnly = true;
            // 
            // grandDerecha
            // 
            this.grandDerecha.HeaderText = "Fin";
            this.grandDerecha.Name = "grandDerecha";
            this.grandDerecha.ReadOnly = true;
            // 
            // tblListos
            // 
            this.tblListos.AllowUserToAddRows = false;
            this.tblListos.AllowUserToDeleteRows = false;
            this.tblListos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblListos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.listoProceso});
            this.tblListos.Location = new System.Drawing.Point(482, 408);
            this.tblListos.Name = "tblListos";
            this.tblListos.ReadOnly = true;
            this.tblListos.Size = new System.Drawing.Size(187, 383);
            this.tblListos.TabIndex = 0;
            // 
            // listoProceso
            // 
            this.listoProceso.HeaderText = "Proceso";
            this.listoProceso.Name = "listoProceso";
            this.listoProceso.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Diagrama de Grantt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(479, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Cola de procesos en estado listo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(720, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Entradas y Salidas";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(942, 130);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(158, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Datos Proceso";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(485, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Datos Entradas y Salidas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(748, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Tamaño Quantum";
            // 
            // txtQuantum
            // 
            this.txtQuantum.Location = new System.Drawing.Point(750, 93);
            this.txtQuantum.Name = "txtQuantum";
            this.txtQuantum.Size = new System.Drawing.Size(89, 20);
            this.txtQuantum.TabIndex = 11;
            this.txtQuantum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtQuantum_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(390, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(310, 40);
            this.label11.TabIndex = 28;
            this.label11.Text = "Algoritmo de Programación de la CPU\r\nRound Robin";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIntercambio
            // 
            this.lblIntercambio.AutoSize = true;
            this.lblIntercambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntercambio.Location = new System.Drawing.Point(748, 125);
            this.lblIntercambio.Name = "lblIntercambio";
            this.lblIntercambio.Size = new System.Drawing.Size(91, 15);
            this.lblIntercambio.TabIndex = 29;
            this.lblIntercambio.Text = "Intercambio: ";
            // 
            // btnValoresDefecto
            // 
            this.btnValoresDefecto.Location = new System.Drawing.Point(42, 26);
            this.btnValoresDefecto.Name = "btnValoresDefecto";
            this.btnValoresDefecto.Size = new System.Drawing.Size(113, 23);
            this.btnValoresDefecto.TabIndex = 30;
            this.btnValoresDefecto.Text = "Valores Defecto";
            this.btnValoresDefecto.UseVisualStyleBackColor = true;
            this.btnValoresDefecto.Click += new System.EventHandler(this.BtnValoresDefecto_Click);
            // 
            // FormRoundRobin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1060, 819);
            this.Controls.Add(this.btnValoresDefecto);
            this.Controls.Add(this.lblIntercambio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtQuantum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tblListos);
            this.Controls.Add(this.tblGrand);
            this.Controls.Add(this.txtNCPUES2);
            this.Controls.Add(this.txtGasta2);
            this.Controls.Add(this.txtNCPUESdos);
            this.Controls.Add(this.txtGastados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNCPUES);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGastaES);
            this.Controls.Add(this.txtNcpu);
            this.Controls.Add(this.txtTLlegada);
            this.Controls.Add(this.lblProceso);
            this.Controls.Add(this.txtProceso);
            this.Controls.Add(this.tblES);
            this.Controls.Add(this.tblPrincipal);
            this.MaximizeBox = false;
            this.Name = "FormRoundRobin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Round Robin";
            ((System.ComponentModel.ISupportInitialize)(this.tblPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblListos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblPrincipal;
        private System.Windows.Forms.DataGridView tblES;
        private System.Windows.Forms.TextBox txtProceso;
        private System.Windows.Forms.Label lblProceso;
        private System.Windows.Forms.TextBox txtTLlegada;
        private System.Windows.Forms.TextBox txtNcpu;
        private System.Windows.Forms.TextBox txtGastaES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtNCPUES;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGastados;
        private System.Windows.Forms.TextBox txtNCPUESdos;
        private System.Windows.Forms.Label txtGasta2;
        private System.Windows.Forms.Label txtNCPUES2;
        private System.Windows.Forms.DataGridView tblGrand;
        private System.Windows.Forms.DataGridView tblListos;
        private System.Windows.Forms.DataGridViewTextBoxColumn listoProceso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn grandIzquierda;
        private System.Windows.Forms.DataGridViewTextBoxColumn grandProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn grandDerecha;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQuantum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNCPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCPUES;
        private System.Windows.Forms.DataGridViewTextBoxColumn GastaES2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCPUES2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProcesoES;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRegresa;
        private System.Windows.Forms.Label lblIntercambio;
        private System.Windows.Forms.Button btnValoresDefecto;
    }
}

