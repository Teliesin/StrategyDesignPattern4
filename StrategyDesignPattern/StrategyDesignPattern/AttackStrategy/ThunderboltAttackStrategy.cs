using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.AtackStrategy
{
    public class ThunderboltAttackStrategy : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Atackuje!");
        }
    }
}