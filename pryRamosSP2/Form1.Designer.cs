namespace pryRamosSP2
{
    partial class frmVentasDeTickets
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentasDeTickets));
            dtpHorario = new DateTimePicker();
            cmbTicket = new ComboBox();
            btnRegistrar = new Button();
            lstVentas = new ListBox();
            txtCantidad = new TextBox();
            lblTitulo = new Label();
            lblCantidad = new Label();
            lblTicket = new Label();
            lblFecha = new Label();
            SuspendLayout();
            // 
            // dtpHorario
            // 
            dtpHorario.Location = new Point(151, 108);
            dtpHorario.Name = "dtpHorario";
            dtpHorario.Size = new Size(186, 23);
            dtpHorario.TabIndex = 0;
            // 
            // cmbTicket
            // 
            cmbTicket.FormattingEnabled = true;
            cmbTicket.Location = new Point(151, 199);
            cmbTicket.Name = "cmbTicket";
            cmbTicket.Size = new Size(104, 23);
            cmbTicket.TabIndex = 1;
            cmbTicket.SelectedIndexChanged += cmbTicket_SelectedIndexChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(151, 241);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(97, 47);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lstVentas
            // 
            lstVentas.FormattingEnabled = true;
            lstVentas.Location = new Point(-1, 306);
            lstVentas.Name = "lstVentas";
            lstVentas.Size = new Size(428, 79);
            lstVentas.TabIndex = 3;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(151, 154);
            txtCantidad.Multiline = true;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(128, 23);
            txtCantidad.TabIndex = 4;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ButtonFace;
            lblTitulo.Location = new Point(45, 38);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(324, 37);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "GENERADOR DE TICKETS";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = Color.Transparent;
            lblCantidad.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblCantidad.ForeColor = SystemColors.ButtonFace;
            lblCantidad.Location = new Point(6, 154);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(139, 20);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Numero de ticket: ";
            // 
            // lblTicket
            // 
            lblTicket.AutoSize = true;
            lblTicket.BackColor = Color.Transparent;
            lblTicket.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblTicket.ForeColor = SystemColors.ButtonFace;
            lblTicket.Location = new Point(50, 196);
            lblTicket.Name = "lblTicket";
            lblTicket.Size = new Size(59, 20);
            lblTicket.TabIndex = 7;
            lblTicket.Text = "Ticket: ";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblFecha.ForeColor = SystemColors.ButtonFace;
            lblFecha.Location = new Point(45, 111);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(57, 20);
            lblFecha.TabIndex = 8;
            lblFecha.Text = "Fecha: ";
            // 
            // frmVentasDeTickets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(426, 379);
            Controls.Add(lblFecha);
            Controls.Add(lblTicket);
            Controls.Add(lblCantidad);
            Controls.Add(lblTitulo);
            Controls.Add(txtCantidad);
            Controls.Add(lstVentas);
            Controls.Add(btnRegistrar);
            Controls.Add(cmbTicket);
            Controls.Add(dtpHorario);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "frmVentasDeTickets";
            Text = "GENERADOR DE TICKETS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpHorario;
        private ComboBox cmbTicket;
        private Button btnRegistrar;
        private ListBox lstVentas;
        private TextBox txtCantidad;
        private Label lblTitulo;
        private Label lblCantidad;
        private Label lblTicket;
        private Label lblFecha;
    }
}
