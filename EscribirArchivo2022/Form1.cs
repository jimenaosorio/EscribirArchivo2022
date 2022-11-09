namespace EscribirArchivo2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\Home\\Documents\\herramientas.txt");
                sw.Write(txtTexto.Text);
                sw.Close();
                MessageBox.Show("Archivo Guardado");
                txtTexto.Clear();
            }
            catch(Exception ex)

            { MessageBox.Show("ERROR: " + ex.Message); }
        }
    }
}