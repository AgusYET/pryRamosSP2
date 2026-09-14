namespace pryRamosSP2
{
    public partial class frmVentasDeTickets : Form
    {
        public frmVentasDeTickets()
        {
            InitializeComponent();
            cmbTicket.Items.Add("basico");
            cmbTicket.Items.Add("estandar");
            cmbTicket.Items.Add("premium");

        }
    
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, ingrese la cantidad de tickets.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbTicket.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un tipo de ticket.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            string fecha = dtpHorario.Value.ToShortDateString(); // Formato: DD/MM/AAAA
            string numeroTicket = txtCantidad.Text.Trim();
            string tipoTicket = cmbTicket.SelectedItem.ToString();

            
            string registro = $"{fecha} - {numeroTicket} - {tipoTicket}";

            
            lstVentas.Items.Add(registro);

           
            txtCantidad.Clear();
            cmbTicket.SelectedIndex = -1;
            txtCantidad.Focus();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {


        }


        private void cmbTicket_SelectedIndexChanged(object sender, EventArgs e)
        {
   
        }
    }
}
