namespace Happy_Tech.PAL.User_Control__Windows_Forms_
{
    partial class UserControlCode
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tpEditAndRemoveCode = new System.Windows.Forms.TabPage();
            this.txtCodeBody1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodeTitle1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tpManageCode = new System.Windows.Forms.TabPage();
            this.txtSearchCodeTitle = new System.Windows.Forms.TextBox();
            this.dgvCodes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.tpAddCode = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCodeBody = new System.Windows.Forms.TextBox();
            this.txtCodeTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tcCode = new System.Windows.Forms.TabControl();
            this.tpEditAndRemoveCode.SuspendLayout();
            this.tpManageCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.tpAddCode.SuspendLayout();
            this.tcCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpEditAndRemoveCode
            // 
            this.tpEditAndRemoveCode.Controls.Add(this.txtCodeBody1);
            this.tpEditAndRemoveCode.Controls.Add(this.label4);
            this.tpEditAndRemoveCode.Controls.Add(this.txtCodeTitle1);
            this.tpEditAndRemoveCode.Controls.Add(this.label5);
            this.tpEditAndRemoveCode.Controls.Add(this.label9);
            this.tpEditAndRemoveCode.Controls.Add(this.btnDelete);
            this.tpEditAndRemoveCode.Controls.Add(this.btnUpdate);
            this.tpEditAndRemoveCode.Location = new System.Drawing.Point(4, 4);
            this.tpEditAndRemoveCode.Name = "tpEditAndRemoveCode";
            this.tpEditAndRemoveCode.Padding = new System.Windows.Forms.Padding(3);
            this.tpEditAndRemoveCode.Size = new System.Drawing.Size(934, 571);
            this.tpEditAndRemoveCode.TabIndex = 2;
            this.tpEditAndRemoveCode.Text = "Edit and Remove Code";
            this.tpEditAndRemoveCode.UseVisualStyleBackColor = true;
            this.tpEditAndRemoveCode.Enter += new System.EventHandler(this.tpEditAndRemoveCode_Enter);
            this.tpEditAndRemoveCode.Leave += new System.EventHandler(this.tpEditAndRemoveCode_Leave);
            // 
            // txtCodeBody1
            // 
            this.txtCodeBody1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodeBody1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtCodeBody1.Location = new System.Drawing.Point(129, 180);
            this.txtCodeBody1.Multiline = true;
            this.txtCodeBody1.Name = "txtCodeBody1";
            this.txtCodeBody1.Size = new System.Drawing.Size(689, 89);
            this.txtCodeBody1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Code Body:";
            // 
            // txtCodeTitle1
            // 
            this.txtCodeTitle1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodeTitle1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtCodeTitle1.Location = new System.Drawing.Point(129, 124);
            this.txtCodeTitle1.Name = "txtCodeTitle1";
            this.txtCodeTitle1.Size = new System.Drawing.Size(689, 24);
            this.txtCodeTitle1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Code Title:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "../Edit and Remove Code";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(325, 310);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 38);
            this.btnDelete.TabIndex = 4;
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
            this.btnUpdate.Location = new System.Drawing.Point(129, 310);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(145, 38);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tpManageCode
            // 
            this.tpManageCode.Controls.Add(this.txtSearchCodeTitle);
            this.tpManageCode.Controls.Add(this.dgvCodes);
            this.tpManageCode.Controls.Add(this.label8);
            this.tpManageCode.Controls.Add(this.lblTotal);
            this.tpManageCode.Controls.Add(this.label6);
            this.tpManageCode.Controls.Add(this.label7);
            this.tpManageCode.Controls.Add(this.picSearch);
            this.tpManageCode.Location = new System.Drawing.Point(4, 4);
            this.tpManageCode.Name = "tpManageCode";
            this.tpManageCode.Padding = new System.Windows.Forms.Padding(3);
            this.tpManageCode.Size = new System.Drawing.Size(934, 571);
            this.tpManageCode.TabIndex = 1;
            this.tpManageCode.Text = "Manage Code";
            this.tpManageCode.UseVisualStyleBackColor = true;
            this.tpManageCode.Enter += new System.EventHandler(this.tpManageCode_Enter);
            // 
            // txtSearchCodeTitle
            // 
            this.txtSearchCodeTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchCodeTitle.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSearchCodeTitle.Location = new System.Drawing.Point(261, 142);
            this.txtSearchCodeTitle.Name = "txtSearchCodeTitle";
            this.txtSearchCodeTitle.Size = new System.Drawing.Size(393, 24);
            this.txtSearchCodeTitle.TabIndex = 1;
            this.txtSearchCodeTitle.TextChanged += new System.EventHandler(this.txtSearchCodeTitle_TextChanged);
            // 
            // dgvCodes
            // 
            this.dgvCodes.AllowUserToAddRows = false;
            this.dgvCodes.AllowUserToDeleteRows = false;
            this.dgvCodes.AllowUserToResizeColumns = false;
            this.dgvCodes.AllowUserToResizeRows = false;
            this.dgvCodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCodes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCodes.BackgroundColor = System.Drawing.Color.White;
            this.dgvCodes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCodes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCodes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCodes.ColumnHeadersHeight = 45;
            this.dgvCodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCodes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCodes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCodes.EnableHeadersVisualStyles = false;
            this.dgvCodes.Location = new System.Drawing.Point(7, 209);
            this.dgvCodes.MultiSelect = false;
            this.dgvCodes.Name = "dgvCodes";
            this.dgvCodes.ReadOnly = true;
            this.dgvCodes.RowHeadersVisible = false;
            this.dgvCodes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCodes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCodes.ShowCellErrors = false;
            this.dgvCodes.ShowEditingIcon = false;
            this.dgvCodes.ShowRowErrors = false;
            this.dgvCodes.Size = new System.Drawing.Size(919, 313);
            this.dgvCodes.TabIndex = 0;
            this.dgvCodes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCodes_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Code_Id";
            this.Column1.HeaderText = "Code #";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Code_Title";
            this.Column2.HeaderText = "Title";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Code_Body";
            this.Column3.HeaderText = "Body";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "../Manage Code";
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
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Code Title:";
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
            // tpAddCode
            // 
            this.tpAddCode.Controls.Add(this.btnAdd);
            this.tpAddCode.Controls.Add(this.txtCodeBody);
            this.tpAddCode.Controls.Add(this.txtCodeTitle);
            this.tpAddCode.Controls.Add(this.label3);
            this.tpAddCode.Controls.Add(this.label2);
            this.tpAddCode.Controls.Add(this.label1);
            this.tpAddCode.Location = new System.Drawing.Point(4, 4);
            this.tpAddCode.Name = "tpAddCode";
            this.tpAddCode.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddCode.Size = new System.Drawing.Size(934, 571);
            this.tpAddCode.TabIndex = 0;
            this.tpAddCode.Text = "Add Code";
            this.tpAddCode.UseVisualStyleBackColor = true;
            this.tpAddCode.Enter += new System.EventHandler(this.tpAddCode_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(129, 310);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 38);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCodeBody
            // 
            this.txtCodeBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodeBody.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtCodeBody.Location = new System.Drawing.Point(129, 180);
            this.txtCodeBody.Multiline = true;
            this.txtCodeBody.Name = "txtCodeBody";
            this.txtCodeBody.Size = new System.Drawing.Size(689, 89);
            this.txtCodeBody.TabIndex = 2;
            // 
            // txtCodeTitle
            // 
            this.txtCodeTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodeTitle.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtCodeTitle.Location = new System.Drawing.Point(129, 124);
            this.txtCodeTitle.Name = "txtCodeTitle";
            this.txtCodeTitle.Size = new System.Drawing.Size(689, 24);
            this.txtCodeTitle.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Code Body:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Code Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "../Add Code";
            // 
            // tcCode
            // 
            this.tcCode.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcCode.Controls.Add(this.tpAddCode);
            this.tcCode.Controls.Add(this.tpManageCode);
            this.tcCode.Controls.Add(this.tpEditAndRemoveCode);
            this.tcCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCode.Location = new System.Drawing.Point(0, 0);
            this.tcCode.Name = "tcCode";
            this.tcCode.SelectedIndex = 0;
            this.tcCode.Size = new System.Drawing.Size(942, 601);
            this.tcCode.TabIndex = 0;
            // 
            // UserControlCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tcCode);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControlCode";
            this.Size = new System.Drawing.Size(942, 601);
            this.tpEditAndRemoveCode.ResumeLayout(false);
            this.tpEditAndRemoveCode.PerformLayout();
            this.tpManageCode.ResumeLayout(false);
            this.tpManageCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.tpAddCode.ResumeLayout(false);
            this.tpAddCode.PerformLayout();
            this.tcCode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabPage tpEditAndRemoveCode;
        private System.Windows.Forms.TextBox txtCodeBody1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodeTitle1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TabPage tpManageCode;
        private System.Windows.Forms.TextBox txtSearchCodeTitle;
        private System.Windows.Forms.DataGridView dgvCodes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.TabPage tpAddCode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCodeBody;
        private System.Windows.Forms.TextBox txtCodeTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tcCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
