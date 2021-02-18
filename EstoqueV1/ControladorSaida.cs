using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueV1
{
    public partial class ControladorSaida : Form
    {
        public ControladorSaida()
        {
            InitializeComponent();
            txtSaida.Mask = "00/00/0000";
        }

        private void ControladorSaida_Load(object sender, EventArgs e)
        {

        }

        private void txtSaida_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&&e.KeyChar!=(char)8)
            {
                e.Handled = true;
            }
        }

        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

        }
    }
}
