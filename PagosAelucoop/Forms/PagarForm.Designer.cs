
namespace PagosAelucoop.Forms
{
    partial class PagarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.tbNroDocumento = new System.Windows.Forms.TextBox();
            this.gbDatosSocioSBS = new System.Windows.Forms.GroupBox();
            this.lbIdPago = new System.Windows.Forms.Label();
            this.tbFechaPago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbImporte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNombreSBS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCodigoSocio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbDatosSocio = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTelefono2 = new System.Windows.Forms.TextBox();
            this.tbTelefono1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbFormaPago = new System.Windows.Forms.GroupBox();
            this.cmbEntidad = new System.Windows.Forms.ComboBox();
            this.cmbFormaPago = new System.Windows.Forms.ComboBox();
            this.tbNombrePago = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbNroCuenta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbPoderNombre = new System.Windows.Forms.TextBox();
            this.cmbPoderTipoDocumento = new System.Windows.Forms.ComboBox();
            this.gbCartaPoder = new System.Windows.Forms.GroupBox();
            this.lbError = new System.Windows.Forms.Label();
            this.ibCancelar = new FontAwesome.Sharp.IconButton();
            this.ibPagar = new FontAwesome.Sharp.IconButton();
            this.btBuscar = new FontAwesome.Sharp.IconButton();
            this.gbDatosSocioSBS.SuspendLayout();
            this.gbDatosSocio.SuspendLayout();
            this.gbFormaPago.SuspendLayout();
            this.gbCartaPoder.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(42, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nro. Documento:";
            // 
            // tbNroDocumento
            // 
            this.tbNroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNroDocumento.Location = new System.Drawing.Point(203, 62);
            this.tbNroDocumento.Name = "tbNroDocumento";
            this.tbNroDocumento.Size = new System.Drawing.Size(166, 24);
            this.tbNroDocumento.TabIndex = 17;
            this.tbNroDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNroDocumento_KeyDown);
            // 
            // gbDatosSocioSBS
            // 
            this.gbDatosSocioSBS.Controls.Add(this.lbIdPago);
            this.gbDatosSocioSBS.Controls.Add(this.tbFechaPago);
            this.gbDatosSocioSBS.Controls.Add(this.label1);
            this.gbDatosSocioSBS.Controls.Add(this.tbImporte);
            this.gbDatosSocioSBS.Controls.Add(this.label5);
            this.gbDatosSocioSBS.Controls.Add(this.tbNombreSBS);
            this.gbDatosSocioSBS.Controls.Add(this.label4);
            this.gbDatosSocioSBS.Controls.Add(this.tbCodigoSocio);
            this.gbDatosSocioSBS.Controls.Add(this.label3);
            this.gbDatosSocioSBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosSocioSBS.ForeColor = System.Drawing.Color.Lime;
            this.gbDatosSocioSBS.Location = new System.Drawing.Point(478, 13);
            this.gbDatosSocioSBS.Name = "gbDatosSocioSBS";
            this.gbDatosSocioSBS.Size = new System.Drawing.Size(621, 120);
            this.gbDatosSocioSBS.TabIndex = 19;
            this.gbDatosSocioSBS.TabStop = false;
            this.gbDatosSocioSBS.Text = "Datos del Socio Aelucoop (Según Estado SBS)";
            this.gbDatosSocioSBS.Visible = false;
            // 
            // lbIdPago
            // 
            this.lbIdPago.AutoSize = true;
            this.lbIdPago.Location = new System.Drawing.Point(327, 85);
            this.lbIdPago.Name = "lbIdPago";
            this.lbIdPago.Size = new System.Drawing.Size(17, 18);
            this.lbIdPago.TabIndex = 27;
            this.lbIdPago.Text = "0";
            this.lbIdPago.Visible = false;
            // 
            // tbFechaPago
            // 
            this.tbFechaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFechaPago.Location = new System.Drawing.Point(153, 84);
            this.tbFechaPago.Name = "tbFechaPago";
            this.tbFechaPago.ReadOnly = true;
            this.tbFechaPago.Size = new System.Drawing.Size(118, 22);
            this.tbFechaPago.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(15, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Fecha Pago:";
            // 
            // tbImporte
            // 
            this.tbImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbImporte.Location = new System.Drawing.Point(466, 23);
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.ReadOnly = true;
            this.tbImporte.Size = new System.Drawing.Size(118, 22);
            this.tbImporte.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(339, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Importe a Pagar S/.";
            // 
            // tbNombreSBS
            // 
            this.tbNombreSBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreSBS.Location = new System.Drawing.Point(153, 56);
            this.tbNombreSBS.Name = "tbNombreSBS";
            this.tbNombreSBS.ReadOnly = true;
            this.tbNombreSBS.Size = new System.Drawing.Size(431, 22);
            this.tbNombreSBS.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(15, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Apellidos y Nombres:";
            // 
            // tbCodigoSocio
            // 
            this.tbCodigoSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoSocio.Location = new System.Drawing.Point(153, 28);
            this.tbCodigoSocio.Name = "tbCodigoSocio";
            this.tbCodigoSocio.ReadOnly = true;
            this.tbCodigoSocio.Size = new System.Drawing.Size(118, 22);
            this.tbCodigoSocio.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(15, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Código de Socio:";
            // 
            // gbDatosSocio
            // 
            this.gbDatosSocio.Controls.Add(this.label9);
            this.gbDatosSocio.Controls.Add(this.tbTelefono2);
            this.gbDatosSocio.Controls.Add(this.tbTelefono1);
            this.gbDatosSocio.Controls.Add(this.label6);
            this.gbDatosSocio.Controls.Add(this.tbEmail);
            this.gbDatosSocio.Controls.Add(this.label7);
            this.gbDatosSocio.Controls.Add(this.tbDireccion);
            this.gbDatosSocio.Controls.Add(this.label8);
            this.gbDatosSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosSocio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbDatosSocio.Location = new System.Drawing.Point(260, 186);
            this.gbDatosSocio.Name = "gbDatosSocio";
            this.gbDatosSocio.Size = new System.Drawing.Size(621, 118);
            this.gbDatosSocio.TabIndex = 25;
            this.gbDatosSocio.TabStop = false;
            this.gbDatosSocio.Text = "Datos del Socio";
            this.gbDatosSocio.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(261, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "/";
            // 
            // tbTelefono2
            // 
            this.tbTelefono2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono2.Location = new System.Drawing.Point(291, 84);
            this.tbTelefono2.Name = "tbTelefono2";
            this.tbTelefono2.Size = new System.Drawing.Size(150, 22);
            this.tbTelefono2.TabIndex = 25;
            this.tbTelefono2.Leave += new System.EventHandler(this.tbTelefono2_Leave);
            // 
            // tbTelefono1
            // 
            this.tbTelefono1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono1.Location = new System.Drawing.Point(96, 84);
            this.tbTelefono1.Name = "tbTelefono1";
            this.tbTelefono1.Size = new System.Drawing.Size(150, 22);
            this.tbTelefono1.TabIndex = 23;
            this.tbTelefono1.Leave += new System.EventHandler(this.tbTelefono1_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(15, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Teléfonos:";
            // 
            // tbEmail
            // 
            this.tbEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(153, 56);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(427, 22);
            this.tbEmail.TabIndex = 21;
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(15, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Correo Electrónico:";
            // 
            // tbDireccion
            // 
            this.tbDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDireccion.Location = new System.Drawing.Point(87, 28);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(493, 22);
            this.tbDireccion.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(15, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Dirección:";
            // 
            // gbFormaPago
            // 
            this.gbFormaPago.Controls.Add(this.cmbEntidad);
            this.gbFormaPago.Controls.Add(this.cmbFormaPago);
            this.gbFormaPago.Controls.Add(this.tbNombrePago);
            this.gbFormaPago.Controls.Add(this.label11);
            this.gbFormaPago.Controls.Add(this.tbNroCuenta);
            this.gbFormaPago.Controls.Add(this.label12);
            this.gbFormaPago.Controls.Add(this.label13);
            this.gbFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFormaPago.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbFormaPago.Location = new System.Drawing.Point(260, 324);
            this.gbFormaPago.Name = "gbFormaPago";
            this.gbFormaPago.Size = new System.Drawing.Size(621, 151);
            this.gbFormaPago.TabIndex = 27;
            this.gbFormaPago.TabStop = false;
            this.gbFormaPago.Text = "Forma de Pago";
            this.gbFormaPago.Visible = false;
            // 
            // cmbEntidad
            // 
            this.cmbEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEntidad.FormattingEnabled = true;
            this.cmbEntidad.Location = new System.Drawing.Point(157, 57);
            this.cmbEntidad.Name = "cmbEntidad";
            this.cmbEntidad.Size = new System.Drawing.Size(322, 24);
            this.cmbEntidad.TabIndex = 28;
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormaPago.FormattingEnabled = true;
            this.cmbFormaPago.Location = new System.Drawing.Point(18, 24);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(240, 24);
            this.cmbFormaPago.TabIndex = 27;
            // 
            // tbNombrePago
            // 
            this.tbNombrePago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombrePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombrePago.Location = new System.Drawing.Point(157, 113);
            this.tbNombrePago.Name = "tbNombrePago";
            this.tbNombrePago.Size = new System.Drawing.Size(427, 22);
            this.tbNombrePago.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(15, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Apellidos y Nombres:";
            // 
            // tbNroCuenta
            // 
            this.tbNroCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNroCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNroCuenta.Location = new System.Drawing.Point(157, 85);
            this.tbNroCuenta.Name = "tbNroCuenta";
            this.tbNroCuenta.Size = new System.Drawing.Size(427, 22);
            this.tbNroCuenta.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(15, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Numero de Cuenta:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(15, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "Cooperativa / Banco:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(2, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1107, 4);
            this.panel2.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(15, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 16);
            this.label16.TabIndex = 20;
            this.label16.Text = "Tipo Documento:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(15, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 16);
            this.label15.TabIndex = 22;
            this.label15.Text = "Apellidos y Nombres:";
            // 
            // tbPoderNombre
            // 
            this.tbPoderNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPoderNombre.Location = new System.Drawing.Point(153, 56);
            this.tbPoderNombre.Name = "tbPoderNombre";
            this.tbPoderNombre.Size = new System.Drawing.Size(427, 22);
            this.tbPoderNombre.TabIndex = 21;
            // 
            // cmbPoderTipoDocumento
            // 
            this.cmbPoderTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPoderTipoDocumento.FormattingEnabled = true;
            this.cmbPoderTipoDocumento.Location = new System.Drawing.Point(127, 26);
            this.cmbPoderTipoDocumento.Name = "cmbPoderTipoDocumento";
            this.cmbPoderTipoDocumento.Size = new System.Drawing.Size(240, 24);
            this.cmbPoderTipoDocumento.TabIndex = 29;
            // 
            // gbCartaPoder
            // 
            this.gbCartaPoder.Controls.Add(this.cmbPoderTipoDocumento);
            this.gbCartaPoder.Controls.Add(this.tbPoderNombre);
            this.gbCartaPoder.Controls.Add(this.label15);
            this.gbCartaPoder.Controls.Add(this.label16);
            this.gbCartaPoder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCartaPoder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbCartaPoder.Location = new System.Drawing.Point(877, 491);
            this.gbCartaPoder.Name = "gbCartaPoder";
            this.gbCartaPoder.Size = new System.Drawing.Size(621, 91);
            this.gbCartaPoder.TabIndex = 27;
            this.gbCartaPoder.TabStop = false;
            this.gbCartaPoder.Visible = false;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(41, 186);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(33, 25);
            this.lbError.TabIndex = 33;
            this.lbError.Text = "---";
            this.lbError.Visible = false;
            // 
            // ibCancelar
            // 
            this.ibCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibCancelar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibCancelar.ForeColor = System.Drawing.Color.Red;
            this.ibCancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.ibCancelar.IconColor = System.Drawing.Color.Red;
            this.ibCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibCancelar.IconSize = 30;
            this.ibCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibCancelar.Location = new System.Drawing.Point(347, 511);
            this.ibCancelar.Name = "ibCancelar";
            this.ibCancelar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibCancelar.Size = new System.Drawing.Size(200, 61);
            this.ibCancelar.TabIndex = 31;
            this.ibCancelar.Text = "  Cancelar";
            this.ibCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibCancelar.UseVisualStyleBackColor = true;
            this.ibCancelar.Visible = false;
            this.ibCancelar.Click += new System.EventHandler(this.ibCancelar_Click);
            // 
            // ibPagar
            // 
            this.ibPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibPagar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibPagar.ForeColor = System.Drawing.Color.Lime;
            this.ibPagar.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight;
            this.ibPagar.IconColor = System.Drawing.Color.Lime;
            this.ibPagar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibPagar.IconSize = 30;
            this.ibPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibPagar.Location = new System.Drawing.Point(599, 511);
            this.ibPagar.Name = "ibPagar";
            this.ibPagar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibPagar.Size = new System.Drawing.Size(200, 61);
            this.ibPagar.TabIndex = 30;
            this.ibPagar.Text = "  Pagar";
            this.ibPagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibPagar.UseVisualStyleBackColor = true;
            this.ibPagar.Visible = false;
            this.ibPagar.Click += new System.EventHandler(this.ibPagar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btBuscar.IconColor = System.Drawing.Color.Gainsboro;
            this.btBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btBuscar.IconSize = 30;
            this.btBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btBuscar.Location = new System.Drawing.Point(383, 56);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(48, 38);
            this.btBuscar.TabIndex = 6;
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // PagarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1111, 605);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ibCancelar);
            this.Controls.Add(this.ibPagar);
            this.Controls.Add(this.gbCartaPoder);
            this.Controls.Add(this.gbFormaPago);
            this.Controls.Add(this.gbDatosSocio);
            this.Controls.Add(this.gbDatosSocioSBS);
            this.Controls.Add(this.tbNroDocumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btBuscar);
            this.Name = "PagarForm";
            this.Text = "PagarForm";
            this.gbDatosSocioSBS.ResumeLayout(false);
            this.gbDatosSocioSBS.PerformLayout();
            this.gbDatosSocio.ResumeLayout(false);
            this.gbDatosSocio.PerformLayout();
            this.gbFormaPago.ResumeLayout(false);
            this.gbFormaPago.PerformLayout();
            this.gbCartaPoder.ResumeLayout(false);
            this.gbCartaPoder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNroDocumento;
        private System.Windows.Forms.GroupBox gbDatosSocioSBS;
        private System.Windows.Forms.TextBox tbImporte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNombreSBS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCodigoSocio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbDatosSocio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTelefono2;
        private System.Windows.Forms.TextBox tbTelefono1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbFormaPago;
        private System.Windows.Forms.ComboBox cmbEntidad;
        private System.Windows.Forms.ComboBox cmbFormaPago;
        private System.Windows.Forms.TextBox tbNombrePago;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbNroCuenta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private FontAwesome.Sharp.IconButton ibPagar;
        private FontAwesome.Sharp.IconButton ibCancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbFechaPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbPoderNombre;
        private System.Windows.Forms.ComboBox cmbPoderTipoDocumento;
        private System.Windows.Forms.GroupBox gbCartaPoder;
        private System.Windows.Forms.Label lbIdPago;
        private System.Windows.Forms.Label lbError;
    }
}