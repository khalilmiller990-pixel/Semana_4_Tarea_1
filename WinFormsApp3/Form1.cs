namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private int conteo;
        private Label lblArchivo;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.AllowDrop = true;
            conteo = 0;
            lblArchivo = new Label();
        }

        // El diseñador usa += para suscribir estos métodos a los eventos del formulario y sus controles.
        // Aquí se usan manejadores con nombre; este formulario no contiene expresiones lambda (=>).
        private void timer1_Tick(object sender, EventArgs e)
        {
            conteo += 1; // Equivale a conteo++; suma uno por cada Tick.
            label1.Text = conteo.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tmr.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tmr.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmr.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (archivos != null && archivos.Length > 0)
            {
                // Ajusta el tamaño de cualquier imagen al control
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Usa StretchImage si prefieres llenar todo sin bordes

                // Libera la imagen anterior si existía
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                }

                pictureBox1.Image = Image.FromFile(archivos[0]);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = "No cambió nada xd "; label5.Refresh();
        }
    }
}


        

        
    

