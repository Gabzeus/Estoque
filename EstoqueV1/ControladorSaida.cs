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
    }
}
