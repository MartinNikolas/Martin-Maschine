using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin_Maschine_Logik.Charakter.Attribute
{
    public class Attribute
    {
        public Attribute(string name, int points = 0, bool body = false) { 
        Points = points;
            Name = name;
            Body = body;
        }
        public int Points { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public bool Body { get; set; } = false;
    }
}
