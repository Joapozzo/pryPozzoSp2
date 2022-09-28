using System;
using System.Linq.Expressions;
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
            optEfectivo.Enabled = true;
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
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int cont = 0;

            if (txtNombre.Text != "" && txtTelefono.Text != "" && lstTipo.SelectedIndex != -1 && lstPersonas.SelectedIndex != -1 && txtDias.Text != "")
            {
                lblResumen.Text = "\n" + "Nombre: " + txtNombre.Text + "\n" + "Telefono: " + txtTelefono.Text + "\n" + "Tipo de cabaña: " + lstTipo.Text + "\n" + "Cantidad de personas: "
                    + lstPersonas.Text + "\n" + "Cantidad de dias: " + txtDias.Text;
            }
            if (chkCocina.Checked==true) 
            {
                cont++;
            }
            if (chkHeladera.Checked==true)
            {  cont++;

            }
            if (chkHeladera.Checked == true)
            {
                cont++;
            }
            lblResumen2.Text = "Ha seleccionado " + cont + " Adicionales"; 


            if (optEfectivo.Checked == true)
            {
                lblResumen3.Text = "Forma de pago: " + "Efectivo";
            }
            else
            {
                if (optTarjeta.Checked == true && lstTarjetas.SelectedIndex ==1 || lstTarjetas.SelectedIndex == 2 || lstTarjetas.SelectedIndex == 0)
                {
                    lblResumen3.Text = "Forma de pago: " + "Tarjeta" + " " + this.lstTarjetas.Text;
                }
            }
            }


        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {


            if (txtTelefono.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese unicamente numeros");

            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64 || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <255)))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese unicamente letras");

            }
        }
    }

  
    }
    

