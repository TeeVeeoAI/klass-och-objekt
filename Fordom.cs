//uppgift 1
namespace klass_och_objekt
{
    public class Fordom
    {
        private string tillverkare;
        private string modell;
        private int årsmodell;
        private double vikt;
        //
        //Get och Set
        //
        public string Tillverkare {
            get { return tillverkare;}
            set { tillverkare = value;}
        }
        public string Modell {
            get { return modell;}
            set { modell = value;}
        }
        public int GetÅrsModell {
            get { return årsmodell;}
            set { årsmodell = value;}
        }
        public double GetVikt {
            get { return vikt; }
            set { vikt = value;}
        }
        public Fordom(string t, string m, int å, double v) {
            tillverkare = t;
            modell = m;
            årsmodell = å;
            vikt = v;
        }
    }
}