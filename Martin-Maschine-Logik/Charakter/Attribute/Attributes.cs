using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin_Maschine_Logik.Charakter.Attribute
{
    public class Attributes
    {
        public static Attributes instance = new Attributes();
        public Attribute Starke;
        public Attribute Konstitution;
        public Attribute Geschick;
        public Attribute Agilitat;
        public Attribute Intuition;
        public Attribute Willenskraft;
        public Attribute Verstand;
        public Attribute Charisma;


        private Attributes()
        {
            Starke = new Attribute("Stärke", body:true);
            Konstitution = new Attribute("Konstitution", body:true);
            Geschick = new Attribute("Geschick", body:true);
            Agilitat = new Attribute("Agilität", body:true);
            Intuition = new Attribute("Intuition");
            Willenskraft = new Attribute("Willenskraft");
            Verstand = new Attribute("Verstand");
            Charisma = new Attribute("Charisma");

        }
    }
}
