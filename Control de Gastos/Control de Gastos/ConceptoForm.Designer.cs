namespace Control_de_Gastos
{
    partial class ConceptoForm
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
            this.gbPanel = new System.Windows.Forms.GroupBox();
            this.chkIsEnabled = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvPanel = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPanel
            // 
            this.gbPanel.Controls.Add(this.chkIsEnabled);
            this.gbPanel.Controls.Add(this.label4);
            this.gbPanel.Controls.Add(this.txtID);
            this.gbPanel.Controls.Add(this.lblCreatedDate);
            this.gbPanel.Controls.Add(this.label2);
            this.gbPanel.Controls.Add(this.label1);
            this.gbPanel.Controls.Add(this.txtDescripcion);
            this.gbPanel.Controls.Add(this.txtNombre);
            this.gbPanel.Location = new System.Drawing.Point(8, 9);
            this.gbPanel.Name = "gbPanel";
            this.gbPanel.Size = new System.Drawing.Size(507, 340);
            this.gbPanel.TabIndex = 0;
            this.gbPanel.TabStop = false;
            this.gbPanel.Text = " ";
            // 
            // chkIsEnabled
            // 
            this.chkIsEnabled.AutoSize = true;
            this.chkIsEnabled.Location = new System.Drawing.Point(17, 304);
            this.chkIsEnabled.Name = "chkIsEnabled";
            this.chkIsEnabled.Size = new System.Drawing.Size(145, 24);
            this.chkIsEnabled.TabIndex = 9;
            this.chkIsEnabled.Text = "Visible al publico";
            this.chkIsEnabled.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(376, 49);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(125, 27);
            this.txtID.TabIndex = 7;
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Location = new System.Drawing.Point(441, 305);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(47, 20);
            this.lblCreatedDate.TabIndex = 5;
            this.lblCreatedDate.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(15, 156);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(476, 139);
            this.txtDescripcion.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(15, 94);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 27);
            this.txtNombre.TabIndex = 0;
            // 
            // dgvPanel
            // 
            this.dgvPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPanel.Location = new System.Drawing.Point(521, 22);
            this.dgvPanel.Name = "dgvPanel";
            this.dgvPanel.RowHeadersWidth = 51;
            this.dgvPanel.RowTemplate.Height = 29;
            this.dgvPanel.Size = new System.Drawing.Size(682, 395);
            this.dgvPanel.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Lime;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(132, 369);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 29);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelar.Location = new System.Drawing.Point(402, 369);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(22, 369);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 29);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "NUEVO";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // ConceptoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 429);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvPanel);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbPanel);
            this.Name = "ConceptoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConceptoForm";
            this.gbPanel.ResumeLayout(false);
            this.gbPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbPanel;
        private CheckBox chkIsEnabled;
        private Label label4;
        private TextBox txtID;
        private Label lblCreatedDate;
        private Label label2;
        private Label label1;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private DataGridView dgvPanel;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnAgregar;
    }
}