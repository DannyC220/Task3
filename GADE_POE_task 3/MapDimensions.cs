using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE_POE_task_3
{
    public partial class MapDimensions: Form
    {
        public MapDimensions()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                int width = Convert.ToInt32(txtMapWidth.Text);
                int height = Convert.ToInt32(txtMapHeight.Text);

                this.Hide();
                FrmMain frm = new FrmMain(width, height);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Invalid width or height entered!");
            }
        }

        private void MapDimensions_Load(object sender, EventArgs e)
        {

        }
    }
}
