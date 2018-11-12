namespace Proyect
{
    partial class Consulta_Base
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Base));
            this.rbtn_Id = new System.Windows.Forms.RadioButton();
            this.rbtn_Prod = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmb_Sel = new System.Windows.Forms.ComboBox();
            this.tbx_campo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtn_Id
            // 
            this.rbtn_Id.AutoSize = true;
            this.rbtn_Id.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Id.ForeColor = System.Drawing.Color.White;
            this.rbtn_Id.Location = new System.Drawing.Point(23, 157);
            this.rbtn_Id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_Id.Name = "rbtn_Id";
            this.rbtn_Id.Size = new System.Drawing.Size(40, 23);
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
            this.rbtn_Prod.Location = new System.Drawing.Point(23, 136);
            this.rbtn_Prod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_Prod.Name = "rbtn_Prod";
            this.rbtn_Prod.Size = new System.Drawing.Size(90, 23);
            this.rbtn_Prod.TabIndex = 1;
            this.rbtn_Prod.TabStop = true;
            this.rbtn_Prod.Text = "Producto";
            this.rbtn_Prod.UseVisualStyleBackColor = true;
            this.rbtn_Prod.CheckedChanged += new System.EventHandler(this.rbtn_Prod_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar por";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.rbtn_Prod);
            this.panel3.Controls.Add(this.rbtn_Id);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 299);
            this.panel3.TabIndex = 13;
            // 
            // cmb_Sel
            // 
            this.cmb_Sel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Sel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Sel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Sel.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_Sel.FormattingEnabled = true;
            this.cmb_Sel.Location = new System.Drawing.Point(228, 101);
            this.cmb_Sel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_Sel.Name = "cmb_Sel";
            this.cmb_Sel.Size = new System.Drawing.Size(247, 29);
            this.cmb_Sel.TabIndex = 32;
            this.cmb_Sel.Text = "PRODUCTO/ID";
            this.cmb_Sel.SelectedIndexChanged += new System.EventHandler(this.cmb_Sel_SelectedIndexChanged);
            this.cmb_Sel.Enter += new System.EventHandler(this.cmb_Sel_Enter);
            this.cmb_Sel.Leave += new System.EventHandler(this.cmb_Sel_Leave);
            // 
            // tbx_campo
            // 
            this.tbx_campo.BackColor = System.Drawing.SystemColors.Window;
            this.tbx_campo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_campo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_campo.ForeColor = System.Drawing.Color.Gray;
            this.tbx_campo.Location = new System.Drawing.Point(228, 158);
            this.tbx_campo.Name = "tbx_campo";
            this.tbx_campo.ReadOnly = true;
            this.tbx_campo.Size = new System.Drawing.Size(247, 20);
            this.tbx_campo.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(228, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 24);
            this.button1.TabIndex = 34;
            this.button1.Text = "CONSULTAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(505, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // Consulta_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 299);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbx_campo);
            this.Controls.Add(this.cmb_Sel);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consulta_Base";
            this.Opacity = 0.9D;
            this.Text = "Consulta_Base";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtn_Id;
        private System.Windows.Forms.RadioButton rbtn_Prod;
        private System.Windows.Forms.ComboBox cmb_Sel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbx_campo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}