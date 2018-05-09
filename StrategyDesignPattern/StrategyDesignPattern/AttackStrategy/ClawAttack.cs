using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.AttackStrategy
{
    public class ClawAttack : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Atackuje pazurkami");
        }
    }
}