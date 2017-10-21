namespace Hoteleria
{
    partial class Ingrediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingrediente));
            this.Pnl_botones = new System.Windows.Forms.Panel();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.Lbl_borrar = new System.Windows.Forms.Label();
            this.Lbl_editar = new System.Windows.Forms.Label();
            this.Lbl_guardar = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.dgv_ingrediente = new System.Windows.Forms.DataGridView();
            this.pnl_ingrediente = new System.Windows.Forms.Panel();
            this.txt_descripcionIngrediente = new System.Windows.Forms.TextBox();
            this.cmb_UnidadMedida = new System.Windows.Forms.ComboBox();
            this.txt_nombreIngrediente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_nombreIngrediente = new System.Windows.Forms.Label();
            this.Pnl_botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ingrediente)).BeginInit();
            this.pnl_ingrediente.SuspendLayout();
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
            this.Pnl_botones.Location = new System.Drawing.Point(299, 12);
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
            // dgv_ingrediente
            // 
            this.dgv_ingrediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ingrediente.Location = new System.Drawing.Point(498, 165);
            this.dgv_ingrediente.Name = "dgv_ingrediente";
            this.dgv_ingrediente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ingrediente.Size = new System.Drawing.Size(403, 218);
            this.dgv_ingrediente.TabIndex = 13;
            this.dgv_ingrediente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Ingrediente_CellContentClick);
            // 
            // pnl_ingrediente
            // 
            this.pnl_ingrediente.Controls.Add(this.txt_descripcionIngrediente);
            this.pnl_ingrediente.Controls.Add(this.cmb_UnidadMedida);
            this.pnl_ingrediente.Controls.Add(this.txt_nombreIngrediente);
            this.pnl_ingrediente.Controls.Add(this.label1);
            this.pnl_ingrediente.Controls.Add(this.lbl_descripcion);
            this.pnl_ingrediente.Controls.Add(this.lbl_nombreIngrediente);
            this.pnl_ingrediente.Location = new System.Drawing.Point(40, 165);
            this.pnl_ingrediente.Name = "pnl_ingrediente";
            this.pnl_ingrediente.Size = new System.Drawing.Size(435, 218);
            this.pnl_ingrediente.TabIndex = 14;
            // 
            // txt_descripcionIngrediente
            // 
            this.txt_descripcionIngrediente.Location = new System.Drawing.Point(147, 83);
            this.txt_descripcionIngrediente.Multiline = true;
            this.txt_descripcionIngrediente.Name = "txt_descripcionIngrediente";
            this.txt_descripcionIngrediente.Size = new System.Drawing.Size(271, 120);
            this.txt_descripcionIngrediente.TabIndex = 19;
            // 
            // cmb_UnidadMedida
            // 
            this.cmb_UnidadMedida.FormattingEnabled = true;
            this.cmb_UnidadMedida.Items.AddRange(new object[] {
            "Kilogramo (kg)",
            "Hectogramo (hg)",
            "Decagramo (dag)",
            "Gramo (g)",
            "Decigramo (dg)\t",
            "Centigramo (cg)",
            "Miligramo (ml)",
            "----------------------------------------",
            "Kilolitro (kl)",
            "Hectolitro (hl)",
            "Decalitro (dal)",
            "Litro (L)",
            "Decilitro (dl)",
            "Centilitro (cl)",
            "Mililitro (ml)"});
            this.cmb_UnidadMedida.Location = new System.Drawing.Point(147, 56);
            this.cmb_UnidadMedida.Name = "cmb_UnidadMedida";
            this.cmb_UnidadMedida.Size = new System.Drawing.Size(146, 21);
            this.cmb_UnidadMedida.TabIndex = 18;
            // 
            // txt_nombreIngrediente
            // 
            this.txt_nombreIngrediente.Location = new System.Drawing.Point(147, 30);
            this.txt_nombreIngrediente.Name = "txt_nombreIngrediente";
            this.txt_nombreIngrediente.Size = new System.Drawing.Size(146, 20);
            this.txt_nombreIngrediente.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Unidad de Medida";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(17, 82);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(80, 16);
            this.lbl_descripcion.TabIndex = 14;
            this.lbl_descripcion.Text = "Descripción";
            // 
            // lbl_nombreIngrediente
            // 
            this.lbl_nombreIngrediente.AutoSize = true;
            this.lbl_nombreIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreIngrediente.Location = new System.Drawing.Point(17, 30);
            this.lbl_nombreIngrediente.Name = "lbl_nombreIngrediente";
            this.lbl_nombreIngrediente.Size = new System.Drawing.Size(57, 16);
            this.lbl_nombreIngrediente.TabIndex = 13;
            this.lbl_nombreIngrediente.Text = "Nombre";
            // 
            // Ingrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(940, 417);
            this.Controls.Add(this.pnl_ingrediente);
            this.Controls.Add(this.dgv_ingrediente);
            this.Controls.Add(this.Pnl_botones);
            this.Name = "Ingrediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingrediente";
            this.Load += new System.EventHandler(this.Ingrediente_Load);
            this.Pnl_botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ingrediente)).EndInit();
            this.pnl_ingrediente.ResumeLayout(false);
            this.pnl_ingrediente.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgv_ingrediente;
        private System.Windows.Forms.Panel pnl_ingrediente;
        private System.Windows.Forms.TextBox txt_nombreIngrediente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_nombreIngrediente;
        private System.Windows.Forms.TextBox txt_descripcionIngrediente;
        private System.Windows.Forms.ComboBox cmb_UnidadMedida;
    }
}