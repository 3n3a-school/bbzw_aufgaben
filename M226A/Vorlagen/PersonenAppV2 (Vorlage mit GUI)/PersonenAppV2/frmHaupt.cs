using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PersonenAppV2
{
    public partial class frmHaupt : Form
    {
        //Membervariablen
        List<Person> m_Personen = new List<Person>();
        private int m_Position = 0;


        /// <summary>
        /// Konstruktor
        /// </summary>
        public frmHaupt() { 
            InitializeComponent();
        }

        /// <summary>
        /// Ereignis das ausgeführt wird, wenn das Formular auf dem Bildschirm angezeigt wird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFormLoad(object sender, EventArgs e){
            for (int i = 1; i <= 3; i++)
            {
                Person p = new Person();
                p.Name = "Neue Person (" + Convert.ToString(i) + ")";
                m_Personen.Add(p);
            }
            m_Position = 1;
            FillForm();
        }

        /// <summary>
        /// Methode welche die via Membervariable m_Position indexierte Person auf dem Formular anzeigt
        /// </summary>
        private void FillForm() {
            txtNavigation.Text = Convert.ToString(m_Position) + "/" + Convert.ToString(m_Personen.Count);
            if (m_Personen.Count == 0)
                return;
            Person p = m_Personen[m_Position - 1];
            txtPersNr.Text = Convert.ToString(p.PersNr);
            txtNamen.Text = p.Name;
            txtVornamen.Text = p.Vorname;
        }
        /// <summary>
        /// Ereignis das ausgeführt wird, wenn der User auf "|<--" klickt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFirst(object sender, EventArgs e) {
            m_Position = 1;
            FillForm();
        }
        /// <summary>
        /// /Ereignis das ausgeführt wird, wenn der User auf "<--" klickt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnPrevious(object sender, EventArgs e) {
            if (m_Position > 1)
            {
                m_Position--;
                FillForm();
            }
        }
        /// <summary>
        /// Ereignis das ausgeführt wird, wenn der User auf "-->" klickt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnNext(object sender, EventArgs e)  {
            if (m_Position < m_Personen.Count)
            {
                m_Position++;
                FillForm();
            }
        }
        /// <summary>
        /// Ereignis das ausgeführt wird, wenn der User auf "-->|" klickt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLast(object sender, EventArgs e) {
            if (m_Personen.Count > 0)
            {
                m_Position = m_Personen.Count;
                FillForm();
            }
        }
        /// <summary>
        /// Ereignis das ausgeführt wird, wenn der User auf "Änderungen speichern" klickt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSave(object sender, EventArgs e) {
            Person p = m_Personen[m_Position - 1];
            p.Name = txtNamen.Text;
            p.Vorname = txtVornamen.Text;
            p.Plz = txtPLZ.Text;
            p.Ort = txtOrt.Text;
            p.Eintrittsjahr = Convert.ToInt32(txtEintrittsjahr.Text);
            p.Salaer = Convert.ToDouble(txtSalaer.Text);
            p.Pensum = Convert.ToDouble(txtPensum.Text);
        }
        /// <summary>
        /// Ereignis das ausgeführt wird, wenn der User auf "Änderungen verwerfen" klickt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAbort(object sender, EventArgs e) {
            FillForm();
        }

        private void OnDelete(object sender, EventArgs e)
        {
            m_Personen.RemoveAt(m_Position - 1); 
            if (m_Position > m_Personen.Count)
                m_Position--;
            FillForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            if (f.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of f's TextBox.
                this.textBox1.Text = testDialog.TextBox1.Text;
                this.textBox1.Text = testDialog.TextBox1.Text;

            }
            else
            {
                this.txtResult.Text = "Cancelled";
            }
            f.Dispose();
        }
    }
}
