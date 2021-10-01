using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
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
            Einlesen();
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
            p.Name = this.txtNamen.Text;
            p.Vorname = this.txtVornamen.Text;
            p.Plz = this.txtPLZ.Text;
            p.Ort = this.txtOrt.Text;
            p.Eintrittsjahr = Convert.ToInt32(this.txtEintrittsjahr.Text);
            p.Salaer = Convert.ToDouble(this.txtSalaer.Text);
            p.Pensum = Convert.ToDouble(this.txtPensum.Text);
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
            Form1 f = new Form1();
            if (f.ShowDialog(this) == DialogResult.OK)
            {
                Person p = f.GetNeuePerson();
                m_Personen.Add(p);
                OnLast(this, null);
            }

            f.Dispose();
        }

        private void Einlesen()
        {
            if (DialogResult.No == MessageBox.Show("Daten aus Datei laden?", "Laden", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {
                for (int i = 1; i <= 3; i++)
                {
                    Person p = new Person();
                    p.Name = "Neue Person (" + Convert.ToString(i) + ")";
                    m_Personen.Add(p);
                }
            }
            else
            {
                string sPfad = Application.StartupPath + "\\Person.pd7";
                if (DialogResult.No == MessageBox.Show("Datei von Applikationsordner laden?", "Informationen lesen",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "pd7 files (*.pd7)";
                    if (DialogResult.OK == ofd.ShowDialog())
                        sPfad = ofd.FileName;
                    else
                        return;
                }

                try
                {
                    FileStream s = new FileStream(sPfad, FileMode.Open);
                    BinaryFormatter binF = new BinaryFormatter();
                    m_Personen = (List<Person>) binF.Deserialize(s);
                    s.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void frmHaupt_FormClosing(object sender, FormClosingEventArgs e)
        {
            string sPfad = Application.StartupPath + "\\Person.pd7";
            if (DialogResult.No == MessageBox.Show("Dateien im Arbeitsverzeichnis speichern?", "Speichern",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "pdf7 files (*.pd7)|*.pd7";
                sfd.DefaultExt = "pdf7";
                if (DialogResult.OK == sfd.ShowDialog())
                    sPfad = sfd.FileName;
                else
                    return;
            }

            FileStream myStream = new FileStream(sPfad, FileMode.Create);
            BinaryFormatter binForm = new BinaryFormatter();
            binForm.Serialize(myStream, m_Personen);
            myStream.Close();
        }
    }
}
