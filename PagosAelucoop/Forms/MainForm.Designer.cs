
namespace PagosAelucoop.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnLeft = new System.Windows.Forms.Panel();
            this.ibSalir = new FontAwesome.Sharp.IconButton();
            this.btReporte = new FontAwesome.Sharp.IconButton();
            this.btPagar = new FontAwesome.Sharp.IconButton();
            this.icMain = new FontAwesome.Sharp.IconPictureBox();
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbEstado = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btMinimizar = new FontAwesome.Sharp.IconButton();
            this.btMaximizar = new FontAwesome.Sharp.IconButton();
            this.btCerrar = new FontAwesome.Sharp.IconButton();
            this.pnMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icMain)).BeginInit();
            this.pnTop.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.Controls.Add(this.ibSalir);
            this.pnLeft.Controls.Add(this.btReporte);
            this.pnLeft.Controls.Add(this.btPagar);
            this.pnLeft.Controls.Add(this.icMain);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(200, 746);
            this.pnLeft.TabIndex = 0;
            this.pnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnLeft_MouseDown);
            // 
            // ibSalir
            // 
            this.ibSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ibSalir.FlatAppearance.BorderSize = 0;
            this.ibSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibSalir.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ibSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.ibSalir.IconColor = System.Drawing.Color.Gainsboro;
            this.ibSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibSalir.IconSize = 30;
            this.ibSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibSalir.Location = new System.Drawing.Point(0, 685);
            this.ibSalir.Name = "ibSalir";
            this.ibSalir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibSalir.Size = new System.Drawing.Size(200, 61);
            this.ibSalir.TabIndex = 5;
            this.ibSalir.Text = "  Salir";
            this.ibSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibSalir.UseVisualStyleBackColor = true;
            this.ibSalir.Click += new System.EventHandler(this.ibSalir_Click);
            // 
            // btReporte
            // 
            this.btReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.btReporte.FlatAppearance.BorderSize = 0;
            this.btReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReporte.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReporte.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btReporte.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.btReporte.IconColor = System.Drawing.Color.Gainsboro;
            this.btReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btReporte.IconSize = 30;
            this.btReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReporte.Location = new System.Drawing.Point(0, 131);
            this.btReporte.Name = "btReporte";
            this.btReporte.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btReporte.Size = new System.Drawing.Size(200, 61);
            this.btReporte.TabIndex = 4;
            this.btReporte.Text = "  Reporte";
            this.btReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btReporte.UseVisualStyleBackColor = true;
            this.btReporte.Click += new System.EventHandler(this.btReporte_Click);
            // 
            // btPagar
            // 
            this.btPagar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btPagar.FlatAppearance.BorderSize = 0;
            this.btPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPagar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPagar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btPagar.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWaveAlt;
            this.btPagar.IconColor = System.Drawing.Color.Gainsboro;
            this.btPagar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btPagar.IconSize = 30;
            this.btPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPagar.Location = new System.Drawing.Point(0, 70);
            this.btPagar.Name = "btPagar";
            this.btPagar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btPagar.Size = new System.Drawing.Size(200, 61);
            this.btPagar.TabIndex = 3;
            this.btPagar.Text = "  Pagar";
            this.btPagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPagar.UseVisualStyleBackColor = true;
            this.btPagar.Click += new System.EventHandler(this.btPagar_Click);
            // 
            // icMain
            // 
            this.icMain.BackColor = System.Drawing.Color.MidnightBlue;
            this.icMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("icMain.BackgroundImage")));
            this.icMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.icMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.icMain.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icMain.IconColor = System.Drawing.SystemColors.ControlText;
            this.icMain.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icMain.IconSize = 70;
            this.icMain.InitialImage = null;
            this.icMain.Location = new System.Drawing.Point(0, 0);
            this.icMain.Name = "icMain";
            this.icMain.Size = new System.Drawing.Size(200, 70);
            this.icMain.TabIndex = 0;
            this.icMain.TabStop = false;
            this.icMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.icMain_MouseDown);
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnTop.Controls.Add(this.lbEstado);
            this.pnTop.Controls.Add(this.panel2);
            this.pnTop.Controls.Add(this.lbUsuario);
            this.pnTop.Controls.Add(this.label1);
            this.pnTop.Controls.Add(this.btMinimizar);
            this.pnTop.Controls.Add(this.btMaximizar);
            this.pnTop.Controls.Add(this.btCerrar);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(5, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1129, 34);
            this.pnTop.TabIndex = 1;
            this.pnTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseDown);
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbEstado.Location = new System.Drawing.Point(9, 7);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(0, 18);
            this.lbEstado.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1129, 5);
            this.panel2.TabIndex = 8;
            // 
            // lbUsuario
            // 
            this.lbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbUsuario.Location = new System.Drawing.Point(902, 10);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(109, 13);
            this.lbUsuario.TabIndex = 7;
            this.lbUsuario.Text = "NOMBRE_USUARIO";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(850, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario:";
            // 
            // btMinimizar
            // 
            this.btMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimizar.FlatAppearance.BorderSize = 0;
            this.btMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btMinimizar.IconColor = System.Drawing.Color.White;
            this.btMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btMinimizar.IconSize = 24;
            this.btMinimizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMinimizar.Location = new System.Drawing.Point(1050, 0);
            this.btMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btMinimizar.Name = "btMinimizar";
            this.btMinimizar.Size = new System.Drawing.Size(26, 23);
            this.btMinimizar.TabIndex = 5;
            this.btMinimizar.UseVisualStyleBackColor = true;
            this.btMinimizar.Click += new System.EventHandler(this.btMinimizar_Click);
            // 
            // btMaximizar
            // 
            this.btMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMaximizar.FlatAppearance.BorderSize = 0;
            this.btMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btMaximizar.IconColor = System.Drawing.Color.White;
            this.btMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btMaximizar.IconSize = 24;
            this.btMaximizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMaximizar.Location = new System.Drawing.Point(1076, 0);
            this.btMaximizar.Margin = new System.Windows.Forms.Padding(0);
            this.btMaximizar.Name = "btMaximizar";
            this.btMaximizar.Size = new System.Drawing.Size(26, 23);
            this.btMaximizar.TabIndex = 4;
            this.btMaximizar.UseVisualStyleBackColor = true;
            this.btMaximizar.Click += new System.EventHandler(this.btMaximizar_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCerrar.FlatAppearance.BorderSize = 0;
            this.btCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btCerrar.IconColor = System.Drawing.Color.White;
            this.btCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btCerrar.IconSize = 24;
            this.btCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCerrar.Location = new System.Drawing.Point(1102, 0);
            this.btCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(26, 23);
            this.btCerrar.TabIndex = 3;
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.pnTop);
            this.pnMain.Controls.Add(this.panel1);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(200, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1134, 746);
            this.pnMain.TabIndex = 2;
            this.pnMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnMain_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 746);
            this.panel1.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1334, 746);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnLeft);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icMain)).EndInit();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.pnMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnMain;
        private FontAwesome.Sharp.IconPictureBox icMain;
        private FontAwesome.Sharp.IconButton btMinimizar;
        private FontAwesome.Sharp.IconButton btMaximizar;
        private FontAwesome.Sharp.IconButton btCerrar;
        private FontAwesome.Sharp.IconButton btReporte;
        private FontAwesome.Sharp.IconButton btPagar;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbEstado;
        private FontAwesome.Sharp.IconButton ibSalir;
    }
}