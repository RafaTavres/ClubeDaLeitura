using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Repository
    {
        public int id = 1;
        public List<Object> listaEntidades = new  List<Object>();
        public int IncrementaId()
        {
            return id++;
        }
    }
}
