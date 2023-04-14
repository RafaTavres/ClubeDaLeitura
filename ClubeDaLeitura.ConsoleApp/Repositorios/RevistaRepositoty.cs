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
            revista.id = id;
            listaEntidades.Add(revista);
            IncrementaId();
        }
         public List<Object> RetornarTodosAsRevistas()
        {
            return listaEntidades;
        }
         public void AtualizarRevistas(int id, Revista revista)
        {
            foreach (Revista r in listaEntidades)
            {
                if (BuscaRevista(id).Equals(r))
                {
                    r.estaEmprestada = revista.estaEmprestada;
                    r.edicao = revista.edicao;
                    r.colecao = revista.colecao;
                    r.anoDaRevista = revista.anoDaRevista;
                    r.caixa = repositorioCaixa.BuscaCaixas(id);
                }
            }
        }
        public  Revista BuscaRevista(int id)
        {
            Revista revista = null;
            foreach (Revista r in listaEntidades)
            {
                if (r.id == id)
                {
                    revista = r;
                    return revista;
                }
            }
            return revista;
        }
        public void DeletaRevista(int id)
        {
            foreach (Revista r in listaEntidades)
            {
                if (BuscaRevista(id).Equals(r))
                {
                    listaEntidades.Remove(r);
                    break;
                }
            }
        }
    }
}
