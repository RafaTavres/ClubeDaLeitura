using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubeDaLeitura.ConsoleApp.ClassesPais;
using ClubeDaLeitura.ConsoleApp.RegrasDeNogocio;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Amigo : Entidade
    {
        public string nome;
        public string nomeDoResponsavel;
        public string telefone;
        public Endereco endereco;

        public override void Atualizar(Entidade entidadeAtualizada)
        {
            Amigo amigo = (Amigo)entidadeAtualizada;
            nome = amigo.nome;
            nomeDoResponsavel = amigo.nomeDoResponsavel;
            telefone = amigo.telefone;
            endereco = amigo.endereco;
        }

    }
}
