namespace ProyectoBasesDatos1
{
    partial class VentanaVendedor
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ConsultClientesJu = new System.Windows.Forms.Button();
            this.ConsultClientesFi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AgregarCliente = new System.Windows.Forms.Button();
            this.EliminarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(346, 748);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(389, 389);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 1143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Consultar Clientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(257, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(577, 425);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1193);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.EliminarCliente);
            this.panel3.Controls.Add(this.AgregarCliente);
            this.panel3.Controls.Add(this.ConsultClientesJu);
            this.panel3.Controls.Add(this.ConsultClientesFi);
            this.panel3.Location = new System.Drawing.Point(0, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 312);
            this.panel3.TabIndex = 7;
            // 
            // ConsultClientesJu
            // 
            this.ConsultClientesJu.BackColor = System.Drawing.Color.Transparent;
            this.ConsultClientesJu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConsultClientesJu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultClientesJu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultClientesJu.ForeColor = System.Drawing.Color.White;
            this.ConsultClientesJu.Location = new System.Drawing.Point(0, 72);
            this.ConsultClientesJu.Name = "ConsultClientesJu";
            this.ConsultClientesJu.Size = new System.Drawing.Size(200, 77);
            this.ConsultClientesJu.TabIndex = 7;
            this.ConsultClientesJu.Text = "Consultar Todos\r\nLos Clientes Jurídicos\r\n(Organizaciones)";
            this.ConsultClientesJu.UseVisualStyleBackColor = false;
            this.ConsultClientesJu.Click += new System.EventHandler(this.ConsultClientesJu_Click);
            // 
            // ConsultClientesFi
            // 
            this.ConsultClientesFi.BackColor = System.Drawing.Color.Transparent;
            this.ConsultClientesFi.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConsultClientesFi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultClientesFi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultClientesFi.ForeColor = System.Drawing.Color.White;
            this.ConsultClientesFi.Location = new System.Drawing.Point(0, 0);
            this.ConsultClientesFi.Name = "ConsultClientesFi";
            this.ConsultClientesFi.Size = new System.Drawing.Size(200, 72);
            this.ConsultClientesFi.TabIndex = 7;
            this.ConsultClientesFi.Text = "Consultar Todos\r\nLos Clientes\r\nFísicos\r\n";
            this.ConsultClientesFi.UseVisualStyleBackColor = false;
            this.ConsultClientesFi.Click += new System.EventHandler(this.ConsultClientesFi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 72);
            this.label3.TabIndex = 7;
            this.label3.Text = "Menu \r\nPara \r\nVendedores\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Punto de Venta";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(180, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 51);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tienda de Tecnología";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(679, 100);
            this.panel2.TabIndex = 6;
            // 
            // AgregarCliente
            // 
            this.AgregarCliente.BackColor = System.Drawing.Color.Transparent;
            this.AgregarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.AgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarCliente.ForeColor = System.Drawing.Color.White;
            this.AgregarCliente.Location = new System.Drawing.Point(0, 149);
            this.AgregarCliente.Name = "AgregarCliente";
            this.AgregarCliente.Size = new System.Drawing.Size(200, 72);
            this.AgregarCliente.TabIndex = 8;
            this.AgregarCliente.Text = "Agregar \r\nCliente\r\n\r\n";
            this.AgregarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AgregarCliente.UseVisualStyleBackColor = false;
            // 
            // EliminarCliente
            // 
            this.EliminarCliente.BackColor = System.Drawing.Color.Transparent;
            this.EliminarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.EliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarCliente.ForeColor = System.Drawing.Color.White;
            this.EliminarCliente.Location = new System.Drawing.Point(0, 221);
            this.EliminarCliente.Name = "EliminarCliente";
            this.EliminarCliente.Size = new System.Drawing.Size(200, 72);
            this.EliminarCliente.TabIndex = 9;
            this.EliminarCliente.Text = "Eliminar \r\nCliente\r\n\r\n";
            this.EliminarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarCliente.UseVisualStyleBackColor = false;
            // 
            // VentanaVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(896, 345);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "VentanaVendedor";
            this.Text = "VentanaVendedor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ConsultClientesFi;
        private System.Windows.Forms.Button ConsultClientesJu;
        private System.Windows.Forms.Button EliminarCliente;
        private System.Windows.Forms.Button AgregarCliente;
    }
}