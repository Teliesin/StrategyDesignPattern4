namespace StrategyDesignPattern.Pokemon
{
    public abstract class PokemonBase
    {
        public IAttackStrategy FastAtack { get; set; }
        public IAttackStrategy ChargedAtack { get; set; }

        public abstract void MakeFastAttack();
        public abstract void MakeChargeAttack();
    }
}