namespace Hoteleria
{
    partial class Bebida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bebida));
            this.Pnl_botones = new System.Windows.Forms.Panel();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.Lbl_borrar = new System.Windows.Forms.Label();
            this.Lbl_editar = new System.Windows.Forms.Label();
            this.Lbl_guardar = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.dgv_bebida = new System.Windows.Forms.DataGridView();
            this.pnl_bebida = new System.Windows.Forms.Panel();
            this.txt_costoBebida = new System.Windows.Forms.TextBox();
            this.txt_descripcionBebida = new System.Windows.Forms.TextBox();
            this.txt_nombreBebida = new System.Windows.Forms.TextBox();
            this.lbl_costo = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_nombreBebida = new System.Windows.Forms.Label();
            this.Pnl_botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bebida)).BeginInit();
            this.pnl_bebida.SuspendLayout();
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
            this.Pnl_botones.Location = new System.Drawing.Point(273, 12);
            this.Pnl_botones.Name = "Pnl_botones";
            this.Pnl_botones.Size = new System.Drawing.Size(283, 106);
            this.Pnl_botones.TabIndex = 12;
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
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
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
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
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
            // dgv_bebida
            // 
            this.dgv_bebida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bebida.Location = new System.Drawing.Point(411, 182);
            this.dgv_bebida.Name = "dgv_bebida";
            this.dgv_bebida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bebida.Size = new System.Drawing.Size(357, 201);
            this.dgv_bebida.TabIndex = 13;
            this.dgv_bebida.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pnl_bebida
            // 
            this.pnl_bebida.Controls.Add(this.txt_costoBebida);
            this.pnl_bebida.Controls.Add(this.txt_descripcionBebida);
            this.pnl_bebida.Controls.Add(this.txt_nombreBebida);
            this.pnl_bebida.Controls.Add(this.lbl_costo);
            this.pnl_bebida.Controls.Add(this.lbl_descripcion);
            this.pnl_bebida.Controls.Add(this.lbl_nombreBebida);
            this.pnl_bebida.Location = new System.Drawing.Point(23, 173);
            this.pnl_bebida.Name = "pnl_bebida";
            this.pnl_bebida.Size = new System.Drawing.Size(382, 210);
            this.pnl_bebida.TabIndex = 14;
            // 
            // txt_costoBebida
            // 
            this.txt_costoBebida.Location = new System.Drawing.Point(108, 50);
            this.txt_costoBebida.Name = "txt_costoBebida";
            this.txt_costoBebida.Size = new System.Drawing.Size(164, 20);
            this.txt_costoBebida.TabIndex = 18;
            // 
            // txt_descripcionBebida
            // 
            this.txt_descripcionBebida.Location = new System.Drawing.Point(108, 76);
            this.txt_descripcionBebida.Multiline = true;
            this.txt_descripcionBebida.Name = "txt_descripcionBebida";
            this.txt_descripcionBebida.Size = new System.Drawing.Size(259, 120);
            this.txt_descripcionBebida.TabIndex = 17;
            // 
            // txt_nombreBebida
            // 
            this.txt_nombreBebida.Location = new System.Drawing.Point(108, 24);
            this.txt_nombreBebida.Name = "txt_nombreBebida";
            this.txt_nombreBebida.Size = new System.Drawing.Size(164, 20);
            this.txt_nombreBebida.TabIndex = 16;
            // 
            // lbl_costo
            // 
            this.lbl_costo.AutoSize = true;
            this.lbl_costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costo.Location = new System.Drawing.Point(15, 50);
            this.lbl_costo.Name = "lbl_costo";
            this.lbl_costo.Size = new System.Drawing.Size(43, 16);
            this.lbl_costo.TabIndex = 15;
            this.lbl_costo.Text = "Costo";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(15, 76);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(80, 16);
            this.lbl_descripcion.TabIndex = 14;
            this.lbl_descripcion.Text = "Descripción";
            // 
            // lbl_nombreBebida
            // 
            this.lbl_nombreBebida.AutoSize = true;
            this.lbl_nombreBebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreBebida.Location = new System.Drawing.Point(15, 24);
            this.lbl_nombreBebida.Name = "lbl_nombreBebida";
            this.lbl_nombreBebida.Size = new System.Drawing.Size(57, 16);
            this.lbl_nombreBebida.TabIndex = 13;
            this.lbl_nombreBebida.Text = "Nombre";
            // 
            // Bebida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(792, 407);
            this.Controls.Add(this.pnl_bebida);
            this.Controls.Add(this.dgv_bebida);
            this.Controls.Add(this.Pnl_botones);
            this.Name = "Bebida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bebida";
            this.Pnl_botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bebida)).EndInit();
            this.pnl_bebida.ResumeLayout(false);
            this.pnl_bebida.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_botones;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label Lbl_borrar;
        private System.Windows.Forms.Label Lbl_editar;
        private System.Windows.Forms.Label Lbl_guardar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DataGridView dgv_bebida;
        private System.Windows.Forms.Panel pnl_bebida;
        private System.Windows.Forms.TextBox txt_costoBebida;
        private System.Windows.Forms.TextBox txt_descripcionBebida;
        private System.Windows.Forms.TextBox txt_nombreBebida;
        private System.Windows.Forms.Label lbl_costo;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_nombreBebida;
    }
}