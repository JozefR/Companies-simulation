namespace XA01
{
    public class Programmer : Employee
    {
        public double Speed { get; private set; }
        public double Effectivity
        {
            get
            {
                return calculateEffectivity();
            }
        }

        public Project Project { get; private set; }

        public string ProjectName
        {
            get
            {
                return Project?.Name ?? "No project assigned";
            }
        }

        public Programmer(string name, double speed, int dailyWage)
            : base(name, dailyWage)
        {
            Speed = speed;
        }

        /// <summary>
        /// Uvolni programatora z projektu.
        /// </summary>
        /// <remarks>Zamerne je implementovano jako metoda pro ilustraci situace, kdy je napr. dopredu pocitano s tim,
        /// ze pri uvolnovani projektu bude implementovana urcita business logika, ktera svym charakterem neodpovida
        /// situaci, kdy by se typicky dala vyuzit vlastnost - setter. Nicmene zadnou logiku nyni do teto metody nepridavejte.</remarks>
        public void ClearProject()
        {
            Project = null;
        }
        
        /// <summary>
        /// Priradi programatorovi projekt, na kterem bude pracovat.
        /// </summary>
        /// <remarks>Duvod proc je toto implementovano jako metoda
        /// a nikoliv pomoci setter jsou obdobne jako u <see cref="ClearProject"/></remarks>
        public void AssignProject(Project project)
        {
            Project = project;
        }

        /// <summary>
        /// Programator odvede svou praci na projektu.
        /// </summary>
        public void WriteCode()
        {
            Project.ReceiveWork(Speed);
        }

        /// <summary>
        /// Spocita effectivitu programatora
        /// </summary>
        /// <returns></returns>
        private double calculateEffectivity()
        {
            return this.DailyWage / (this.Speed * 100);
        }
    }
}
