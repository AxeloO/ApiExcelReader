﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace ApiExcelReader.Conexion
{
    public class ConexionExcelFiltros
    {

        public DataTable Consulta(string strConsulta, int intUbicacion)
        {
            string conexion = string.Empty;
       
            

            switch (intUbicacion)
            {
                case 1:
                     conexion = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Sitios/Documentos/INF APP FORD.XLSX; Extended Properties = \"Excel 8.0;HDR = YES\"";
                    break;
                case 2:
                     conexion = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Sitios/Documentos/Login.XLSX; Extended Properties = \"Excel 8.0;HDR = YES\"";
                    break;
                default:
                    break;
            }

            OleDbConnection conector = new OleDbConnection();
            conector = new OleDbConnection(conexion);
            conector.Open();
            OleDbCommand consulta = default(OleDbCommand);
            consulta = new OleDbCommand(strConsulta, conector);
            OleDbDataAdapter adaptador = new OleDbDataAdapter();
            adaptador.SelectCommand = consulta;
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            DataTable b = new DataTable();
            b = ds.Tables[0];

            conector.Close();


            return b;
        }


    }

}
