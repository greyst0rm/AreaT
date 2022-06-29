using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            double bs;
            double altura;
            double resultado;

            if (txtBase.Text != "" && txtAltura.Text != "")
            {
                bs = double.Parse(txtBase.Text);
                altura = double.Parse(txtAltura.Text);
                resultado = (double)bs * (double)altura / 2;
                lblResultado.Text = resultado.ToString();
            }
            
            
        }
    }
}
