namespace UI
{
    partial class LibroForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEdicion = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarLibro = new System.Windows.Forms.Button();
            this.gridLibro = new System.Windows.Forms.DataGridView();
            this.btnActualizarLibro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEditorial);
            this.groupBox1.Controls.Add(this.txtGenero);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIsbn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEdicion);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(65, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Libro";
            // 
            // txtEdicion
            // 
            this.txtEdicion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdicion.Location = new System.Drawing.Point(152, 162);
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(144, 27);
            this.txtEdicion.TabIndex = 3;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(152, 107);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(144, 27);
            this.txtTitulo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edicion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo:";
            // 
            // btnGuardarLibro
            // 
            this.btnGuardarLibro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarLibro.Location = new System.Drawing.Point(497, 67);
            this.btnGuardarLibro.Name = "btnGuardarLibro";
            this.btnGuardarLibro.Size = new System.Drawing.Size(149, 43);
            this.btnGuardarLibro.TabIndex = 2;
            this.btnGuardarLibro.Text = "GUARDAR";
            this.btnGuardarLibro.UseVisualStyleBackColor = true;
            this.btnGuardarLibro.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gridLibro
            // 
            this.gridLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLibro.Location = new System.Drawing.Point(65, 407);
            this.gridLibro.Name = "gridLibro";
            this.gridLibro.RowHeadersWidth = 51;
            this.gridLibro.RowTemplate.Height = 24;
            this.gridLibro.Size = new System.Drawing.Size(725, 323);
            this.gridLibro.TabIndex = 3;
            // 
            // btnActualizarLibro
            // 
            this.btnActualizarLibro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarLibro.Location = new System.Drawing.Point(497, 169);
            this.btnActualizarLibro.Name = "btnActualizarLibro";
            this.btnActualizarLibro.Size = new System.Drawing.Size(149, 43);
            this.btnActualizarLibro.TabIndex = 4;
            this.btnActualizarLibro.Text = "ACTUALIZAR";
            this.btnActualizarLibro.UseVisualStyleBackColor = true;
            this.btnActualizarLibro.Click += new System.EventHandler(this.btnActualizarLibro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Isbn:";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsbn.Location = new System.Drawing.Point(152, 55);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(144, 27);
            this.txtIsbn.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID Genero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "ID Editorial:";
            // 
            // txtGenero
            // 
            this.txtGenero.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.Location = new System.Drawing.Point(181, 222);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(144, 27);
            this.txtGenero.TabIndex = 8;
            // 
            // txtEditorial
            // 
            this.txtEditorial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditorial.Location = new System.Drawing.Point(181, 279);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(144, 27);
            this.txtEditorial.TabIndex = 9;
            // 
            // LibroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 764);
            this.Controls.Add(this.btnActualizarLibro);
            this.Controls.Add(this.gridLibro);
            this.Controls.Add(this.btnGuardarLibro);
            this.Controls.Add(this.groupBox1);
            this.Name = "LibroForm";
            this.Text = "LibroForm";
            this.Load += new System.EventHandler(this.LibroForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLibro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEdicion;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnGuardarLibro;
        private System.Windows.Forms.DataGridView gridLibro;
        private System.Windows.Forms.Button btnActualizarLibro;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}