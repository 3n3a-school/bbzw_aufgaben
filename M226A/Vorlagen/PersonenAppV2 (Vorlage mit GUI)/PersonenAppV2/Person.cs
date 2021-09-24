using System;
using System.Windows.Forms;

namespace PersonenAppV2
{
    public class Person
    {
        static int sAnzahlPersonen = 0;
        static double MAXSALAER = 99999.95;
        static int MINYEAR = 1985;
        public Person()
        {
            PersNr = ++sAnzahlPersonen;
            Anrede = "Frau";
            Name = "Neue Person";
            Vorname = "";
            Plz = "6000";
            Ort = "Luzern";
            Eintrittsjahr = DateTime.Now.Year;
            Salaer = 5000.00;
            Pensum = 100.00;
        }
        public Person(int PersNr)
        {
            Anrede = "Frau";
            this.PersNr = ++sAnzahlPersonen;
            Name = "Neue Person";
            Vorname = "";
            Plz = "6000";
            Ort = "Luzern";
            Eintrittsjahr = DateTime.Now.Year;
            Salaer = 5000.00;
            Pensum = 100.00;
        }
        public Person(string Anredn, string Namen, string Vorname)
        {
            this.Anrede = Anrede;
            this.PersNr =++sAnzahlPersonen;
            this.Name = Namen;
            this.Vorname = Vorname;
            Plz = "6000";
            Ort = "Luzern";
            Eintrittsjahr = DateTime.Now.Year;
            Salaer = 5000.00;
            Pensum = 100.00;
        }
        public Person(string Namen, string Vornamen, int Eintrittsjahr)
        {
            this.Anrede = Anrede;
            this.PersNr = ++sAnzahlPersonen;
            this.Name = Name;
            this.Vorname = Vorname;
            Plz = "6000";
            Ort = "Luzern";
            this.Eintrittsjahr = Eintrittsjahr;
            Salaer = 5000.00;
            Pensum = 100.00;
        }
        private int m_PersNr { get; set; }
        public int PersNr { get; set; }
        private string m_Anrede { get; set; }
        public string Anrede { get; set; }
        private string m_Name { get; set; }
        public string Name { get; set; }
        private string m_Vorname { get; set; }
        public string Vorname { get; set; }
        private string m_Plz { get; set; }
        public string Plz { get; set; }
        private string m_Ort { get; set; }
        public string Ort { get; set; }
        private int m_Eintrittsjahr { get; set; }
        public int Eintrittsjahr { 
            get {
                return m_Eintrittsjahr;
            } 
            set{
                int currentYear = DateTime.Now.Year;
                switch (value)
                {
                    case int v when v < 1975:
                        m_Eintrittsjahr = 1975;
                        MessageBox.Show($"Date Needs to be in Range 1975 {currentYear}");
                        break;
                    case int v when v > currentYear:
                        m_Eintrittsjahr = currentYear;
                        MessageBox.Show($"Date Needs to be in Range 1975 {currentYear}");
                        break;
                    default:
                        m_Eintrittsjahr = value;
                        break;
                }
            } 
        }
        private double m_Salaer { get; set; }
        public double Salaer { 
            get {
                return m_Salaer;
            }
            set
            {
                const double kleinstesJahr = 0.00;
                const double grosstesJahr = 99999.95;
                void ShowMsg (double min = kleinstesJahr, double max = grosstesJahr)
                {
                    MessageBox.Show($"Salaer needs to be in Range {min} to {max}");
                }
               if (value > kleinstesJahr && value < grosstesJahr)
                {
                    m_Salaer = value;
                }
               else if (value > kleinstesJahr)
                {
                    m_Salaer = kleinstesJahr;
                    ShowMsg();
                }
               else if (value < grosstesJahr)
                {
                    m_Salaer = grosstesJahr;
                    ShowMsg();
                }
            }
        }
        private double m_Pensum { get; set; }
        public double Pensum { get; set; }
        public static double CalculateLohn(double Salaer, int Pensum)
        {
            return Salaer * (Pensum / 100);
        }
    }
}
