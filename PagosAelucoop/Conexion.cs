﻿using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PagosAelucoop
{
    class Conexion
    {

        public static SqlConnection connection;
        public static SqlCommand command;
        public static SqlDataReader reader;
        public static bool conectar()
        {
            try
            {
                ConnString connString = new ConnString();
                string conexion;
                if (ConfigurationManager.AppSettings["customConnection"].ToString() != "")
                {
                    conexion = ConfigurationManager.AppSettings["customConnection"].ToString();
                }
                else
                {
                    conexion = connString.GetString(ConfigurationManager.AppSettings["ambiente"].ToString());
                }

                connection = new SqlConnection(conexion);
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                GlobalFunctions.casoError(ex, "");
                return false;
            }
        }

        public static bool iniciaCommand(string strSQL)
        {
            try
            {
                command = new SqlCommand(strSQL, connection);
                return true;
            }
            catch (Exception ex)
            {
                GlobalFunctions.casoError(ex, strSQL);
                return false;
            }
        }

        public static bool ejecutarQuery()
        {
            try
            {
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                GlobalFunctions.casoError(ex, command.CommandText);
                return false;
            }
        }

        public static int ejecutarQueryReturn()
        {
            try
            {
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                GlobalFunctions.casoError(ex, command.CommandText);
                return 0;
            }
        }
        public static int ejecutarQueryEscalar()
        {
            try
            {
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                GlobalFunctions.casoError(ex, command.CommandText);
                return -1;
            }
        }

        public static DataTable llenarDataTable()
        {
            DataTable dt = new DataTable();
            try
            {
                reader = command.ExecuteReader();
                dt.Load(reader);
                return dt;
            }
            catch (Exception ex)
            {
                GlobalFunctions.casoError(ex, command.CommandText);
                return null;
            }
        }

        public static int lastIdInsert()
        {
            SqlCommand cmd2 = new SqlCommand("SELECT @@IDENTITY", connection);
            try
            {
                return Convert.ToInt32(cmd2.ExecuteScalar());
            }
            catch (Exception ex)
            {
                GlobalFunctions.casoError(ex, "SELECT @@IDENTITY");
                return -1;
            }
        }

        public static void cerrar()
        {
            try
            {
                if (connection != null)
                    connection.Close();
            }
            catch (Exception ex)
            {
                SimpleLog.Log(ex);
            }

            try
            {
                if (connection != null)
                    connection.Dispose();
            }
            catch (Exception ex)
            {
                SimpleLog.Log(ex);
            }

            try
            {
                if (reader != null)
                    reader.Dispose();
            }
            catch (Exception ex)
            {
                SimpleLog.Log(ex);
            }

            try
            {
                if (command != null)
                    command.Dispose();
            }
            catch (Exception ex)
            {
                SimpleLog.Log(ex);
            }
        }

    }
}
