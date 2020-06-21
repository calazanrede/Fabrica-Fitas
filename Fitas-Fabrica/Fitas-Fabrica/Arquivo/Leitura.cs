using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fitas_Fabrica.Arquivo
{
    class Leitura
    {
        public static bool ler(string nome)
        {
            try
            {   // Open the text file using a stream reader.
                bool flag = false;
                int contador = 0;
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Public\Banco de Dados.txt");
                foreach (var line in lines)
                {
                    if (line.Contains(nome))
                    {
                        flag = true;

                    }
                    if (flag)
                    {
                        Console.WriteLine(line);
                        ++contador;
                        if (contador == 12) break;
                    }



                }
                if (flag == false)
                {
                    Console.WriteLine("Esse cliente nao consta no banco de dados.");
                    return false;
                }





            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return true;
        }
    }
}