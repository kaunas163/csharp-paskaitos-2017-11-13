using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_2_darbas_su_failu
{
    public partial class SkaiciavimaiForma : Form
    {
        public SkaiciavimaiForma(List<Darbuotojas> Darbuotojai)
        {
            InitializeComponent();
            textBox1.Text = Vidurkis(Darbuotojai).ToString();
        }

        public double Vidurkis(List<Darbuotojas> darbuotojai)
        {
            /* 1. kintamasis sumai saugoti
             * 2. eiti er sarasa ir prideeti suma
             * 3. padalinti suma is kiekio ir grazinti
             */
            return 0;
        }
    }
}
