using Fitas_Fabrica.Arquivo;
using Fitas_Fabrica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Fitas_Fabrica
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade;

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
            //Fita a qual o usuário deseja:
            string tipo;
            Console.WriteLine("Deseja fita Adesiva, ou não adesiva? adesiva/naoadesiva");
            tipo = Console.ReadLine();
            while ((tipo != "adesiva") && (r != "naoadesiva"))
            {
                Console.WriteLine("Valor inválido, digite novamente ");
                tipo = Console.ReadLine();
            }

            if (tipo == "adesiva")
            {
                try
                {
                    Adesiva adesiva = new Adesiva();
                    Console.WriteLine(" Qual tipo de fita adesiva procura? ");
                    adesiva.tipo = Console.ReadLine();
                    ArquivoPessoa.addText("Tipo de fita desejada: " + adesiva.tipo);
                    Console.WriteLine(" Deseja fita dupla face? ");
                    adesiva.duplaFace = Console.ReadLine();
                    ArquivoPessoa.addText("Fita Dupla Face: " + adesiva.duplaFace);
                    Console.WriteLine(" Aderência desejada: ");
                    adesiva.aderencia = double.Parse(Console.ReadLine());
                    ArquivoPessoa.addText("Aderência desejada na fita: " + adesiva.aderencia);
                    Console.WriteLine("Quantidade de fitas desse modelo desejadas: ");
                    quantidade = Convert.ToInt32(Console.ReadLine());

                    if ((r == "juridica") && (quantidade > 50))
                    {
                        precoFinal = (quantidade + (1.05 * adesiva.aderencia)) * 0.8;
                    }
                    else
                    {
                        precoFinal = quantidade + (1.05 * adesiva.aderencia);
                    }
                }
                catch (Exception erro)
                {
                    Console.WriteLine("Ocorreu o seguinte erro: " + erro.Message);
                    Console.ReadKey();
                }
                Console.WriteLine("preço final do pedido: " + precoFinal);
                ArquivoPessoa.addText("Preço final do pedido: " + precoFinal);
                Console.WriteLine("Pedido realizado com sucesso!!");

                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Quantidade de fitas decorativas desejadas: ");
                quantidade = Convert.ToInt32(Console.ReadLine());
                if ((r == "juridica") && (quantidade > 50))
                {
                    precoFinal = (quantidade)* 0.8;
                }
                else
                {
                    precoFinal = quantidade;
                }
                Console.WriteLine("preço final do pedido: " + precoFinal);
                ArquivoPessoa.addText("Preço final do pedido: " + precoFinal);
                Console.WriteLine("Pedido realizado com sucesso!!");
            }

            

        }
    }
}

