namespace klass_och_objekt
{
    public class Fordomlista
    {
        public List<Fordom> Billista = new List<Fordom>();

        public void NyBil(){
            Write("Tillverkare: ");
            string t = Console.ReadLine();
            Write("Modell: ");
            string m = Console.ReadLine();
            Write("Årsmodell: ");
            int å = TryInt();
            Write("Vikt: ");
            double v = TryDouble();
            Billista.Add(new Fordom(t, m, å, v));
        }

        public void VisaBil(){
            int i = 1;
            foreach (Fordom fordom in Billista) {
                Write("Bil" + i);
                Write("Tillverkare: " + fordom.Tillverkare);
                Write("Modell: " + fordom.Modell);
                Write("Årsmodell: " + fordom.ÅrsModell);
                Write("Vikt: " + fordom.Vikt + "kg");
                Write("\n");
                i++;
            }
        }

        void Write(string a) {
            foreach (char c in a) {
                Console.Write(c);
                Thread.Sleep(50);
            }
            Console.WriteLine();
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
    }
}