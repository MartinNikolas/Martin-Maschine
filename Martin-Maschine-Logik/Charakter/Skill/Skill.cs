using Martin_Maschine_Logik.Charakter.Attribute;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Martin_Maschine_Logik.Charakter.Skill
{
    public class Skill
    {
        public string Name { get; set; }
        private List<Attribute.Attribute> Attribut { get; set; }
        public int Points { get; set; }
        public Skill(string name, Attribute.Attribute attribute, int points)
        {
            Name = name;
            Attribut = new List<Attribute.Attribute> { attribute};
            Points = points;
        }
        public Skill(string name, List<Attribute.Attribute> attribute, int points)
        {
            Name = name;
            Attribut =  attribute;
            Points = points;
        }
        public string GetSkillsDescription() { 
        string description = Name + " ";
        for (int i = 0; i <Attribut.Count; i++)
            {
                if(i!=0)
                { description += "\\"; }
                Name += Attribut[i].Name;
            }
            return description;
        }
        public Attribute.Attribute GetAttribut() { 
        return Attribut.OrderBy(x => x.Points).FirstOrDefault()?? new Attribute.Attribute("");
        }
        
    }
}
