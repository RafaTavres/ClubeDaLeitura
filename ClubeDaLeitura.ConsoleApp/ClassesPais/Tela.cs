using ClubeDaLeitura.ConsoleApp.RegrasDeNogocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.ClassesPais
{
    internal class Tela
    {
        public void ApresentaMensagem(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
            Console.ReadKey();
       }
        public bool VerificaObjetosValidos(Object objeto)
        {
            if (objeto == null)
            {
                return false;
            }
            else
                return true;
        }
        public void Menu(string nome)
        {
            Console.Clear();
            Console.WriteLine($"----Menu {nome}----\n");
            Console.WriteLine($"1- Adicionar {nome} | 2- Ver {nome} | 3- Atualizar {nome} | 4- Deletar {nome} | S- Sair");
        }
        public void Adiciona(Repository repositorio, Entidade novaEntidade)
        {
            repositorio.Inserir(novaEntidade);
        }
        public virtual Entidade PegaDados()
        {
            Console.Clear();
            Entidade entidade = new Entidade();          
            return entidade;
        }
    }

}
