namespace Projeto_dotnet_POO.src.Entities
{



    public class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string Herotype { get; set; }


        public Hero(string name, int level, string herotype)
        {
            Name = name;
            Level = level;
            Herotype = herotype;
        }


        public virtual string Attack()
        {
            return Name + " Atacou com sua espada";    
        }



        public override string ToString()
        {
            return $"{Name}  {Level}  {Herotype}";
        }


    }
}
