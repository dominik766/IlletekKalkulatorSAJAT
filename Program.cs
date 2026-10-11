using illetekKalkulator;
Console.WriteLine("a program elindult...");
// uj lista (amibe a beolvasott adatok kerulnek majd)
// List<Osztaly> Lista neve = new List<Osztaly> !!
List<Szoba> szobak = new List<Szoba>();
// foreach porog "aktualis sor"kent a beolvasott fajlban => aktsor: segedvaltozo
foreach (string aktsor in File.ReadAllLines("szobak.txt")){
    // egy tombbe teszi a feldarabolt adatokat
    string[] adatok = aktsor.Split(';');
    // uj peldanyt hoz letre minden sorbol (1. elem, 2. elem, stb...)
    Szoba aktualis = new Szoba(adatok[0], int.Parse(adatok[1]), int.Parse(adatok[2]), int.Parse(adatok[3]));
    // beleteszi egyesevel a peldanyokat a listaba
    szobak.Add(aktualis);
}
// foreach porog "szoba" kent a listaban
// foreach(Osztaly segedvaltozo in Lista) !!!!!
foreach(Szoba szoba in szobak)
{
    //ToString metodusunkat hasznalja a kiirashoz (konyebb mint amugy)
    Console.WriteLine(szoba.ToString());
}