using ClubeDaLeitura.ConsoleApp.ClassesPais;
using ClubeDaLeitura.ConsoleApp.RegrasDeNogocio;
using ClubeDaLeitura.ConsoleApp.Repositorios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    
    internal class RevistaRepositoty : Repository
    {
         public CaixaRepository repositorioCaixa = null;
         public void InseriraRevista(Revista revista)
        {
            Inserir(revista);
        }
         public List<Object> RetornarTodosAsRevistas()
        {
            return listaEntidades;
        }
         public void AtualizarRevistas(int id, Revista revistaAtualizada)
        {
            Entidade revista = (Revista)Busca(id);
            revista.Atualizar(revistaAtualizada);
        }
        public void DeletaRevista(int id)
        {
            Deletar(id);
        }
    }
}
