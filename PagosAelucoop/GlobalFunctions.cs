using PagosAelucoop.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagosAelucoop
{
    public class GlobalFunctions
    {

        public static string sha256(string piString)
        {
            var crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(piString));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }
            return hash;
        }
        
        public static void ExportarDataGridViewCSV(DataGridView dgv, string fileName)
        {
            int limite = 500;
            if (dgv.Rows.Count > limite)
            {
                DialogResult dialogResult = MessageBox.Show("Tabla tiene mas de " + limite + " filas\nDesea Continuar", "Muchas Filas", MessageBoxButtons.YesNo);
                if (dialogResult != DialogResult.Yes)
                {
                    return;
                }
            }

            LoadingScreen.iniciarLoading();

            if (!Directory.Exists(Globals.ExportarPath))
            {
                Directory.CreateDirectory(Globals.ExportarPath);
            }
            if (fileName is null)
            {
                fileName = Globals.ExportarPath + "EXPORTAR_" + Globals.Username + "_" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".csv";
            }

            int cols;

            try
            {
                StreamWriter wr = new StreamWriter(fileName);
                cols = dgv.Columns.Count;
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    wr.Write(dgv.Columns[j].Name + System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator);
                }
                wr.WriteLine();

                //Recorremos el DataTable rellenando la hoja de trabajo
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        if (dgv.Rows[i].Cells[j] != null)
                        {
                            if (GlobalFunctions.IsDate(dgv.Rows[i].Cells[j].Value.ToString()))
                            {
                                try
                                {
                                    wr.Write(DateTime.Parse(dgv.Rows[i].Cells[j].Value.ToString()).ToString("yyyy-MM-dd HH:mm:ss") + System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator);
                                }
                                catch
                                {
                                    wr.Write("'" + dgv.Rows[i].Cells[j].Value.ToString() + System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator);
                                }
                            }
                            else
                            {
                                wr.Write(dgv.Rows[i].Cells[j].Value.ToString() + System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator);
                            }
                        }
                    }
                    wr.WriteLine();
                }
                wr.Close();

                Process.Start(fileName);

                LoadingScreen.cerrarLoading();

            }
            catch (Exception ex)
            {
                GlobalFunctions.casoError(ex, "");
                return;
            }

        }

        public static bool IsDate(Object obj)
        {
            string strDate = obj.ToString();
            try
            {
                DateTime dt = DateTime.Parse(strDate);
                if (dt != DateTime.MinValue && dt != DateTime.MaxValue)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }

        public static System.Data.DataTable ToDataTable<T>(List<T> items)
        {
            System.Data.DataTable dataTable = new System.Data.DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Defining type of data column gives proper data table 
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        public static string SinTildes(string texto)
        {
            string textoNormalizado = texto.Normalize(NormalizationForm.FormD);
            //Regex reg = new Regex("[^a-zA-Z0-9]");
            //return reg.Replace(textoNormalizado, "");
            return textoNormalizado;
        }

        public static void casoError(Exception ex, string strSQL)
        {
            Conexion.cerrar();
            Globals.lastSQL = strSQL;
            SimpleLog.Log(ex);
            LoadingScreen.cerrarLoading();
            MessageBox.Show(ex.Message + "\n" + strSQL);
        }
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        private static void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to release the object(object:{0})\n" + ex.Message, obj.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        public static void generarPDF(string idpago, string fileName)
        {

            if (!Directory.Exists(Globals.ExportarPath))
            {
                Directory.CreateDirectory(Globals.ExportarPath);
            }
            if (fileName is null)
            {
                fileName = Globals.ExportarPath + "EXPORTAR_" + Globals.Username + "_" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".pdf";
            }

            string strSQL = "SELECT TU.USERNAME, (SELECT NOMBRE FROM " + Globals.TablaEntidad  + " WHERE IDENTIDAD = TU.ENTIDAD) ENTIDAD, TP.CODIGO, TP.NUMDOC, TP.NUMDOC, TP.NOMBRECOMPLETO, TP.IMPORTE, TPR.FECHAPROCESO";
            strSQL += " FROM ((" + Globals.TablaProcesado + " TPR LEFT JOIN " + Globals.TablaPago + " TP ON TP.IDPAGO = TPR.IDPAGOFK)";
            strSQL += " LEFT JOIN " + Globals.TablaEntidad + " TE ON TE.IDENTIDAD = TPR.IDENTIDADFK)";
            strSQL += " LEFT JOIN " + Globals.TablaUsuario + " TU ON TU.IDUSER = TPR.IDUSERFK";
            strSQL += " WHERE IDPAGO = " + idpago;

            DataTable dt = new DataTable("REPORTE");

            if (!Conexion.conectar())
                return;
            if (!Conexion.iniciaCommand(strSQL))
                return;
            if (!Conexion.ejecutarQuery())
                return;
            dt = Conexion.llenarDataTable();
            if (dt is null)
                return;
            Conexion.cerrar();

            PdfDocument pdf = new PdfDocument();
            pdf.Info.Title = dt.Rows[0]["NOMBRECOMPLETO"].ToString() + " " + DateTime.Parse(dt.Rows[0]["FECHAPROCESO"].ToString()).ToString("yyyyMMddHHmmss");
            PdfPage pdfPage = pdf.AddPage();

            var path = Path.GetTempPath() + DateTime.Now.ToString("HHmmss") + ".jpg";
            Properties.Resources.LOMBRIMEX.Save(path);

            XGraphics graph = XGraphics.FromPdfPage(pdfPage);

            XImage xImage = XImage.FromFile(path);
            graph.DrawImage(xImage, new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point));

            int margentop = 300;
            int margenizquierdo1 = 50;
            int margenizquierdo2 = 200;

            int sangria = 30;

            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
            //graph.DrawString("This is my first PDF document", font, XBrushes.Black, new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString("Cooperativa:", font, XBrushes.Black, new XRect(margenizquierdo1, margentop, 100, 20), XStringFormats.TopLeft);
            graph.DrawString(dt.Rows[0]["ENTIDAD"].ToString(), font, XBrushes.Black, new XRect(margenizquierdo2, margentop, 100, 20), XStringFormats.TopLeft);

            graph.DrawString("Nombre:", font, XBrushes.Black, new XRect(margenizquierdo1, margentop + sangria, 100, 20), XStringFormats.TopLeft);
            graph.DrawString(dt.Rows[0]["NOMBRECOMPLETO"].ToString(), font, XBrushes.Black, new XRect(margenizquierdo2, margentop + sangria, 100, 20), XStringFormats.TopLeft);

            graph.DrawString("DOI:", font, XBrushes.Black, new XRect(margenizquierdo1, margentop + sangria*2, 100, 20), XStringFormats.TopLeft);
            graph.DrawString(dt.Rows[0]["NUMDOC"].ToString(), font, XBrushes.Black, new XRect(margenizquierdo2, margentop + sangria * 2, margentop, 20), XStringFormats.TopLeft);

            graph.DrawString("Fecha:", font, XBrushes.Black, new XRect(margenizquierdo1, margentop + sangria*3, 100, 20), XStringFormats.TopLeft);
            graph.DrawString(DateTime.Parse(dt.Rows[0]["FECHAPROCESO"].ToString()).ToString("dd/MM/yyyy"), font, XBrushes.Black, new XRect(margenizquierdo2, margentop + sangria * 3, 100, 20), XStringFormats.TopLeft);

            graph.DrawString("Hora:", font, XBrushes.Black, new XRect(margenizquierdo1, margentop + sangria*4, 100, 20), XStringFormats.TopLeft);
            graph.DrawString(DateTime.Parse(dt.Rows[0]["FECHAPROCESO"].ToString()).ToString("HH:mm:ss"), font, XBrushes.Black, new XRect(margenizquierdo2, margentop + + sangria * 4, 100, 20), XStringFormats.TopLeft);

            graph.DrawString("Firma: _________________     Huella: ______", font, XBrushes.Black, new XRect(margenizquierdo1, margentop + sangria * 10, 100, 20), XStringFormats.TopLeft);
            
            pdf.Save(fileName);
            Process.Start(fileName);
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
