﻿using Entidades.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Produtos
{
    public class SaborPizza
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public string Observacao { get; set; }
        public decimal ValorAdicional { get; set; }
        public Status Status { get; set; }
        public DateTime DtAlteracao { get; set; }
        public int CodigoUsrAlteracao { get; set; }
    }
}
