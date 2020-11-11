using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;


namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario sam = new Funcionario(2000, "159.357.486-82");
            Diretor adm = new Diretor(5000, "578.165.167-71"); //pode-se usar Funcionario e Diretor() pois Diretor é "filha" de Funcionario
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Console.WriteLine("O cpf de Sam é: " + sam.CPF);
            Console.WriteLine("O cpf de Adm é: " + adm.CPF);


            sam.Nome = "Sam";
            //sam.CPF = "159.357.486-82";
            //sam.Salario = 2000;
            gerenciador.Registrar(sam);
            sam.AumentaSalario();

            Console.WriteLine();
            Console.WriteLine("Salário Sam: " + sam.Salario);
            Console.WriteLine("A bonificação do funcionário Sam é de: " + sam.GetBonificacao());

            adm.Nome = "Adm";
            //adm.CPF = "578.165.167-71";
            //adm.Salario = 5000;
            gerenciador.Registrar(adm);
            adm.AumentaSalario();

            Console.WriteLine();
            Console.WriteLine("Salário Adm: " + adm.Salario);
            Console.WriteLine("A bonificação do diretor Adm é de: " + adm.GetBonificacao());

            Console.WriteLine();
            Console.WriteLine("A soma das bonificações é de: " + gerenciador.GetTotalBonificacao());

            Console.WriteLine();
            Console.WriteLine("Número de Funcionários: " + Funcionario.TotalFuncionarios);

            Console.ReadLine();
        }
    }
}
