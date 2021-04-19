using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AADS.Views.ShowCategory
{
    public partial class Polygon : UserControl
    {
        public Polygon()
        {
            InitializeComponent();
        }
        public UserControl currentControl;
        public void SetControl(UserControl control)
        {
            currentControl = control;
            panelShowDetail.Controls.Clear();
            panelShowDetail.Controls.Add(currentControl);
        }
        private void btnShowGeographic_Click(object sender, EventArgs e)
        {
            SetControl(ControlViews.GeographicCreation);
        }

        private void btnShowRestrictedArea_Click(object sender, EventArgs e)
        {

        }

        private void btnShowRD_Click(object sender, EventArgs e)
        {

        }
    }
}
