using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_2_darbas_su_failu
{
    public partial class Form1 : Form
    {
        public List<Darbuotojas> Darbuotojai { get; private set; } = new List<Darbuotojas>();

        public Form1()
        {
            InitializeComponent();
        }

        private void iseiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void atidarytiFailaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forma = new OpenFileDialog();
            forma.Filter = "csv failas (*.csv)|*.csv";

            if (forma.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(forma.FileName);

                using (var sr = new StreamReader(forma.FileName))
                {
                    string eilute;
                    int indeksas = 0;

                    while ((eilute = sr.ReadLine()) != null)
                    {
                        if (indeksas == 0)
                        {
                            indeksas++;
                            continue;
                        }

                        //MessageBox.Show(eilute);
                        var isskaidyta = eilute.Split(';');
                        var vardas = isskaidyta[0];
                        var pavarde = isskaidyta[1];
                        var amzius = Convert.ToInt32(isskaidyta[2]);
                        var pareigos = isskaidyta[3];
                        var alga = Convert.ToDouble(isskaidyta[4]);

                        var darbuotojas = new Darbuotojas(vardas, pavarde, amzius, pareigos, alga);
                        Darbuotojai.Add(darbuotojas);
                    }

                    dataGridView1.DataSource = Darbuotojai;
                }
            }
        }

        private void skaiciuotiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forma = new SkaiciavimaiForma(Darbuotojai);
            forma.ShowDialog();
        }
    }
}
