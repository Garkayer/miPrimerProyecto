using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimerProyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            sbyte num1 = sbyte.Parse(txtNum1.Text);
            sbyte num2 = sbyte.Parse(txtNum2.Text);
            int resp = 0;
            if (optSuma.Checked)
            {
                resp = num1 + num2;
            }
            if (optResta.Checked)
            {
                resp = num1 - num2;
            }
            if (optMultiplicacion.Checked)
            {
                resp = num1 * num2;
            }
            if (optDivision.Checked)
            {
                resp = num1 / num2;
            }
            lblRespuesta.Text = " Respuesta: " + resp;
        }
    }
}