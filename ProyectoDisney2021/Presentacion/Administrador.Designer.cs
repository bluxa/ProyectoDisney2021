
namespace ProyectoDisney2021.Presentacion
{
    partial class Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdP = new System.Windows.Forms.TextBox();
            this.cmbCategoriaP = new System.Windows.Forms.ComboBox();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.txtImgP = new System.Windows.Forms.TextBox();
            this.txtIdVideoP = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(262, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Peliculas Al Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(211, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Pelicula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(211, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(211, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(211, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Link Imagen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(211, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Id Video";
            // 
            // txtIdP
            // 
            this.txtIdP.Location = new System.Drawing.Point(335, 124);
            this.txtIdP.Name = "txtIdP";
            this.txtIdP.Size = new System.Drawing.Size(214, 23);
            this.txtIdP.TabIndex = 6;
            // 
            // cmbCategoriaP
            // 
            this.cmbCategoriaP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaP.FormattingEnabled = true;
            this.cmbCategoriaP.Items.AddRange(new object[] {
            "Disney",
            "Pixar",
            "Marvel",
            "Star Wars",
            "National Geographic"});
            this.cmbCategoriaP.Location = new System.Drawing.Point(335, 164);
            this.cmbCategoriaP.Name = "cmbCategoriaP";
            this.cmbCategoriaP.Size = new System.Drawing.Size(214, 23);
            this.cmbCategoriaP.TabIndex = 7;
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(335, 202);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(214, 23);
            this.txtNombreP.TabIndex = 8;
            // 
            // txtImgP
            // 
            this.txtImgP.Location = new System.Drawing.Point(335, 242);
            this.txtImgP.Name = "txtImgP";
            this.txtImgP.Size = new System.Drawing.Size(214, 23);
            this.txtImgP.TabIndex = 9;
            // 
            // txtIdVideoP
            // 
            this.txtIdVideoP.Location = new System.Drawing.Point(335, 280);
            this.txtIdVideoP.Name = "txtIdVideoP";
            this.txtIdVideoP.Size = new System.Drawing.Size(214, 23);
            this.txtIdVideoP.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(369, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 51);
            this.button1.TabIndex = 11;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIdVideoP);
            this.Controls.Add(this.txtImgP);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.cmbCategoriaP);
            this.Controls.Add(this.txtIdP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdP;
        private System.Windows.Forms.ComboBox cmbCategoriaP;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.TextBox txtImgP;
        private System.Windows.Forms.TextBox txtIdVideoP;
        private System.Windows.Forms.Button button1;
    }
}