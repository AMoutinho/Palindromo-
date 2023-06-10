using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

        #region Declaração de Variáveis
namespace Palindrome
{
    public partial class frmpalindromo : Form
    {
        int i,startchar,lastchar;
        public frmpalindromo()
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
            while (startchar<lastchar)
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
  
                    txt_digite.Focus();
                    i = 2;
                    break;
                }
            }
            if (i < 2)
            {
                lbl_rsp.Visible = true;
                lbl_rsp.Text = "É Palindromo";
                txt_digite.Focus();
            }
            else
            {
                i = 0;
            }
            if (i < 2)
            {
                lstbx_verificadas.Items.Add(txt_digite.Text + " - É palindromo");
            }
            else
            {
                lstbx_verificadas.Items.Add(txt_digite.Text + " - Não é palindromo");
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
    }
}
        #endregion