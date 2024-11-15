using System.ComponentModel;
using klass_och_objekt;

Fordomlista fordomlista = new Fordomlista();

M();

void M()  {
    int i = 0;
    while (true) {
        if (i != 0) {
            Write("Vill du ha en till: ");
            string input = Console.ReadLine();
            if (input == "Ja" || input == "ja" || input == "JA") {} 
            else {
                break;
            }
        }
        fordomlista.NyBil();
        i++;
    }
    Console.Clear();
    fordomlista.VisaBil();
}

void Write(string a) {
    foreach (char c in a) {
        Console.Write(c);
        Thread.Sleep(50);
    }
    Console.WriteLine();
}