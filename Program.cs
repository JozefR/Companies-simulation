using System;
using System.Collections.Generic;

namespace XA01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Testovaci data

            List<Company> companies = new List<Company>();
            companies.Add(new Company("Alpha", 2, 1000, 90000));
            companies.Add(new Company("Beta", 2, 1500, 100000));
            companies.Add(new Company("Gamma", 3, 3000, 200000));
            companies.Add(new Company("Delta", 5, 6000, 400000));
            companies.Add(new Company("Epsilon", 6, 8000, 900000));
            companies.Add(new Company("Theta", 7, 10000, 1200000));
            companies.Add(new Company("Omega", 7, 20000, 20000000));

            List<Programmer> programmers = new List<Programmer>();
            programmers.Add(new Programmer("Martin", 1.9, 2000));
            programmers.Add(new Programmer("Jarda", 1.0, 1300));
            programmers.Add(new Programmer("Lukas", 0.6, 900));
            programmers.Add(new Programmer("Pepa", 1.7, 2200));
            programmers.Add(new Programmer("Kamil", 0.4, 1800));
            programmers.Add(new Programmer("Honza", 1.3, 1500));
            programmers.Add(new Programmer("Filip", 1.1, 1000));

            List<Project> projects = new List<Project>();
            projects.Add(new Project("Web", 5.0, 20000));
            projects.Add(new Project("Portal", 15.0, 60000));
            projects.Add(new Project("Email system", 25.0, 90000));
            projects.Add(new Project("Eshop", 40.0, 150000));
            projects.Add(new Project("CMS", 60.0, 250000));
            projects.Add(new Project("Forum", 30.0, 35000));
            projects.Add(new Project("B2B SYS", 120.0, 800000));
            projects.Add(new Project("Multimedia Web", 7.0, 50000));
            projects.Add(new Project("TODO List", 3.0, 10000));
            projects.Add(new Project("CRM", 20.0, 80000));

            #endregion

            // Pro kazdou firmu je spustena simulace
            foreach(Company company in companies)
            {
                company.AllocateProgrammers(programmers);
                company.AllocateProjects(projects);
                company.Run();
                company.PrintResult();

                /*  Protoze pri simulaci pracujeme v kazde firme se stejnymi objekty programatoru a projektu,
                 *  pak po kazde dokoncene simulaci pro jednu firmu resetujeme programatory a projekty do vychoziho stavu,
                 *  aby jim nezustal prirazen projekt a nebyla u nich evidovana odvedena prace.
                 */ 
                foreach(Programmer programmer in programmers)
                {
                    programmer.ClearProject();
                }
                foreach(Project project in projects)
                {
                    project.Reset();
                }
            }
            Console.ReadLine();
        }
    }
}
