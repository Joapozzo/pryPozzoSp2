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
            if (lstTipo.Text == "A")
            {
                lstPersonas.Items.Clear();
                lstPersonas.Items.Add(1);
                lstPersonas.Items.Add(2);
                lstPersonas.Items.Add(3);
                lstPersonas.Items.Add(4);
            }
            if (lstTipo.Text == "B")
            {
                lstPersonas.Items.Clear();
                lstPersonas.Items.Add(1);
                lstPersonas.Items.Add(2);
                lstPersonas.Items.Add(3);
                lstPersonas.Items.Add(4);
                lstPersonas.Items.Add(5);
                lstPersonas.Items.Add(6);
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
            if (optEfectivo.Checked)
            {
                txtNombre.Enabled = true;
                txtTelefono.Enabled = true;
            }
            else
            {
                txtNombre.Enabled = false;
                txtTelefono.Enabled =false;
            }
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese unicamente numeros");

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (lstTipo.SelectedIndex != -1) && ()
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            lblResumen.Text = lstTipo.Text + ", " + lstPersonas.Text + ", "; txtDias.Text + ", ";
        }
    }
    
}
