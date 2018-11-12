namespace Proyect
{
    partial class ModInv
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtn_Id = new System.Windows.Forms.RadioButton();
            this.rbtn_Prod = new System.Windows.Forms.RadioButton();
            this.tbx_Pventa = new System.Windows.Forms.TextBox();
            this.tbx_Pcompra = new System.Windows.Forms.TextBox();
            this.tbx_Cant = new System.Windows.Forms.TextBox();
            this.mtbx_Cad = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Det = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_Sel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbtn_Id);
            this.panel1.Controls.Add(this.rbtn_Prod);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 534);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar por";
            // 
            // rbtn_Id
            // 
            this.rbtn_Id.AutoSize = true;
            this.rbtn_Id.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Id.ForeColor = System.Drawing.Color.White;
            this.rbtn_Id.Location = new System.Drawing.Point(36, 104);
            this.rbtn_Id.Name = "rbtn_Id";
            this.rbtn_Id.Size = new System.Drawing.Size(49, 25);
            this.rbtn_Id.TabIndex = 1;
            this.rbtn_Id.TabStop = true;
            this.rbtn_Id.Text = "ID";
            this.rbtn_Id.UseVisualStyleBackColor = true;
            this.rbtn_Id.CheckedChanged += new System.EventHandler(this.rbtn_Id_CheckedChanged);
            // 
            // rbtn_Prod
            // 
            this.rbtn_Prod.AutoSize = true;
            this.rbtn_Prod.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Prod.ForeColor = System.Drawing.Color.White;
            this.rbtn_Prod.Location = new System.Drawing.Point(36, 77);
            this.rbtn_Prod.Name = "rbtn_Prod";
            this.rbtn_Prod.Size = new System.Drawing.Size(108, 25);
            this.rbtn_Prod.TabIndex = 0;
            this.rbtn_Prod.TabStop = true;
            this.rbtn_Prod.Text = "Producto";
            this.rbtn_Prod.UseVisualStyleBackColor = true;
            this.rbtn_Prod.CheckedChanged += new System.EventHandler(this.rbtn_Prod_CheckedChanged);
            // 
            // tbx_Pventa
            // 
            this.tbx_Pventa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Pventa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbx_Pventa.Location = new System.Drawing.Point(443, 320);
            this.tbx_Pventa.Name = "tbx_Pventa";
            this.tbx_Pventa.Size = new System.Drawing.Size(150, 15);
            this.tbx_Pventa.TabIndex = 29;
            // 
            // tbx_Pcompra
            // 
            this.tbx_Pcompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Pcompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbx_Pcompra.Location = new System.Drawing.Point(443, 289);
            this.tbx_Pcompra.Name = "tbx_Pcompra";
            this.tbx_Pcompra.Size = new System.Drawing.Size(150, 15);
            this.tbx_Pcompra.TabIndex = 28;
            // 
            // tbx_Cant
            // 
            this.tbx_Cant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Cant.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbx_Cant.Location = new System.Drawing.Point(443, 206);
            this.tbx_Cant.Name = "tbx_Cant";
            this.tbx_Cant.Size = new System.Drawing.Size(150, 15);
            this.tbx_Cant.TabIndex = 25;
            // 
            // mtbx_Cad
            // 
            this.mtbx_Cad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbx_Cad.Location = new System.Drawing.Point(443, 397);
            this.mtbx_Cad.Mask = "00/00/0000";
            this.mtbx_Cad.Name = "mtbx_Cad";
            this.mtbx_Cad.PromptChar = ' ';
            this.mtbx_Cad.Size = new System.Drawing.Size(150, 15);
            this.mtbx_Cad.TabIndex = 26;
            this.mtbx_Cad.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Caducidad";
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
            this.cmb_Det.Location = new System.Drawing.Point(443, 163);
            this.cmb_Det.Name = "cmb_Det";
            this.cmb_Det.Size = new System.Drawing.Size(150, 24);
            this.cmb_Det.Sorted = true;
            this.cmb_Det.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(264, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Precio de venta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(264, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Precio de compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Detalle";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(374, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_Sel
            // 
            this.cmb_Sel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Sel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_Sel.FormattingEnabled = true;
            this.cmb_Sel.Location = new System.Drawing.Point(265, 77);
            this.cmb_Sel.Name = "cmb_Sel";
            this.cmb_Sel.Size = new System.Drawing.Size(328, 24);
            this.cmb_Sel.TabIndex = 30;
            this.cmb_Sel.SelectedIndexChanged += new System.EventHandler(this.cmb_Sel_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Producto/ID";
            // 
            // ModInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 534);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_Sel);
            this.Controls.Add(this.tbx_Pventa);
            this.Controls.Add(this.tbx_Pcompra);
            this.Controls.Add(this.tbx_Cant);
            this.Controls.Add(this.mtbx_Cad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Det);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "ModInv";
            this.Text = "ModInv";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtn_Id;
        private System.Windows.Forms.RadioButton rbtn_Prod;
        private System.Windows.Forms.TextBox tbx_Pventa;
        private System.Windows.Forms.TextBox tbx_Pcompra;
        private System.Windows.Forms.TextBox tbx_Cant;
        private System.Windows.Forms.MaskedTextBox mtbx_Cad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Det;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_Sel;
        private System.Windows.Forms.Label label2;
    }
}