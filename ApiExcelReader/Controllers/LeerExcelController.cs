﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Data;
using System.Data.OleDb;

using ApiExcelReader.Conexion;
using ApiExcelReader.Modelo;

namespace ApiExcelReader.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class LeerExcelController : Controller
    {

        ConexionExcelFiltros conexionExcelFiltros = new ConexionExcelFiltros();
        EntidadExcelListado entidadExcelListado = new EntidadExcelListado();

        string strdescripcionError = string.Empty;

        [HttpGet("{tipoBusqueda}&{palabraBusqueda}", Name = "obtenerTipoBusqueda")]
        public ActionResult<EntidadExcelListado> obtenerTipoBusqueda(int tipoBusqueda, string palabraBusqueda)
        {

            try
            {

                DataTable RespuestaTbConsulta = new DataTable();

                switch (tipoBusqueda)
                {
                    case 1:
                        RespuestaTbConsulta = conexionExcelFiltros.Consulta(string.Format("select * from [LEVANTAMIENTO SIEMENS$] where CODIGO_INASA = '{0}'", palabraBusqueda));
                        break;
                    case 2:
                        RespuestaTbConsulta = conexionExcelFiltros.Consulta(string.Format("select * from [LEVANTAMIENTO SIEMENS$] where CODIGO_ORIGINAL = '{0}'", palabraBusqueda));
                        break;
                    case 3:
                        RespuestaTbConsulta = conexionExcelFiltros.Consulta(string.Format("select * from [LEVANTAMIENTO SIEMENS$] where CODIGO_FORD = '{0}'", palabraBusqueda));
                        break;
                    case 4:
                        RespuestaTbConsulta = conexionExcelFiltros.Consulta(string.Format("select * from [LEVANTAMIENTO SIEMENS$] where ITEM_ALMACEN_FORD = '{0}'", palabraBusqueda));
                        break;
                    default:
                        break;
                }

                if (RespuestaTbConsulta.Rows.Count != 0)
                {
                    entidadExcelListado.CODIGO_FORD = RespuestaTbConsulta.Rows[0]["CODIGO_FORD"].ToString();
                    entidadExcelListado.CODIGO_ORIGINAL = RespuestaTbConsulta.Rows[0]["CODIGO_ORIGINAL"].ToString();
                    entidadExcelListado.error = "0";
                }
                else
                {
                    entidadExcelListado.error = "2";
                    entidadExcelListado.descripcionError = "no se encontro el producto solicitado.";
                }                                

                return entidadExcelListado;
            }

            catch (Exception ex)
            {
                entidadExcelListado.error = "1";
                strdescripcionError = ex.Message.ToString();
                entidadExcelListado.descripcionError = strdescripcionError;
                return entidadExcelListado;
                
            }           


        }


        





    }
    
}
