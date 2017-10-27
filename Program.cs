using System;
using cadastrovendaspoo.classes;


namespace cadastrovendapoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##########################################");
            Console.WriteLine("#                                        #");
            Console.WriteLine("           Programa de vendas             ");
            Console.WriteLine("#                                        #");
            Console.WriteLine("##########################################");


            int opcao =0;
            while(opcao!=9){
                    Console.WriteLine("Digite: \n1- Para cadastro de clientes \n2- Para cadastro de produtos \n3 - cadastro de vendas \n4 - extrato do cliente \n9 - Sair ");
            opcao = int.Parse(Console.ReadLine());
            switch(opcao){
                case 1:
                Console.WriteLine("Digite o nome do cliente:");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o email do cliente:");
                string email = Console.ReadLine();

                Console.WriteLine("Digite o cpf do cliente:");
                string cpf = Console.ReadLine();

                Cliente cl = new Cliente(nome,email,cpf,DateTime.Now.Date);
                SalvarCliente sc = new SalvarCliente();
                //Console.WriteLine(new SalvarCliente().Salvar(cl));       
                Console.WriteLine(sc.Salvar(cl));      
                break;

                case 2:
                Console.WriteLine("Digite o Id do produto:");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o nome do produto:");
                string nomeproduto = Console.ReadLine();

                Console.WriteLine("Digite o preço do produto:");
                double preco = double.Parse(Console.ReadLine());

                Produto pr = new Produto(id,nomeproduto,preco);
                SalvarProduto sp = new SalvarProduto();
                Console.WriteLine(sp.Salvar(pr));      
                break;

            }
            }

            /* 
            Cliente cl = new Cliente();
            cl.Nome="jose";
            cl.Email="jose@gmail.com";
            cl.Cpf="21212154";
            cl.Datacadastro= DateTime.Today;

            Produto pr = new Produto();
            pr.Id =232;
            pr.Nomeproduto="detergente";
            pr.Descricao="um produto de limpeza";
            pr.preco=33,25; */
    }
}}
