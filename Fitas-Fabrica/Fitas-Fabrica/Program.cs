using Fitas_Fabrica.Arquivo;
using Fitas_Fabrica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Fitas_Fabrica
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double precoFinal = 0;
            ArquivoPessoa.criar();
            //identificando tipo de pessoa
            string r;
            Console.WriteLine("Informe se o cliente é pessoa fisica ou juridica: ");
            r = Console.ReadLine();
            while ((r != "fisica") && (r != "juridica"))
            {
                Console.WriteLine("valor inválido, digite novamente: ");
                r = Console.ReadLine();
            }

            if (r == "juridica")
            {
                Juridica pessoa = new Juridica();

                Console.WriteLine("Digite o nome do cliente: ");
                pessoa.nomePessoa = (Console.ReadLine());
                ArquivoPessoa.addText("Nome: " + pessoa.nomePessoa);

                Console.WriteLine("Digite o cnpj do cliente: ");
                pessoa.cnpj = (Console.ReadLine());
                ArquivoPessoa.addText("cnpj: " + pessoa.nomePessoa);


                Console.WriteLine("Digite o numero do cliente: ");
                pessoa.numeroPessoa = (Console.ReadLine());
                ArquivoPessoa.addText("Numero: " + pessoa.numeroPessoa);

                Console.WriteLine("Digite o endereço do cliente: ");
                pessoa.enderecoPessoa = (Console.ReadLine());
                ArquivoPessoa.addText("Endereço: " + pessoa.enderecoPessoa);

                Console.WriteLine("Razão social: ");
                pessoa.razaoSocial = (Console.ReadLine());
                ArquivoPessoa.addText("Razão Social: " + pessoa.razaoSocial);

                Console.WriteLine("CNAE: ");
                pessoa.cnae = ("CNAE: " + Console.ReadLine());
                ArquivoPessoa.addText(pessoa.cnae);

                Console.WriteLine("A empresa é uma multinacional? (sim/nao) ");
                r = Console.ReadLine();
                while ((r != "sim") && (r != "nao"))
                {
                    Console.WriteLine("Valor inválido, digite novamente ");
                    r = Console.ReadLine();
                }
                if (r == "sim")
                {
                    pessoa.multinacional = (true);
                    ArquivoPessoa.addText("Multinacional: Sim ");
                }
                else
                {
                    pessoa.multinacional = false;
                    ArquivoPessoa.addText("Multinacional: Não ");
                }

                Console.WriteLine("Informe o tipo de empresa: ");
                pessoa.tipoEmpresa = (Console.ReadLine());
                ArquivoPessoa.addText("Tipo: " + pessoa.tipoEmpresa);

                Console.WriteLine("Responsável: ");
                pessoa.responsavel = (Console.ReadLine());
                ArquivoPessoa.addText("Responsavel: " + pessoa.responsavel);
            }
            else
            {
                Fisica pessoa = new Fisica();
                Console.WriteLine("Digite o nome do cliente: ");
                pessoa.cpf = (Console.ReadLine());
                ArquivoPessoa.addText("cpf: " + pessoa.nomePessoa);

                Console.WriteLine("Digite o nome do cliente: ");
                pessoa.nomePessoa = (Console.ReadLine());
                ArquivoPessoa.addText("Nome: " + pessoa.nomePessoa);

                Console.WriteLine("Digite o numero do cliente: ");
                pessoa.numeroPessoa = (Console.ReadLine());
                ArquivoPessoa.addText("Numero: " + pessoa.numeroPessoa);

                Console.WriteLine("Digite o endereço do cliente: ");
                pessoa.enderecoPessoa = (Console.ReadLine());
                ArquivoPessoa.addText("Endereço: " + pessoa.enderecoPessoa);

                Console.WriteLine("Digite a idade do cliente: ");
                pessoa.idade = (Console.ReadLine());
                ArquivoPessoa.addText("Idade: " + pessoa.idade);

                Console.WriteLine("Digite o rg do cliente: ");
                pessoa.rg = (Console.ReadLine());
                ArquivoPessoa.addText("RG: " + pessoa.rg);

                Console.WriteLine("Nacionalidade do cliente: ");
                pessoa.nacionalidade = Console.ReadLine();
                ArquivoPessoa.addText("Nacionalidade: " + pessoa.nacionalidade);
            }
        }
    }
}
