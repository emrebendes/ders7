namespace ders7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 8; i < 20; i++)
                fontSize.Items.Add(i.ToString());
            foreach(FontFamily f in FontFamily.Families)
                fontName.Items.Add(f.Name.ToString());

            fontSize.SelectedIndex = 0;
            fontName.SelectedIndex = 0; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Dr=MessageBox.Show("Kayýt silinsin mi?"
                ,"Kayýt silme"
                ,MessageBoxButtons.OKCancel
                ,MessageBoxIcon.Question);
                
            if (Dr == DialogResult.OK) 
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else if(Dr==DialogResult.Cancel)
                MessageBox.Show("silmeyi iptal ettiniz..");
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            VeriGir veriGir = new VeriGir();
            DialogResult result= veriGir.ShowDialog();
            if (result == DialogResult.OK)
            {
                listBox1.Items.Add(veriGir.veri);
            }

        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            VeriGir veriGir=new VeriGir();
            veriGir.veri = listBox1.GetItemText(listBox1.SelectedItem);
            DialogResult result = veriGir.ShowDialog();
            if (result == DialogResult.OK)
            {
                listBox1.Items[listBox1.SelectedIndex] = veriGir.veri;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Font font = new Font(fontName.Text, Convert.ToInt32( fontSize.Text));
            button1.Font = font;
            foreach (Control c in this.Controls)
                c.Font = font;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            Ekle.Font = fontDialog1.Font;
            /*foreach (Control c in this.Controls)
                c.Font = fontDialog1.Font;*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            panel1.BackColor = colorDialog1.Color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            //openFileDialog1.FileNames
            Resim resim = new Resim();
            resim.BackgroundImageLayout = ImageLayout.Stretch;
            resim.BackgroundImage = new Bitmap(openFileDialog1.FileName);
            resim.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                Sil.Enabled = false;
                Guncelle.Enabled = false;
                güncelleToolStripMenuItem.Enabled = false;
                silToolStripMenuItem.Enabled = false;
            }
            else {
                Sil.Enabled = true;
                Guncelle.Enabled = true;
                güncelleToolStripMenuItem.Enabled = true;
                silToolStripMenuItem.Enabled = true;
            }
        }
    }
}