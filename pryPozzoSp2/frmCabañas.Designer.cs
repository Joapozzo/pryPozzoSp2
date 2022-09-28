namespace pryPozzoSp2
{
    partial class frmCabañas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCabañas));
            this.mrcTipo = new System.Windows.Forms.GroupBox();
            this.lstPersonas = new System.Windows.Forms.ComboBox();
            this.lstTipo = new System.Windows.Forms.ComboBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.chkCocina = new System.Windows.Forms.CheckBox();
            this.mrcAdicionales = new System.Windows.Forms.GroupBox();
            this.chkTelevision = new System.Windows.Forms.CheckBox();
            this.chkHeladera = new System.Windows.Forms.CheckBox();
            this.mrcPago = new System.Windows.Forms.GroupBox();
            this.optTarjeta = new System.Windows.Forms.RadioButton();
            this.optEfectivo = new System.Windows.Forms.RadioButton();
            this.lblTarjetas = new System.Windows.Forms.Label();
            this.lstTarjetas = new System.Windows.Forms.ComboBox();
            this.mrcTitular = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblResumen = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.mrcTipo.SuspendLayout();
            this.mrcAdicionales.SuspendLayout();
            this.mrcPago.SuspendLayout();
            this.mrcTitular.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcTipo
            // 
            this.mrcTipo.Controls.Add(this.lstPersonas);
            this.mrcTipo.Controls.Add(this.lstTipo);
            this.mrcTipo.Controls.Add(this.txtDias);
            this.mrcTipo.Controls.Add(this.lblTipo);
            this.mrcTipo.Controls.Add(this.lblPersonas);
            this.mrcTipo.Controls.Add(this.lblDia);
            this.mrcTipo.Location = new System.Drawing.Point(12, 12);
            this.mrcTipo.Name = "mrcTipo";
            this.mrcTipo.Size = new System.Drawing.Size(512, 110);
            this.mrcTipo.TabIndex = 0;
            this.mrcTipo.TabStop = false;
            this.mrcTipo.Text = "Tipo de Cabaña";
            // 
            // lstPersonas
            // 
            this.lstPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstPersonas.Enabled = false;
            this.lstPersonas.FormattingEnabled = true;
            this.lstPersonas.Location = new System.Drawing.Point(216, 40);
            this.lstPersonas.Name = "lstPersonas";
            this.lstPersonas.Size = new System.Drawing.Size(96, 21);
            this.lstPersonas.TabIndex = 9;
            this.lstPersonas.SelectedIndexChanged += new System.EventHandler(this.lstPersonas_SelectedIndexChanged);
            // 
            // lstTipo
            // 
            this.lstTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTipo.FormattingEnabled = true;
            this.lstTipo.Items.AddRange(new object[] {
            "A",
            "B"});
            this.lstTipo.Location = new System.Drawing.Point(47, 40);
            this.lstTipo.Name = "lstTipo";
            this.lstTipo.Size = new System.Drawing.Size(88, 21);
            this.lstTipo.TabIndex = 8;
            this.lstTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtDias
            // 
            this.txtDias.Enabled = false;
            this.txtDias.Location = new System.Drawing.Point(377, 40);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(107, 20);
            this.txtDias.TabIndex = 7;
            this.txtDias.TextChanged += new System.EventHandler(this.txtDias_TextChanged);
            this.txtDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDias_KeyPress);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(6, 44);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo";
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Location = new System.Drawing.Point(159, 44);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(51, 13);
            this.lblPersonas.TabIndex = 1;
            this.lblPersonas.Text = "Personas";
            this.lblPersonas.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(343, 44);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(28, 13);
            this.lblDia.TabIndex = 0;
            this.lblDia.Text = "Dias";
            // 
            // chkCocina
            // 
            this.chkCocina.AutoSize = true;
            this.chkCocina.Location = new System.Drawing.Point(6, 35);
            this.chkCocina.Name = "chkCocina";
            this.chkCocina.Size = new System.Drawing.Size(59, 17);
            this.chkCocina.TabIndex = 3;
            this.chkCocina.Text = "Cocina";
            this.chkCocina.UseVisualStyleBackColor = true;
            // 
            // mrcAdicionales
            // 
            this.mrcAdicionales.Controls.Add(this.chkTelevision);
            this.mrcAdicionales.Controls.Add(this.chkHeladera);
            this.mrcAdicionales.Controls.Add(this.chkCocina);
            this.mrcAdicionales.Enabled = false;
            this.mrcAdicionales.Location = new System.Drawing.Point(12, 138);
            this.mrcAdicionales.Name = "mrcAdicionales";
            this.mrcAdicionales.Size = new System.Drawing.Size(175, 120);
            this.mrcAdicionales.TabIndex = 3;
            this.mrcAdicionales.TabStop = false;
            this.mrcAdicionales.Text = "Adicionales";
            // 
            // chkTelevision
            // 
            this.chkTelevision.AutoSize = true;
            this.chkTelevision.Location = new System.Drawing.Point(6, 81);
            this.chkTelevision.Name = "chkTelevision";
            this.chkTelevision.Size = new System.Drawing.Size(74, 17);
            this.chkTelevision.TabIndex = 5;
            this.chkTelevision.Text = "Television";
            this.chkTelevision.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            this.chkHeladera.AutoSize = true;
            this.chkHeladera.Location = new System.Drawing.Point(6, 58);
            this.chkHeladera.Name = "chkHeladera";
            this.chkHeladera.Size = new System.Drawing.Size(69, 17);
            this.chkHeladera.TabIndex = 4;
            this.chkHeladera.Text = "Heladera";
            this.chkHeladera.UseVisualStyleBackColor = true;
            // 
            // mrcPago
            // 
            this.mrcPago.Controls.Add(this.optTarjeta);
            this.mrcPago.Controls.Add(this.optEfectivo);
            this.mrcPago.Controls.Add(this.lblTarjetas);
            this.mrcPago.Controls.Add(this.lstTarjetas);
            this.mrcPago.Enabled = false;
            this.mrcPago.Location = new System.Drawing.Point(222, 138);
            this.mrcPago.Name = "mrcPago";
            this.mrcPago.Size = new System.Drawing.Size(302, 120);
            this.mrcPago.TabIndex = 6;
            this.mrcPago.TabStop = false;
            this.mrcPago.Text = "Formas de pago";
            this.mrcPago.Enter += new System.EventHandler(this.mrcPago_Enter);
            // 
            // optTarjeta
            // 
            this.optTarjeta.AutoSize = true;
            this.optTarjeta.Location = new System.Drawing.Point(6, 57);
            this.optTarjeta.Name = "optTarjeta";
            this.optTarjeta.Size = new System.Drawing.Size(58, 17);
            this.optTarjeta.TabIndex = 5;
            this.optTarjeta.TabStop = true;
            this.optTarjeta.Text = "Tarjeta";
            this.optTarjeta.UseVisualStyleBackColor = true;
            this.optTarjeta.CheckedChanged += new System.EventHandler(this.optTarjeta_CheckedChanged);
            // 
            // optEfectivo
            // 
            this.optEfectivo.AutoSize = true;
            this.optEfectivo.Location = new System.Drawing.Point(6, 34);
            this.optEfectivo.Name = "optEfectivo";
            this.optEfectivo.Size = new System.Drawing.Size(64, 17);
            this.optEfectivo.TabIndex = 4;
            this.optEfectivo.TabStop = true;
            this.optEfectivo.Text = "Efectivo";
            this.optEfectivo.UseVisualStyleBackColor = true;
            this.optEfectivo.CheckedChanged += new System.EventHandler(this.optEfectivo_CheckedChanged);
            // 
            // lblTarjetas
            // 
            this.lblTarjetas.AutoSize = true;
            this.lblTarjetas.Location = new System.Drawing.Point(123, 34);
            this.lblTarjetas.Name = "lblTarjetas";
            this.lblTarjetas.Size = new System.Drawing.Size(45, 13);
            this.lblTarjetas.TabIndex = 3;
            this.lblTarjetas.Text = "Tarjetas";
            this.lblTarjetas.Click += new System.EventHandler(this.label4_Click);
            // 
            // lstTarjetas
            // 
            this.lstTarjetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTarjetas.Enabled = false;
            this.lstTarjetas.FormattingEnabled = true;
            this.lstTarjetas.Items.AddRange(new object[] {
            "VISA",
            "MASTERCARD",
            "CORDOBESA"});
            this.lstTarjetas.Location = new System.Drawing.Point(126, 53);
            this.lstTarjetas.Name = "lstTarjetas";
            this.lstTarjetas.Size = new System.Drawing.Size(121, 21);
            this.lstTarjetas.TabIndex = 0;
            this.lstTarjetas.SelectedIndexChanged += new System.EventHandler(this.lstTarjetas_SelectedIndexChanged);
            // 
            // mrcTitular
            // 
            this.mrcTitular.Controls.Add(this.txtTelefono);
            this.mrcTitular.Controls.Add(this.txtNombre);
            this.mrcTitular.Controls.Add(this.lblTelefono);
            this.mrcTitular.Controls.Add(this.lblNombre);
            this.mrcTitular.Location = new System.Drawing.Point(12, 273);
            this.mrcTitular.Name = "mrcTitular";
            this.mrcTitular.Size = new System.Drawing.Size(512, 120);
            this.mrcTitular.TabIndex = 6;
            this.mrcTitular.TabStop = false;
            this.mrcTitular.Text = "Titular de la Reserva";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(64, 80);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(168, 20);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(64, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 20);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(6, 83);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 40);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumen.Location = new System.Drawing.Point(557, 22);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(0, 17);
            this.lblResumen.TabIndex = 7;
            this.lblResumen.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(449, 415);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmCabañas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 449);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.mrcTitular);
            this.Controls.Add(this.mrcPago);
            this.Controls.Add(this.mrcAdicionales);
            this.Controls.Add(this.mrcTipo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCabañas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva de Cabañas CASLA";
            this.Load += new System.EventHandler(this.frmCabañas_Load);
            this.mrcTipo.ResumeLayout(false);
            this.mrcTipo.PerformLayout();
            this.mrcAdicionales.ResumeLayout(false);
            this.mrcAdicionales.PerformLayout();
            this.mrcPago.ResumeLayout(false);
            this.mrcPago.PerformLayout();
            this.mrcTitular.ResumeLayout(false);
            this.mrcTitular.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.CheckBox chkCocina;
        private System.Windows.Forms.GroupBox mrcAdicionales;
        private System.Windows.Forms.CheckBox chkTelevision;
        private System.Windows.Forms.CheckBox chkHeladera;
        private System.Windows.Forms.GroupBox mrcPago;
        private System.Windows.Forms.RadioButton optTarjeta;
        private System.Windows.Forms.RadioButton optEfectivo;
        private System.Windows.Forms.Label lblTarjetas;
        private System.Windows.Forms.ComboBox lstTarjetas;
        private System.Windows.Forms.ComboBox lstTipo;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.GroupBox mrcTitular;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox lstPersonas;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Button btnAceptar;
    }
}

