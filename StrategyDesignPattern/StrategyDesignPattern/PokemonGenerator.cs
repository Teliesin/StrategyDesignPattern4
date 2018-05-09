using StrategyDesignPattern.AtackStrategy;
using StrategyDesignPattern.AttackStrategy;
using StrategyDesignPattern.Pokemon;

namespace StrategyDesignPattern
{
    public class PokemonGenerator
    {
        public PokemonBase Generate()
        {
            PokemonBase pokemon = new Zapdos();

            pokemon.ChargedAtack = new ThunderboltAttackStrategy();
            pokemon.FastAtack = new ClawAttack();

            return pokemon;
        }

        public PokemonBase ChangeFastAttack(
            PokemonBase pokemon)
        {
            pokemon.FastAtack = new WindAttack();
            return pokemon;
        }
    }
}