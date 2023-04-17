using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.ClassesPais
{
    internal class Entidade
    {
        public int id;

        public virtual void Atualizar(Entidade entidadeAtualizada)
        {
            id = entidadeAtualizada.id;
        }
    }

}
