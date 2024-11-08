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
        //Set
        //
        public void SetTillverkare(string a) {
            tillverkare = a;
        }
        public void SetModell(string a) {
            modell = a;
        }
        public void SetÅrsModell(int a) {
            if (a < 1885) {
                årsmodell = 1885;
            } else {
                årsmodell = a;
            }
        }
        public void SetVikt(double a) {
            if (a < 0) {
                vikt = 0;
            } else {
                vikt = a;
            }
        }
        //
        //Get
        //
        public string GetTillverkare() {
            return tillverkare;
        }
        public string GetModell() {
            return modell;
        }
        public int GetÅrsModell() {
            return årsmodell;
        }
        public double GetVikt() {
            return vikt;
        }
    }
}