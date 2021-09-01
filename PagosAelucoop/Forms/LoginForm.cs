using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PagosAelucoop.Forms;

namespace PagosAelucoop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            SimpleLog.SetLogFile(".\\Log", "MyLog_");

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Close-Maximize-Minimize
        private void btCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                entrar();
            }
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            entrar();
        }

        private void entrar()
        {
            //Validar Campos
            if (tbUsername.Text == "")
            {
                MessageBox.Show("Usuario vacio");
                return;
            }
            if (tbPassword.Text == "")
            {
                MessageBox.Show("Contraseña vacia");
                return;
            }
            //

            DataTable dt = new DataTable("Password");

            String strSQL = "SELECT IDUSER, PASSWORD, ENTIDAD FROM " + Globals.TablaUsuario + " WHERE USERNAME = '" + tbUsername.Text + "' AND ACTIVO = 1";

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
                MessageBox.Show("Usuario o Contraseña Errada");
                return;
            }

            if (dt.Rows[0]["PASSWORD"].ToString() != "")
            {
                if (dt.Rows[0]["PASSWORD"].ToString().Trim() == GlobalFunctions.sha256(tbPassword.Text).ToUpper())
                {
                    SimpleLog.Info(tbUsername.Text + " inicio Session Exitosamente");
                    this.Hide();

                    Globals.Username = tbUsername.Text;

                    try
                    {
                        Globals.IdUsername = Int32.Parse(dt.Rows[0]["IDUSER"].ToString());
                        Globals.IdUserEntidad = Int32.Parse(dt.Rows[0]["ENTIDAD"].ToString());
                    }
                    catch (Exception ex)
                    {
                        GlobalFunctions.casoError(ex, strSQL);
                        return;
                    }

                    MainForm mf = new MainForm();
                    //mf.Closed += (s, args) => this.Close();
                    mf.Show();

                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Errada");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Contraseña vacia en BD");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
