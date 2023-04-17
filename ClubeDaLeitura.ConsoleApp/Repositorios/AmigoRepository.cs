using ClubeDaLeitura.ConsoleApp.ClassesPais;
using ClubeDaLeitura.ConsoleApp.RegrasDeNogocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class AmigoRepository : Repository
    {

        public void InseriraAmigo(Amigo amigo)
        {
            Inserir(amigo);
        }
        public List<Object> RetornarTodosOsAmigos()
        {
            return listaEntidades;
        }
        public void AtualizarAmigos(int id,Amigo amigoAtualizado)
        {
            Entidade amigo = (Amigo)Busca(id);
            amigo.Atualizar(amigoAtualizado);
        }
        public void DeletarAmigos(int id)
        {
            Deletar(id);
        }
    }
}
