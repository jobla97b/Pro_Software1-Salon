namespace Presentacion
{
    partial class Citas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Citas));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.pCerrar = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pDays = new System.Windows.Forms.PictureBox();
            this.pAgendar = new System.Windows.Forms.PictureBox();
            this.pToday = new System.Windows.Forms.PictureBox();
            this.pMonth = new System.Windows.Forms.PictureBox();
            this.pIcono = new System.Windows.Forms.PictureBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCerrar)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAgendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pToday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIcono)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.panelTitulo.Controls.Add(this.pCerrar);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(950, 30);
            this.panelTitulo.TabIndex = 0;
            // 
            // pCerrar
            // 
            this.pCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pCerrar.BackColor = System.Drawing.Color.Transparent;
            this.pCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pCerrar.Image = global::Presentacion.Properties.Resources._031_cancelar;
            this.pCerrar.Location = new System.Drawing.Point(922, 2);
            this.pCerrar.Name = "pCerrar";
            this.pCerrar.Size = new System.Drawing.Size(25, 25);
            this.pCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pCerrar.TabIndex = 0;
            this.pCerrar.TabStop = false;
            this.pCerrar.Click += new System.EventHandler(this.pCerrar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.pDays);
            this.panelMenu.Controls.Add(this.pAgendar);
            this.panelMenu.Controls.Add(this.pToday);
            this.panelMenu.Controls.Add(this.pMonth);
            this.panelMenu.Controls.Add(this.pIcono);
            this.panelMenu.Controls.Add(this.shapeContainer2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 30);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(950, 54);
            this.panelMenu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.label1.Location = new System.Drawing.Point(57, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Citas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pDays
            // 
            this.pDays.BackColor = System.Drawing.Color.White;
            this.pDays.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pDays.Image = ((System.Drawing.Image)(resources.GetObject("pDays.Image")));
            this.pDays.Location = new System.Drawing.Point(363, 2);
            this.pDays.Name = "pDays";
            this.pDays.Size = new System.Drawing.Size(48, 50);
            this.pDays.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pDays.TabIndex = 1;
            this.pDays.TabStop = false;
            this.toolTip1.SetToolTip(this.pDays, "Dias del Mes");
            this.pDays.Click += new System.EventHandler(this.pDays_Click);
            // 
            // pAgendar
            // 
            this.pAgendar.BackColor = System.Drawing.Color.White;
            this.pAgendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pAgendar.Image = global::Presentacion.Properties.Resources.Agendar;
            this.pAgendar.Location = new System.Drawing.Point(294, 2);
            this.pAgendar.Name = "pAgendar";
            this.pAgendar.Size = new System.Drawing.Size(48, 50);
            this.pAgendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pAgendar.TabIndex = 4;
            this.pAgendar.TabStop = false;
            this.toolTip1.SetToolTip(this.pAgendar, "Agendar Cita");
            this.pAgendar.Click += new System.EventHandler(this.pAgendar_Click);
            // 
            // pToday
            // 
            this.pToday.BackColor = System.Drawing.Color.White;
            this.pToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pToday.Image = global::Presentacion.Properties.Resources.Today;
            this.pToday.Location = new System.Drawing.Point(240, 2);
            this.pToday.Name = "pToday";
            this.pToday.Size = new System.Drawing.Size(48, 50);
            this.pToday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pToday.TabIndex = 3;
            this.pToday.TabStop = false;
            this.toolTip1.SetToolTip(this.pToday, "Citas del Dia");
            this.pToday.Click += new System.EventHandler(this.pToday_Click);
            // 
            // pMonth
            // 
            this.pMonth.BackColor = System.Drawing.Color.White;
            this.pMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pMonth.Image = ((System.Drawing.Image)(resources.GetObject("pMonth.Image")));
            this.pMonth.Location = new System.Drawing.Point(417, 2);
            this.pMonth.Name = "pMonth";
            this.pMonth.Size = new System.Drawing.Size(48, 50);
            this.pMonth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pMonth.TabIndex = 1;
            this.pMonth.TabStop = false;
            this.toolTip1.SetToolTip(this.pMonth, "Meses");
            this.pMonth.Click += new System.EventHandler(this.pMonth_Click);
            // 
            // pIcono
            // 
            this.pIcono.BackColor = System.Drawing.Color.White;
            this.pIcono.Enabled = false;
            this.pIcono.Image = global::Presentacion.Properties.Resources.Form_Citas;
            this.pIcono.Location = new System.Drawing.Point(3, 2);
            this.pIcono.Name = "pIcono";
            this.pIcono.Size = new System.Drawing.Size(48, 50);
            this.pIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pIcono.TabIndex = 0;
            this.pIcono.TabStop = false;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(950, 54);
            this.shapeContainer2.TabIndex = 2;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lineShape2.BorderWidth = 3;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 352;
            this.lineShape2.X2 = 352;
            this.lineShape2.Y1 = 47;
            this.lineShape2.Y2 = 5;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lineShape1.BorderWidth = 3;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 228;
            this.lineShape1.X2 = 228;
            this.lineShape1.Y1 = 47;
            this.lineShape1.Y2 = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panelContenido);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 516);
            this.panel2.TabIndex = 2;
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.LightGray;
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(950, 516);
            this.panelContenido.TabIndex = 0;
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Citas";
            this.Text = "Citas";
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pCerrar)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAgendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pToday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIcono)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pDays;
        private System.Windows.Forms.PictureBox pAgendar;
        private System.Windows.Forms.PictureBox pToday;
        private System.Windows.Forms.PictureBox pMonth;
        private System.Windows.Forms.PictureBox pIcono;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Panel panelContenido;
        public System.Windows.Forms.Panel panelTitulo;
        public System.Windows.Forms.Panel panelMenu;
        public System.Windows.Forms.Panel panel2;
    }
}