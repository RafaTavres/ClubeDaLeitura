using ClubeDaLeitura.ConsoleApp.ClassesPais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.RegrasDeNogocio
{
    internal class Emprestimo : Entidade
    {
        public bool emAberto;
        public Amigo amigoQueEmprestou;
        public Revista revistaEmprestada;
        public DateTime dataDoEmpresimo;
        public DateTime dataDeDevolução;

        public override void Atualizar(Entidade entidadeAtualizada)
        {
            Emprestimo emprestimo = (Emprestimo)entidadeAtualizada;
            emAberto = true;
            amigoQueEmprestou = emprestimo.amigoQueEmprestou;
            revistaEmprestada = emprestimo.revistaEmprestada;
            dataDoEmpresimo = emprestimo.dataDoEmpresimo;
            dataDeDevolução = emprestimo.dataDeDevolução;
        }

    }
}
