namespace Presentacion
{
    partial class ViewClient
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
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primerNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundoNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primerApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundoApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesCitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salonDataSet = new Presentacion.SalonDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbletiqueta = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clientesCitasTableAdapter = new Presentacion.SalonDataSetTableAdapters.ClientesCitasTableAdapter();
            this.salonDataSet1 = new Presentacion.SalonDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesCitasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AllowUserToAddRows = false;
            this.dataGridViewClient.AutoGenerateColumns = false;
            this.dataGridViewClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numeroCedulaDataGridViewTextBoxColumn,
            this.primerNombreDataGridViewTextBoxColumn,
            this.segundoNombreDataGridViewTextBoxColumn,
            this.primerApellidoDataGridViewTextBoxColumn,
            this.segundoApellidoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn});
            this.dataGridViewClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewClient.DataSource = this.clientesCitasBindingSource;
            this.dataGridViewClient.Location = new System.Drawing.Point(12, 111);
            this.dataGridViewClient.MultiSelect = false;
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.ReadOnly = true;
            this.dataGridViewClient.RowHeadersVisible = false;
            this.dataGridViewClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClient.Size = new System.Drawing.Size(642, 191);
            this.dataGridViewClient.TabIndex = 0;
            this.dataGridViewClient.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClient_CellDoubleClick);
            this.dataGridViewClient.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewClient_DataBindingComplete);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 80;
            // 
            // numeroCedulaDataGridViewTextBoxColumn
            // 
            this.numeroCedulaDataGridViewTextBoxColumn.DataPropertyName = "NumeroCedula";
            this.numeroCedulaDataGridViewTextBoxColumn.HeaderText = "NumeroCedula";
            this.numeroCedulaDataGridViewTextBoxColumn.Name = "numeroCedulaDataGridViewTextBoxColumn";
            this.numeroCedulaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroCedulaDataGridViewTextBoxColumn.Width = 80;
            // 
            // primerNombreDataGridViewTextBoxColumn
            // 
            this.primerNombreDataGridViewTextBoxColumn.DataPropertyName = "PrimerNombre";
            this.primerNombreDataGridViewTextBoxColumn.HeaderText = "PrimerNombre";
            this.primerNombreDataGridViewTextBoxColumn.Name = "primerNombreDataGridViewTextBoxColumn";
            this.primerNombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.primerNombreDataGridViewTextBoxColumn.Width = 80;
            // 
            // segundoNombreDataGridViewTextBoxColumn
            // 
            this.segundoNombreDataGridViewTextBoxColumn.DataPropertyName = "SegundoNombre";
            this.segundoNombreDataGridViewTextBoxColumn.HeaderText = "SegundoNombre";
            this.segundoNombreDataGridViewTextBoxColumn.Name = "segundoNombreDataGridViewTextBoxColumn";
            this.segundoNombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.segundoNombreDataGridViewTextBoxColumn.Width = 80;
            // 
            // primerApellidoDataGridViewTextBoxColumn
            // 
            this.primerApellidoDataGridViewTextBoxColumn.DataPropertyName = "PrimerApellido";
            this.primerApellidoDataGridViewTextBoxColumn.HeaderText = "PrimerApellido";
            this.primerApellidoDataGridViewTextBoxColumn.Name = "primerApellidoDataGridViewTextBoxColumn";
            this.primerApellidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.primerApellidoDataGridViewTextBoxColumn.Width = 79;
            // 
            // segundoApellidoDataGridViewTextBoxColumn
            // 
            this.segundoApellidoDataGridViewTextBoxColumn.DataPropertyName = "SegundoApellido";
            this.segundoApellidoDataGridViewTextBoxColumn.HeaderText = "SegundoApellido";
            this.segundoApellidoDataGridViewTextBoxColumn.Name = "segundoApellidoDataGridViewTextBoxColumn";
            this.segundoApellidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.segundoApellidoDataGridViewTextBoxColumn.Width = 80;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonoDataGridViewTextBoxColumn.Width = 80;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            this.correoDataGridViewTextBoxColumn.Width = 80;
            // 
            // clientesCitasBindingSource
            // 
            this.clientesCitasBindingSource.DataMember = "ClientesCitas";
            this.clientesCitasBindingSource.DataSource = this.salonDataSet;
            // 
            // salonDataSet
            // 
            this.salonDataSet.DataSetName = "SalonDataSet";
            this.salonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(642, 51);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbletiqueta
            // 
            this.lbletiqueta.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbletiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbletiqueta.Location = new System.Drawing.Point(12, 13);
            this.lbletiqueta.Name = "lbletiqueta";
            this.lbletiqueta.Size = new System.Drawing.Size(642, 38);
            this.lbletiqueta.TabIndex = 2;
            this.lbletiqueta.Text = "Cliente";
            this.lbletiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.BuscarDatagrid;
            this.pictureBox2.Location = new System.Drawing.Point(26, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Apellido: ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(154, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // clientesCitasTableAdapter
            // 
            this.clientesCitasTableAdapter.ClearBeforeFill = true;
            // 
            // salonDataSet1
            // 
            this.salonDataSet1.DataSetName = "SalonDataSet";
            this.salonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filtrar por: ";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Apellido ",
            "Nombre"});
            this.comboBox1.Location = new System.Drawing.Point(498, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ViewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 314);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewClient);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbletiqueta);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(682, 353);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(682, 353);
            this.Name = "ViewClient";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.ViewClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesCitasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbletiqueta;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private SalonDataSet salonDataSet;
        private System.Windows.Forms.BindingSource clientesCitasBindingSource;
        private SalonDataSetTableAdapters.ClientesCitasTableAdapter clientesCitasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundoNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundoApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private SalonDataSet salonDataSet1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}