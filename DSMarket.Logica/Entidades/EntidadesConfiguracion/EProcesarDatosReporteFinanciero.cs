﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesConfiguracion
{
    public class EProcesarDatosReporteFinanciero
    {
        public System.Nullable<decimal> IdUsuario { get; set; }

        public System.Nullable<int> TipoReporte { get; set; }

        public string CuentaAuxiliar { get; set; }

        public string ConceptoCuenta { get; set; }

        public System.Nullable<decimal> Valor { get; set; }

        public string Cuenta { get; set; }

        public string CuentaDescargo { get; set; }

        public string Ano { get; set; }

        public string Mes { get; set; }
    }
}
