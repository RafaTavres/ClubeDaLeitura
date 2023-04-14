using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubeDaLeitura.ConsoleApp.ClassesPais;
using ClubeDaLeitura.ConsoleApp.RegrasDeNogocio;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Revista : Entidade
    {
        public string colecao;
        public bool estaEmprestada;
        public string edicao;
        public DateTime anoDaRevista;
        public CaixaDeRevistas caixa;
    }
}
