using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBatle
{
    internal class Object : Unit, IAction
    {
        public void Buff(int treatment)
        {
            throw new NotImplementedException();
        }

        public void Debuff(int Damage)
        {
            Health -= Damage;
        }

        public ILoot[] Destroy()
        {
            return Loot;
        }
    }
}
