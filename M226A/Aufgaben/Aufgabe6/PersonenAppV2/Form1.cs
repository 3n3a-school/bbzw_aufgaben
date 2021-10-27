using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonenAppV2
{
    public partial class Form1 : Form
    {
        private Person m_person = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form myHiddenForm = new Form();
            myHiddenForm.Text = "Hehe hidden Mode";
            myHiddenForm.SetBounds(10, 10, 200, 200);
            myHiddenForm.Show();
        }

        private void OnAbort(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }

        private void OnSave(object sender, EventArgs e)
        {
            m_person = new Person();
            m_person.Name = textBox1.Text;
            m_person.Vorname = textBox2.Text;
            DialogResult = DialogResult.OK;
        }

        public Person GetNeuePerson()
        {
            return m_person;
        }
    }
}
