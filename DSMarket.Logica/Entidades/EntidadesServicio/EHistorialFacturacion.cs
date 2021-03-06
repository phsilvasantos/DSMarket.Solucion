﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesServicio
{
    public class EHistorialFacturacion
    {
		public string Cliente {get;set;}

		public string EstatusFacturacion {get;set;}

		public decimal? IdFactura {get;set;}

		public decimal? NumeroConector {get;set;}

		public int? IdEstatusFacturacion {get;set;}

		public string TipoIdentificacion {get;set;}

		public string DescripcionComprobante {get;set;}

		public string Comprobante {get;set;}

		public System.Nullable<decimal> IdComprobante {get;set;}

		public string Descripcion {get;set;}

		public string Telefono {get;set;}

		public string Email {get;set;}

		public System.Nullable<decimal> IdTipoIdentificacion {get;set;}

		public string NumeroIdentificacion {get;set;}

		public string Direccion {get;set;}

		public string Comentario {get;set;}

		public System.Nullable<decimal> IdTipoVenta {get;set;}

		public string TipoVenta {get;set;}

		public string CantidadDias {get;set;}

		public System.Nullable<decimal> IdCantidadDias {get;set;}

		public System.Nullable<int> IdTipoIngreso {get;set;}

		public string TipoIngreso {get;set;}

		public System.Nullable<decimal> IdUsuario {get;set;}

		public string CreadoPor {get;set;}

		public System.Nullable<System.DateTime> FechaFacturacion0 {get;set;}

		public string FechaFacturacion {get;set;}

		public System.Nullable<int> CantidadProductos {get;set;}

		public System.Nullable<int> CantidadServicios {get;set;}

		public System.Nullable<int> CantidadArticulos {get;set;}

		public System.Nullable<decimal> TotalDescuento {get;set;}

		public System.Nullable<decimal> SubTotal {get;set;}

		public System.Nullable<decimal> Impuesto {get;set;}

		public System.Nullable<int> PorcientoImpuesto {get;set;}

		public System.Nullable<decimal> MontoPagado {get;set;}

		public System.Nullable<decimal> Cambio {get;set;}

		public System.Nullable<decimal> IdTipoPago {get;set;}

		public string TipoPago {get;set;}

		public System.Nullable<int> PorcientoTipoPago {get;set;}

		public System.Nullable<decimal> MontoImpuestoTipoPago {get;set;}

		public System.Nullable<int> PorcientoImpuestoComprobante {get;set;}

		public System.Nullable<decimal> MontoImpuestoComprobante {get;set;}

		public System.Nullable<decimal> TotalGeneral {get;set;}

		public System.Nullable<bool> AplicaGarantia0 {get;set;}

		public string AplicaGarantia {get;set;}

		public System.Nullable<int> DiasGarantia {get;set;}

		public System.Nullable<int> TipoTiempoGarantia0 {get;set;}

		public string TipoTiempoGarantia {get;set;}

		public System.Nullable<int> CantidadRegistros {get;set;}
	}
}
