using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Block_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double seiteA, seiteB, flaeche;

       private void btnBerechneDynamisch_Click(object sender, EventArgs e)
        {
            seiteA = Convert.ToDouble(tbxSeiteA.Text);
            seiteB = Convert.ToDouble(tbxSeiteB.Text);

            Rechteck rechteck = new Rechteck();
            rechteck.setSeiten(seiteA, seiteB);
            flaeche = rechteck.getFlaeche();
            tbxFlaeche.Text = flaeche.ToString();

       }

       private void btnBerechneStatisch_Click(object sender, EventArgs e)
        {
            Rechteck.seiteAStatic = Convert.ToDouble(tbxSeiteA.Text);
            Rechteck.seiteBStatic = Convert.ToDouble(tbxSeiteB.Text);
            Rechteck.calcFlaeche();
            flaeche = Rechteck.flaecheStatic;
            tbxFlaeche.Text = flaeche.ToString();
        }
    }
}
