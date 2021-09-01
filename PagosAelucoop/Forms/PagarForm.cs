using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PagosAelucoop.GlobalFunctions;

namespace PagosAelucoop.Forms
{
    public partial class PagarForm : Form
    {
        public PagarForm()
        {
            InitializeComponent();

            CheckBox chk = new CheckBox();
            chk.Text = "Carta Poder";
            chk.Checked = false;
            ManageCheckGroupBox(chk, gbCartaPoder);

            cmbFormaPago.Items.Clear();

            ComboboxItem item = new ComboboxItem();
            item.Value = 1;
            item.Text = "Efectivo";
            cmbFormaPago.Items.Add(item);
            //cmbFormaPago.Items.Add("Transferencia");
            cmbFormaPago.SelectedIndex = 0;

            //Llenar ComboBox con Entidades
            llenarCmb(cmbEntidad, "SELECT IDENTIDAD, NOMBRE FROM " + Globals.TablaEntidad + " WHERE ACTIVO = 1");
        }

        private void llenarCmb (ComboBox cb, string strSQL)
        {
            int i = 0, pos = 0;
            DataTable dt = new DataTable("ComboBox");

            try
            {
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

                cb.Items.Clear();

                ComboboxItem item;

                foreach (DataRow dr in dt.Rows)
                {
                    item = new ComboboxItem();
                    item.Value = dr[0];
                    item.Text = dr[1].ToString().Trim();

                    if (dr[0].ToString() == Globals.IdUserEntidad.ToString())
                    {
                        pos = i;
                    }

                    cb.Items.Add(item);
                    i++;
                }

                cb.SelectedIndex = pos;
            }
            catch (Exception ex)
            {
                GlobalFunctions.casoError(ex, strSQL);
                return;
            }
        }

        private void ManageCheckGroupBox(CheckBox chk, GroupBox grp)
        {
            // Make sure the CheckBox isn't in the GroupBox.
            // This will only happen the first time.
            if (chk.Parent == grp)
            {
                // Reparent the CheckBox so it's not in the GroupBox.
                grp.Parent.Controls.Add(chk);

                // Adjust the CheckBox's location.
                chk.Location = new Point(
                    chk.Left + grp.Left,
                    chk.Top + grp.Top);

                // Move the CheckBox to the top of the stacking order.
                chk.BringToFront();
            }

            // Enable or disable the GroupBox.
            grp.Enabled = chk.Checked;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            /*
            if (cmbTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Tipo Documento Invalido");
                return;
            }*/

            if (tbNroDocumento.Text == "")
            {
                lbError.Text = "Nro Documento Vacio";
                lbError.ForeColor = System.Drawing.Color.Red;
                lbError.Visible = true;
                //MessageBox.Show("Nro Documento Vacio");
                return;
            }

            DataTable dt = new DataTable("Password");

            String strSQL = "SELECT IDPAGO, CODIGO, NUMDOC, NOMBRECOMPLETO, IMPORTE, FECHAPAGO, PROCESADO FROM " + Globals.TablaPago + " WHERE NUMDOC = '" + tbNroDocumento.Text + "'";

            try
            {
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

            }
            catch (Exception ex)
            {
                GlobalFunctions.casoError(ex, strSQL);
                return;
            }

            if (dt.Rows.Count == 0)
            {
                limpiarForm();
                lbError.Text = "El documento de identidad no se encuentra en el listado enviado por la SBS";
                lbError.ForeColor = System.Drawing.Color.Red;
                lbError.Visible = true;
                //MessageBox.Show("El documento de identidad no se encuentra en el listado enviado por la SBS");
                return;
            }

            string idpago = dt.Rows[0]["IDPAGO"].ToString();

            if (dt.Rows.Count == 1)
            {
                DateTime fechapago = DateTime.Parse(dt.Rows[0]["FECHAPAGO"].ToString());

                lbIdPago.Text = idpago;
                tbCodigoSocio.Text = dt.Rows[0]["CODIGO"].ToString().Trim();
                tbImporte.Text = dt.Rows[0]["IMPORTE"].ToString();
                tbNombreSBS.Text = dt.Rows[0]["NOMBRECOMPLETO"].ToString().Trim();
                tbFechaPago.Text = fechapago.ToString("dd/MM/yyyy");

                if (dt.Rows[0]["PROCESADO"].ToString() == "1")
                {
                    dt = new DataTable("PROCESADO");

                    strSQL = "SELECT IDPROCESADO, IDPAGOFK, DIRECCION, EMAIL, TELEFONO1, TELEFONO2, FORMAPAGO, IDENTIDADFK, NUMCUENTA, CARTAPODER, PODERNUMDOC, PODERNOMBRE, FECHAPROCESO, IDUSERFK, TU.USERNAME FROM " + Globals.TablaProcesado + " TP LEFT JOIN " + Globals.TablaUsuario + " TU ON TP.IDUSERFK = TU.IDUSER WHERE TP.ACTIVO = 1 AND IDPAGOFK = " + idpago + "";

                    try
                    {
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

                        DateTime fechaproceso = DateTime.Parse(dt.Rows[0]["FECHAPROCESO"].ToString());
                        string fecha, hora, usuario;
                        fecha = fechaproceso.ToString("dd/MM/yyyy");
                        hora = fechaproceso.ToString("HH:mm:ss");
                        usuario = dt.Rows[0]["USERNAME"].ToString();

                        limpiarForm();
                        gbDatosSocioSBS.Visible = true;
                        lbError.Text = "Ya se realizó el pago al documento de identidad ingresado.\n" + "USUARIO: " + usuario + "\nFECHA: " + fecha + "\nHORA: " + hora;
                        lbError.ForeColor = System.Drawing.Color.Red;
                        lbError.Visible = true;
                        //MessageBox.Show("Ya se realizó el pago al documento de identidad ingresado.\n" + "USUARIO: " + usuario + "\nFECHA: " + fecha + "\nHORA: " + hora);
                        return;
                    }
                    catch (Exception ex)
                    {
                        GlobalFunctions.casoError(ex, strSQL);
                        return;
                    }
                }

                tbNroDocumento.Enabled = false;

                lbError.Visible = false;

                gbFormaPago.Visible = true;
                gbDatosSocio.Visible = true;
                gbDatosSocioSBS.Visible = true;
                //gbCartaPoder.Visible = true;

                ibCancelar.Visible = true;
                ibPagar.Visible = true;
            }
        }

        private void tbNroDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                btBuscar_Click(sender, e);
            }
        }

        private void limpiarForm()
        {
            gbFormaPago.Visible = false;
            gbDatosSocio.Visible = false;
            gbDatosSocioSBS.Visible = false;
            //gbCartaPoder.Visible = true;

            ibCancelar.Visible = false;
            ibPagar.Visible = false;

            lbIdPago.Text = "0";
            tbNroDocumento.Enabled = true;

            lbError.Text = "";
            lbError.Visible = false;
            lbError.ForeColor = System.Drawing.Color.Red;
        }

        private void ibPagar_Click(object sender, EventArgs e)
        {
            if (tbDireccion.Text == "")
            {
                MessageBox.Show("Dirección Vacia");
                return;
            }
            if (tbEmail.Text == "")
            {
                MessageBox.Show("Correo Vacio");
                return;
            }
            if (tbTelefono1.Text == "")
            {
                MessageBox.Show("Dirección Vacia");
                return;
            }
            if (tbNroCuenta.Text == "")
            {
                MessageBox.Show("Numero de Cuenta Vacio");
                return;
            }
            if (tbNombrePago.Text == "")
            {
                MessageBox.Show("Nombre Destino Vacio");
                return;
            }

            if (validarPagoPendiente(lbIdPago.Text) == 1)
            {
                string strSQL = "INSERT INTO " + Globals.TablaProcesado + " (IDPAGOFK, DIRECCION, EMAIL, TELEFONO1, TELEFONO2, FORMAPAGO, IDENTIDADFK, NUMCUENTA, NOMBREDESTINO, FECHAPROCESO, IDUSERFK, USERNAME, ACTIVO) ";
                strSQL += " VALUES ( " + lbIdPago.Text + ", ";
                strSQL += "'" + tbDireccion.Text + "', ";
                strSQL += "'" + tbEmail.Text + "', ";
                strSQL += "'" + tbTelefono1.Text + "', ";
                if (tbTelefono2.Text == "")
                {
                    strSQL += "NULL, ";
                }
                else
                {
                    strSQL += "'" + tbTelefono2.Text + "', ";
                }
                strSQL += "" + ((ComboboxItem)cmbFormaPago.SelectedItem).Value + ", ";
                strSQL += "" + ((ComboboxItem)cmbEntidad.SelectedItem).Value + ", ";
                strSQL += "'" + tbNroCuenta.Text + "', ";
                strSQL += "'" + tbNombrePago.Text.Replace("'", "''") + "', ";
                strSQL += "CAST('" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "' AS DATETIME), ";
                strSQL += "" + Globals.IdUsername + ", ";
                strSQL += "'" + Globals.Username + "', ";
                strSQL += "1)";

                try
                {
                    if (!Conexion.conectar())
                        return;
                    if (!Conexion.iniciaCommand(strSQL))
                        return;
                    if (!Conexion.ejecutarQuery())
                        return;
                    Conexion.cerrar();
                }
                catch (Exception ex)
                {
                    GlobalFunctions.casoError(ex, strSQL);
                    return;
                }

                strSQL = "UPDATE " + Globals.TablaPago + " SET PROCESADO = 1 WHERE IDPAGO = " + lbIdPago.Text;
                try
                {
                    if (!Conexion.conectar())
                        return;
                    if (!Conexion.iniciaCommand(strSQL))
                        return;
                    if (!Conexion.ejecutarQuery())
                        return;
                    Conexion.cerrar();
                }
                catch (Exception ex)
                {
                    GlobalFunctions.casoError(ex, strSQL);
                    return;
                }

                GlobalFunctions.generarPDF(lbIdPago.Text, null);

                limpiarForm();

                lbError.Text = "Pago Registrado";
                lbError.ForeColor = System.Drawing.Color.White;
                lbError.Visible = true;

                //MessageBox.Show("Pago Registrado");


            }
        }
        //0=Procesado 1=Pendiente 2=Error
        private int validarPagoPendiente(string idpago)
        {
            DataTable dt = new DataTable("Procesado");
            String strSQL = "SELECT IDPAGO, CODIGO, NUMDOC, NOMBRECOMPLETO, IMPORTE, FECHAPAGO, PROCESADO FROM " + Globals.TablaPago + " WHERE IDPAGO = " + idpago + "";
            try
            {
                if (!Conexion.conectar())
                    return 2;
                if (!Conexion.iniciaCommand(strSQL))
                    return 2;
                if (!Conexion.ejecutarQuery())
                    return 2;
                dt = Conexion.llenarDataTable();
                if (dt is null)
                    return 2;
                Conexion.cerrar();
            }
            catch (Exception ex)
            {
                GlobalFunctions.casoError(ex, strSQL);
                return 2;
            }

            if (dt.Rows[0]["PROCESADO"].ToString() == "1")
            {
                dt = new DataTable("PROCESADO");

                strSQL = "SELECT IDPROCESADO, IDPAGOFK, DIRECCION, EMAIL, TELEFONO1, TELEFONO2, FORMAPAGO, IDENTIDADFK, NUMCUENTA, CARTAPODER, PODERNUMDOC, PODERNOMBRE, FECHAPROCESO, IDUSERFK, TU.USERNAME FROM " + Globals.TablaProcesado + " TP LEFT JOIN " + Globals.TablaUsuario + " TU ON TP.IDUSERFK = TU.IDUSER WHERE TP.ACTIVO = 1 AND IDPAGOFK = " + idpago + "";

                try
                {
                    if (!Conexion.conectar())
                        return 2;
                    if (!Conexion.iniciaCommand(strSQL))
                        return 2;
                    if (!Conexion.ejecutarQuery())
                        return 2;
                    dt = Conexion.llenarDataTable();
                    if (dt is null)
                        return 2;
                    Conexion.cerrar();

                    DateTime fechaproceso = DateTime.Parse(dt.Rows[0]["FECHAPROCESO"].ToString());
                    string fecha, hora, usuario;
                    fecha = fechaproceso.ToString("dd/MM/yyyy");
                    hora = fechaproceso.ToString("HH:mm:ss");
                    usuario = dt.Rows[0]["USERNAME"].ToString();

                    limpiarForm();

                    lbError.Text = "Ya se realizó el pago al documento de identidad ingresado.\n" + "USUARIO: " + usuario + "\nFECHA: " + fecha + "\nHORA: " + hora;
                    lbError.ForeColor = System.Drawing.Color.Red;
                    lbError.Visible = true;
                    //MessageBox.Show("Ya se realizó el pago al documento de identidad ingresado.\n" + "USUARIO: " + usuario + "\nFECHA: " + fecha + "\nHORA: " + hora);
                    return 0;
                }
                catch (Exception ex)
                {
                    GlobalFunctions.casoError(ex, strSQL);
                    return 2;
                }
            }
            else
            {
                return 1;
            }
        }

        private void ibCancelar_Click(object sender, EventArgs e)
        {
            limpiarForm();
            //tbNroDocumento.Text = "";
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text != "")
            {
                if (!GlobalFunctions.IsValidEmail(tbEmail.Text))
                {
                    tbEmail.Focus();
                    MessageBox.Show(tbEmail.Text + " no es un correo electronico valido");
                }
            }
        }

        private void tbTelefono1_Leave(object sender, EventArgs e)
        {
            tbTelefono1.Text = tbTelefono1.Text.Trim();
            Regex ex = new Regex("^[0-9]+$");

            if (!ex.IsMatch(tbTelefono1.Text) && tbTelefono1.Text != "")
            {
                tbTelefono1.Focus();
                MessageBox.Show(tbTelefono1.Text + " no es un telefono valido");
            }
        }

        private void tbTelefono2_Leave(object sender, EventArgs e)
        {
            tbTelefono2.Text = tbTelefono2.Text.Trim();
            Regex ex = new Regex("^[0-9]+$");

            if (!ex.IsMatch(tbTelefono2.Text) && tbTelefono2.Text != "")
            {
                tbTelefono2.Focus();
                MessageBox.Show(tbTelefono2.Text + " no es un telefono valido");
            }
        }
    }

}
