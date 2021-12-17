using System;
using System.Data;
using System.Windows.Forms;
using Happy_Tech.DAL;
using Happy_Tech.BAL;
using Happy_Tech.Properties;

namespace Happy_Tech.PAL.User_Control__Windows_Forms_
{
    public partial class UserControlFeedback : UserControl
    {
        private string Id = "";

        public UserControlFeedback()
        {
            InitializeComponent();
        }

        public void EmptyBox()
        {
            tcFeedback.SelectedTab = tpAddFeedback;
            txtName.Clear();
            txtEmail.Clear();
            cbTemplate.Items.Clear();
            cbTemplate.Items.Add("-- SELECT --");
            HappyTechDB.FillComboBox("SELECT DISTINCT(Template_Name) FROM Templates;", cbTemplate);
            cbTemplate.SelectedIndex = 0;
            cbCode.Items.Clear();
            cbCode.Items.Add("-- SELECT --");
            HappyTechDB.FillComboBox("SELECT DISTINCT(Code_Title) FROM Codes;", cbCode);
            cbCode.SelectedIndex = 0;
            txtText.Clear();
        }

        private void EmptyBox1()
        {
            txtName1.Clear();
            txtEmail1.Clear();
            txtText1.Clear();
            Id = "";
        }

        private void picSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(picSearch, "Search");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter applicant name.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtEmail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter applicant email.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!EmailVerify.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter valid email.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cbTemplate.SelectedIndex == 0)
            {
                MessageBox.Show("Please select template name.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cbCode.SelectedIndex == 0)
            {
                MessageBox.Show("Please select code title.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtText.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter free text.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Feedback feedback = new Feedback(txtName.Text.Trim(), txtEmail.Text.Trim(), cbTemplate.SelectedItem.ToString(), cbCode.SelectedItem.ToString(), txtText.Text.Trim());
                HappyTechDB.AddFeedback(feedback);
                EmptyBox();
            }
        }

        private void tpAddFeedback_Enter(object sender, EventArgs e)
        {
            EmptyBox();
        }

        private void tpManageFeedback_Enter(object sender, EventArgs e)
        {
            txtSearchApplicantName.Clear();
            dgvApplicants.Columns["Column1"].Visible = false;
            HappyTechDB.DisplayAndSearch("SELECT Feedback_Id, Applicant_Name, Applicant_Email, Template_Name, Code_Title, Applicant_Free_Text FROM Feedbacks INNER JOIN Templates ON Feedbacks.Feedback_Template_Id = Templates.Template_Id INNER JOIN Codes ON Feedbacks.Feedback_Code_Id = Codes.Code_Id;", dgvApplicants);
            lblTotal.Text = dgvApplicants.Rows.Count.ToString();
        }

        private void txtSearchApplicantName_TextChanged(object sender, EventArgs e)
        {
            HappyTechDB.DisplayAndSearch("SELECT Feedback_Id, Applicant_Name, Applicant_Email, Template_Name, Code_Title, Applicant_Free_Text FROM Feedbacks INNER JOIN Templates ON Feedbacks.Feedback_Template_Id = Templates.Template_Id INNER JOIN Codes ON Feedbacks.Feedback_Code_Id = Codes.Code_Id WHERE Applicant_Name LIKE '%" + txtSearchApplicantName.Text + "%';", dgvApplicants);
            lblTotal.Text = dgvApplicants.Rows.Count.ToString();
        }

        private void dgvApplicants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvApplicants.Columns["Column7"].Index && e.RowIndex != -1)
            {
                DataGridViewRow row = dgvApplicants.Rows[e.RowIndex];

                easyHTMLReports.Clear();
                easyHTMLReports.AddImage(Resources.Transparent, "width = 100, style = 'float : right'");
                easyHTMLReports.AddString("<h1>HAPPY TECH</h1>");
                easyHTMLReports.AddString("<h2>Applicant # <i>" + row.Cells["Column1"].Value.ToString() + "</i></h2>");
                easyHTMLReports.AddLineBreak();
                easyHTMLReports.AddLineBreak();
                DataTable dt = new DataTable();
                dt.Columns.Add("Name");
                dt.Columns.Add("Email");
                dt.Columns.Add("Template");
                dt.Columns.Add("Code");
                dt.Columns.Add("Free Text");
                dt.Rows.Add(new object[] { row.Cells["Column2"].Value.ToString(), row.Cells["Column3"].Value.ToString(), row.Cells["Column4"].Value.ToString(), row.Cells["Column5"].Value.ToString(), row.Cells["Column6"].Value.ToString() });
                easyHTMLReports.AddDataTable(dt);
                easyHTMLReports.ShowPrintPreviewDialog();
                return;
            }

            if (e.ColumnIndex == dgvApplicants.Columns["Column8"].Index && e.RowIndex != -1)
            {
                DataGridViewRow row = dgvApplicants.Rows[e.RowIndex];

                Gmail.Send.SendEmail("software9344@gmail.com", "Table123", row.Cells["Column3"].Value.ToString(), row.Cells["Column5"].Value.ToString(), row.Cells["Column6"].Value.ToString());
                return;
            }

            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvApplicants.Rows[e.RowIndex];
                Id = row.Cells["Column1"].Value.ToString();
                txtName1.Text = row.Cells["Column2"].Value.ToString();
                txtEmail1.Text = row.Cells["Column3"].Value.ToString();
                cbTemplate1.Items.Clear();
                cbTemplate1.Items.Add("-- SELECT --");
                HappyTechDB.FillComboBox("SELECT DISTINCT(Template_Name) FROM Templates;", cbTemplate1);
                cbTemplate1.SelectedItem = row.Cells["Column4"].Value.ToString();
                cbCode1.Items.Clear();
                cbCode1.Items.Add("-- SELECT --");
                HappyTechDB.FillComboBox("SELECT DISTINCT(Code_Title) FROM Codes;", cbCode1);
                cbCode1.SelectedItem = row.Cells["Column5"].Value.ToString();
                txtText1.Text = row.Cells["Column6"].Value.ToString();
                tcFeedback.SelectedTab = tpEditAndRemoveFeedback;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Id == "")
            {
                MessageBox.Show("Please select row from table.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtName1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter applicant name.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtEmail1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter applicant email.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!EmailVerify.IsValidEmail(txtEmail1.Text))
            {
                MessageBox.Show("Please enter valid email.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cbTemplate1.SelectedIndex == 0)
            {
                MessageBox.Show("Please select template name.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cbCode1.SelectedIndex == 0)
            {
                MessageBox.Show("Please select code title.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtText1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter free text.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Feedback feedback = new Feedback(txtName1.Text.Trim(), txtEmail1.Text.Trim(), cbTemplate1.SelectedItem.ToString(), cbCode1.SelectedItem.ToString(), txtText1.Text.Trim());
                HappyTechDB.UpdateFeedback(feedback, Id);
                EmptyBox1();
                tcFeedback.SelectedTab = tpManageFeedback;
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
                DialogResult dialogResult = MessageBox.Show("Are you want to delete this applicant?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    HappyTechDB.DeleteFeedback(Id);
                    EmptyBox1();
                    tcFeedback.SelectedTab = tpManageFeedback;
                }
            }
        }

        private void tpEditAndRemoveFeedback_Enter(object sender, EventArgs e)
        {
            if (Id == "")
                tcFeedback.SelectedTab = tpManageFeedback;
        }

        private void tpEditAndRemoveFeedback_Leave(object sender, EventArgs e)
        {
            EmptyBox1();
        }
    }
}
