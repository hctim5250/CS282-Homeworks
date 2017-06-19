using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class Ivysaur : Bulbasaur
    {
        public Ivysaur()
        {
            Name = "妙蛙草";
        }

        public override void Attack(Pokemon other)
        {
            //base.Attack(other);  呼叫上層做攻擊 (Bulbasaur的攻擊為-5)
            //other.CurrentHp -= 15; 總共為-20
            other.CurrentHp -= 20;
        }
    }
}