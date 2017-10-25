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
    public partial class Statisika : Form
    {
        List<Islaidos> irasai = new List<Islaidos>();
        public Statisika()
        {
            InitializeComponent();
        }
        public void UpdateBinding()
        {
            irasaiFoundListBox.DataSource = irasai;
            irasaiFoundListBox.DisplayMember = "FullInfo";
        }

        public void rodytibutton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            irasai = db.GetIslaidos(ieskotitextBox.Text);
            UpdateBinding();
        }

        private void VisaDatabutton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            irasai = db.GetALLData();
            UpdateBinding();
        }

        //private void Statisika_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'islaidosDataSet1.VisosIslaidos' table. You can move, or remove it, as needed.
        //    this.visosIslaidosTableAdapter1.Fill(this.islaidosDataSet1.VisosIslaidos);
        //    // TODO: This line of code loads data into the 'islaidosDataSet.VisosIslaidos' table. You can move, or remove it, as needed.
        //    this.visosIslaidosTableAdapter.Fill(this.islaidosDataSet.VisosIslaidos);

        //}
    }
}
