using ClubeDaLeitura.ConsoleApp.ClassesPais;
using ClubeDaLeitura.ConsoleApp.RegrasDeNogocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.Repositorios
{
    internal class EmprestimoRepository : Repository
    {
        public void InserirEmprestimo(Emprestimo emprestimo)
        {
            Inserir(emprestimo);
        }
        public List<Object> RetornarTodososEmprestimos()
        {
            return listaEntidades;
        }
        public void AtualizaEmprestimo(int id,Emprestimo emprestimoAtualizado)
        {
            Entidade emprestimo = (Emprestimo)Busca(id);
            emprestimo.Atualizar(emprestimoAtualizado);
        }
        public void DeletaEmprestimo(int id)
        {
            Deletar(id);
        }
        public void FechaEmprestimo(int id)
        {
            foreach (Emprestimo r in listaEntidades)
            {
                if (Busca(id).Equals(r))
                {
                    r.emAberto = false;
                    break;
                }
            }
        }
    }
}
