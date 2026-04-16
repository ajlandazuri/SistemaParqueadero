
namespace Parqueadero
{
    partial class frmRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrar));
            this.txtDueño = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn5 = new System.Windows.Forms.RadioButton();
            this.btn10 = new System.Windows.Forms.RadioButton();
            this.btn15 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDueño
            // 
            this.txtDueño.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDueño.Location = new System.Drawing.Point(185, 116);
            this.txtDueño.Multiline = true;
            this.txtDueño.Name = "txtDueño";
            this.txtDueño.Size = new System.Drawing.Size(244, 34);
            this.txtDueño.TabIndex = 0;
            this.txtDueño.TextChanged += new System.EventHandler(this.txtDueño_TextChanged);
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(185, 181);
            this.txtCedula.Multiline = true;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(244, 34);
            this.txtCedula.TabIndex = 1;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(186, 308);
            this.txtPlaca.Multiline = true;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(243, 34);
            this.txtPlaca.TabIndex = 4;
            this.txtPlaca.TextChanged += new System.EventHandler(this.txtPlaca_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(82, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dueño :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(82, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor Targeta :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(82, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cédula :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(82, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Placa : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btn5
            // 
            this.btn5.AutoSize = true;
            this.btn5.BackColor = System.Drawing.Color.Transparent;
            this.btn5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn5.Location = new System.Drawing.Point(229, 403);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(35, 20);
            this.btn5.TabIndex = 10;
            this.btn5.TabStop = true;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.CheckedChanged += new System.EventHandler(this.btn5_CheckedChanged);
            // 
            // btn10
            // 
            this.btn10.AutoSize = true;
            this.btn10.BackColor = System.Drawing.Color.Transparent;
            this.btn10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn10.Location = new System.Drawing.Point(297, 402);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(42, 20);
            this.btn10.TabIndex = 11;
            this.btn10.TabStop = true;
            this.btn10.Text = "10";
            this.btn10.UseVisualStyleBackColor = false;
            this.btn10.CheckedChanged += new System.EventHandler(this.btn10_CheckedChanged);
            // 
            // btn15
            // 
            this.btn15.AutoSize = true;
            this.btn15.BackColor = System.Drawing.Color.Transparent;
            this.btn15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn15.Location = new System.Drawing.Point(378, 403);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(42, 20);
            this.btn15.TabIndex = 12;
            this.btn15.TabStop = true;
            this.btn15.Text = "15";
            this.btn15.UseVisualStyleBackColor = false;
            this.btn15.CheckedChanged += new System.EventHandler(this.btn15_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(86, 554);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(343, 44);
            this.button2.TabIndex = 14;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(161, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 27);
            this.label2.TabIndex = 15;
            this.label2.Text = "Registrar Vehículo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(82, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Celular :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(185, 243);
            this.txtCelular.Multiline = true;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(244, 34);
            this.txtCelular.TabIndex = 16;
            this.txtCelular.TextChanged += new System.EventHandler(this.txtCelular_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtCelular);
            this.panel1.Controls.Add(this.txtDueño);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtPlaca);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn15);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(88, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 640);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(89, 485);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(340, 44);
            this.button3.TabIndex = 18;
            this.button3.Text = "Registrar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(699, 748);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistrar";
            this.Load += new System.EventHandler(this.frmRegistrar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton btn5;
        private System.Windows.Forms.RadioButton btn10;
        private System.Windows.Forms.RadioButton btn15;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtDueño;
        public System.Windows.Forms.TextBox txtCedula;
        public System.Windows.Forms.TextBox txtPlaca;
        public System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Button button3;
    }
}