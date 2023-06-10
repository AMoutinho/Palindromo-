namespace Palindrome
{
    partial class frmpalindromo
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
            this.components = new System.ComponentModel.Container();
            this.txt_digite = new System.Windows.Forms.TextBox();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.lbl_rsp = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstbx_verificadas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_digite
            // 
            this.txt_digite.Location = new System.Drawing.Point(124, 18);
            this.txt_digite.MaxLength = 100;
            this.txt_digite.Name = "txt_digite";
            this.txt_digite.Size = new System.Drawing.Size(202, 20);
            this.txt_digite.TabIndex = 1;
            this.txt_digite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txt_digite, "Entre com uma frase ou uma palavra para verificação");
            // 
            // btn_verificar
            // 
            this.btn_verificar.Location = new System.Drawing.Point(378, 26);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(110, 23);
            this.btn_verificar.TabIndex = 2;
            this.btn_verificar.Text = "Verificar";
            this.toolTip1.SetToolTip(this.btn_verificar, "Verificar Palavra");
            this.btn_verificar.UseVisualStyleBackColor = true;
            this.btn_verificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_rsp
            // 
            this.lbl_rsp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_rsp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rsp.ForeColor = System.Drawing.Color.Red;
            this.lbl_rsp.Location = new System.Drawing.Point(9, 50);
            this.lbl_rsp.Name = "lbl_rsp";
            this.lbl_rsp.Size = new System.Drawing.Size(316, 38);
            this.lbl_rsp.TabIndex = 2;
            this.lbl_rsp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_rsp.Visible = false;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(378, 51);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(110, 23);
            this.btn_limpar.TabIndex = 3;
            this.btn_limpar.Text = "Limpar";
            this.toolTip1.SetToolTip(this.btn_limpar, "Limpar ");
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(378, 77);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(110, 23);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Text = "Sair";
            this.toolTip1.SetToolTip(this.btn_sair, "Sair do Programa");
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite Frase ou Palavra";
            // 
            // lstbx_verificadas
            // 
            this.lstbx_verificadas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lstbx_verificadas.FormattingEnabled = true;
            this.lstbx_verificadas.Location = new System.Drawing.Point(33, 153);
            this.lstbx_verificadas.Name = "lstbx_verificadas";
            this.lstbx_verificadas.Size = new System.Drawing.Size(455, 212);
            this.lstbx_verificadas.TabIndex = 6;
            this.toolTip1.SetToolTip(this.lstbx_verificadas, "Aqui ficam as palavras já verificadas");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Palavra e Frases verificadas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_digite);
            this.groupBox1.Controls.Add(this.lbl_rsp);
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 99);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserir Dados";
            // 
            // frmpalindromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(518, 411);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_verificar);
            this.Controls.Add(this.lstbx_verificadas);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_limpar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmpalindromo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificação de Palindromos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_digite;
        private System.Windows.Forms.Button btn_verificar;
        private System.Windows.Forms.Label lbl_rsp;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstbx_verificadas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

