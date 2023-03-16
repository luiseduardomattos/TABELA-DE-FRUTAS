using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TABELA_DE_FRUTAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEscolha_Click(object sender, EventArgs e)
        {
           Stgring txt = ";
            if (chkMACA.Checked)
            {
                txt += chkMACAxt + ",";
            }
            if (chkPERA.Checked)
            {
                txt += chkPERA+ ",";
            }
            if (ChkUVA.Checked)
            {
                txt += chkUVA+ ",";
            }
            if (chkABACAXI.Checked) 
            {
                txt += chkABACAXI + ",";
            }
            if ()
        }
    }
}
