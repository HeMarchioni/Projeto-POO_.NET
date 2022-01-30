namespace Projeto_dotnet_POO.src.Entities
{
    internal class Wizard : Hero
    {
        public Wizard(string name, int level, string herotype) : base(name, level, herotype)
        {
        }


        public override string Attack()
        {
            return this.Name + "Lançou Magia";
        }

        public string Attack(int Bonus)
        {
            return this.Name + "Lançou Magia co bonus de ataque"+ Bonus;
        }


    }
}
