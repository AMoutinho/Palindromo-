        #region Inicialização de Parametros
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
#endregion

        #region Declaração de Variáveis
namespace Palindrome
{
    public partial class VerificarPalindromo_03 : Form
    {
        int i, startchar, lastchar;
        public VerificarPalindromo_03()
        {
            InitializeComponent();
        }
        #endregion

        #region Teste Lógico - Atribuiçôes
        private void button1_Click(object sender, EventArgs e)
        {

            string low = txt_digite.Text.ToLower();
            low = low.Replace(" ", "");
            char[] character = new char[100];
            character = low.ToCharArray();
            startchar = 0;
            lastchar = character.Length - 1;
            while (startchar < lastchar)
            {
                if (character[startchar] == character[lastchar])
                {
                    startchar++;
                    lastchar--;
                }
                else
                {
                    lbl_rsp.Visible = true;
                    lbl_rsp.Text = "Não é Palindromo";
                    btn_verificar.Text = "Tentar novamente";
                    txt_digite.Focus();
                    i = 2;
                    break;
                }
            }
            if (i < 2)
            {
                lbl_rsp.Visible = true;
                lbl_rsp.Text = "É Palindromo";
                btn_verificar.Text = "Nova Verificação";
                txt_digite.Focus();
            }
            else
            {
                i = 0;
            }
            if (this.txt_digite.Text != "")
            {
                lstbx_verificadas.Items.Add(this.txt_digite.Text);
                // lstbx_verificadas.Items.Add(this.lbl_rsp.Text);   
            }
            else
            {
                MessageBox.Show("Entrar com uma palavra ou frase", "Error", MessageBoxButtons.OK);
            }

        }
        #endregion
        #region Sair
        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Limpar
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_digite.ResetText();
            lbl_rsp.ResetText();
        }
        #endregion

        #region Carregamento do Formulário
        private void VerificarPalindromo_03_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            txt_digite.GotFocus += new EventHandler(this.TextGotFocus);
            txt_digite.LostFocus += new EventHandler(this.TextLostFocus);
        }
        #endregion

        #region PlaceHolder
        public void TextGotFocus(object sender, EventArgs e)
        {
            TextBox digite = (TextBox)sender;
            if (txt_digite.Text == "Digite uma frase ou palavra aqui...")
            {
                txt_digite.Text = "";
                txt_digite.ForeColor = Color.Black;
            }
        }

        public void TextLostFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (txt_digite.Text == "")
            {
                txt_digite.Text = "Digite uma frase ou palavra aqui...";
                txt_digite.ForeColor = Color.LightGray;
            }
        }
    }

}
#endregion