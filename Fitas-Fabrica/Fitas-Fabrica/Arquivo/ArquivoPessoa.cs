using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Fitas_Fabrica.Models;

namespace Fitas_Fabrica.Arquivo
{
    class ArquivoPessoa
    {
        public static void criar()
        {
            string path = @"C:\Users\Public\Banco de Dados.txt";

            if (!File.Exists(path))
            {

                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Dados do Cliente: ");

                }
            }

        }
        public static void addText(string text)
        {

            string path = @"C:\Users\Public\Banco de Dados.txt";

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(text);

            }


        }



    }
}