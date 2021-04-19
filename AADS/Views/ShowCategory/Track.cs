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
    public partial class Track : UserControl
    {
        public Track()
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
    }
}
