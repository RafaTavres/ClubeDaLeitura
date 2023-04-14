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
            caixaRevistas.id = id;
            listaEntidades.Add(caixaRevistas);
            IncrementaId();
        }

        public List<Object> MostraTodasAsCaixas()
        {
            return listaEntidades;
        }
        public void AtualizaCaixas(int id, CaixaDeRevistas caixaRevistas)
        {
            foreach (CaixaDeRevistas c in listaEntidades)
            {
                if (BuscaCaixas(id).Equals(c))
                {
                    c.cor = caixaRevistas.cor;
                    c.etiqueta= caixaRevistas.etiqueta;
                    c.numero = caixaRevistas.numero;
                }
            }
        }
        public void DeletaCaixas(int id)
        {
            foreach (CaixaDeRevistas c in listaEntidades)
            {
                if (BuscaCaixas(id).Equals(c))
                {
                    listaEntidades.Remove(c);
                    break;
                }
            }
        }
        public CaixaDeRevistas BuscaCaixas(int id)
        {
            CaixaDeRevistas caixa = null;

            foreach (CaixaDeRevistas c in listaEntidades)
            {
                if (c.id == id)
                {
                    caixa = c;
                    return caixa;
                }
            }
            return caixa;
        }
    }
}
