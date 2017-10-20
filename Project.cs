namespace XA01
{
    public enum ProjectState
    {
        Waiting,
        Current,
        Done
    }

    public class Project
    {
        public string Name { get; private set; }
        public double ManDays { get; private set; }

        public int Price { get; private set; }
        public double ManDaysDone { get; private set; } = 0;

        public ProjectState State { get; set; } = ProjectState.Waiting;

        public Project(string name, double manDays,int price)
        {
            Name = name;
            ManDays = manDays;
            Price = price;
        }

        /// <summary>
        /// Prida programatorem odvedenou praci projektu.
        /// </summary>
        public void ReceiveWork(double manDays)
        {
            ManDaysDone += manDays;
        }
        
        /// <summary>
        /// Vrati projekt do vychoziho stavu. Vola se vzdy po provedeni simulace pro jednu firmu.
        /// Nikde volani teto metody nepridavejte. Jeji volani je jiz implementovano v cyklu, ve kterem
        /// jsou spousteny simulace pro jednotlive firmy.
        /// </summary>
        public void Reset()
        {
            State = ProjectState.Waiting;
            ManDaysDone = 0;
        }
    }
}
