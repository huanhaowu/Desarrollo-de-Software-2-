namespace Control_de_Gastos
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarConcepto = new System.Windows.Forms.Button();
            this.btnCategoría = new System.Windows.Forms.Button();
            this.btnConcepto = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCategoría = new System.Windows.Forms.TextBox();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAgregarConcepto);
            this.groupBox1.Controls.Add(this.btnCategoría);
            this.groupBox1.Controls.Add(this.btnConcepto);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.txtCategoría);
            this.groupBox1.Controls.Add(this.txtConcepto);
            this.groupBox1.Controls.Add(this.dtFecha);
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(913, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESOS Y EGRESOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Referencia / categoría";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Concepto:";
            // 
            // btnAgregarConcepto
            // 
            this.btnAgregarConcepto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarConcepto.Location = new System.Drawing.Point(165, 228);
            this.btnAgregarConcepto.Name = "btnAgregarConcepto";
            this.btnAgregarConcepto.Size = new System.Drawing.Size(118, 29);
            this.btnAgregarConcepto.TabIndex = 7;
            this.btnAgregarConcepto.Text = "AGREGAR";
            this.btnAgregarConcepto.UseVisualStyleBackColor = true;
            this.btnAgregarConcepto.Click += new System.EventHandler(this.btnAgregarConcepto_Click);
            // 
            // btnCategoría
            // 
            this.btnCategoría.Location = new System.Drawing.Point(289, 170);
            this.btnCategoría.Name = "btnCategoría";
            this.btnCategoría.Size = new System.Drawing.Size(39, 29);
            this.btnCategoría.TabIndex = 6;
            this.btnCategoría.Text = "...";
            this.btnCategoría.UseVisualStyleBackColor = true;
            this.btnCategoría.Click += new System.EventHandler(this.btnCategoría_Click);
            // 
            // btnConcepto
            // 
            this.btnConcepto.Location = new System.Drawing.Point(289, 112);
            this.btnConcepto.Name = "btnConcepto";
            this.btnConcepto.Size = new System.Drawing.Size(39, 29);
            this.btnConcepto.TabIndex = 5;
            this.btnConcepto.Text = "...";
            this.btnConcepto.UseVisualStyleBackColor = true;
            this.btnConcepto.Click += new System.EventHandler(this.btnConcepto_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(24, 230);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(125, 27);
            this.txtCantidad.TabIndex = 4;
            // 
            // txtCategoría
            // 
            this.txtCategoría.Location = new System.Drawing.Point(24, 172);
            this.txtCategoría.Name = "txtCategoría";
            this.txtCategoría.Size = new System.Drawing.Size(250, 27);
            this.txtCategoría.TabIndex = 3;
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(24, 114);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(250, 27);
            this.txtConcepto.TabIndex = 2;
            this.txtConcepto.Click += new System.EventHandler(this.txtConcepto_Click);
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(24, 58);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(250, 27);
            this.dtFecha.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(913, 335);
            this.dataGridView1.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 638);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAgregarConcepto;
        private Button btnCategoría;
        private Button btnConcepto;
        private TextBox txtCantidad;
        private TextBox txtCategoría;
        private TextBox txtConcepto;
        private DateTimePicker dtFecha;
        private DataGridView dataGridView1;
    }
}