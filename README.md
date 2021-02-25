# 01-05-01-FigureSkating
Osztálychierarchia UML diagram alapján.
## Műkorcsolya eredmények (FigureSkatingProject)
A feladata a műkorcsolya eredményeket tároló osztályhierarchia programozása UML diagramok alapján. A feladatot a következő osztályok elkészítésével oldja meg!  
### CompationScore osztály  
Az osztály eredményeket és annak típusát tárolja el. Az eredménynek van leolvasható get tulajdonsága.  
Teszt kód:  
```
CompationScore emmiTechnikScore = new CompationScore("technikai", 25.18);  
Console.WriteLine(emmiTechnikScore);
```
Teszt kód kimenete (ToString metódus segítségével)
```
A versenyző technikai pontszáma:25,18
```
Az osztály UML diagramja:  
![UML diagram](https://github.com/csarp-dotnet-core-oop-feladatok/01-05-01-FigureSkating/blob/main/CompationScore.png?raw=true)  
### SkatingScore osztály
A feladat megoldását a SkatingScore osztály kifejlesztésével folytassa, amely egy versenyző összes pontjait tartalmazza. Egy versenyen a versenyző kap technikai pontokat, program pontokat és a hibák miatt levonás is lehet.  
Az összpontszámot tulajdonságként készítse el. Az összpontszám a program pontok és technikai pontok összege, amelyből kivontjuk a levonást. Az összpontszám olvasható tulajdonság.  
Az osztályban kell konstruktor és a ToString elkészítését a következő kódrészlet segíti!  
Teszt kód:  
```
SkatingScore emiSkatingScore = new SkatingScore(emmiTechnikScore, emiProgramScore, emiDeductionScore);
Console.WriteLine(emiSkatingScore);
```
Teszt kód kimenete:
```
A versenyző technikai pontszáma:25,18
A versenyző komponens pontszáma:25,56
A versenyző levonás pontszáma:1,56
Összes pontszám: 49,18
```
Az osztály UML diagramja:  
![UML diagram](https://github.com/csarp-dotnet-core-oop-feladatok/01-05-01-FigureSkating/blob/main/SkatingScore.png?raw=true)  
### Skater osztály
A munkát a Skater osztály elkészítésével folytassa. A műkorcsolya versenyzőnek van neve, származási országa és pontszáma.  
A név és pontszám olvasható tulajdonság.  
A Skatter osztály ToString metódusának eredménye:
```
Emmi Peltonen versenyző FIN országból.
A versenyző technikai pontszáma:25,18
A versenyző komponens pontszáma:25,56
A versenyző levonás pontszáma:1,56
Összes pontszám: 49,18
```
Az osztály UML diagramja:  
![UML diagram](https://github.com/csarp-dotnet-core-oop-feladatok/01-05-01-FigureSkating/blob/main/Skater.png?raw=true)  
A teljes tesztkód:
 ```
CompationScore emmiTechnikScore = new CompationScore("technikai", 25.18);
Console.WriteLine(emmiTechnikScore);

CompationScore emiProgramScore = new CompationScore("komponens", 25.56);            
CompationScore emiDeductionScore = new CompationScore("levonás", 1.56);
SkatingScore emiSkatingScore = new SkatingScore(emmiTechnikScore, emiProgramScore, emiDeductionScore);
Console.WriteLine(emiSkatingScore);

Skater emi = new Skater("Emmi Peltonen", "FIN", emiSkatingScore);

CompationScore ivettTechnikScore = new CompationScore("technikai", 33.6);
CompationScore ivettProgramScore = new CompationScore("komponens", 27.4);
CompationScore ivettDeductionScore = new CompationScore("levonás", 3.1);
SkatingScore ivettSkatingScore = new SkatingScore(ivettTechnikScore, ivettProgramScore, ivettDeductionScore);

Skater ivett = new Skater("Tóth Ivett", "HUN", ivettSkatingScore);
Console.WriteLine(emi);
Console.WriteLine(ivett);
```
## Feladat
Írjon kódot, amely eldönti, hogy Emmi Peltonen vagy Tóth Ivett ért el több pontot a versenyen. Az is lehetséges, hogy egyenlő pontotszámot értek el!
Az eredményt a következő formátumba jelenítse meg:   
```
Tóth Ivett ért el jobb eredményt:57,9 pontot.
```
