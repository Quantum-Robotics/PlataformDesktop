namespace ProyectoTituloAlpha
{
    partial class Connect
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connect));
            this.serialPorts = new System.IO.Ports.SerialPort(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.boxPort = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new Bunifu.Framework.UI.BunifuFlatButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textStatus = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.boxSpeed = new System.Windows.Forms.ComboBox();
            this.panelConnect = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panelConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(320, 32);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Conectar";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(24, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 242);
            this.panel1.TabIndex = 18;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.CustomForeColor = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(320, 150);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(96, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Programar";
            // 
            // boxPort
            // 
            this.boxPort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boxPort.Font = new System.Drawing.Font("Helvetica LT Std Fractions", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPort.FormattingEnabled = true;
            this.boxPort.Location = new System.Drawing.Point(79, 13);
            this.boxPort.Name = "boxPort";
            this.boxPort.Size = new System.Drawing.Size(121, 21);
            this.boxPort.TabIndex = 3;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.buttonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.buttonConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonConnect.BorderRadius = 0;
            this.buttonConnect.ButtonText = "Conectar";
            this.buttonConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConnect.DisabledColor = System.Drawing.Color.Gray;
            this.buttonConnect.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonConnect.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonConnect.Iconimage")));
            this.buttonConnect.Iconimage_right = null;
            this.buttonConnect.Iconimage_right_Selected = null;
            this.buttonConnect.Iconimage_Selected = null;
            this.buttonConnect.IconMarginLeft = 0;
            this.buttonConnect.IconMarginRight = 0;
            this.buttonConnect.IconRightVisible = true;
            this.buttonConnect.IconRightZoom = 0D;
            this.buttonConnect.IconVisible = true;
            this.buttonConnect.IconZoom = 80D;
            this.buttonConnect.IsTab = false;
            this.buttonConnect.Location = new System.Drawing.Point(220, 7);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.buttonConnect.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.buttonConnect.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonConnect.selected = false;
            this.buttonConnect.Size = new System.Drawing.Size(123, 25);
            this.buttonConnect.TabIndex = 5;
            this.buttonConnect.Text = "Conectar";
            this.buttonConnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConnect.Textcolor = System.Drawing.Color.White;
            this.buttonConnect.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(21, 15);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Puerto:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textStatus
            // 
            this.textStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textStatus.Enabled = false;
            this.textStatus.Font = new System.Drawing.Font("Helvetica LT Std Fractions", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStatus.ForeColor = System.Drawing.Color.White;
            this.textStatus.HintForeColor = System.Drawing.Color.Empty;
            this.textStatus.HintText = "";
            this.textStatus.isPassword = false;
            this.textStatus.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.textStatus.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.textStatus.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.textStatus.LineThickness = 5;
            this.textStatus.Location = new System.Drawing.Point(220, 36);
            this.textStatus.Margin = new System.Windows.Forms.Padding(4);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(123, 30);
            this.textStatus.TabIndex = 7;
            this.textStatus.Text = "Desconectado";
            this.textStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.CustomBackground = true;
            this.metroLabel11.CustomForeColor = true;
            this.metroLabel11.ForeColor = System.Drawing.Color.White;
            this.metroLabel11.Location = new System.Drawing.Point(7, 44);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(69, 19);
            this.metroLabel11.TabIndex = 15;
            this.metroLabel11.Text = "Velocidad:";
            // 
            // boxSpeed
            // 
            this.boxSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boxSpeed.Font = new System.Drawing.Font("Helvetica LT Std Fractions", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxSpeed.FormattingEnabled = true;
            this.boxSpeed.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.boxSpeed.Location = new System.Drawing.Point(79, 40);
            this.boxSpeed.Name = "boxSpeed";
            this.boxSpeed.Size = new System.Drawing.Size(121, 23);
            this.boxSpeed.TabIndex = 17;
            // 
            // panelConnect
            // 
            this.panelConnect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConnect.Controls.Add(this.boxSpeed);
            this.panelConnect.Controls.Add(this.metroLabel11);
            this.panelConnect.Controls.Add(this.textStatus);
            this.panelConnect.Controls.Add(this.metroLabel2);
            this.panelConnect.Controls.Add(this.buttonConnect);
            this.panelConnect.Controls.Add(this.boxPort);
            this.panelConnect.Location = new System.Drawing.Point(24, 60);
            this.panelConnect.Name = "panelConnect";
            this.panelConnect.Size = new System.Drawing.Size(687, 78);
            this.panelConnect.TabIndex = 4;
            // 
            // Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.panelConnect);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Connect";
            this.Size = new System.Drawing.Size(741, 441);
            this.Load += new System.EventHandler(this.Connect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panelConnect.ResumeLayout(false);
            this.panelConnect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPorts;
        private System.Windows.Forms.BindingSource bindingSource1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ComboBox boxPort;
        private Bunifu.Framework.UI.BunifuFlatButton buttonConnect;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textStatus;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.ComboBox boxSpeed;
        private System.Windows.Forms.Panel panelConnect;
    }
}
