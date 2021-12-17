using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Happy_Tech.BAL;
using Happy_Tech.DAL;

namespace Happy_Tech.PAL.User_Control__Windows_Forms_
{
    public partial class UserControlTemplate : UserControl
    {
        private string Id = "";

        public UserControlTemplate()
        {
            InitializeComponent();
        }

        public void EmptyBox()
        {
            tcTemplate.SelectedTab = tpAddTemplate;
            txtTemplateName.Clear();
            txtSection1.Clear();
            txtSection2.Clear();
            txtSection3.Clear();
        }

        private void EmptyBox1()
        {
            txtTemplateName1.Clear();
            txtSection11.Clear();
            txtSection22.Clear();
            txtSection33.Clear();
            Id = "";
        }

        private void picSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(picSearch, "Search");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTemplateName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter template name.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtSection1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter section # 1.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtSection2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter section # 2.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtSection3.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter section # 3.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Template template = new Template(txtTemplateName.Text.Trim(), txtSection1.Text.Trim(), txtSection2.Text.Trim(), txtSection3.Text.Trim());
                HappyTechDB.AddTemplate(template);
                EmptyBox();
            }
        }

        private void tpAddTemplate_Enter(object sender, EventArgs e)
        {
            EmptyBox();
        }

        private void tpManageTemplate_Enter(object sender, EventArgs e)
        {
            txtSearchTemplateName.Clear();
            dgvTemplates.Columns[0].Visible = false;
            HappyTechDB.DisplayAndSearch("SELECT * FROM Templates;", dgvTemplates);
            lblTotal.Text = dgvTemplates.Rows.Count.ToString();
        }

        private void txtSearchTemplateName_TextChanged(object sender, EventArgs e)
        {
            HappyTechDB.DisplayAndSearch("SELECT * FROM Templates WHERE Template_Name LIKE '%" + txtSearchTemplateName.Text + "%';", dgvTemplates);
            lblTotal.Text = dgvTemplates.Rows.Count.ToString();
        }

        private void dgvTemplates_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvTemplates.Rows[e.RowIndex];
                Id = row.Cells[0].Value.ToString();
                txtTemplateName1.Text = row.Cells[1].Value.ToString();
                txtSection11.Text = row.Cells[2].Value.ToString();
                txtSection22.Text = row.Cells[3].Value.ToString();
                txtSection33.Text = row.Cells[4].Value.ToString();
                tcTemplate.SelectedTab = tpEditAndRemoveTemplate;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Id == "")
            {
                MessageBox.Show("Please select row from table.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTemplateName1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter template name.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtSection11.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter section # 1.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtSection22.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter section # 2.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtSection33.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter section # 3.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Template template = new Template(txtTemplateName1.Text.Trim(), txtSection11.Text.Trim(), txtSection22.Text.Trim(), txtSection33.Text.Trim());
                HappyTechDB.UpdateTemplate(template, Id);
                EmptyBox1();
                tcTemplate.SelectedTab = tpManageTemplate;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Id == "")
            {
                MessageBox.Show("Please select row from table.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you want to delete this template?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    HappyTechDB.DeleteTemplate(Id);
                    EmptyBox1();
                    tcTemplate.SelectedTab = tpManageTemplate;
                }
            }
        }

        private void tpEditAndRemoveTemplate_Enter(object sender, EventArgs e)
        {
            if (Id == "")
                tcTemplate.SelectedTab = tpManageTemplate;
        }

        private void tpEditAndRemoveTemplate_Leave(object sender, EventArgs e)
        {
            EmptyBox1();
        }
    }
}
