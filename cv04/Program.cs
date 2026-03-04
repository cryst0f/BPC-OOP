
string testovaciText = "Toto je retezec predstavovany nekolika radky,\n"
+ "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
+ "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
+ "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
+ "posledni veta!";

Console.WriteLine(testovaciText);
Console.WriteLine();
Console.WriteLine("Pocet slov: " + StringStatistics.wordCount(testovaciText));
Console.WriteLine("Pocet radku: " + StringStatistics.lineCount(testovaciText));
Console.WriteLine("Pocet vet: " + StringStatistics.sentenceCount(testovaciText));
Console.WriteLine("Nejdelsi slova: " + StringStatistics.longestWord(testovaciText));
Console.WriteLine("Nejkratsi slova: " + StringStatistics.shortesttWord(testovaciText));
Console.WriteLine("Nejcetnejsi slova: " + StringStatistics.mostWord(testovaciText));
Console.WriteLine("Slova dle abecedy: " + StringStatistics.alphabeticOrder(testovaciText));