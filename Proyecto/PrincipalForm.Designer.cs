namespace Proyecto
{
    partial class PrincipalForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cambiarNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarArchivoButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.datosDataGridView = new System.Windows.Forms.DataGridView();
            this.guardarButton = new System.Windows.Forms.Button();
            this.guardarComoButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.preProcesamientoButton = new System.Windows.Forms.Button();
            this.analisisEButton = new System.Windows.Forms.Button();
            this.machineLButton = new System.Windows.Forms.Button();
            this.archivoLabel = new System.Windows.Forms.Label();
            this.nombreALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cambiarNombreToolStripMenuItem
            // 
            this.cambiarNombreToolStripMenuItem.Name = "cambiarNombreToolStripMenuItem";
            this.cambiarNombreToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cambiarNombreToolStripMenuItem.Text = "Cambiar nombre";
            // 
            // cargarArchivoButton
            // 
            this.cargarArchivoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cargarArchivoButton.Location = new System.Drawing.Point(12, 12);
            this.cargarArchivoButton.Name = "cargarArchivoButton";
            this.cargarArchivoButton.Size = new System.Drawing.Size(102, 30);
            this.cargarArchivoButton.TabIndex = 1;
            this.cargarArchivoButton.Text = "Cargar archivo";
            this.cargarArchivoButton.UseVisualStyleBackColor = true;
            this.cargarArchivoButton.Click += new System.EventHandler(this.abrirArchivoButton_Click);
            // 
            // datosDataGridView
            // 
            this.datosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datosDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.datosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.datosDataGridView.Location = new System.Drawing.Point(12, 61);
            this.datosDataGridView.Name = "datosDataGridView";
            this.datosDataGridView.Size = new System.Drawing.Size(708, 207);
            this.datosDataGridView.TabIndex = 2;
            this.datosDataGridView.Visible = false;
            this.datosDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datosDataGridView_CellClick);
            this.datosDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datosDataGridView_CellMouseClick);
            this.datosDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.datosDataGridView_CellValueChanged);
            // 
            // guardarButton
            // 
            this.guardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.guardarButton.Location = new System.Drawing.Point(120, 12);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(102, 30);
            this.guardarButton.TabIndex = 3;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Visible = false;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // guardarComoButton
            // 
            this.guardarComoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.guardarComoButton.Location = new System.Drawing.Point(228, 12);
            this.guardarComoButton.Name = "guardarComoButton";
            this.guardarComoButton.Size = new System.Drawing.Size(102, 30);
            this.guardarComoButton.TabIndex = 4;
            this.guardarComoButton.Text = "Guardar Como";
            this.guardarComoButton.UseVisualStyleBackColor = true;
            this.guardarComoButton.Visible = false;
            this.guardarComoButton.Click += new System.EventHandler(this.guardarComoButton_Click);
            // 
            // preProcesamientoButton
            // 
            this.preProcesamientoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.preProcesamientoButton.Location = new System.Drawing.Point(336, 12);
            this.preProcesamientoButton.Name = "preProcesamientoButton";
            this.preProcesamientoButton.Size = new System.Drawing.Size(124, 30);
            this.preProcesamientoButton.TabIndex = 5;
            this.preProcesamientoButton.Text = "Pre-procesamiento";
            this.preProcesamientoButton.UseVisualStyleBackColor = true;
            this.preProcesamientoButton.Visible = false;
            // 
            // analisisEButton
            // 
            this.analisisEButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.analisisEButton.Location = new System.Drawing.Point(466, 12);
            this.analisisEButton.Name = "analisisEButton";
            this.analisisEButton.Size = new System.Drawing.Size(124, 30);
            this.analisisEButton.TabIndex = 6;
            this.analisisEButton.Text = "Análisis Estadístico";
            this.analisisEButton.UseVisualStyleBackColor = true;
            this.analisisEButton.Visible = false;
            // 
            // machineLButton
            // 
            this.machineLButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.machineLButton.Location = new System.Drawing.Point(596, 12);
            this.machineLButton.Name = "machineLButton";
            this.machineLButton.Size = new System.Drawing.Size(124, 30);
            this.machineLButton.TabIndex = 7;
            this.machineLButton.Text = "Machine Learning";
            this.machineLButton.UseVisualStyleBackColor = true;
            this.machineLButton.Visible = false;
            // 
            // archivoLabel
            // 
            this.archivoLabel.AutoSize = true;
            this.archivoLabel.Location = new System.Drawing.Point(9, 45);
            this.archivoLabel.Name = "archivoLabel";
            this.archivoLabel.Size = new System.Drawing.Size(46, 13);
            this.archivoLabel.TabIndex = 8;
            this.archivoLabel.Text = "Archivo:";
            this.archivoLabel.Visible = false;
            // 
            // nombreALabel
            // 
            this.nombreALabel.AutoSize = true;
            this.nombreALabel.Location = new System.Drawing.Point(61, 45);
            this.nombreALabel.Name = "nombreALabel";
            this.nombreALabel.Size = new System.Drawing.Size(0, 13);
            this.nombreALabel.TabIndex = 9;
            this.nombreALabel.Visible = false;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 291);
            this.Controls.Add(this.nombreALabel);
            this.Controls.Add(this.archivoLabel);
            this.Controls.Add(this.machineLButton);
            this.Controls.Add(this.analisisEButton);
            this.Controls.Add(this.preProcesamientoButton);
            this.Controls.Add(this.guardarComoButton);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.datosDataGridView);
            this.Controls.Add(this.cargarArchivoButton);
            this.Name = "PrincipalForm";
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrincipalFormClosing);
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem cambiarNombreToolStripMenuItem;
        private System.Windows.Forms.Button cargarArchivoButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView datosDataGridView;
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.Button guardarComoButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button preProcesamientoButton;
        private System.Windows.Forms.Button analisisEButton;
        private System.Windows.Forms.Button machineLButton;
        private System.Windows.Forms.Label archivoLabel;
        private System.Windows.Forms.Label nombreALabel;
    }
}

