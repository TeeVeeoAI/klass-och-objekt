using klass_och_objekt;

Fordom bil1 = new Fordom();
Fordom bil2 = new Fordom();
M();

void M()  {
    Bil1();
    Bil2();
    info("bil1");
    info("bil2");
}
// uppgift 2
void Bil1() {
    Console.WriteLine("skriv in tillverkare till bil1: ");
    string tillverkare = Console.ReadLine();
    bil1.SetTillverkare(tillverkare);
    Console.WriteLine("skriv in modell till bil1: ");
    string modell = Console.ReadLine();
    bil1.SetModell(modell);
    Console.WriteLine("skriv in årsmodell till bil1: ");
    int årsmodell = Convert.ToInt32(Console.ReadLine());
    bil1.SetÅrsModell(årsmodell);
    Console.WriteLine("skriv in vikt till bil1: ");
    double vikt = Convert.ToDouble(Console.ReadLine());
    bil1.SetVikt(vikt);
}
void Bil2() {
    Console.WriteLine("skriv in tillverkare till bil2: ");
    string tillverkare = Console.ReadLine();
    bil2.SetTillverkare(tillverkare);
    Console.WriteLine("skriv in modell till bil2: ");
    string modell = Console.ReadLine();
    bil2.SetModell(modell);
    Console.WriteLine("skriv in årsmodell till bil2: ");
    int årsmodell = Convert.ToInt32(Console.ReadLine());
    bil2.SetÅrsModell(årsmodell);
    Console.WriteLine("skriv in vikt till bil2: ");
    double vikt = Convert.ToDouble(Console.ReadLine());
    bil2.SetVikt(vikt);
}
void info(string a) {
    if (a == "bil1") {
        Console.WriteLine(
            "Bil1 \n" +
            "Tillverkare:" + bil1.GetTillverkare() + "\n" +
            "Modell: " + bil1.GetModell() + "\n" +
            "Årsmodell: " + bil1.GetÅrsModell() + "\n" +
            "Vikt: " + bil1.GetVikt() + "kg\n");
    } else if (a == "bil2") {
        Console.WriteLine(
            "Bil2 \n" +
            "Tillverkare:" + bil2.GetTillverkare() + "\n" +
            "Modell: " + bil2.GetModell() + "\n" +
            "Årsmodell: " + bil2.GetÅrsModell() + "\n" +
            "Vikt: " + bil2.GetVikt() + "kg\n");
    }
}