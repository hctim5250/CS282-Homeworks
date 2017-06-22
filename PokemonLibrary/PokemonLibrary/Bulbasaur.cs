using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class Bulbasaur : Pokemon
    {
        public Bulbasaur()
        {
            Hp = 120;
            NationalNumber = 1;
            CurrentHp = Hp;
            attack = 20;
            defense = 20;
            speed = 10;
            iv = 100;
            Name = "妙蛙種子";
        }

        public override void Attack(Pokemon other)
        {
            other.CurrentHp -= 5;
        }

        public override string ToString()
        {
            return base.ToString() + "進化後會變成妙蛙草";  //base會把上一層(Pokemon)的東西全部叫來用
        }
    }
}