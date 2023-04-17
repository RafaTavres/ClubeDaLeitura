using ClubeDaLeitura.ConsoleApp.ClassesPais;
using ClubeDaLeitura.ConsoleApp.RegrasDeNogocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.Repositorios
{
    internal class CaixaRepository : Repository
    {
        public void InserirCaixas(CaixaDeRevistas caixaRevistas)
        {
            Inserir(caixaRevistas);
        }

        public List<Object> MostraTodasAsCaixas()
        {
            return listaEntidades;
        }
        public void AtualizaCaixas(int id, CaixaDeRevistas caixaRevistasAtualizada)
        {
            Entidade caixa  = (CaixaDeRevistas)Busca(id);
            caixa.Atualizar(caixaRevistasAtualizada);
        }
        public void DeletaCaixas(int id)
        {
            Deletar(id);
        }
    }
}
