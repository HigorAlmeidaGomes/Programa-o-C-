using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto, fornecedores, clientes,  nomef, endereco, descricao, nomesobre;
            double preço, validade, cnpj, fone,cpf;
            int  resposta;
            do
            {
                Console.WriteLine("|---------------------------|");
                Console.WriteLine("|SELECIONE AS OPÇÂO DESEJADA|");
                Console.WriteLine("|----PARA O CADASTRO--------|");
                Console.WriteLine("|[1]PRODUTO-----------------|");
                Console.WriteLine("|[2]CLIENTE-----------------|");
                Console.WriteLine("|[3]FONERCEDOR--------------|");
                Console.WriteLine("|[0]EXITE-------------------|");
                Console.WriteLine("|---------------------------|");
                resposta = Convert.ToInt32(Console.ReadLine());
                
                if (resposta == 0)
                {
                    Console.Clear();
                }


                if (resposta == 1)
                {
                    Console.WriteLine("|--CADASTRO PRODUTO--|");
                    Console.WriteLine("|--------------------|");
                    Console.WriteLine("|-DIGITE A DESCRIÇÃO-|");
                    Console.WriteLine("|____________________|");
                    descricao = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("DIGITE O PREÇO ");
                    preço = Double.Parse(Console.ReadLine());
                    Console.WriteLine("VALIDADE DO PRODUTO");
                    validade = Double.Parse(Console.ReadLine());
                    Console.WriteLine("|---------------------------------------------------|");
                    Console.WriteLine("|CADASTRADO COM SUCESSO                             |");
                    Console.WriteLine("|---------------------------------------------------|");
                    Console.WriteLine("|Produto " + descricao);
                    Console.WriteLine("|Preço " + preço);
                    Console.WriteLine("|Valido até " + validade);
                    Console.WriteLine("|---------------------------------------------------|");
                    Console.ReadKey(true);

                }
                else if (resposta == 2)
                {
                    Console.WriteLine("|--CADASTRO CLIENTE--|");
                    Console.WriteLine("|--------------------|");
                    Console.WriteLine("|------NOME----------|");
                    clientes = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("SOBRE NOME");
                    nomesobre = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("INFOME O CPF");
                    cpf = Double.Parse(Console.ReadLine());
                    Console.WriteLine("TELEFONE,FAX");
                    fone = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("INFORME O ENDEREÇO");
                    endereco = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("|---------------------------------------------------|");
                    Console.WriteLine("|CADASTRADO COM SUCESSO                             |");
                    Console.WriteLine("|---------------------------------------------------|");
                    Console.WriteLine("|NOME: " + clientes);
                    Console.WriteLine("|SOBRE NOME: " + nomesobre);
                    Console.WriteLine("|CPF: " + cpf);
                    Console.WriteLine("|TELEFONE OU FAX: " + fone);
                    Console.WriteLine("|ENDEREÇO: " + endereco);
                    Console.WriteLine("|---------------------------------------------------|");
                    Console.ReadKey(true);
                }
                else if (resposta == 3)
                {
                    Console.WriteLine("|CADASTRO FORNECEDOR-|");
                    Console.WriteLine("|--------------------|");
                    Console.WriteLine("|____________________|");
                    Console.WriteLine("NOME DO FORNECEDOR");
                    fornecedores = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("CNPJ OU CPF");
                    cnpj = Double.Parse(Console.ReadLine());
                    Console.WriteLine("TELEFONE,FAX");
                    fone = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("ENDEREÇO");
                    endereco = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("|---------------------------------------------------|");
                    Console.WriteLine("|CADASTRADO COM SUCESSO                             |");
                    Console.WriteLine("|---------------------------------------------------|");
                    Console.WriteLine("|FORNECEDOR " + fornecedores);
                    Console.WriteLine("|CNPJ " + cnpj);
                    Console.WriteLine("|TELEFONE " + fone);
                    Console.WriteLine("|ENDEREÇO " + endereco);
                    Console.WriteLine("|---------------------------------------------------|");
                    Console.ReadKey(true);
                }
                Console.Clear();
            }
            while (resposta != 0);
        }
    }
}
