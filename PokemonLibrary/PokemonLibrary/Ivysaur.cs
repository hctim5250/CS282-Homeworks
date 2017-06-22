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
            Hp = 133;
            NationalNumber = 2;
            CurrentHp = Hp;
            attack = 40;
            defense = 30;
            speed = 25;
            iv = 200;
            Name = "妙蛙草";
        }

        public override void Attack(Pokemon other)
        {
            //base.Attack(other);  呼叫上層做攻擊 (Bulbasaur的攻擊為-5)
            //other.CurrentHp -= 15; 總共為-20
            other.CurrentHp -= 20;
        }

        public override string ToString()
        {
            return string.Format("這行在Pokemon\n Number : {0}, Name : {1}", NationalNumber, Name) + "進化後會變成妙蛙花";
        }
    }
}