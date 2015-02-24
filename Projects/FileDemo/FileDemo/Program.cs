using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //  string texto = "olha só heim meu!";
            //@ verbate usado para incluir tudo que está dentro da string, até caracteres especiais como " ou \
            //string caminho = @"e:\arquivo.txt";
            //File.WriteAllText(caminho, texto);

            //string textoLido = File.ReadAllText(caminho);
            //string[] linhas = File.ReadAllLines(caminho);
            


            //Console.WriteLine(textoLido);

            //foreach (var item in linhas)
            //{
            //    textoLido += item;
            //}

            //Console.WriteLine(textoLido);

            //var arquivo = new FileInfo(caminho);//usado para referenciar o próprio arquivo

            //if (arquivo.Exists)
            //{
            //    arquivo.Delete();
            //}

            //Directory.CreateDirectory(@"E:\Minha Pasta");
            //var arquivos = Directory.GetFiles(@"E:\Minha Pasta");

            ////cria uma variável que representa a pasta
            //DirectoryInfo pasta = new DirectoryInfo(@"E:\Minha Pasta");
            
            //string pasta = @"E:\Minha Pasta";
            //string arquivo = @"arquivo.txt";

            //Path.Combine(pasta, arquivo);//junta a pasta com o arquivo

            //var temp = Path.GetTempPath();
            
            //Console.Read();

            StreamWriter();
            
        }

        static void StreamWriter()
        {
            string destinationFilePath = @"E:\setting.txt";
            string data = "Hello, this will be written in plain text";

            using (var destFile = new FileStream(
                destinationFilePath, 
                FileMode.Create,
                FileAccess.Write))
            using (var writer = new StreamWriter(destFile))
            {
                writer.WriteLine(data);
            }
                
        }
    }
}
