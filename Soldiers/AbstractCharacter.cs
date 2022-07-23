using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoftCamp_2_Game_.Soldiers
{
    abstract class AbstractCharacter
    {
        public int HP = 100;
        public int Armor { get; set; }
        public int ImpactForce { get; set; }
    }
}
