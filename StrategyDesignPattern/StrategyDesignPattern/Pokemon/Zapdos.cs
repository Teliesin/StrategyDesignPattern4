using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.Pokemon
{
    public class Zapdos : PokemonBase
    {
        public override void MakeChargeAttack()
        {
            ChargedAtack.Attack();
        }

        public override void MakeFastAttack()
        {
            FastAtack.Attack();
        }
    }
}