using ExoftCamp_2_Game_.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoftCamp_2_Game_.Soldiers
{
    public abstract class AbstractCharacter
    {
        public string Name { get; set; }
        public int HP = 100;
        public int Armor { get; set; }
        public int ImpactForce { get; set; }
        public bool isAlive
        {
            get
            {
                if (HP < 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public virtual void AddSuperPower(SuperPower option, int power)
        {
            option.AddSuperPower(this, power);
        }

        public void Defend(int power)
        {
            var fullNumber = (int)Math.Ceiling(Convert.ToDouble(power) / 2d);
            if (Armor <= fullNumber)
            {
                Armor -= fullNumber;
                HP -= fullNumber;
            }
            else if (Armor > fullNumber & Armor > 0)
            {
                HP -= Armor;
                Armor = 0;
            }

        }

        public void Attack(AbstractCharacter enemy)
        {
            if (Armor < 1)
            {
                if (ImpactForce > 1)
                {
                    ImpactForce--;
                }
                else
                {
                    ImpactForce = 1;
                }
            }

            enemy.Defend(ImpactForce);
        }
    }
}
