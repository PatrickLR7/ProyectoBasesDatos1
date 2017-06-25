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
            this.EliminarCliente = new System.Windows.Forms.Button();
            this.AgregarCliente = new System.Windows.Forms.Button();
            this.ConsultClientesJu = new System.Windows.Forms.Button();
            this.ConsultClientesFi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelInsertarEliminar = new System.Windows.Forms.Panel();
            this.InsertarCliente = new System.Windows.Forms.Button();
            this.LabelApellido2 = new System.Windows.Forms.Label();
            this.LabelApellido1 = new System.Windows.Forms.Label();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.textBoxApellido2 = new System.Windows.Forms.TextBox();
            this.textBoxApellido1 = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TipoDeClienteStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.personaFísicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personaJurídicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_IdCliente = new System.Windows.Forms.Label();
            this.textBoxId_Cliente = new System.Windows.Forms.TextBox();
            this.btnBorrarCliente = new System.Windows.Forms.Button();
            this.SalirVendedor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelInsertarEliminar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(343, 804);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(389, 389);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(738, 1143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Consultar Clientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(263, 343);
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
            this.panel3.Controls.Add(this.SalirVendedor);
            this.panel3.Controls.Add(this.EliminarCliente);
            this.panel3.Controls.Add(this.AgregarCliente);
            this.panel3.Controls.Add(this.ConsultClientesJu);
            this.panel3.Controls.Add(this.ConsultClientesFi);
            this.panel3.Location = new System.Drawing.Point(0, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 371);
            this.panel3.TabIndex = 7;
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
            this.EliminarCliente.Click += new System.EventHandler(this.EliminarCliente_Click);
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
            this.AgregarCliente.Click += new System.EventHandler(this.AgregarCliente_Click);
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
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(691, 100);
            this.label1.TabIndex = 5;
            this.label1.Text = "Punto de Venta\r\nTienda de Tecnología";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(691, 100);
            this.panel2.TabIndex = 6;
            // 
            // PanelInsertarEliminar
            // 
            this.PanelInsertarEliminar.Controls.Add(this.btnBorrarCliente);
            this.PanelInsertarEliminar.Controls.Add(this.textBoxId_Cliente);
            this.PanelInsertarEliminar.Controls.Add(this.label_IdCliente);
            this.PanelInsertarEliminar.Controls.Add(this.InsertarCliente);
            this.PanelInsertarEliminar.Controls.Add(this.LabelApellido2);
            this.PanelInsertarEliminar.Controls.Add(this.LabelApellido1);
            this.PanelInsertarEliminar.Controls.Add(this.LabelNombre);
            this.PanelInsertarEliminar.Controls.Add(this.textBoxApellido2);
            this.PanelInsertarEliminar.Controls.Add(this.textBoxApellido1);
            this.PanelInsertarEliminar.Controls.Add(this.textBoxNombre);
            this.PanelInsertarEliminar.Controls.Add(this.menuStrip1);
            this.PanelInsertarEliminar.Location = new System.Drawing.Point(233, 103);
            this.PanelInsertarEliminar.Name = "PanelInsertarEliminar";
            this.PanelInsertarEliminar.Size = new System.Drawing.Size(646, 143);
            this.PanelInsertarEliminar.TabIndex = 7;
            this.PanelInsertarEliminar.Visible = false;
            // 
            // InsertarCliente
            // 
            this.InsertarCliente.BackColor = System.Drawing.Color.Blue;
            this.InsertarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertarCliente.ForeColor = System.Drawing.Color.White;
            this.InsertarCliente.Location = new System.Drawing.Point(30, 85);
            this.InsertarCliente.Name = "InsertarCliente";
            this.InsertarCliente.Size = new System.Drawing.Size(129, 39);
            this.InsertarCliente.TabIndex = 7;
            this.InsertarCliente.Text = "InsertarCliente";
            this.InsertarCliente.UseVisualStyleBackColor = false;
            this.InsertarCliente.Visible = false;
            this.InsertarCliente.Click += new System.EventHandler(this.InsertarCliente_Click);
            // 
            // LabelApellido2
            // 
            this.LabelApellido2.AutoSize = true;
            this.LabelApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelApellido2.ForeColor = System.Drawing.Color.White;
            this.LabelApellido2.Location = new System.Drawing.Point(222, 108);
            this.LabelApellido2.Name = "LabelApellido2";
            this.LabelApellido2.Size = new System.Drawing.Size(74, 16);
            this.LabelApellido2.TabIndex = 6;
            this.LabelApellido2.Text = "Apellido2";
            this.LabelApellido2.Visible = false;
            // 
            // LabelApellido1
            // 
            this.LabelApellido1.AutoSize = true;
            this.LabelApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelApellido1.ForeColor = System.Drawing.Color.White;
            this.LabelApellido1.Location = new System.Drawing.Point(222, 64);
            this.LabelApellido1.Name = "LabelApellido1";
            this.LabelApellido1.Size = new System.Drawing.Size(74, 16);
            this.LabelApellido1.TabIndex = 5;
            this.LabelApellido1.Text = "Apellido1";
            this.LabelApellido1.Visible = false;
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombre.ForeColor = System.Drawing.Color.White;
            this.LabelNombre.Location = new System.Drawing.Point(222, 18);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(63, 16);
            this.LabelNombre.TabIndex = 4;
            this.LabelNombre.Text = "Nombre";
            this.LabelNombre.Visible = false;
            // 
            // textBoxApellido2
            // 
            this.textBoxApellido2.Location = new System.Drawing.Point(305, 104);
            this.textBoxApellido2.Name = "textBoxApellido2";
            this.textBoxApellido2.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellido2.TabIndex = 2;
            this.textBoxApellido2.Visible = false;
            // 
            // textBoxApellido1
            // 
            this.textBoxApellido1.Location = new System.Drawing.Point(305, 60);
            this.textBoxApellido1.Name = "textBoxApellido1";
            this.textBoxApellido1.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellido1.TabIndex = 1;
            this.textBoxApellido1.Visible = false;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(305, 18);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 0;
            this.textBoxNombre.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TipoDeClienteStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(15, 35);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(178, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TipoDeClienteStripMenu
            // 
            this.TipoDeClienteStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personaFísicaToolStripMenuItem,
            this.personaJurídicaToolStripMenuItem});
            this.TipoDeClienteStripMenu.Name = "TipoDeClienteStripMenu";
            this.TipoDeClienteStripMenu.Size = new System.Drawing.Size(170, 20);
            this.TipoDeClienteStripMenu.Text = "Seleccione un tipo de cliente";
            // 
            // personaFísicaToolStripMenuItem
            // 
            this.personaFísicaToolStripMenuItem.Name = "personaFísicaToolStripMenuItem";
            this.personaFísicaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.personaFísicaToolStripMenuItem.Text = "Persona Física";
            this.personaFísicaToolStripMenuItem.Click += new System.EventHandler(this.personaFísicaToolStripMenuItem_Click);
            // 
            // personaJurídicaToolStripMenuItem
            // 
            this.personaJurídicaToolStripMenuItem.Name = "personaJurídicaToolStripMenuItem";
            this.personaJurídicaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.personaJurídicaToolStripMenuItem.Text = "Persona Jurídica";
            this.personaJurídicaToolStripMenuItem.Click += new System.EventHandler(this.personaJurídicaToolStripMenuItem_Click);
            // 
            // label_IdCliente
            // 
            this.label_IdCliente.AutoSize = true;
            this.label_IdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IdCliente.ForeColor = System.Drawing.Color.White;
            this.label_IdCliente.Location = new System.Drawing.Point(441, 36);
            this.label_IdCliente.Name = "label_IdCliente";
            this.label_IdCliente.Size = new System.Drawing.Size(77, 16);
            this.label_IdCliente.TabIndex = 8;
            this.label_IdCliente.Text = "Id_Cliente";
            this.label_IdCliente.Visible = false;
            // 
            // textBoxId_Cliente
            // 
            this.textBoxId_Cliente.Location = new System.Drawing.Point(524, 35);
            this.textBoxId_Cliente.Name = "textBoxId_Cliente";
            this.textBoxId_Cliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxId_Cliente.TabIndex = 9;
            this.textBoxId_Cliente.Visible = false;
            // 
            // btnBorrarCliente
            // 
            this.btnBorrarCliente.BackColor = System.Drawing.Color.Blue;
            this.btnBorrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBorrarCliente.Location = new System.Drawing.Point(493, 76);
            this.btnBorrarCliente.Name = "btnBorrarCliente";
            this.btnBorrarCliente.Size = new System.Drawing.Size(129, 39);
            this.btnBorrarCliente.TabIndex = 10;
            this.btnBorrarCliente.Text = "BorrarCliente";
            this.btnBorrarCliente.UseVisualStyleBackColor = false;
            this.btnBorrarCliente.Visible = false;
            this.btnBorrarCliente.Click += new System.EventHandler(this.btnBorrarCliente_Click);
            // 
            // SalirVendedor
            // 
            this.SalirVendedor.BackColor = System.Drawing.Color.Transparent;
            this.SalirVendedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.SalirVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalirVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirVendedor.ForeColor = System.Drawing.Color.White;
            this.SalirVendedor.Location = new System.Drawing.Point(0, 293);
            this.SalirVendedor.Name = "SalirVendedor";
            this.SalirVendedor.Size = new System.Drawing.Size(200, 72);
            this.SalirVendedor.TabIndex = 10;
            this.SalirVendedor.Text = "Salir";
            this.SalirVendedor.UseVisualStyleBackColor = false;
            this.SalirVendedor.Click += new System.EventHandler(this.SalirVendedor_Click);
            // 
            // VentanaVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(908, 600);
            this.Controls.Add(this.PanelInsertarEliminar);
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
            this.PanelInsertarEliminar.ResumeLayout(false);
            this.PanelInsertarEliminar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ConsultClientesFi;
        private System.Windows.Forms.Button ConsultClientesJu;
        private System.Windows.Forms.Button EliminarCliente;
        private System.Windows.Forms.Button AgregarCliente;
        private System.Windows.Forms.Panel PanelInsertarEliminar;
        private System.Windows.Forms.Label LabelApellido2;
        private System.Windows.Forms.Label LabelApellido1;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.TextBox textBoxApellido2;
        private System.Windows.Forms.TextBox textBoxApellido1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TipoDeClienteStripMenu;
        private System.Windows.Forms.ToolStripMenuItem personaFísicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personaJurídicaToolStripMenuItem;
        private System.Windows.Forms.Button InsertarCliente;
        private System.Windows.Forms.Button btnBorrarCliente;
        private System.Windows.Forms.TextBox textBoxId_Cliente;
        private System.Windows.Forms.Label label_IdCliente;
        private System.Windows.Forms.Button SalirVendedor;
    }
}