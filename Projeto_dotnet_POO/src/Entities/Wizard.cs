namespace Projeto_dotnet_POO.src.Entities
{
    internal class Wizard : Hero
    {
        public Wizard(string name, int level, string herotype) : base(name, level, herotype)
        {
        }


        public override string Attack()
        {
            return this.Name + " Lançou Magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
                return this.Name + "Lançou Magia super efetiva com bonus de " + Bonus;
            else
                return this.Name + "Lançou uma magia com força fraca com bonus de " + Bonus;



        }


    }
}
