using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using MyHRManagement.Forms;
using MyHRManagement.UserControls;

namespace MyHRManagement.UserControls
{
    public partial class HomePage : UserControl
    {
        private static HomePage _instancehpa;
        public static HomePage Instancehpg
        {
            get
            {
                if (_instancehpa == null)
                    _instancehpa = new HomePage();
                return _instancehpa;
            }
        }


        public HomePage()
        {
            InitializeComponent();
        }
    }
}
