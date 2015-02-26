using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesDemo
{
    [DebuggerDisplay("Nome: {name}")]
    class Program
    {
        static void Main(string[] args)
        {
          var classe = new Teste();
          var type = classe.GetType(); // pega o tipo da instancia

          var attributes = type.GetCustomAttributes(typeof (DeveloperInfo), false);//pega todos os atributos que são desse tipo

          foreach (var attribute in attributes)
          {
              var devInfo = (DeveloperInfo)attribute;
            Console.WriteLine((devInfo.EmailAddress));
            Console.WriteLine(devInfo.Revision);
          }

//#pragma warning disable 0618 // diretiva de compilação para ignorar o warning.
//          QualquerCoisa();
//#pragma warning restore 0618
        }

      //[Obsolete("Ninguém usa mais essa pinóia!")]
      //public static void QualquerCoisa()
      //{
       
      //}


    }


    [DeveloperInfo("fulano@fulano.com", 1)]
  public class Teste
  {
    
  }

    [AttributeUsage(AttributeTargets.All)]//atributo
  public class DeveloperInfo : Attribute
  {
      public string EmailAddress { get; set; }
      public int Revision { get; set; }
        

      public DeveloperInfo(string emailAddress, int revision)
      {
        EmailAddress = emailAddress;
        Revision = revision;
      }
    
  }

}
