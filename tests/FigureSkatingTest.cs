using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using FigureSkatingProject;

namespace FigureSkatingProject.Tests
{
    [TestClass()]
    public class FigureSkatingTest
    {
        [TestMethod()]
        public void TestCompationScore()
        {
            CompationScore emmiTechnikScore = new CompationScore("technikai", 25.18);

            double expectedScore = 25.18;
            double actualScore = emmiTechnikScore.Score;
            Assert.AreEqual(expectedScore, actualScore, "CompationScore Score tulajdonsága nem a megfelelő értéket adja!");


            var culture = System.Globalization.CultureInfo.CurrentCulture;
            string expectedToString = "";
            if (culture.ToString() == "hu-HU")
                expectedToString = "technikai pontszám: 25,18 pont.";
            else
                expectedToString = "technikai pontszám: 25.18 pont.";
            string actualToString = emmiTechnikScore.ToString();

            Assert.AreEqual(expectedToString, actualToString, "CompationScore ToString metódusa nem a megfelelő értéket adja!");
        }

        [TestMethod()]
        public void TestSkatingScore()
        {
            CompationScore emmiTechnikScore = new CompationScore("technikai", 25.18);
            CompationScore emiProgramScore = new CompationScore("komponens", 25.56);
            CompationScore emiDeductionScore = new CompationScore("levonás", 1.56);
            SkatingScore emiSkatingScore = new SkatingScore(emmiTechnikScore, emiProgramScore, emiDeductionScore);

            double expextedCompositeScore = 49.179;
            double actualCompositeScore = emiSkatingScore.CompositeScore;
            Assert.AreEqual(expextedCompositeScore, actualCompositeScore, 0.001, "A SkatingScore osztály az összpontszámot nem jól határozza meg.");

            var culture = System.Globalization.CultureInfo.CurrentCulture;
            string expectedToString = "";
            if (culture.ToString() == "hu-HU")
                expectedToString = "technikai pontszám: 25,18 pont.\nkomponens pontszám: 25,56 pont.\nlevonás pontszám: 1,56 pont.\nÖsszes pontszám: 49,18 pont.";
            else
                expectedToString = "technikai pontszám: 25.18 pont.\nkomponens pontszám: 25.56 pont.\nlevonás pontszám: 1.56 pont.\nÖsszes pontszám: 49.18 pont.";
            string actualToString = emiSkatingScore.ToString();
            Assert.AreEqual(expectedToString, actualToString, "A SkatingScore osztály ToString metódusa nem a megfelelő szöveget adja!");
        }

        [TestMethod()]
        public void TestSkater()
        {
            CompationScore emmiTechnikScore = new CompationScore("technikai", 25.18);
            CompationScore emiProgramScore = new CompationScore("komponens", 25.56);
            CompationScore emiDeductionScore = new CompationScore("levonás", 1.56);
            SkatingScore emiSkatingScore = new SkatingScore(emmiTechnikScore, emiProgramScore, emiDeductionScore);
            Skater emi = new Skater("Emmi Peltonen", "FIN", emiSkatingScore);

            string expectedName = "Emmi Peltonen";
            string actualName = emi.Name;
            Assert.AreEqual(expectedName, actualName, "A Skater osztály Name tulajdonsága nem a megelelő éréket adja!");

            double expectedScore = 49.18;
            double actualScore = emi.Score;
            Assert.AreEqual(expectedScore, actualScore, 0.001, "A Skater osztály Score tulajdonsága nem a megfelelő értéket adja!");

            string expectedToString = "Emmi Peltonen (FIN)";           
            string actualToString = emi.ToString();
            Assert.AreEqual(expectedToString, actualToString, "A Skater osztály ToString metódusa nem a megfelelő szöveget adja!");
        }

        [TestMethod()]
        public void TestSkaterCompareToGreater()
        {
            CompationScore emmiTechnikScore = new CompationScore("technikai", 25.18);
            CompationScore emiProgramScore = new CompationScore("komponens", 25.56);
            CompationScore emiDeductionScore = new CompationScore("levonás", 1.56);
            SkatingScore emiSkatingScore = new SkatingScore(emmiTechnikScore, emiProgramScore, emiDeductionScore);
            Skater emi = new Skater("Emmi Peltonen", "FIN", emiSkatingScore);

            CompationScore ivettTechnikScore = new CompationScore("technikai", 33.6);
            CompationScore ivettProgramScore = new CompationScore("komponens", 27.4);
            CompationScore ivettDeductionScore = new CompationScore("levonás", 3.1);
            SkatingScore ivettSkatingScore = new SkatingScore(ivettTechnikScore, ivettProgramScore, ivettDeductionScore);
            Skater ivett = new Skater("Tóth Ivett", "HUN", ivettSkatingScore);

            int expectedCompareTo = 1;
            int actualCompareTo = ivett.CompareTo(emi);
            Assert.AreEqual(expectedCompareTo, actualCompareTo, "A Skater CompertTo nagyobb relációs jel esetén nem a megfelelő eredményt adja!");
        }

        [TestMethod()]
        public void TestSkaterCompareToLess()
        {
            CompationScore emmiTechnikScore = new CompationScore("technikai", 25.18);
            CompationScore emiProgramScore = new CompationScore("komponens", 25.56);
            CompationScore emiDeductionScore = new CompationScore("levonás", 1.56);
            SkatingScore emiSkatingScore = new SkatingScore(emmiTechnikScore, emiProgramScore, emiDeductionScore);
            Skater emi = new Skater("Emmi Peltonen", "FIN", emiSkatingScore);

            CompationScore ivettTechnikScore = new CompationScore("technikai", 33.6);
            CompationScore ivettProgramScore = new CompationScore("komponens", 27.4);
            CompationScore ivettDeductionScore = new CompationScore("levonás", 3.1);
            SkatingScore ivettSkatingScore = new SkatingScore(ivettTechnikScore, ivettProgramScore, ivettDeductionScore);
            Skater ivett = new Skater("Tóth Ivett", "HUN", ivettSkatingScore);

            int expectedCompareTo = -1;
            int actualCompareTo = emi.CompareTo(ivett);
            Assert.AreEqual(expectedCompareTo, actualCompareTo, "A Skater CompertTo kisebb relációs jel esetén nem a megfelelő eredményt adja!");
        }

        [TestMethod()]
        public void TestSkaterCompareEqual()
        {
            CompationScore technikScore = new CompationScore("technikai", 25.18);
            CompationScore programScore = new CompationScore("komponens", 25.56);
            CompationScore deductionScore = new CompationScore("levonás", 1.56);
            SkatingScore skatingScore = new SkatingScore(technikScore, programScore, deductionScore);
            Skater emi = new Skater("Emmi Peltonen", "FIN", skatingScore);

            CompationScore ivettTechnikScore = new CompationScore("technikai", 33.6);
            CompationScore ivettProgramScore = new CompationScore("komponens", 27.4);
            CompationScore ivettDeductionScore = new CompationScore("levonás", 3.1);
            SkatingScore ivettSkatingScore = new SkatingScore(technikScore, programScore, deductionScore);
            Skater ivett = new Skater("Tóth Ivett", "HUN", skatingScore);

            int expectedCompareTo = 0;
            int actualCompareTo = emi.CompareTo(ivett);
            Assert.AreEqual(expectedCompareTo, actualCompareTo, "A Skater CompertTo kisebb relációs jel esetén nem a megfelelő eredményt adja!");
        }
    }       
}