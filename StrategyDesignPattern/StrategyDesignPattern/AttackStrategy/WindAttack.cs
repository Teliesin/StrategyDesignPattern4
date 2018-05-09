using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.AttackStrategy
{
    public class WindAttack : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Atackuje powietrzem!1!");
        }
    }
}
