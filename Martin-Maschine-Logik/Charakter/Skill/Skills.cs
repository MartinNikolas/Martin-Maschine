using Martin_Maschine_Logik.Charakter.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin_Maschine_Logik.Charakter.Skill
{
    public class Skills
    {
        public static Skills instance = new Skills();
        public Skill Athletik { get; set; }
        public Skill Alchemie { get; set; }
        public Skill Akrobatik { get; set; }
        public Skill Einschüchtern { get; set; }
        public Skill Fingerfertigkeit { get; set; }
        public Skill Fuhren { get; set; }
        public Skill Geselligkeit { get; set; }
        public Skill Heilkunde { get; set; }
        public Skill Orientierung { get; set; }
        public Skill Reiten { get; set; }
        public Skill Schleichen { get; set; }
        public Skill Spurenlesen { get; set; }
        public Skill Rhetorik { get; set; }
        public Skill Wahrnehmung { get; set; }
        public Skill Wildnisleben { get; set; }
        public Skill Menschenkenntnis { get; set; }
        public Skill Zauber_wirken { get; set; }
        public Skill Schauspiel { get; set; }
        private Skills() {
            Athletik = new Skill("Athletik", Attributes.instance.Starke, 0);
            Athletik = new Skill("Alchemie", Attributes.instance.Verstand, 0);
            Athletik = new Skill("Akrobatik", Attributes.instance.Agilitat, 0);
            Athletik = new Skill("Einschüchtern", new List<Attribute.Attribute> { Attributes.instance.Charisma, Attributes.instance.Starke }, 0);
            Athletik = new Skill("Fingerfertigkeit", Attributes.instance.Geschick, 0);
            Athletik = new Skill("Fuhren", Attributes.instance.Charisma, 0);
            Athletik = new Skill("Geselligkeit", Attributes.instance.Charisma, 0);
            Athletik = new Skill("Heilkunde", Attributes.instance.Verstand, 0);
            Athletik = new Skill("Orientierung", Attributes.instance.Verstand, 0);
            Athletik = new Skill("Reiten", Attributes.instance.Agilitat, 0);
            Athletik = new Skill("Schleichen", Attributes.instance.Geschick, 0);
            Athletik = new Skill("Spurenlesen", Attributes.instance.Verstand, 0);
            Athletik = new Skill("Rhetorik", Attributes.instance.Charisma, 0);
            Athletik = new Skill("Wahrnehmung", Attributes.instance.Intuition, 0);
            Athletik = new Skill("Wildnisleben", Attributes.instance.Intuition, 0);
            Athletik = new Skill("Menschenkenntnis", new List<Attribute.Attribute>{ Attributes.instance.Charisma, Attributes.instance.Verstand }, 0);
            Athletik = new Skill("Zauber wirken", Attributes.instance.Willenskraft, 0);
            Athletik = new Skill("Schauspiel", Attributes.instance.Charisma, 0);
        }
    }
}
