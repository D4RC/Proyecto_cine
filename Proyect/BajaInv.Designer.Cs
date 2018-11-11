namespace Proyect
{
    partial class BajaInv
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
            this.rbtn_Prod = new System.Windows.Forms.RadioButton();
            this.rbtn_Id = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Sel = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgrid_Datos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Datos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtn_Prod
            // 
            this.rbtn_Prod.AutoSize = true;
            this.rbtn_Prod.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Prod.ForeColor = System.Drawing.Color.White;
            this.rbtn_Prod.Location = new System.Drawing.Point(38, 129);
            this.rbtn_Prod.Name = "rbtn_Prod";
            this.rbtn_Prod.Size = new System.Drawing.Size(108, 25);
            this.rbtn_Prod.TabIndex = 0;
            this.rbtn_Prod.TabStop = true;
            this.rbtn_Prod.Text = "Producto";
            this.rbtn_Prod.UseVisualStyleBackColor = true;
            this.rbtn_Prod.CheckedChanged += new System.EventHandler(this.rbtn_Prod_CheckedChanged);
            // 
            // rbtn_Id
            // 
            this.rbtn_Id.AutoSize = true;
            this.rbtn_Id.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Id.ForeColor = System.Drawing.Color.White;
            this.rbtn_Id.Location = new System.Drawing.Point(38, 156);
            this.rbtn_Id.Name = "rbtn_Id";
            this.rbtn_Id.Size = new System.Drawing.Size(49, 25);
            this.rbtn_Id.TabIndex = 1;
            this.rbtn_Id.TabStop = true;
            this.rbtn_Id.Text = "ID";
            this.rbtn_Id.UseVisualStyleBackColor = true;
            this.rbtn_Id.CheckedChanged += new System.EventHandler(this.rbtn_Id_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar por";
            // 
            // cmb_Sel
            // 
            this.cmb_Sel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_Sel.FormattingEnabled = true;
            this.cmb_Sel.Location = new System.Drawing.Point(12, 33);
            this.cmb_Sel.Name = "cmb_Sel";
            this.cmb_Sel.Size = new System.Drawing.Size(998, 24);
            this.cmb_Sel.TabIndex = 4;
            this.cmb_Sel.SelectedIndexChanged += new System.EventHandler(this.cmb_Sel_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(718, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 69);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(140, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 45);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(140, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 45);
            this.button3.TabIndex = 7;
            this.button3.Text = "Borrar producto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.dgrid_Datos);
            this.panel2.Controls.Add(this.cmb_Sel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1025, 180);
            this.panel2.TabIndex = 9;
            // 
            // dgrid_Datos
            // 
            this.dgrid_Datos.AllowUserToAddRows = false;
            this.dgrid_Datos.AllowUserToDeleteRows = false;
            this.dgrid_Datos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgrid_Datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrid_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Datos.Location = new System.Drawing.Point(12, 73);
            this.dgrid_Datos.Name = "dgrid_Datos";
            this.dgrid_Datos.ReadOnly = true;
            this.dgrid_Datos.RowTemplate.Height = 24;
            this.dgrid_Datos.Size = new System.Drawing.Size(998, 59);
            this.dgrid_Datos.TabIndex = 5;
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
            this.panel1.Size = new System.Drawing.Size(216, 270);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flowLayoutPanel2);
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(225, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 270);
            this.panel3.TabIndex = 11;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(124, 140);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(5, 45);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(124, 86);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(5, 45);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // BajaInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BajaInv";
            this.Text = "panel";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Datos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn_Prod;
        private System.Windows.Forms.RadioButton rbtn_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Sel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dgrid_Datos;
    }
}