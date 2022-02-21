using System;

namespace FigureSkatingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CompationScore emmiTechnikScore = new CompationScore("technikai", 25.18);
            Console.WriteLine(emmiTechnikScore);
            Console.WriteLine();

            CompationScore emiProgramScore = new CompationScore("komponens", 25.56);
            CompationScore emiDeductionScore = new CompationScore("levonás", 1.56);
            SkatingScore emiSkatingScore = new SkatingScore(emmiTechnikScore, emiProgramScore, emiDeductionScore);
            Console.WriteLine(emiSkatingScore);
            Console.WriteLine();

            Skater emi = new Skater("Emmi Peltonen", "FIN", emiSkatingScore);

            CompationScore ivettTechnikScore = new CompationScore("technikai", 33.6);
            CompationScore ivettProgramScore = new CompationScore("komponens", 27.4);
            CompationScore ivettDeductionScore = new CompationScore("levonás", 3.1);
            SkatingScore ivettSkatingScore = new SkatingScore(ivettTechnikScore, ivettProgramScore, ivettDeductionScore);
            Skater ivett = new Skater("Tóth Ivett", "HUN", ivettSkatingScore);

            Console.WriteLine(emi);
            Console.WriteLine();
            Console.WriteLine(ivett);

            if (emi.Score > ivett.Score)
                Console.WriteLine(emi.Name + " ért el jobb eredményt:" + emi.Score + " pont");
            else if (ivett.Score > emi.Score)
                Console.WriteLine(ivett.Name + " ért el jobb eredményt:" + ivett.Score);
            else
                Console.WriteLine(emi.Name + " ugyan annyi pontot ért el mint, " + ivett.Name);

            if (emi.CompareTo(ivett)>0)
                Console.WriteLine(emi.Name + " ért el jobb eredményt:" + emi.Score + " pont");
            else if (emi.CompareTo(ivett) < 0)
                Console.WriteLine(ivett.Name + " ért el jobb eredményt:" + ivett.Score);
            else
                Console.WriteLine(emi.Name + " ugyan annyi pontot ért el mint, " + ivett.Name);

        }
    }
}
