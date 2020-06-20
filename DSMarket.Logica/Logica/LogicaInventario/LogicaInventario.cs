﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Logica.LogicaInventario
{
    public class LogicaInventario
    {
        DSMarket.Data.Conexion.ConexionLINQ.BDConexionInventarioDataContext Objdata = new Data.Conexion.ConexionLINQ.BDConexionInventarioDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["DSMarketConexion"].ConnectionString);

        #region MANTENIMIENTO DE TIPO DE PRODUCTO
        //LISTADO DE TIPO DE PRODUCTO
        public List<DSMarket.Logica.Entidades.EntidadesInventario.ETipoProducto> BuscaTipoProducto(decimal? IdTipoProducto = null, string Descripcion = null, int? NumeroPagina = null, int? NumeroRegistros = null)
        {
            Objdata.CommandTimeout = 999999999;

            var Buscar = (from n in Objdata.SP_BUSCA_TIPO_PRODUCTOS(IdTipoProducto, Descripcion, NumeroPagina, NumeroRegistros)
                          select new DSMarket.Logica.Entidades.EntidadesInventario.ETipoProducto
                          {
                             IdTipoproducto=n.IdTipoproducto,
                             Tipoproducto=n.Tipoproducto,
                             Estatus0=n.Estatus0,
                             Estatus=n.Estatus,
                             Acumulativo0=n.Acumulativo0,
                             Acumulativo=n.Acumulativo,
                             UsuarioAdiciona=n.UsuarioAdiciona,
                             CreadoPor=n.CreadoPor,
                             Fechaadiciona=n.Fechaadiciona,
                             FechaCreado=n.FechaCreado,
                             UsuarioModifica=n.UsuarioModifica,
                             ModificadoPor=n.ModificadoPor,
                             FechaModifica=n.FechaModifica,
                             FechaModificado=n.FechaModificado,
                             CantidadRegistros=n.CantidadRegistros   
                          }).ToList();
            return Buscar;
        }

        //MANTENIMIENTO DE TIPO DE PRODUCTO
        public DSMarket.Logica.Entidades.EntidadesInventario.ETipoProducto MantenimeintoTipoProducto(DSMarket.Logica.Entidades.EntidadesInventario.ETipoProducto Item, string Accion)
        {
            Objdata.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesInventario.ETipoProducto Mantenimeinto = null;

            var TipoProducto = Objdata.SP_MANTENIMIENTO_TIPO_PRODUCTO(
                Item.IdTipoproducto,
                Item.Tipoproducto,
                Item.Estatus0,
                Item.Acumulativo0,
                Item.UsuarioAdiciona,
                Accion);
            if (TipoProducto != null)
            {
                Mantenimeinto = (from n in TipoProducto
                                 select new DSMarket.Logica.Entidades.EntidadesInventario.ETipoProducto
                                 {
                                     IdTipoproducto=n.IdTipoproducto,
                                     Tipoproducto=n.Descripcion,
                                     Estatus0=n.Estatus,
                                     Acumulativo0=n.Acumulativo,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     Fechaadiciona=n.Fechaadiciona,
                                     UsuarioModifica=n.UsuarioModifica,
                                     FechaModifica=n.FechaModifica
                                 }).FirstOrDefault();
            }
            return Mantenimeinto;
        }
        #endregion

        #region MANTENIMIENTO DE CATEGORIAS
        //LISTADO DE CATEGORIAS
        public List<DSMarket.Logica.Entidades.EntidadesInventario.ECategorias> Buscacategoria(decimal? Idcategoria = null,decimal? IdTipoProducto = null, string Descripcion = null, int? NumeroPagina = null, int? Numeroregistros = null)
        {
            Objdata.CommandTimeout = 999999999;

            var Buscar = (from n in Objdata.SP_BUSCA_CATEGORIAS(Idcategoria,IdTipoProducto, Descripcion, NumeroPagina, Numeroregistros)
                          select new DSMarket.Logica.Entidades.EntidadesInventario.ECategorias
                          {
                              IdCategoria=n.IdCategoria,
                              IdTipoProducto=n.IdTipoProducto,
                              TipoProducto=n.TipoProducto,
                              Categoria=n.Categoria,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus,
                              UsuarioAdiciona=n.UsuarioAdiciona,
                              CreadoPor=n.CreadoPor,
                              Fechaadiciona=n.Fechaadiciona,
                              FechaCreado=n.FechaCreado,
                              UsuarioModifica=n.UsuarioModifica,
                              FechaModificado=n.FechaModificado,
                              FechaModifica=n.FechaModifica,
                              ModificadoPor=n.ModificadoPor,
                              CantidadRegistros=n.CantidadRegistros
                          }).ToList();
            return Buscar;
        }

        //MANTENIMIENTO DE CATEGORIAS
        public DSMarket.Logica.Entidades.EntidadesInventario.ECategorias MantenimientoCategorias(DSMarket.Logica.Entidades.EntidadesInventario.ECategorias Item, string Accion)
        {
            Objdata.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesInventario.ECategorias Mantenimiento = null;

            var Categoria = Objdata.SP_MANTENIMIENTO_CATEGORIAS(
                Item.IdCategoria,
                Item.IdTipoProducto,
                Item.Categoria,
                Item.Estatus0,
                Item.UsuarioAdiciona,
                Accion);
            if (Categoria != null)
            {
                Mantenimiento = (from n in Categoria
                                 select new DSMarket.Logica.Entidades.EntidadesInventario.ECategorias
                                 {
                                     IdCategoria=n.IdCategoria,
                                     IdTipoProducto=n.IdTipoProducto,
                                     Categoria=n.Descripcion,
                                     Estatus0=n.Estatus,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     Fechaadiciona=n.Fechaadiciona,
                                     UsuarioModifica=n.UsuarioModifica,
                                     FechaModifica = n.FechaModifica
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion

        #region MANTENIMIENTO DE MARCAS
        //LISTADO DE MARCAS
        public List<DSMarket.Logica.Entidades.EntidadesInventario.Emarcas> Buscamarcas(decimal? IdMarca = null, string Descripcion = null, int? NumeroPagina = null, int? Numeroregistros = null)
        {
            Objdata.CommandTimeout = 999999999;

            var Buscar = (from n in Objdata.SP_BUSCA_MARCAS(IdMarca, Descripcion, NumeroPagina, Numeroregistros)
                          select new DSMarket.Logica.Entidades.EntidadesInventario.Emarcas
                          {
                              IdMarca=n.IdMarca,
                              Marca=n.Marca,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus,
                              UsuarioAdiciona=n.UsuarioAdiciona,
                              CreadoPor=n.CreadoPor,
                              FechaAdiciona=n.FechaAdiciona,
                              FechaCreado=n.FechaCreado,
                              UsuarioModifica=n.UsuarioModifica,
                              ModificadoPor=n.ModificadoPor,
                              FechaModifica=n.FechaModifica,
                              FechaModificado=n.FechaModificado,
                              CantidadRegistros=n.CantidadRegistros
                          }).ToList();
            return Buscar;
        }

        //MANTENIMIENTO DE MARCAS
        public DSMarket.Logica.Entidades.EntidadesInventario.Emarcas MantenimientoMarcas(DSMarket.Logica.Entidades.EntidadesInventario.Emarcas Item, string Accion)
        {
            Objdata.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesInventario.Emarcas Mantenimiento = null;

            var Marcas = Objdata.SP_MANTENIMIENTO_MARCAS(
                Item.IdMarca,
                Item.Marca,
                Item.Estatus0,
                Item.UsuarioAdiciona,
                Accion);
            if (Marcas != null)
            {
                Mantenimiento = (from n in Marcas
                                 select new DSMarket.Logica.Entidades.EntidadesInventario.Emarcas
                                 {
                                     IdMarca=n.IdMarca,
                                     Marca=n.Descripcion,
                                     Estatus0=n.Estatus,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     FechaAdiciona=n.FechaAdiciona,
                                     UsuarioModifica=n.UsuarioModifica,
                                     FechaModifica=n.FechaModifica
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion

        #region MANTENIMIENTO DE UNIDAD DE MEDIDA
        //LISTADO DE UNIDAD DE MEDIDA
        public List<DSMarket.Logica.Entidades.EntidadesInventario.EUnidadMedida> BuscaUnidadMedida(decimal? IdUnidadMedida = null, string Descripcion = null, int? NumeroPagina = null, int? NumeroRegistros = null)
        {
            Objdata.CommandTimeout = 999999999;

            var Buscar = (from n in Objdata.SP_BUSCA_UNIDAD_MEDIDA(IdUnidadMedida, Descripcion, NumeroPagina, NumeroRegistros)
                          select new DSMarket.Logica.Entidades.EntidadesInventario.EUnidadMedida
                          {
                              IdUnidadMedida=n.IdUnidadMedida,
                              UnidadMedida=n.UnidadMedida,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus,
                              UsuarioAdiciona=n.UsuarioAdiciona,
                              CredoPor=n.CredoPor,
                              FechaAdiciona=n.FechaAdiciona,
                              FechaCreado=n.FechaCreado,
                              UsuarioModifica=n.UsuarioModifica,
                              ModificadoPor=n.ModificadoPor,
                              FechaModifica=n.FechaModifica,
                              FechaModificado=n.FechaModificado,
                              CantidadRegistros=n.CantidadRegistros
                          }).ToList();
            return Buscar;
        }

        //MANTENIMIENTO DE UNIDAD DE MEDIDA
        public DSMarket.Logica.Entidades.EntidadesInventario.EUnidadMedida MantenimientoUnidadMedida(DSMarket.Logica.Entidades.EntidadesInventario.EUnidadMedida Item, string Accion)
        {
            Objdata.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesInventario.EUnidadMedida Mantenimiento = null;

            var UnudadMedda = Objdata.SP_MANTENIMIENTO_UNIDAD_MEDIDA(
                Item.IdUnidadMedida,
                Item.UnidadMedida,
                Item.Estatus0,
                Item.UsuarioAdiciona,
                Accion);
            if (UnudadMedda != null)
            {
                Mantenimiento = (from n in UnudadMedda
                                 select new DSMarket.Logica.Entidades.EntidadesInventario.EUnidadMedida
                                 {
                                     IdUnidadMedida=n.IdUnidadMedida,
                                     UnidadMedida=n.Descripcion,
                                     Estatus0=n.Estatus,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     FechaAdiciona=n.FechaAdiciona,
                                     UsuarioModifica=n.UsuarioModifica,
                                     FechaModifica=n.FechaModifica
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion

        #region MANTENIMIENTO DE MODELOS
        //LISTADO DE MODELOS
        public List<DSMarket.Logica.Entidades.EntidadesInventario.EModelos> BuscaModelos(decimal? IdMarca = null, decimal? IdModelo = null, string Descripcion = null, int? NumeroPagina = null, int? Numeroregistro = null)
        {
            Objdata.CommandTimeout = 999999999;

            var Buscar = (from n in Objdata.SP_BUSCA_MODELOS(IdMarca, IdModelo, Descripcion, NumeroPagina, Numeroregistro)
                          select new DSMarket.Logica.Entidades.EntidadesInventario.EModelos
                          {
                              IdMarca=n.IdMarca,
                              IdModelo=n.IdModelo,
                              Marca=n.Marca,
                              Modelo=n.Modelo,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus,
                              UsuarioAdiciona=n.UsuarioAdiciona,
                              CreadoPor=n.CreadoPor,
                              FechaAdiciona=n.FechaAdiciona,
                              FechaCreado=n.FechaCreado,
                              UsuarioModifica=n.UsuarioModifica,
                              ModificadoPor=n.ModificadoPor,
                              FechaModifica=n.FechaModifica,
                              FechaModificado=n.FechaModificado,
                              CantidadRegistros=n.CantidadRegistros
                          }).ToList();
            return Buscar;
        }

        //MANTENIMIENTO DE MODELOS
        public DSMarket.Logica.Entidades.EntidadesInventario.EModelos MantenimientoModelos(DSMarket.Logica.Entidades.EntidadesInventario.EModelos Item, string Accion)
        {
            Objdata.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesInventario.EModelos Mantenimiento = null;

            var Modelos = Objdata.SP_MANTENIMIENTO_MODELO(
                Item.IdMarca,
                Item.IdModelo,
                Item.Modelo,
                Item.Estatus0,
                Item.UsuarioAdiciona,
               Accion);
            if (Modelos != null)
            {
                Mantenimiento = (from n in Modelos
                                 select new DSMarket.Logica.Entidades.EntidadesInventario.EModelos
                                 {
                                     IdMarca=n.IdMarca,
                                     IdModelo=n.IdModelo,
                                     Modelo=n.Descripcion,
                                     Estatus0=n.Estatus,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     FechaAdiciona=n.FechaAdiciona,
                                     UsuarioModifica=n.UsuarioModifica,
                                     FechaModifica=n.FechaModifica
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion

        #region MANTENIMIENTO DE TIPO DE SUPLIDORES
        //LISTADO DE TIPO DE SUPLIDORES
        public List<DSMarket.Logica.Entidades.EntidadesInventario.ETipoSuplidores> BuscaTipoSupidores(decimal? IdTipoSuplidor = null, string Descripcion = null, int? NumeroPagina = null, int? NumeroRegistros = null)
        {
            Objdata.CommandTimeout = 999999999;

            var Buscar = (from n in Objdata.SP_BUSCA_TIPO_SUPLIDORES(IdTipoSuplidor, Descripcion, NumeroPagina, NumeroRegistros)
                          select new DSMarket.Logica.Entidades.EntidadesInventario.ETipoSuplidores
                          {
                              IdTipoSuplidor=n.IdTipoSuplidor,
                              TipoSuplidor=n.TipoSuplidor,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus,
                              UsuarioAdiciona=n.UsuarioAdiciona,
                              CreadoPor=n.CreadoPor,
                              FechaAdiciona=n.FechaAdiciona,
                              FechaCreado=n.FechaCreado,
                              UsuarioModifica=n.UsuarioModifica,
                              ModificadoPor=n.ModificadoPor,
                              FechaModificado=n.FechaModificado,
                              FechaModifica=n.FechaModifica,
                              CantidadRegistros=n.CantidadRegistros
                          }).ToList();
            return Buscar;
        }

        //MANTENIMIENTO DE TIPO DE SUPLIDORES
        public DSMarket.Logica.Entidades.EntidadesInventario.ETipoSuplidores MantenimientoTipoSuplidores(DSMarket.Logica.Entidades.EntidadesInventario.ETipoSuplidores Item, string Accion)
        {
            Objdata.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesInventario.ETipoSuplidores Mantenimiento = null;

            var TipoSuplidor = Objdata.SP_MANTENIMIENTO_TIPO_SUPLIDOR(
                Item.IdTipoSuplidor,
                Item.TipoSuplidor,
                Item.Estatus0,
                Item.UsuarioAdiciona,
                Accion);
            if (TipoSuplidor != null)
            {
                Mantenimiento = (from n in TipoSuplidor
                                 select new DSMarket.Logica.Entidades.EntidadesInventario.ETipoSuplidores
                                 {
                                     IdTipoSuplidor=n.IdTipoSuplidor,
                                     TipoSuplidor=n.Descripcion,
                                     Estatus0=n.Estatus,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     FechaAdiciona=n.FechaAdiciona,
                                     UsuarioModifica=n.UsuarioModifica,
                                     FechaModifica=n.FechaModifica
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion

        #region MANTENIMIENTO DE SUPLIDORES
        //LISTADO DE SUPLIDORES
        public List<DSMarket.Logica.Entidades.EntidadesInventario.ESuplidores> BuscaSupervisores(decimal? IdTipoSuplidor = null, decimal? IdSuplidor = null, string Suplidor = null, int? NumeroPagina = null, int? NumeroRegistros = 10)
        {
            Objdata.CommandTimeout = 999999999;

            var Listado = (from n in Objdata.SP_BUSCA_SUPLIDORES(IdTipoSuplidor, IdSuplidor, Suplidor, NumeroPagina, NumeroRegistros)
                           select new DSMarket.Logica.Entidades.EntidadesInventario.ESuplidores
                           {
                               IdTipoSuplidor=n.IdTipoSuplidor,
                               TipoSuplidor=n.TipoSuplidor,
                               IdSuplidor=n.IdSuplidor,
                               Suplidor=n.Suplidor,
                               Telefono=n.Telefono,
                               Email=n.Email,
                               Direccion=n.Direccion,
                               Contacto=n.Contacto,
                               Estatus0=n.Estatus0,
                               Estatus=n.Estatus,
                               UsuarioAdiciona=n.UsuarioAdiciona,
                               CreadoPor=n.CreadoPor,
                               FechaAdiciona=n.FechaAdiciona,
                               FechaCreado=n.FechaCreado,
                               UsuarioModifica=n.UsuarioModifica,
                               ModificadoPor=n.ModificadoPor,
                               FechaModifica=n.FechaModifica,
                               FechaModificado=n.FechaModificado,
                               CantidadRegistros=n.CantidadRegistros
                           }).ToList();
            return Listado;
        }
        //MANTENIMIENTO DE SUPLIDORES
        public DSMarket.Logica.Entidades.EntidadesInventario.ESuplidores MantenimientoSuplidores(DSMarket.Logica.Entidades.EntidadesInventario.ESuplidores Item, string Accion)
        {
            Objdata.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesInventario.ESuplidores Mantenimiento = null;

            var Suplidor = Objdata.SP_MANTENIMIENTO_SUPLIDORES(
                Item.IdTipoSuplidor,
                Item.IdSuplidor,
                Item.Suplidor,
                Item.Telefono,
                Item.Email,
                Item.Direccion,
                Item.Contacto,
                Item.Estatus0,
                Item.UsuarioAdiciona,
                Accion);
            if (Suplidor != null)
            {
                Mantenimiento = (from n in Suplidor
                                 select new DSMarket.Logica.Entidades.EntidadesInventario.ESuplidores
                                 {
                                     IdTipoSuplidor=n.IdTipoSuplidor,
                                     IdSuplidor=n.IdSuplidor,
                                     Suplidor=n.Nombre,
                                     Telefono=n.Telefono,
                                     Email=n.Email,
                                     Direccion=n.Direccion,
                                     Contacto=n.Contacto,
                                     Estatus0=n.Estatus,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     FechaAdiciona=n.FechaAdiciona,
                                     UsuarioModifica=n.UsuarioModifica,
                                     FechaModifica=n.FechaModifica
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion
    }
}
