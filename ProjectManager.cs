using System.Collections.Generic;

namespace XA01
{
    /// <summary>
    /// IMPLEMENTUJTE ZDE
    ///     Tato trida zatim neni v programu nikde vyuzita, ale predstavte si, ze program bude nekdy v budoucnu dale rozvijen.
    ///     Trida ProjectManager ma nektere prvky spolecne s tridou Programmer. Vytvorte vhodneho spolecneho predka temto tridam,
    ///     o kterem vite, ze bude obecny a nebudou z nej v programu vytvareny instance. Timto tedy musite upravit jak tuto tridu tak
    ///     tridu Programmer, pricemz ze spolecneho predka vyuzijte jeho konstruktor v potomcich.
    /// </summary>
    public class ProjectManager : Employee
    {
        public List<Project> ManagedProjects { get; set; }

        public ProjectManager(string name, int dailyWage, List<Project> managedProjects)
            : base(name, dailyWage)
        {
            ManagedProjects = managedProjects;
        }
    }
}
