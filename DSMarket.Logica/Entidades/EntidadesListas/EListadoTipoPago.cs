﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesListas
{
    public class EListadoTipoPago
    {
        public decimal? IdTipoPago { get; set; }

        public string TipoPago { get; set; }

        public System.Nullable<bool> BloqueaMonto { get; set; }

        public System.Nullable<bool> ImpuestoAdicional { get; set; }

        public System.Nullable<bool> PorcentajeEntero { get; set; }

        public System.Nullable<decimal> Valor { get; set; }
    }
}
