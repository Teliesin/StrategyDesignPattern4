using System;
using System.Threading;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PokemonGenerator generator = new PokemonGenerator();

            var pokemon = generator.Generate();

            Random random = new Random();
            
            while(true)
            {
                if(random.Next(0, 1000000) > 950000)
                {
                    generator.ChangeFastAttack(pokemon);
                }

                Thread.Sleep(100);

                pokemon.MakeFastAttack();
            }
        }
    }
}