﻿using System.ComponentModel;
using klass_och_objekt;

M();

void M()  {
    int bil = 1;
    int i = 0;
    while (true) {
        if (i != 0) {
            Write("Vill du ha en till: ");
            if (Console.ReadLine() == "Ja") {
                bil++;
            } else {
                break;
            }
        }
        Bil();
        i++;
    }
}

void Bil() {
    Write("Tillverkare: ");
    string t = Console.ReadLine();
    Write("Modell: ");
    string m = Console.ReadLine();
    Write("Årsmodell: ");
    int å = TryInt();
    Write("Vikt: ");
    double v = TryDouble();
    Fordom fordom = new Fordom(t, m, å, v);
}

void Write(string a) {
    foreach (char c in a) {
        Console.Write(c);
        Thread.Sleep(50);
    }
}

int TryInt(){
    int å;
    while (true) { 
        try {
            å = int.Parse(Console.ReadLine());
            break;
        } catch(System.Exception) {
            Write("Skriv nummer pls: ");
        }
    }
    return å;
}

double TryDouble(){
    double å;
    while (true) { 
        try {
            å = double.Parse(Console.ReadLine());
            break;
        } catch(System.Exception) {
            Write("Skriv nummer pls: ");
        }
    }
    return å;
}