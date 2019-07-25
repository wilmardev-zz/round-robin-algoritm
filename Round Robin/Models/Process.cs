using System;

namespace Round_Robin.Models
{
    internal class Process
    {
        public string Name { get; set; }
        public int Quantum { get; set; }
        public int SpendES { get; set; }
        public int Ncpu { get; set; }
        public int ArrivalTime { get; set; }
        public int NCPUES { get; set; }
        public bool IsCurrent { get; set; }
        public int QuantumRemaining { get; set; }
        public bool Tachado { get; set; }
        public int NCPUES2 { get; set; }
        public int Gasta2 { get; set; }

        public Process()
        {
            QuantumRemaining = Math.Abs(Ncpu);
            Quantum = 0;
            Ncpu = 0;
            ArrivalTime = 0;
            NCPUES = 0;
            SpendES = 0;
            NCPUES2 = 0;
            Gasta2 = 0;
        }

        public void restarQuantum()
        {
            QuantumRemaining--;
        }
    }
}