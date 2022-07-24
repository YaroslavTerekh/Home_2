using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoftCamp_2_Game_
{
    public class SuperPowerGenerator
    {
        public int GetSuperPower()
        {
            int time = DateTime.Now.Millisecond;
            int result = (time % 6) + 5;
            return result;
            //int result = (time % 6) - 5 + 10 / 2 * 2;  // - with all operators
        }
    }
}
