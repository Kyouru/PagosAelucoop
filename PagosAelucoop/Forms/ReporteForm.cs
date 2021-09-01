using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagosAelucoop.Forms
{
    public partial class ReporteForm : Form
    {
        public ReporteForm()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (tbFechaInicio.Text != "" && tbFechaFin.Text != "")
            {
                if (GlobalFunctions.IsDate(tbFechaInicio.Text) && GlobalFunctions.IsDate(tbFechaFin.Text))
                {
                    DataTable dt = new DataTable("REPORTE");

                    string strSQL = "SELECT IDPAGO, CODIGO, NUMDOC, NOMBRECOMPLETO, IMPORTE, FECHAPAGO, DIRECCION, EMAIL, TELEFONO1, TELEFONO2, TE.NOMBRE AS COOPERATIVA, TPR.NUMCUENTA, TPR.NOMBREDESTINO, TPR.USERNAME, TPR.FECHAPROCESO";
                    strSQL += " FROM (" + Globals.TablaPago + " TP LEFT JOIN " + Globals.TablaProcesado + " TPR ON TP.IDPAGO = TPR.IDPAGOFK)";
                    strSQL += " LEFT JOIN " + Globals.TablaEntidad + " TE ON TE.IDENTIDAD = TPR.IDENTIDADFK";
                    strSQL += " WHERE TPR.ACTIVO = 1";
                    strSQL += " AND FECHAPROCESO >= '" + DateTime.Parse(tbFechaInicio.Text).ToString("yyyy-MM-dd") + "'";
                    strSQL += " AND FECHAPROCESO <= '" + DateTime.Parse(tbFechaFin.Text).ToString("yyyy-MM-dd") + "'";

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

                    dgvBusqueda.DataSource = dt;
                    dgvBusqueda.Columns[0].Visible = false;
                    //dgvBusqueda.Columns["DESC_1"].Width = 250;
                }
                else
                {
                    MessageBox.Show("Formato Invalido");
                }
            }
            else
            {
                MessageBox.Show("Fechas Vacias");
            }
        }

        private void btExportar_Click(object sender, EventArgs e)
        {
            GlobalFunctions.ExportarDataGridViewCSV(dgvBusqueda, null);
        }

        private void dgvBusqueda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBusqueda.SelectedCells.Count == 1)
            {
                GlobalFunctions.generarPDF(dgvBusqueda.Rows[dgvBusqueda.SelectedCells[0].RowIndex].Cells[0].Value.ToString(), null);
            }
        }
    }
}
