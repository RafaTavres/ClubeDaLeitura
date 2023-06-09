﻿using ClubeDaLeitura.ConsoleApp.ClassesPais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.RegrasDeNogocio
{
    internal class CaixaDeRevistas : Entidade
    {
        public int numero;
        public string cor;
        public string etiqueta;

        public override void Atualizar(Entidade entidadeAtualizada)
        {
            CaixaDeRevistas caixaDeRevistas = (CaixaDeRevistas)entidadeAtualizada;
            numero = caixaDeRevistas.numero;
            cor = caixaDeRevistas.cor;
            etiqueta = caixaDeRevistas.etiqueta;
        }
    }
}
