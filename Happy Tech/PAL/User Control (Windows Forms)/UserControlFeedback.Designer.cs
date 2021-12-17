namespace Happy_Tech.PAL.User_Control__Windows_Forms_
{
    partial class UserControlFeedback
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tpEditAndRemoveFeedback = new System.Windows.Forms.TabPage();
            this.cbCode1 = new System.Windows.Forms.ComboBox();
            this.cbTemplate1 = new System.Windows.Forms.ComboBox();
            this.txtText1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmail1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tcFeedback = new System.Windows.Forms.TabControl();
            this.tpAddFeedback = new System.Windows.Forms.TabPage();
            this.cbCode = new System.Windows.Forms.ComboBox();
            this.cbTemplate = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpManageFeedback = new System.Windows.Forms.TabPage();
            this.txtSearchApplicantName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvApplicants = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.easyHTMLReports = new KimToo.EasyHTMLReports(this.components);
            this.tpEditAndRemoveFeedback.SuspendLayout();
            this.tcFeedback.SuspendLayout();
            this.tpAddFeedback.SuspendLayout();
            this.tpManageFeedback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotal.Location = new System.Drawing.Point(51, 525);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(20, 15);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "{?}";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(3, 525);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(257, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Applicant Name:";
            // 
            // tpEditAndRemoveFeedback
            // 
            this.tpEditAndRemoveFeedback.Controls.Add(this.cbCode1);
            this.tpEditAndRemoveFeedback.Controls.Add(this.cbTemplate1);
            this.tpEditAndRemoveFeedback.Controls.Add(this.txtText1);
            this.tpEditAndRemoveFeedback.Controls.Add(this.label9);
            this.tpEditAndRemoveFeedback.Controls.Add(this.label10);
            this.tpEditAndRemoveFeedback.Controls.Add(this.label11);
            this.tpEditAndRemoveFeedback.Controls.Add(this.txtEmail1);
            this.tpEditAndRemoveFeedback.Controls.Add(this.label12);
            this.tpEditAndRemoveFeedback.Controls.Add(this.txtName1);
            this.tpEditAndRemoveFeedback.Controls.Add(this.label13);
            this.tpEditAndRemoveFeedback.Controls.Add(this.label15);
            this.tpEditAndRemoveFeedback.Controls.Add(this.btnDelete);
            this.tpEditAndRemoveFeedback.Controls.Add(this.btnUpdate);
            this.tpEditAndRemoveFeedback.Location = new System.Drawing.Point(4, 4);
            this.tpEditAndRemoveFeedback.Name = "tpEditAndRemoveFeedback";
            this.tpEditAndRemoveFeedback.Padding = new System.Windows.Forms.Padding(3);
            this.tpEditAndRemoveFeedback.Size = new System.Drawing.Size(934, 571);
            this.tpEditAndRemoveFeedback.TabIndex = 2;
            this.tpEditAndRemoveFeedback.Text = "Edit and Remove Feedback";
            this.tpEditAndRemoveFeedback.UseVisualStyleBackColor = true;
            this.tpEditAndRemoveFeedback.Enter += new System.EventHandler(this.tpEditAndRemoveFeedback_Enter);
            this.tpEditAndRemoveFeedback.Leave += new System.EventHandler(this.tpEditAndRemoveFeedback_Leave);
            // 
            // cbCode1
            // 
            this.cbCode1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCode1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCode1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCode1.FormattingEnabled = true;
            this.cbCode1.Location = new System.Drawing.Point(129, 247);
            this.cbCode1.Name = "cbCode1";
            this.cbCode1.Size = new System.Drawing.Size(689, 25);
            this.cbCode1.TabIndex = 4;
            // 
            // cbTemplate1
            // 
            this.cbTemplate1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTemplate1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTemplate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTemplate1.FormattingEnabled = true;
            this.cbTemplate1.Location = new System.Drawing.Point(129, 190);
            this.cbTemplate1.Name = "cbTemplate1";
            this.cbTemplate1.Size = new System.Drawing.Size(689, 25);
            this.cbTemplate1.TabIndex = 3;
            // 
            // txtText1
            // 
            this.txtText1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtText1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtText1.Location = new System.Drawing.Point(129, 304);
            this.txtText1.Multiline = true;
            this.txtText1.Name = "txtText1";
            this.txtText1.Size = new System.Drawing.Size(689, 89);
            this.txtText1.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(126, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Free Text:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(126, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Code:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(126, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Template:";
            // 
            // txtEmail1
            // 
            this.txtEmail1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtEmail1.Location = new System.Drawing.Point(129, 134);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Size = new System.Drawing.Size(689, 24);
            this.txtEmail1.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(126, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Applicant Email:";
            // 
            // txtName1
            // 
            this.txtName1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtName1.Location = new System.Drawing.Point(129, 78);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(689, 24);
            this.txtName1.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(126, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Applicant Name:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            this.label15.Location = new System.Drawing.Point(3, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "../Add Feedback";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(325, 436);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 38);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(129, 436);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(145, 38);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tcFeedback
            // 
            this.tcFeedback.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcFeedback.Controls.Add(this.tpAddFeedback);
            this.tcFeedback.Controls.Add(this.tpManageFeedback);
            this.tcFeedback.Controls.Add(this.tpEditAndRemoveFeedback);
            this.tcFeedback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcFeedback.Location = new System.Drawing.Point(0, 0);
            this.tcFeedback.Name = "tcFeedback";
            this.tcFeedback.SelectedIndex = 0;
            this.tcFeedback.Size = new System.Drawing.Size(942, 601);
            this.tcFeedback.TabIndex = 0;
            // 
            // tpAddFeedback
            // 
            this.tpAddFeedback.Controls.Add(this.cbCode);
            this.tpAddFeedback.Controls.Add(this.cbTemplate);
            this.tpAddFeedback.Controls.Add(this.btnAdd);
            this.tpAddFeedback.Controls.Add(this.txtText);
            this.tpAddFeedback.Controls.Add(this.label5);
            this.tpAddFeedback.Controls.Add(this.label14);
            this.tpAddFeedback.Controls.Add(this.label4);
            this.tpAddFeedback.Controls.Add(this.txtEmail);
            this.tpAddFeedback.Controls.Add(this.label3);
            this.tpAddFeedback.Controls.Add(this.txtName);
            this.tpAddFeedback.Controls.Add(this.label2);
            this.tpAddFeedback.Controls.Add(this.label1);
            this.tpAddFeedback.Location = new System.Drawing.Point(4, 4);
            this.tpAddFeedback.Name = "tpAddFeedback";
            this.tpAddFeedback.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddFeedback.Size = new System.Drawing.Size(934, 571);
            this.tpAddFeedback.TabIndex = 0;
            this.tpAddFeedback.Text = "Add Feedback";
            this.tpAddFeedback.UseVisualStyleBackColor = true;
            this.tpAddFeedback.Enter += new System.EventHandler(this.tpAddFeedback_Enter);
            // 
            // cbCode
            // 
            this.cbCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCode.FormattingEnabled = true;
            this.cbCode.Location = new System.Drawing.Point(129, 243);
            this.cbCode.Name = "cbCode";
            this.cbCode.Size = new System.Drawing.Size(689, 25);
            this.cbCode.TabIndex = 4;
            // 
            // cbTemplate
            // 
            this.cbTemplate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTemplate.FormattingEnabled = true;
            this.cbTemplate.Location = new System.Drawing.Point(129, 186);
            this.cbTemplate.Name = "cbTemplate";
            this.cbTemplate.Size = new System.Drawing.Size(689, 25);
            this.cbTemplate.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(129, 432);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 38);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtText
            // 
            this.txtText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtText.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtText.Location = new System.Drawing.Point(129, 300);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(689, 89);
            this.txtText.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Free Text:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(126, 223);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Code:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Template:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtEmail.Location = new System.Drawing.Point(129, 130);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(689, 24);
            this.txtEmail.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Applicant Email:";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtName.Location = new System.Drawing.Point(129, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(689, 24);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Applicant Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "../Add Feedback";
            // 
            // tpManageFeedback
            // 
            this.tpManageFeedback.Controls.Add(this.txtSearchApplicantName);
            this.tpManageFeedback.Controls.Add(this.label8);
            this.tpManageFeedback.Controls.Add(this.dgvApplicants);
            this.tpManageFeedback.Controls.Add(this.lblTotal);
            this.tpManageFeedback.Controls.Add(this.label6);
            this.tpManageFeedback.Controls.Add(this.label7);
            this.tpManageFeedback.Controls.Add(this.picSearch);
            this.tpManageFeedback.Location = new System.Drawing.Point(4, 4);
            this.tpManageFeedback.Name = "tpManageFeedback";
            this.tpManageFeedback.Padding = new System.Windows.Forms.Padding(3);
            this.tpManageFeedback.Size = new System.Drawing.Size(934, 571);
            this.tpManageFeedback.TabIndex = 1;
            this.tpManageFeedback.Text = "Manage Feedback";
            this.tpManageFeedback.UseVisualStyleBackColor = true;
            this.tpManageFeedback.Enter += new System.EventHandler(this.tpManageFeedback_Enter);
            // 
            // txtSearchApplicantName
            // 
            this.txtSearchApplicantName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchApplicantName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSearchApplicantName.Location = new System.Drawing.Point(261, 142);
            this.txtSearchApplicantName.Name = "txtSearchApplicantName";
            this.txtSearchApplicantName.Size = new System.Drawing.Size(393, 24);
            this.txtSearchApplicantName.TabIndex = 1;
            this.txtSearchApplicantName.TextChanged += new System.EventHandler(this.txtSearchApplicantName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "../Manage Feedback";
            // 
            // dgvApplicants
            // 
            this.dgvApplicants.AllowUserToAddRows = false;
            this.dgvApplicants.AllowUserToDeleteRows = false;
            this.dgvApplicants.AllowUserToResizeColumns = false;
            this.dgvApplicants.AllowUserToResizeRows = false;
            this.dgvApplicants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvApplicants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApplicants.BackgroundColor = System.Drawing.Color.White;
            this.dgvApplicants.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvApplicants.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplicants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApplicants.ColumnHeadersHeight = 45;
            this.dgvApplicants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvApplicants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvApplicants.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvApplicants.EnableHeadersVisualStyles = false;
            this.dgvApplicants.Location = new System.Drawing.Point(7, 209);
            this.dgvApplicants.MultiSelect = false;
            this.dgvApplicants.Name = "dgvApplicants";
            this.dgvApplicants.ReadOnly = true;
            this.dgvApplicants.RowHeadersVisible = false;
            this.dgvApplicants.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvApplicants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplicants.ShowCellErrors = false;
            this.dgvApplicants.ShowEditingIcon = false;
            this.dgvApplicants.ShowRowErrors = false;
            this.dgvApplicants.Size = new System.Drawing.Size(919, 313);
            this.dgvApplicants.TabIndex = 0;
            this.dgvApplicants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApplicants_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Feedback_Id";
            this.Column1.HeaderText = "Feedback #";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Applicant_Name";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Applicant_Email";
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Template_Name";
            this.Column4.HeaderText = "Template";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Code_Title";
            this.Column5.HeaderText = "Code";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Applicant_Free_Text";
            this.Column6.HeaderText = "Free Text";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 20F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Happy_Tech.Properties.Resources.pdf_50px;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.ToolTipText = "Print";
            this.dataGridViewImageColumn1.Width = 114;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 20F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Happy_Tech.Properties.Resources.Gmail_logo_50px;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ToolTipText = "Mail";
            this.dataGridViewImageColumn2.Width = 29;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 20F;
            this.Column7.HeaderText = "";
            this.Column7.Image = global::Happy_Tech.Properties.Resources.pdf_50px;
            this.Column7.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.ToolTipText = "Print";
            // 
            // Column8
            // 
            this.Column8.FillWeight = 20F;
            this.Column8.HeaderText = "";
            this.Column8.Image = global::Happy_Tech.Properties.Resources.Gmail_logo_50px;
            this.Column8.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.ToolTipText = "Mail";
            // 
            // picSearch
            // 
            this.picSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.picSearch.Image = global::Happy_Tech.Properties.Resources.icons8_search_64px;
            this.picSearch.Location = new System.Drawing.Point(653, 142);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(26, 24);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch.TabIndex = 17;
            this.picSearch.TabStop = false;
            this.picSearch.MouseHover += new System.EventHandler(this.picSearch_MouseHover);
            // 
            // easyHTMLReports
            // 
            this.easyHTMLReports.AlternativeRowBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.easyHTMLReports.AlternativeRowGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.easyHTMLReports.HeaderBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.easyHTMLReports.HeaderFontColor = System.Drawing.Color.White;
            this.easyHTMLReports.HeaderGridColor = System.Drawing.Color.DodgerBlue;
            this.easyHTMLReports.RowDefaultBackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.easyHTMLReports.RowDefaultFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.easyHTMLReports.RowDefaultGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            // 
            // UserControlFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tcFeedback);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlFeedback";
            this.Size = new System.Drawing.Size(942, 601);
            this.tpEditAndRemoveFeedback.ResumeLayout(false);
            this.tpEditAndRemoveFeedback.PerformLayout();
            this.tcFeedback.ResumeLayout(false);
            this.tpAddFeedback.ResumeLayout(false);
            this.tpAddFeedback.PerformLayout();
            this.tpManageFeedback.ResumeLayout(false);
            this.tpManageFeedback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.TabPage tpEditAndRemoveFeedback;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabControl tcFeedback;
        private System.Windows.Forms.TabPage tpAddFeedback;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpManageFeedback;
        private System.Windows.Forms.TextBox txtSearchApplicantName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvApplicants;
        private System.Windows.Forms.ComboBox cbCode;
        private System.Windows.Forms.ComboBox cbTemplate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbCode1;
        private System.Windows.Forms.ComboBox cbTemplate1;
        private System.Windows.Forms.TextBox txtText1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmail1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private KimToo.EasyHTMLReports easyHTMLReports;
    }
}
