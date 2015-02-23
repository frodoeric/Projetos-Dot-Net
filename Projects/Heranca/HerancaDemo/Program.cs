
namespace HerancaDemo
{
    abstract class Animal
    {
        //protected int Idade;//protected privado mas as classes que herdam têm acesso

        public abstract void Falar();//método abstrato(membros abstratos) são obrigados a serem implementados

        public Animal()//Construtor vazio
        {

        }

        public Animal(string nome)
            : this(nome, 0)//Construtor chamando o outros(Encadear um construtor no outro)
        {
            
        }

        public Animal(string nome, int idade)
        {
            Nome = nome;

        }


        public string Nome { get; set; }

        public virtual void Andar()
        {
            System.Console.WriteLine("Animal andando");
            System.Console.Read();
        }
    }

    sealed class Cachorro : Animal
    {
        public Cachorro():base("Cachorro")//Construtor chama o construtor da classe pai
        {

        }

        public override void Falar()
        {
            throw new System.NotImplementedException();
        }

        public override void Andar()
        {
            base.Andar();
            System.Console.WriteLine("Cachorro andando");
            
        }
    }

    sealed class Gato : Animal
    {



        public Gato():base("Gato")
        {

        }

        public override void Falar()
        {
            throw new System.NotImplementedException();
        }

        public override void Andar()
        {
            System.Console.WriteLine("Gato andando");
            
        }
    }

    class CuidadorDeAnimais
    {
        
        public static void LevarParaPassear(Animal animal)
        {
            animal.Andar();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            

            var c = new Cachorro();
            c.Nome = "Fido";
            //Polimorfismo, interagir com vários tipos de objeto usando a mesma interface de objeto.    
            CuidadorDeAnimais.LevarParaPassear(c);

            var g = new Gato();
            g.Nome = "Miau";
            
            CuidadorDeAnimais.LevarParaPassear(g);
            
            System.Console.Read();

        }
    }
}
