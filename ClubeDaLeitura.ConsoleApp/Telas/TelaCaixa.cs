using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ClubeDaLeitura.ConsoleApp.ClassesPais;
using ClubeDaLeitura.ConsoleApp.RegrasDeNogocio;
using ClubeDaLeitura.ConsoleApp.Repositorios;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class TelaCaixa : Tela
    {
        public CaixaRepository repositorioCaixa = null;
        public void MenuCaixa(string opcao)
        {

            do           
            {
                Menu("Caixas");
                opcao = Console.ReadLine();
                if (opcao == "1")
                {
                    Console.Clear();
                    AdicionaCaixas();
                }
                if (opcao == "2")
                {
                    Console.Clear();
                    MostraTodasAsCaixas();
                    Console.ReadKey();
                }
                if (opcao == "3")
                {
                    Console.Clear();
                    MostraTodasAsCaixas();
                    AtualizaCaixas();
                }
                if (opcao == "4")
                {
                    Console.Clear();
                    MostraTodasAsCaixas();
                    DeletaCaixas();
                }

            } while (opcao.ToUpper() != "S");
            
        }
        private void AdicionaCaixas()
        {
            CaixaDeRevistas caixaDeRevistas = (CaixaDeRevistas)PegaDados();
            Adiciona(repositorioCaixa, caixaDeRevistas);
        }

        public void MostraTodasAsCaixas()
        {
            Console.WriteLine("Caixas: ");
            Console.WriteLine("____________________________________________________________________________");
            if (repositorioCaixa.MostraTodasAsCaixas().Count == 0)
            {
                ApresentaMensagem("Nenhuma Caixa Registradada", ConsoleColor.DarkYellow);
            }
            else
            {
                foreach (CaixaDeRevistas c in repositorioCaixa.MostraTodasAsCaixas())
                {
                    Console.WriteLine($"id: {c.id} | Etiqueta: {c.etiqueta} | Cor: {c.cor}");
                }
            }
        }
        private void AtualizaCaixas()
        {
            Console.WriteLine("Id para Editar: ");
            int idParaEditar = Convert.ToInt32(Console.ReadLine());
            CaixaDeRevistas caixaDeRevistas = (CaixaDeRevistas)PegaDados();
            repositorioCaixa.AtualizaCaixas(idParaEditar, caixaDeRevistas);
        }
        private void DeletaCaixas()
        {
            Console.WriteLine("Id para Deletar: ");
            int idParaDeletar = Convert.ToInt32(Console.ReadLine());
            repositorioCaixa.DeletaCaixas(idParaDeletar);
        }
        public override Entidade PegaDados()
        {
            CaixaDeRevistas novaCaixa = new CaixaDeRevistas();
            Console.WriteLine("Cor da Caixa: ");
            novaCaixa.cor = Console.ReadLine();
            Console.WriteLine("Numero da Caixa: ");
            novaCaixa.numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Etiqueta da Caixa: ");
            novaCaixa.etiqueta = Console.ReadLine();
            return novaCaixa;
        }
    }
}
