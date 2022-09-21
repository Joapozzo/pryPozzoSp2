using System;
using System.Windows.Forms;

namespace pryPozzoSp2
{
    public partial class frmCabañas : Form
    {
        public frmCabañas()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTipo.SelectedIndex != -1)
            {
                lstPersonas.Enabled = true; 
            }
            else
            {
                lstPersonas.Enabled=false;
            }
        }

        private void lstPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPersonas.SelectedIndex != -1)
            {
                txtDias.Enabled = true;
            }
            else
            {
                txtDias.Enabled=false;
            }
        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            if (txtDias.Text != "")
            {
                mrcAdicionales.Enabled = true;
                mrcPago.Enabled = true;
            }
            else
            {
                mrcAdicionales.Enabled = false;
                mrcPago.Enabled = false;
            }

        }

        private void mrcPago_Enter(object sender, EventArgs e)
        {
            
            }

        private void optEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void optTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (optTarjeta.Checked == true)
            {
                lstTarjetas.Enabled = true;
            }
            else
            {
                lstTarjetas.Enabled=false;
            }
        }

        private void lstTarjetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTarjetas.SelectedIndex != -1)
            {
                txtNombre.Enabled = true;
                txtTelefono.Enabled = true;
            }
            else
            {
                txtNombre.Enabled = false;
                txtTelefono.Enabled = false;
            }
        }
    }
    
}
