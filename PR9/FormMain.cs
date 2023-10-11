using PR9.FolderModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public static ModelDB DB = new ModelDB();

        List<Table_Motobike> Motobikes = DB.Table_Motobike.ToList();
        int AccNumber = 0;

        private void Loading()
        {
            userControlName1.Fill(Motobikes[AccNumber]);
            userControlName2.Fill(Motobikes[AccNumber + 1]);
        }
        private void Loading(bool Insr)
        {
            if (Insr == true && Motobikes.Count > AccNumber + 2)
                AccNumber++;
            else if (Insr == false && 0 <= AccNumber -1)
                AccNumber--;
            else 
                return;

            Loading();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            Loading();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Loading(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loading(false);
        }
    }
}
