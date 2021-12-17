using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Happy_Tech.DAL;

namespace Happy_Tech.PAL.User_Control__Windows_Forms_
{
    public partial class UserControlDashboard : UserControl
    {
        public UserControlDashboard()
        {
            InitializeComponent();
        }

        public void Count()
        {
            lblTemplate.Text = HappyTechDB.Count("SELECT COUNT(*) FROM Templates;").ToString();
            lblCode.Text = HappyTechDB.Count("SELECT COUNT(*) FROM Codes;").ToString();
            lblFeedback.Text = HappyTechDB.Count("SELECT COUNT(*) FROM Feedbacks;").ToString();
            lblUser.Text = HappyTechDB.Count("SELECT COUNT(*) FROM Users;").ToString();
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            Count();
        }
    }
}
