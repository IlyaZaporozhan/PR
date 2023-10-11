using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PR9.FolderModel;

namespace PR9
{
    public partial class UserControlName : UserControl
    {
        public UserControlName()
        {
            InitializeComponent();
        }

        private void UserControlName_Load(object sender, EventArgs e)
        {

        }

       

        public void Fill(Table_Motobike Motobike)
        {
            labelIDData.Text = Motobike.ID.ToString();
            labelModelData.Text = Motobike.Model;
            labelBrandData.Text = Motobike.Brand;
            labelPriceData.Text = Motobike.Price.ToString();
            labelHorsepowerData.Text = Motobike.Horsepower.ToString();
            labelMileageData.Text = Motobike.Mileage.ToString();
            pictureBox1.Image = Image.FromFile($@"Pictures\{Motobike.Picture}");
        }
    }
}
