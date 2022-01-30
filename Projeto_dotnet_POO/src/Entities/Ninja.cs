namespace Projeto_dotnet_POO.src.Entities
{
    internal class Ninja : Hero
    {
        public Ninja(string name, int level, string herotype) : base(name, level, herotype)
        {
        }

        public override string Attack()
        {
            return this.Name + " Lançou Shurikens ";
        }



    }



}
