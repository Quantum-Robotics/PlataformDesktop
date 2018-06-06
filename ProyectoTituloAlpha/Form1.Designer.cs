namespace ProyectoTituloAlpha
{
    partial class MENU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MENU));
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.panelOther = new System.Windows.Forms.Panel();
            this.buttonExpand = new Bunifu.Framework.UI.BunifuImageButton();
            this.LogoBig = new System.Windows.Forms.PictureBox();
            this.buttonConnect = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonConfig = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonCode = new Bunifu.Framework.UI.BunifuFlatButton();
            this.header = new System.Windows.Forms.Panel();
            this.Label_Version = new MetroFramework.Controls.MetroLabel();
            this.buttonMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.buttonClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.menuTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.InterfaceConfig = new ProyectoTituloAlpha.Config();
            this.InterfaceConnect = new ProyectoTituloAlpha.Connect();
            this.InterfaceCode = new ProyectoTituloAlpha.Code();
            this.logoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelOptions.SuspendLayout();
            this.panelOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExpand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBig)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOptions
            // 
            this.panelOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelOptions.Controls.Add(this.panelOther);
            this.panelOptions.Controls.Add(this.buttonConnect);
            this.panelOptions.Controls.Add(this.buttonConfig);
            this.panelOptions.Controls.Add(this.buttonCode);
            this.logoTransition.SetDecoration(this.panelOptions, BunifuAnimatorNS.DecorationType.None);
            this.menuTransition.SetDecoration(this.panelOptions, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.panelOptions, "panelOptions");
            this.panelOptions.Name = "panelOptions";
            // 
            // panelOther
            // 
            this.panelOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.panelOther.Controls.Add(this.buttonExpand);
            this.panelOther.Controls.Add(this.LogoBig);
            this.logoTransition.SetDecoration(this.panelOther, BunifuAnimatorNS.DecorationType.None);
            this.menuTransition.SetDecoration(this.panelOther, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.panelOther, "panelOther");
            this.panelOther.Name = "panelOther";
            // 
            // buttonExpand
            // 
            this.buttonExpand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.logoTransition.SetDecoration(this.buttonExpand, BunifuAnimatorNS.DecorationType.None);
            this.menuTransition.SetDecoration(this.buttonExpand, BunifuAnimatorNS.DecorationType.None);
            this.buttonExpand.Image = global::ProyectoTituloAlpha.Properties.Resources.Menu_32_Whitepx;
            this.buttonExpand.ImageActive = null;
            resources.ApplyResources(this.buttonExpand, "buttonExpand");
            this.buttonExpand.Name = "buttonExpand";
            this.buttonExpand.TabStop = false;
            this.buttonExpand.Zoom = 20;
            this.buttonExpand.Click += new System.EventHandler(this.buttonExpand_Click);
            // 
            // LogoBig
            // 
            this.LogoBig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.menuTransition.SetDecoration(this.LogoBig, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.LogoBig, BunifuAnimatorNS.DecorationType.None);
            this.LogoBig.Image = global::ProyectoTituloAlpha.Properties.Resources.QUANTUM_ROBOTICS;
            resources.ApplyResources(this.LogoBig, "LogoBig");
            this.LogoBig.Name = "LogoBig";
            this.LogoBig.TabStop = false;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(70)))));
            this.buttonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            resources.ApplyResources(this.buttonConnect, "buttonConnect");
            this.buttonConnect.BorderRadius = 0;
            this.buttonConnect.ButtonText = "Conexiones";
            this.buttonConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoTransition.SetDecoration(this.buttonConnect, BunifuAnimatorNS.DecorationType.None);
            this.menuTransition.SetDecoration(this.buttonConnect, BunifuAnimatorNS.DecorationType.None);
            this.buttonConnect.DisabledColor = System.Drawing.Color.Gray;
            this.buttonConnect.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonConnect.Iconimage = global::ProyectoTituloAlpha.Properties.Resources.Connect_32_Whitepx;
            this.buttonConnect.Iconimage_right = null;
            this.buttonConnect.Iconimage_right_Selected = null;
            this.buttonConnect.Iconimage_Selected = null;
            this.buttonConnect.IconMarginLeft = 0;
            this.buttonConnect.IconMarginRight = 0;
            this.buttonConnect.IconRightVisible = true;
            this.buttonConnect.IconRightZoom = 0D;
            this.buttonConnect.IconVisible = true;
            this.buttonConnect.IconZoom = 70D;
            this.buttonConnect.IsTab = false;
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonConnect.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.buttonConnect.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonConnect.selected = false;
            this.buttonConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonConnect.Textcolor = System.Drawing.Color.White;
            this.buttonConnect.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonConfig
            // 
            this.buttonConfig.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(70)))));
            this.buttonConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            resources.ApplyResources(this.buttonConfig, "buttonConfig");
            this.buttonConfig.BorderRadius = 0;
            this.buttonConfig.ButtonText = "Configuracion";
            this.buttonConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoTransition.SetDecoration(this.buttonConfig, BunifuAnimatorNS.DecorationType.None);
            this.menuTransition.SetDecoration(this.buttonConfig, BunifuAnimatorNS.DecorationType.None);
            this.buttonConfig.DisabledColor = System.Drawing.Color.Gray;
            this.buttonConfig.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonConfig.Iconimage = global::ProyectoTituloAlpha.Properties.Resources.Settings_32_Whitepx;
            this.buttonConfig.Iconimage_right = null;
            this.buttonConfig.Iconimage_right_Selected = null;
            this.buttonConfig.Iconimage_Selected = null;
            this.buttonConfig.IconMarginLeft = 0;
            this.buttonConfig.IconMarginRight = 0;
            this.buttonConfig.IconRightVisible = true;
            this.buttonConfig.IconRightZoom = 0D;
            this.buttonConfig.IconVisible = true;
            this.buttonConfig.IconZoom = 70D;
            this.buttonConfig.IsTab = false;
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonConfig.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.buttonConfig.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonConfig.selected = false;
            this.buttonConfig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonConfig.Textcolor = System.Drawing.Color.White;
            this.buttonConfig.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfig.Click += new System.EventHandler(this.buttonConfig_Click);
            // 
            // buttonCode
            // 
            this.buttonCode.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(70)))));
            this.buttonCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            resources.ApplyResources(this.buttonCode, "buttonCode");
            this.buttonCode.BorderRadius = 0;
            this.buttonCode.ButtonText = "Codigo";
            this.buttonCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoTransition.SetDecoration(this.buttonCode, BunifuAnimatorNS.DecorationType.None);
            this.menuTransition.SetDecoration(this.buttonCode, BunifuAnimatorNS.DecorationType.None);
            this.buttonCode.DisabledColor = System.Drawing.Color.Gray;
            this.buttonCode.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonCode.Iconimage = global::ProyectoTituloAlpha.Properties.Resources.Code_32_Whitepx;
            this.buttonCode.Iconimage_right = null;
            this.buttonCode.Iconimage_right_Selected = null;
            this.buttonCode.Iconimage_Selected = null;
            this.buttonCode.IconMarginLeft = 0;
            this.buttonCode.IconMarginRight = 0;
            this.buttonCode.IconRightVisible = true;
            this.buttonCode.IconRightZoom = 0D;
            this.buttonCode.IconVisible = true;
            this.buttonCode.IconZoom = 70D;
            this.buttonCode.IsTab = false;
            this.buttonCode.Name = "buttonCode";
            this.buttonCode.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonCode.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.buttonCode.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonCode.selected = false;
            this.buttonCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonCode.Textcolor = System.Drawing.Color.White;
            this.buttonCode.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCode.Click += new System.EventHandler(this.buttonCode_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.header.Controls.Add(this.Label_Version);
            this.header.Controls.Add(this.buttonMinimize);
            this.header.Controls.Add(this.buttonClose);
            this.logoTransition.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.menuTransition.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.header, "header");
            this.header.Name = "header";
            // 
            // Label_Version
            // 
            resources.ApplyResources(this.Label_Version, "Label_Version");
            this.Label_Version.CustomBackground = true;
            this.Label_Version.CustomForeColor = true;
            this.logoTransition.SetDecoration(this.Label_Version, BunifuAnimatorNS.DecorationType.None);
            this.menuTransition.SetDecoration(this.Label_Version, BunifuAnimatorNS.DecorationType.None);
            this.Label_Version.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Label_Version.ForeColor = System.Drawing.Color.White;
            this.Label_Version.Name = "Label_Version";
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoTransition.SetDecoration(this.buttonMinimize, BunifuAnimatorNS.DecorationType.None);
            this.menuTransition.SetDecoration(this.buttonMinimize, BunifuAnimatorNS.DecorationType.None);
            this.buttonMinimize.Image = global::ProyectoTituloAlpha.Properties.Resources.Minus_32_Whitepx;
            this.buttonMinimize.ImageActive = null;
            resources.ApplyResources(this.buttonMinimize, "buttonMinimize");
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.TabStop = false;
            this.buttonMinimize.Zoom = 20;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoTransition.SetDecoration(this.buttonClose, BunifuAnimatorNS.DecorationType.None);
            this.menuTransition.SetDecoration(this.buttonClose, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.buttonClose, "buttonClose");
            this.buttonClose.ImageActive = null;
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.TabStop = false;
            this.buttonClose.Zoom = 20;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // menuTransition
            // 
            this.menuTransition.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.menuTransition.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 1F;
            this.menuTransition.DefaultAnimation = animation4;
            // 
            // InterfaceConfig
            // 
            this.InterfaceConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.menuTransition.SetDecoration(this.InterfaceConfig, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.InterfaceConfig, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.InterfaceConfig, "InterfaceConfig");
            this.InterfaceConfig.Name = "InterfaceConfig";
            // 
            // InterfaceConnect
            // 
            this.InterfaceConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.menuTransition.SetDecoration(this.InterfaceConnect, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.InterfaceConnect, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.InterfaceConnect, "InterfaceConnect");
            this.InterfaceConnect.Name = "InterfaceConnect";
            // 
            // InterfaceCode
            // 
            this.InterfaceCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.menuTransition.SetDecoration(this.InterfaceCode, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.InterfaceCode, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.InterfaceCode, "InterfaceCode");
            this.InterfaceCode.Name = "InterfaceCode";
            // 
            // logoTransition
            // 
            this.logoTransition.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.logoTransition.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 1F;
            this.logoTransition.DefaultAnimation = animation3;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = null;
            this.bunifuDragControl2.Vertical = true;
            // 
            // MENU
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.panelOptions);
            this.Controls.Add(this.InterfaceCode);
            this.Controls.Add(this.InterfaceConnect);
            this.Controls.Add(this.InterfaceConfig);
            this.Controls.Add(this.header);
            this.menuTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MENU";
            this.Load += new System.EventHandler(this.MENU_Load);
            this.panelOptions.ResumeLayout(false);
            this.panelOther.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonExpand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBig)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton buttonClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton buttonConnect;
        private Bunifu.Framework.UI.BunifuFlatButton buttonConfig;
        private Bunifu.Framework.UI.BunifuFlatButton buttonCode;
        private BunifuAnimatorNS.BunifuTransition menuTransition;
        private Bunifu.Framework.UI.BunifuImageButton buttonMinimize;
        private BunifuAnimatorNS.BunifuTransition logoTransition;
        private System.Windows.Forms.Panel panelOther;
        private Bunifu.Framework.UI.BunifuImageButton buttonExpand;
        private System.Windows.Forms.PictureBox LogoBig;
        private MetroFramework.Controls.MetroLabel Label_Version;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Config InterfaceConfig;
        private Connect InterfaceConnect;
        private Code InterfaceCode;
    }
}

