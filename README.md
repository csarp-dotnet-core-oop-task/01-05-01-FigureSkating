# 01-05-01-FigureSkating
Osztálychierarchia UML diagram alapján.
## Műkorcsolya eredmények (FigureSkatingProject)
A feladata a műkorcsolya eredményeket tároló osztályhierarchia programozása UML diagramok alapján. A feladatot a következő osztályok elkészítésével oldja meg!  
### CompationScore osztály  
Az osztály eredményeket és annak típusát tárolja el. Az eredménynek van olvasható get tulajdonsága.  
Teszt kód:  
```
CompationScore emmiTechnikScore = new CompationScore("technikai", 25.18);  
Console.WriteLine(emmiTechnikScore);
```
Teszt kód kimenete (ToString metódus segítségével)
```
technikai pontszám: 25,18 pont.
```
Az osztály UML diagramja:  
![UML diagram](https://github.com/csarp-dotnet-core-oop-feladatok/01-05-01-FigureSkating/blob/main/CompationScore.png?raw=true)  
### SkatingScore osztály
A feladat megoldását a SkatingScore osztály kifejlesztésével folytassa, amely egy versenyző összes pontjait tartalmazza. Egy versenyen a versenyző kap technikai pontokat, program pontokat és a hibák miatt levonás is lehet.  
Az összpontszámot tulajdonságként készítse el. Az összpontszám a program pontok és technikai pontok összege, amelyből kivontjuk a levonást. Az összpontszám olvasható tulajdonság.  
Az osztályban kell konstruktor és a ToString elkészítését a következő kódrészlet segíti! A ToString metódusban az összpontszámot két tizedes jegyre kerekítse! 
Teszt kód:  
```
SkatingScore emiSkatingScore = new SkatingScore(emmiTechnikScore, emiProgramScore, emiDeductionScore);
Console.WriteLine(emiSkatingScore);
```
Teszt kód kimenete:
```
technikai pontszám: 25,18 pont.
komponens pontszám: 25,56 pont.
levonás pontszám: 1,56 pont.
Összes pontszám: 49,18 pont.
```
### Skater osztály
A munkát a Skater osztály elkészítésével folytassa. A műkorcsolya versenyzőnek van neve, származási országa és pontszáma.  
A név és pontszám olvasható tulajdonság.  
A Skatter osztály ToString metódusának eredménye:
```
Emmi Peltonen (FIN)
```
Készítse el az UML diagramon látható CompareTo metódust. A metódus 1 értéket ad vissza, ha a Skater objektum összpontszáma nagyobb a másik osztály osztpontszánámál! Ha kisebb, akkor -1 értéket ad vissza. Ha az összpontszámok megegyeznek, akkor 0 értéket ad vissza.


A teljes tesztkód:
 ```
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
```
