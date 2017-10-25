using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bandymasSuDuomenim
{
    public partial class Pagrindinis : Form
    {
        List<Islaidos> irasai = new List<Islaidos>();
        public Pagrindinis()
        {
            InitializeComponent();         
            LabelMaistui();
            LabelTransportui();
            labelKitos();
            piechartas();
            labelVisaSuma();
        }
      
        private void buttonPrideti_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.InsertIslaidos(Convert.ToInt32(islaidosMaistuitextBox.Text), Convert.ToInt32(islaidosTranspotuitextBox.Text), Convert.ToInt32(islaidosMaistuitextBox.Text));
            islaidosMaistuitextBox.Text = "";
            islaidosTranspotuitextBox.Text = "";
            islaidosKitostextBox.Text = "";
            LabelMaistui();
            LabelTransportui();
            labelKitos();
            
        }

        private void statistikabutton_Click(object sender, EventArgs e)
        {
            Statisika statisika = new Statisika();
            statisika.ShowDialog();
        }
        public void labelVisaSuma()
        {
            DataAccess db = new DataAccess();
            labelBiudzetas.Text = db.LabelBendrasBiudzetas().ToString();
        }
        public void LabelMaistui()
        {
        DataAccess db = new DataAccess();
            labelIslaidosMaistui.Text = db.PridetiLabelMaistui().ToString();
        }
        public void LabelTransportui()
        {
            DataAccess db = new DataAccess();
            labelIslaidosTransportui.Text = db.PridetiLabelTransportui().ToString();
        }
        public void labelKitos()
        {
            DataAccess db = new DataAccess();
            labelIslaidosKitos.Text = db.PridetiLabelKitos().ToString();
        }
        private void piechartas()
        {
            this.chart1.Series["Islaidos"].Points.Clear();
            this.chart1.Series["Islaidos"].Points.AddXY("Maistas", labelIslaidosMaistui.Text);
            this.chart1.Series["Islaidos"].Points.AddXY("Transportas", labelIslaidosTransportui.Text);
            this.chart1.Series["Islaidos"].Points.AddXY("Kitos", labelIslaidosKitos.Text);
        }

        
    }
}
