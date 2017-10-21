namespace Hoteleria
{
    partial class Pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedido));
            this.Pnl_botones = new System.Windows.Forms.Panel();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.Lbl_borrar = new System.Windows.Forms.Label();
            this.Lbl_editar = new System.Windows.Forms.Label();
            this.Lbl_guardar = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.dgv_pedido = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_cantBebida = new System.Windows.Forms.TextBox();
            this.cmb_bebida = new System.Windows.Forms.ComboBox();
            this.txt_cantPlatillo = new System.Windows.Forms.TextBox();
            this.cmb_platillo = new System.Windows.Forms.ComboBox();
            this.lbl_cantidadBebida = new System.Windows.Forms.Label();
            this.lbl_bebida = new System.Windows.Forms.Label();
            this.lbl_cantidadPlatillo = new System.Windows.Forms.Label();
            this.lbl_platillo = new System.Windows.Forms.Label();
            this.cmb_cliente = new System.Windows.Forms.ComboBox();
            this.cmb_mesa = new System.Windows.Forms.ComboBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedido)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_botones
            // 
            this.Pnl_botones.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Pnl_botones.Controls.Add(this.btn_borrar);
            this.Pnl_botones.Controls.Add(this.btn_editar);
            this.Pnl_botones.Controls.Add(this.Lbl_borrar);
            this.Pnl_botones.Controls.Add(this.Lbl_editar);
            this.Pnl_botones.Controls.Add(this.Lbl_guardar);
            this.Pnl_botones.Controls.Add(this.btn_guardar);
            this.Pnl_botones.Location = new System.Drawing.Point(452, 12);
            this.Pnl_botones.Name = "Pnl_botones";
            this.Pnl_botones.Size = new System.Drawing.Size(283, 106);
            this.Pnl_botones.TabIndex = 11;
            // 
            // btn_borrar
            // 
            this.btn_borrar.FlatAppearance.BorderSize = 0;
            this.btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_borrar.Image")));
            this.btn_borrar.Location = new System.Drawing.Point(199, 7);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(65, 65);
            this.btn_borrar.TabIndex = 16;
            this.btn_borrar.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.Location = new System.Drawing.Point(111, 7);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(65, 65);
            this.btn_editar.TabIndex = 13;
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // Lbl_borrar
            // 
            this.Lbl_borrar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_borrar.Location = new System.Drawing.Point(199, 75);
            this.Lbl_borrar.Name = "Lbl_borrar";
            this.Lbl_borrar.Size = new System.Drawing.Size(65, 22);
            this.Lbl_borrar.TabIndex = 10;
            this.Lbl_borrar.Text = "Borrar";
            this.Lbl_borrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_editar
            // 
            this.Lbl_editar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_editar.Location = new System.Drawing.Point(111, 75);
            this.Lbl_editar.Name = "Lbl_editar";
            this.Lbl_editar.Size = new System.Drawing.Size(65, 22);
            this.Lbl_editar.TabIndex = 7;
            this.Lbl_editar.Text = "Editar";
            this.Lbl_editar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_guardar
            // 
            this.Lbl_guardar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_guardar.Location = new System.Drawing.Point(21, 75);
            this.Lbl_guardar.Name = "Lbl_guardar";
            this.Lbl_guardar.Size = new System.Drawing.Size(65, 22);
            this.Lbl_guardar.TabIndex = 1;
            this.Lbl_guardar.Text = "Guardar";
            this.Lbl_guardar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_guardar
            // 
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(21, 7);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(16, 26);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(46, 16);
            this.lbl_fecha.TabIndex = 12;
            this.lbl_fecha.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mesa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cliente";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(172, 25);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(172, 20);
            this.dtp_fecha.TabIndex = 15;
            // 
            // dgv_pedido
            // 
            this.dgv_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pedido.Location = new System.Drawing.Point(452, 157);
            this.dgv_pedido.Name = "dgv_pedido";
            this.dgv_pedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pedido.Size = new System.Drawing.Size(608, 231);
            this.dgv_pedido.TabIndex = 18;
            this.dgv_pedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pedido_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_cantBebida);
            this.panel1.Controls.Add(this.cmb_bebida);
            this.panel1.Controls.Add(this.txt_cantPlatillo);
            this.panel1.Controls.Add(this.cmb_platillo);
            this.panel1.Controls.Add(this.lbl_cantidadBebida);
            this.panel1.Controls.Add(this.lbl_bebida);
            this.panel1.Controls.Add(this.lbl_cantidadPlatillo);
            this.panel1.Controls.Add(this.lbl_platillo);
            this.panel1.Controls.Add(this.cmb_cliente);
            this.panel1.Controls.Add(this.cmb_mesa);
            this.panel1.Controls.Add(this.lbl_fecha);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtp_fecha);
            this.panel1.Location = new System.Drawing.Point(42, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 231);
            this.panel1.TabIndex = 19;
            // 
            // txt_cantBebida
            // 
            this.txt_cantBebida.Location = new System.Drawing.Point(172, 185);
            this.txt_cantBebida.Name = "txt_cantBebida";
            this.txt_cantBebida.Size = new System.Drawing.Size(89, 20);
            this.txt_cantBebida.TabIndex = 25;
            // 
            // cmb_bebida
            // 
            this.cmb_bebida.FormattingEnabled = true;
            this.cmb_bebida.Location = new System.Drawing.Point(172, 158);
            this.cmb_bebida.Name = "cmb_bebida";
            this.cmb_bebida.Size = new System.Drawing.Size(172, 21);
            this.cmb_bebida.TabIndex = 24;
            // 
            // txt_cantPlatillo
            // 
            this.txt_cantPlatillo.Location = new System.Drawing.Point(172, 132);
            this.txt_cantPlatillo.Name = "txt_cantPlatillo";
            this.txt_cantPlatillo.Size = new System.Drawing.Size(89, 20);
            this.txt_cantPlatillo.TabIndex = 23;
            // 
            // cmb_platillo
            // 
            this.cmb_platillo.FormattingEnabled = true;
            this.cmb_platillo.Location = new System.Drawing.Point(172, 105);
            this.cmb_platillo.Name = "cmb_platillo";
            this.cmb_platillo.Size = new System.Drawing.Size(172, 21);
            this.cmb_platillo.TabIndex = 22;
            // 
            // lbl_cantidadBebida
            // 
            this.lbl_cantidadBebida.AutoSize = true;
            this.lbl_cantidadBebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidadBebida.Location = new System.Drawing.Point(16, 198);
            this.lbl_cantidadBebida.Name = "lbl_cantidadBebida";
            this.lbl_cantidadBebida.Size = new System.Drawing.Size(135, 16);
            this.lbl_cantidadBebida.TabIndex = 21;
            this.lbl_cantidadBebida.Text = "Cantidad de Bebidas";
            // 
            // lbl_bebida
            // 
            this.lbl_bebida.AutoSize = true;
            this.lbl_bebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bebida.Location = new System.Drawing.Point(16, 168);
            this.lbl_bebida.Name = "lbl_bebida";
            this.lbl_bebida.Size = new System.Drawing.Size(52, 16);
            this.lbl_bebida.TabIndex = 20;
            this.lbl_bebida.Text = "Bebida";
            // 
            // lbl_cantidadPlatillo
            // 
            this.lbl_cantidadPlatillo.AutoSize = true;
            this.lbl_cantidadPlatillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidadPlatillo.Location = new System.Drawing.Point(16, 138);
            this.lbl_cantidadPlatillo.Name = "lbl_cantidadPlatillo";
            this.lbl_cantidadPlatillo.Size = new System.Drawing.Size(131, 16);
            this.lbl_cantidadPlatillo.TabIndex = 19;
            this.lbl_cantidadPlatillo.Text = "Cantidad de Platillos";
            // 
            // lbl_platillo
            // 
            this.lbl_platillo.AutoSize = true;
            this.lbl_platillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_platillo.Location = new System.Drawing.Point(16, 108);
            this.lbl_platillo.Name = "lbl_platillo";
            this.lbl_platillo.Size = new System.Drawing.Size(48, 16);
            this.lbl_platillo.TabIndex = 18;
            this.lbl_platillo.Text = "Platillo";
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(172, 78);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Size = new System.Drawing.Size(172, 21);
            this.cmb_cliente.TabIndex = 17;
            // 
            // cmb_mesa
            // 
            this.cmb_mesa.FormattingEnabled = true;
            this.cmb_mesa.Location = new System.Drawing.Point(172, 51);
            this.cmb_mesa.Name = "cmb_mesa";
            this.cmb_mesa.Size = new System.Drawing.Size(89, 21);
            this.cmb_mesa.TabIndex = 16;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(106, 62);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(83, 31);
            this.lbl_total.TabIndex = 20;
            this.lbl_total.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "------";
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1090, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_pedido);
            this.Controls.Add(this.Pnl_botones);
            this.Name = "Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.Pnl_botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedido)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_botones;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label Lbl_borrar;
        private System.Windows.Forms.Label Lbl_editar;
        private System.Windows.Forms.Label Lbl_guardar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.DataGridView dgv_pedido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_cliente;
        private System.Windows.Forms.ComboBox cmb_mesa;
        private System.Windows.Forms.TextBox txt_cantBebida;
        private System.Windows.Forms.ComboBox cmb_bebida;
        private System.Windows.Forms.TextBox txt_cantPlatillo;
        private System.Windows.Forms.ComboBox cmb_platillo;
        private System.Windows.Forms.Label lbl_cantidadBebida;
        private System.Windows.Forms.Label lbl_bebida;
        private System.Windows.Forms.Label lbl_cantidadPlatillo;
        private System.Windows.Forms.Label lbl_platillo;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label1;
    }
}

