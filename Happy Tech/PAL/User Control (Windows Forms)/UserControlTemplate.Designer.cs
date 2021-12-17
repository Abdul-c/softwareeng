namespace Happy_Tech.PAL.User_Control__Windows_Forms_
{
    partial class UserControlTemplate
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
            this.tcTemplate = new System.Windows.Forms.TabControl();
            this.tpAddTemplate = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSection3 = new System.Windows.Forms.TextBox();
            this.txtSection2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSection1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTemplateName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpManageTemplate = new System.Windows.Forms.TabPage();
            this.txtSearchTemplateName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvTemplates = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tpEditAndRemoveTemplate = new System.Windows.Forms.TabPage();
            this.txtTemplateName1 = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSection33 = new System.Windows.Forms.TextBox();
            this.txtSection22 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSection11 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.tcTemplate.SuspendLayout();
            this.tpAddTemplate.SuspendLayout();
            this.tpManageTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemplates)).BeginInit();
            this.tpEditAndRemoveTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // tcTemplate
            // 
            this.tcTemplate.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcTemplate.Controls.Add(this.tpAddTemplate);
            this.tcTemplate.Controls.Add(this.tpManageTemplate);
            this.tcTemplate.Controls.Add(this.tpEditAndRemoveTemplate);
            this.tcTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTemplate.Location = new System.Drawing.Point(0, 0);
            this.tcTemplate.Name = "tcTemplate";
            this.tcTemplate.SelectedIndex = 0;
            this.tcTemplate.Size = new System.Drawing.Size(942, 601);
            this.tcTemplate.TabIndex = 0;
            // 
            // tpAddTemplate
            // 
            this.tpAddTemplate.Controls.Add(this.btnAdd);
            this.tpAddTemplate.Controls.Add(this.txtSection3);
            this.tpAddTemplate.Controls.Add(this.txtSection2);
            this.tpAddTemplate.Controls.Add(this.label5);
            this.tpAddTemplate.Controls.Add(this.label4);
            this.tpAddTemplate.Controls.Add(this.txtSection1);
            this.tpAddTemplate.Controls.Add(this.label3);
            this.tpAddTemplate.Controls.Add(this.txtTemplateName);
            this.tpAddTemplate.Controls.Add(this.label2);
            this.tpAddTemplate.Controls.Add(this.label1);
            this.tpAddTemplate.Location = new System.Drawing.Point(4, 4);
            this.tpAddTemplate.Name = "tpAddTemplate";
            this.tpAddTemplate.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddTemplate.Size = new System.Drawing.Size(934, 571);
            this.tpAddTemplate.TabIndex = 0;
            this.tpAddTemplate.Text = "Add Template";
            this.tpAddTemplate.UseVisualStyleBackColor = true;
            this.tpAddTemplate.Enter += new System.EventHandler(this.tpAddTemplate_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(129, 499);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 38);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSection3
            // 
            this.txtSection3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSection3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSection3.Location = new System.Drawing.Point(129, 370);
            this.txtSection3.Multiline = true;
            this.txtSection3.Name = "txtSection3";
            this.txtSection3.Size = new System.Drawing.Size(689, 89);
            this.txtSection3.TabIndex = 4;
            // 
            // txtSection2
            // 
            this.txtSection2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSection2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSection2.Location = new System.Drawing.Point(129, 249);
            this.txtSection2.Multiline = true;
            this.txtSection2.Name = "txtSection2";
            this.txtSection2.Size = new System.Drawing.Size(689, 89);
            this.txtSection2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Section # 3:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Section # 2:";
            // 
            // txtSection1
            // 
            this.txtSection1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSection1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSection1.Location = new System.Drawing.Point(129, 128);
            this.txtSection1.Multiline = true;
            this.txtSection1.Name = "txtSection1";
            this.txtSection1.Size = new System.Drawing.Size(689, 89);
            this.txtSection1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Section # 1:";
            // 
            // txtTemplateName
            // 
            this.txtTemplateName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTemplateName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtTemplateName.Location = new System.Drawing.Point(129, 72);
            this.txtTemplateName.Name = "txtTemplateName";
            this.txtTemplateName.Size = new System.Drawing.Size(689, 24);
            this.txtTemplateName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tamplate Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "../Add Template";
            // 
            // tpManageTemplate
            // 
            this.tpManageTemplate.Controls.Add(this.txtSearchTemplateName);
            this.tpManageTemplate.Controls.Add(this.label8);
            this.tpManageTemplate.Controls.Add(this.dgvTemplates);
            this.tpManageTemplate.Controls.Add(this.lblTotal);
            this.tpManageTemplate.Controls.Add(this.label6);
            this.tpManageTemplate.Controls.Add(this.label7);
            this.tpManageTemplate.Controls.Add(this.picSearch);
            this.tpManageTemplate.Location = new System.Drawing.Point(4, 4);
            this.tpManageTemplate.Name = "tpManageTemplate";
            this.tpManageTemplate.Padding = new System.Windows.Forms.Padding(3);
            this.tpManageTemplate.Size = new System.Drawing.Size(934, 571);
            this.tpManageTemplate.TabIndex = 1;
            this.tpManageTemplate.Text = "Manage Template";
            this.tpManageTemplate.UseVisualStyleBackColor = true;
            this.tpManageTemplate.Enter += new System.EventHandler(this.tpManageTemplate_Enter);
            // 
            // txtSearchTemplateName
            // 
            this.txtSearchTemplateName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchTemplateName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSearchTemplateName.Location = new System.Drawing.Point(261, 142);
            this.txtSearchTemplateName.Name = "txtSearchTemplateName";
            this.txtSearchTemplateName.Size = new System.Drawing.Size(393, 24);
            this.txtSearchTemplateName.TabIndex = 1;
            this.txtSearchTemplateName.TextChanged += new System.EventHandler(this.txtSearchTemplateName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "../Manage Template";
            // 
            // dgvTemplates
            // 
            this.dgvTemplates.AllowUserToAddRows = false;
            this.dgvTemplates.AllowUserToDeleteRows = false;
            this.dgvTemplates.AllowUserToResizeColumns = false;
            this.dgvTemplates.AllowUserToResizeRows = false;
            this.dgvTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTemplates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTemplates.BackgroundColor = System.Drawing.Color.White;
            this.dgvTemplates.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTemplates.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTemplates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTemplates.ColumnHeadersHeight = 45;
            this.dgvTemplates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTemplates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTemplates.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTemplates.EnableHeadersVisualStyles = false;
            this.dgvTemplates.Location = new System.Drawing.Point(7, 209);
            this.dgvTemplates.MultiSelect = false;
            this.dgvTemplates.Name = "dgvTemplates";
            this.dgvTemplates.ReadOnly = true;
            this.dgvTemplates.RowHeadersVisible = false;
            this.dgvTemplates.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTemplates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTemplates.ShowCellErrors = false;
            this.dgvTemplates.ShowEditingIcon = false;
            this.dgvTemplates.ShowRowErrors = false;
            this.dgvTemplates.Size = new System.Drawing.Size(919, 313);
            this.dgvTemplates.TabIndex = 0;
            this.dgvTemplates.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTemplates_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Template_Id";
            this.Column1.HeaderText = "Template #";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Template_Name";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Section_One";
            this.Column3.HeaderText = "Section # 1";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Section_Two";
            this.Column4.HeaderText = "Section # 2";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Section_Three";
            this.Column5.HeaderText = "Section # 3";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
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
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Template Name:";
            // 
            // tpEditAndRemoveTemplate
            // 
            this.tpEditAndRemoveTemplate.Controls.Add(this.txtTemplateName1);
            this.tpEditAndRemoveTemplate.Controls.Add(this.btnDelete);
            this.tpEditAndRemoveTemplate.Controls.Add(this.btnUpdate);
            this.tpEditAndRemoveTemplate.Controls.Add(this.txtSection33);
            this.tpEditAndRemoveTemplate.Controls.Add(this.txtSection22);
            this.tpEditAndRemoveTemplate.Controls.Add(this.label9);
            this.tpEditAndRemoveTemplate.Controls.Add(this.label10);
            this.tpEditAndRemoveTemplate.Controls.Add(this.txtSection11);
            this.tpEditAndRemoveTemplate.Controls.Add(this.label11);
            this.tpEditAndRemoveTemplate.Controls.Add(this.label12);
            this.tpEditAndRemoveTemplate.Controls.Add(this.label13);
            this.tpEditAndRemoveTemplate.Location = new System.Drawing.Point(4, 4);
            this.tpEditAndRemoveTemplate.Name = "tpEditAndRemoveTemplate";
            this.tpEditAndRemoveTemplate.Padding = new System.Windows.Forms.Padding(3);
            this.tpEditAndRemoveTemplate.Size = new System.Drawing.Size(934, 571);
            this.tpEditAndRemoveTemplate.TabIndex = 2;
            this.tpEditAndRemoveTemplate.Text = "Edit and Remove Template";
            this.tpEditAndRemoveTemplate.UseVisualStyleBackColor = true;
            this.tpEditAndRemoveTemplate.Enter += new System.EventHandler(this.tpEditAndRemoveTemplate_Enter);
            this.tpEditAndRemoveTemplate.Leave += new System.EventHandler(this.tpEditAndRemoveTemplate_Leave);
            // 
            // txtTemplateName1
            // 
            this.txtTemplateName1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTemplateName1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtTemplateName1.Location = new System.Drawing.Point(193, 77);
            this.txtTemplateName1.Name = "txtTemplateName1";
            this.txtTemplateName1.Size = new System.Drawing.Size(689, 24);
            this.txtTemplateName1.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(389, 504);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 38);
            this.btnDelete.TabIndex = 6;
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
            this.btnUpdate.Location = new System.Drawing.Point(193, 504);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(145, 38);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSection33
            // 
            this.txtSection33.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSection33.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSection33.Location = new System.Drawing.Point(193, 375);
            this.txtSection33.Multiline = true;
            this.txtSection33.Name = "txtSection33";
            this.txtSection33.Size = new System.Drawing.Size(689, 89);
            this.txtSection33.TabIndex = 4;
            // 
            // txtSection22
            // 
            this.txtSection22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSection22.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSection22.Location = new System.Drawing.Point(193, 254);
            this.txtSection22.Multiline = true;
            this.txtSection22.Name = "txtSection22";
            this.txtSection22.Size = new System.Drawing.Size(689, 89);
            this.txtSection22.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(190, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Section # 3:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(190, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Section # 2:";
            // 
            // txtSection11
            // 
            this.txtSection11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSection11.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSection11.Location = new System.Drawing.Point(193, 133);
            this.txtSection11.Multiline = true;
            this.txtSection11.Name = "txtSection11";
            this.txtSection11.Size = new System.Drawing.Size(689, 89);
            this.txtSection11.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(190, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Section # 1:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(190, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tamplate Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            this.label13.Location = new System.Drawing.Point(3, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(204, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "../Edit and Remove Template";
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
            // UserControlTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tcTemplate);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControlTemplate";
            this.Size = new System.Drawing.Size(942, 601);
            this.tcTemplate.ResumeLayout(false);
            this.tpAddTemplate.ResumeLayout(false);
            this.tpAddTemplate.PerformLayout();
            this.tpManageTemplate.ResumeLayout(false);
            this.tpManageTemplate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemplates)).EndInit();
            this.tpEditAndRemoveTemplate.ResumeLayout(false);
            this.tpEditAndRemoveTemplate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcTemplate;
        private System.Windows.Forms.TabPage tpAddTemplate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTemplateName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSection3;
        private System.Windows.Forms.TextBox txtSection2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSection1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tpManageTemplate;
        private System.Windows.Forms.TextBox txtSearchTemplateName;
        private System.Windows.Forms.DataGridView dgvTemplates;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tpEditAndRemoveTemplate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSection33;
        private System.Windows.Forms.TextBox txtSection22;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSection11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTemplateName1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
