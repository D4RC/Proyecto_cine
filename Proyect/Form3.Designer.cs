namespace Proyect
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_Id = new System.Windows.Forms.TextBox();
            this.tbx_Prod = new System.Windows.Forms.TextBox();
            this.cmb_Det = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbx_Cad = new System.Windows.Forms.MaskedTextBox();
            this.tbx_Cant = new System.Windows.Forms.TextBox();
            this.tbx_Pcompra = new System.Windows.Forms.TextBox();
            this.tbx_Pventa = new System.Windows.Forms.TextBox();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.btn_RegOtro = new System.Windows.Forms.Button();
            this.btn_BMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID de Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Detalle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio de compra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Precio de venta";
            // 
            // tbx_Id
            // 
            this.tbx_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbx_Id.Location = new System.Drawing.Point(194, 66);
            this.tbx_Id.Name = "tbx_Id";
            this.tbx_Id.Size = new System.Drawing.Size(150, 15);
            this.tbx_Id.TabIndex = 7;
            // 
            // tbx_Prod
            // 
            this.tbx_Prod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Prod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbx_Prod.Location = new System.Drawing.Point(194, 100);
            this.tbx_Prod.Name = "tbx_Prod";
            this.tbx_Prod.Size = new System.Drawing.Size(150, 15);
            this.tbx_Prod.TabIndex = 8;
            // 
            // cmb_Det
            // 
            this.cmb_Det.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Det.FormattingEnabled = true;
            this.cmb_Det.Items.AddRange(new object[] {
            "Gramos",
            "Kg",
            "Litros",
            "Ml",
            "Unidades"});
            this.cmb_Det.Location = new System.Drawing.Point(194, 137);
            this.cmb_Det.Name = "cmb_Det";
            this.cmb_Det.Size = new System.Drawing.Size(135, 24);
            this.cmb_Det.Sorted = true;
            this.cmb_Det.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(48, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 32);
            this.button1.TabIndex = 21;
            this.button1.Text = "Añadir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Caducidad";
            // 
            // mtbx_Cad
            // 
            this.mtbx_Cad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbx_Cad.Location = new System.Drawing.Point(194, 226);
            this.mtbx_Cad.Mask = "00/00/0000";
            this.mtbx_Cad.Name = "mtbx_Cad";
            this.mtbx_Cad.PromptChar = ' ';
            this.mtbx_Cad.Size = new System.Drawing.Size(100, 15);
            this.mtbx_Cad.TabIndex = 17;
            this.mtbx_Cad.ValidatingType = typeof(System.DateTime);
            // 
            // tbx_Cant
            // 
            this.tbx_Cant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Cant.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbx_Cant.Location = new System.Drawing.Point(194, 191);
            this.tbx_Cant.Name = "tbx_Cant";
            this.tbx_Cant.Size = new System.Drawing.Size(150, 15);
            this.tbx_Cant.TabIndex = 16;
            // 
            // tbx_Pcompra
            // 
            this.tbx_Pcompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Pcompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbx_Pcompra.Location = new System.Drawing.Point(194, 276);
            this.tbx_Pcompra.Name = "tbx_Pcompra";
            this.tbx_Pcompra.Size = new System.Drawing.Size(150, 15);
            this.tbx_Pcompra.TabIndex = 18;
            // 
            // tbx_Pventa
            // 
            this.tbx_Pventa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Pventa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbx_Pventa.Location = new System.Drawing.Point(194, 307);
            this.tbx_Pventa.Name = "tbx_Pventa";
            this.tbx_Pventa.Size = new System.Drawing.Size(150, 15);
            this.tbx_Pventa.TabIndex = 19;
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.BackColor = System.Drawing.Color.Silver;
            this.btn_Borrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Borrar.FlatAppearance.BorderSize = 0;
            this.btn_Borrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Borrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Borrar.ForeColor = System.Drawing.Color.Black;
            this.btn_Borrar.Location = new System.Drawing.Point(48, 382);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(174, 32);
            this.btn_Borrar.TabIndex = 20;
            this.btn_Borrar.Text = "Limpiar";
            this.btn_Borrar.UseVisualStyleBackColor = false;
            this.btn_Borrar.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // btn_RegOtro
            // 
            this.btn_RegOtro.BackColor = System.Drawing.Color.Silver;
            this.btn_RegOtro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_RegOtro.FlatAppearance.BorderSize = 0;
            this.btn_RegOtro.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_RegOtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegOtro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegOtro.ForeColor = System.Drawing.Color.Black;
            this.btn_RegOtro.Location = new System.Drawing.Point(228, 382);
            this.btn_RegOtro.Name = "btn_RegOtro";
            this.btn_RegOtro.Size = new System.Drawing.Size(174, 32);
            this.btn_RegOtro.TabIndex = 22;
            this.btn_RegOtro.Text = "Registrar otro ";
            this.btn_RegOtro.UseVisualStyleBackColor = false;
            this.btn_RegOtro.Visible = false;
            this.btn_RegOtro.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_BMenu
            // 
            this.btn_BMenu.BackColor = System.Drawing.Color.Silver;
            this.btn_BMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_BMenu.FlatAppearance.BorderSize = 0;
            this.btn_BMenu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_BMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BMenu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BMenu.ForeColor = System.Drawing.Color.Black;
            this.btn_BMenu.Location = new System.Drawing.Point(228, 420);
            this.btn_BMenu.Name = "btn_BMenu";
            this.btn_BMenu.Size = new System.Drawing.Size(174, 32);
            this.btn_BMenu.TabIndex = 23;
            this.btn_BMenu.Text = "Menú principal";
            this.btn_BMenu.UseVisualStyleBackColor = false;
            this.btn_BMenu.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 507);
            this.Controls.Add(this.btn_BMenu);
            this.Controls.Add(this.btn_RegOtro);
            this.Controls.Add(this.btn_Borrar);
            this.Controls.Add(this.tbx_Pventa);
            this.Controls.Add(this.tbx_Pcompra);
            this.Controls.Add(this.tbx_Cant);
            this.Controls.Add(this.mtbx_Cad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_Det);
            this.Controls.Add(this.tbx_Prod);
            this.Controls.Add(this.tbx_Id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form3";
            this.Text = "Altas de inventario";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_Id;
        private System.Windows.Forms.TextBox tbx_Prod;
        private System.Windows.Forms.ComboBox cmb_Det;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbx_Cad;
        private System.Windows.Forms.TextBox tbx_Cant;
        private System.Windows.Forms.TextBox tbx_Pcompra;
        private System.Windows.Forms.TextBox tbx_Pventa;
        private System.Windows.Forms.Button btn_Borrar;
        private System.Windows.Forms.Button btn_RegOtro;
        private System.Windows.Forms.Button btn_BMenu;
    }
}