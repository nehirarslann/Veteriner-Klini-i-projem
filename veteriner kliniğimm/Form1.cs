namespace veteriner_kliniğimm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void hAKKIMIZDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HakkimizdaForm frm = new HakkimizdaForm();
            frm.Show();
            //yeni bir form oluşturur ve onu ekranda gösterir
        }
        private void hİZMETLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HizmetlerForm frm = new HizmetlerForm();
            frm.Show();
            //yeni bir form oluşturur ve onu ekranda gösterir
        }
        private void ekibimizToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void iLETİŞİMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IletisimForm frm = new IletisimForm();
            frm.Show();
            //yeni bir form oluşturur ve onu ekranda gösterir
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }
        private void galeriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            galeriForm frm = new galeriForm();
            frm.Show();
            //yeni bir form oluşturur ve onu ekranda gösterir
        }
    }
}
