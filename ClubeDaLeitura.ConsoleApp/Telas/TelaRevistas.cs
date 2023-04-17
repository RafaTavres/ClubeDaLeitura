using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubeDaLeitura.ConsoleApp.ClassesPais;
using ClubeDaLeitura.ConsoleApp.RegrasDeNogocio;
using ClubeDaLeitura.ConsoleApp.Repositorios;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class TelaRevistas : Tela
    {
        public RevistaRepositoty repositorioDeRevista = null;
        public CaixaRepository repositorioDeCaixas = null;
        public TelaCaixa telaCaixa = null;

        public void MenuRevista(string opcao)
        {          
            do
            {
                Menu("Revistas");
                opcao = Console.ReadLine();
                if (opcao == "1")
                {
                    Console.Clear();
                    AdicionaRevista();
                }
                if (opcao == "2")
                {
                    Console.Clear();
                    MostraTodosAsRevistas();
                    Console.ReadKey();
                }
                if (opcao == "3")
                {
                    Console.Clear();
                    MostraTodosAsRevistas();
                    AtualizaRevista();
                }
                if (opcao == "4")
                {
                    Console.Clear();
                    MostraTodosAsRevistas();
                    DeletaRevista();
                }

            }while (opcao.ToUpper() != "S");
            
        }

        private void AdicionaRevista()
        {
            Revista revista = (Revista)PegaDados();
            if (revista == null)
            {               
                ApresentaMensagem("Erro Revista deve possuir uma caixa!", ConsoleColor.DarkRed);
            }
            else
            {
                repositorioDeRevista.InseriraRevista(revista);
                ApresentaMensagem("Adicionada com Sucesso!", ConsoleColor.Green);
            }

        }
        public void MostraTodosAsRevistas()
        {
            Console.WriteLine("Revistas: ");
            Console.WriteLine("____________________________________________________________________________");
            if (repositorioDeRevista.RetornarTodosAsRevistas().Count == 0)
            {
                ApresentaMensagem("Nenhuma Revista Registradada", ConsoleColor.DarkYellow);
            }
            else
            {
                foreach (Revista a in repositorioDeRevista.RetornarTodosAsRevistas())
                {
                    Console.WriteLine($"id: {a.id} | Edição: {a.edicao} | Coleção : {a.colecao} | Ano da Revista: {a.anoDaRevista.ToString("dd/MMM/yyyy")} | Etique da Caixa :{a.caixa.etiqueta}");
                }
            }
        }
        private void AtualizaRevista()
        {
            Console.WriteLine("Id para Editar: ");
            int idParaEditar = Convert.ToInt32(Console.ReadLine());
            Revista revista = (Revista)PegaDados();
            repositorioDeRevista.AtualizarRevistas(idParaEditar,revista);
        }
        private void DeletaRevista()
        {
            Console.WriteLine("Id para Deletar: ");
            int idParaDeletar = Convert.ToInt32(Console.ReadLine());
            repositorioDeRevista.DeletaRevista(idParaDeletar);
        }
        public override Entidade PegaDados()
        {
            Revista novaRevista = new Revista();
            novaRevista.estaEmprestada = false;
            Console.WriteLine("Colecao : ");
            novaRevista.colecao = Console.ReadLine();
            Console.WriteLine("Edicao : ");
            novaRevista.edicao = Console.ReadLine();
            Console.WriteLine("Ano da Revista");
            novaRevista.anoDaRevista = Convert.ToDateTime(Console.ReadLine());
            Console.Clear();
            telaCaixa.MostraTodasAsCaixas();
            Console.WriteLine("____________________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("id da Caixa que deseja a Colocar a Revista");
            int id = Convert.ToInt32(Console.ReadLine());     
            novaRevista.caixa = (CaixaDeRevistas)repositorioDeCaixas.Busca(id);
            if (VerificaObjetosValidos(novaRevista.caixa) == true)
            {
                return novaRevista;
            }
            else
            {
                return null;
            }
        }

    }
}
