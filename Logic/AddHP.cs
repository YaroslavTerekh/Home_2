using ExoftCamp_2_Game_.Soldiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoftCamp_2_Game_.Logic
{
    class AddHP : SuperPower
    {
        public void AddSuperPower(AbstractCharacter character, int power)
        {
            character.HP = power;
        }
    }
}
