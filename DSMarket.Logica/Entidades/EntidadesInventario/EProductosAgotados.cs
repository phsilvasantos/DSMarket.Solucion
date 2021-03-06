﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesInventario
{
    public class EProductosAgotados
    {
        public System.Nullable<decimal> IdProducto {get;set;}

        public System.Nullable<decimal> NumeroConector {get;set;}

        public System.Nullable<decimal> IdTipoProducto {get;set;}

        public string Producto {get;set;}

        public string TipoProducto {get;set;}

        public System.Nullable<decimal> IdCategoria {get;set;}

        public string Categoria {get;set;}

        public System.Nullable<decimal> IdUnidadMedida {get;set;}

        public string UnidadMedida {get;set;}

        public System.Nullable<decimal> IdMarca {get;set;}

        public string Marca {get;set;}

        public System.Nullable<decimal> IdModelo {get;set;}

        public string Modelo {get;set;}

        public System.Nullable<decimal> IdTipoSuplidor {get;set;}

        public string TipoSuplidor {get;set;}

        public System.Nullable<decimal> IdSuplidor {get;set;}

        public string Suplidor {get;set;}

        public string CodigoBarra {get;set;}

        public string Referencia {get;set;}

        public System.Nullable<decimal> PrecioCompra {get;set;}

        public System.Nullable<decimal> PrecioVenta {get;set;}

        public System.Nullable<decimal> Stock {get;set;}

        public System.Nullable<decimal> StockMinimo {get;set;}

        public System.Nullable<decimal> PorcientoDescuento {get;set;}

        public System.Nullable<bool> AfectaOferta0 {get;set;}

        public string AceptaOferta {get;set;}

        public System.Nullable<bool> ProductoAcumulativo0 {get;set;}

        public string ProductoAcumulativo {get;set;}

        public System.Nullable<bool> LlevaImagen0 {get;set;}

        public string LlevaImagen {get;set;}

        public System.Nullable<decimal> UsuarioAdicion {get;set;}

        public string CreadoPor {get;set;}

        public System.Nullable<System.DateTime> FechaAdiciona {get;set;}

        public string FechaCreado {get;set;}

        public System.Nullable<decimal> UsuarioModifica {get;set;}

        public string ModificadoPor {get;set;}

        public System.Nullable<System.DateTime> FechaModifica {get;set;}

        public string FechaModificado {get;set;}

        public System.Nullable<System.DateTime> Fecha {get;set;}

        public System.Nullable<int> CantidadRegistros {get;set;}

        public string Comentario {get;set;}
    }
}
