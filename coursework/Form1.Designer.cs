namespace coursework
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnAddNew = new Button();
            btnView = new Button();
            btnViewByRole = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            Telephone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            AdditionalInformation = new DataGridViewTextBoxColumn();
            bindingSource1 = new BindingSource(components);
            mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(24, 52);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(94, 29);
            btnAddNew.TabIndex = 0;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(136, 52);
            btnView.Name = "btnView";
            btnView.Size = new Size(94, 29);
            btnView.TabIndex = 1;
            btnView.Text = "View ";
            btnView.UseVisualStyleBackColor = true;
            // 
            // btnViewByRole
            // 
            btnViewByRole.Location = new Point(393, 52);
            btnViewByRole.Name = "btnViewByRole";
            btnViewByRole.Size = new Size(110, 29);
            btnViewByRole.TabIndex = 2;
            btnViewByRole.Text = "View By Role ";
            btnViewByRole.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(524, 53);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(638, 53);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(254, 53);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(110, 28);
            comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 6;
            label1.Text = "Menu";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, ColumnName, Telephone, Email, Role, AdditionalInformation });
            dataGridView1.Location = new Point(24, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(911, 248);
            dataGridView1.TabIndex = 7;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Name";
            ColumnName.MinimumWidth = 6;
            ColumnName.Name = "ColumnName";
            ColumnName.Width = 125;
            // 
            // Telephone
            // 
            Telephone.HeaderText = "Telephone";
            Telephone.MinimumWidth = 6;
            Telephone.Name = "Telephone";
            Telephone.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // Role
            // 
            Role.HeaderText = "Role";
            Role.MinimumWidth = 6;
            Role.Name = "Role";
            Role.Width = 125;
            // 
            // AdditionalInformation
            // 
            AdditionalInformation.HeaderText = "Additional Information";
            AdditionalInformation.MinimumWidth = 6;
            AdditionalInformation.Name = "AdditionalInformation";
            AdditionalInformation.Width = 125;
            // 
            // mySqlDataAdapter1
            // 
            mySqlDataAdapter1.DeleteCommand = null;
            mySqlDataAdapter1.InsertCommand = null;
            mySqlDataAdapter1.SelectCommand = null;
            mySqlDataAdapter1.UpdateCommand = null;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 511);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnViewByRole);
            Controls.Add(btnView);
            Controls.Add(btnAddNew);
            Name = "Form1";
            Text = "Education Centre System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddNew;
        private Button btnView;
        private Button btnViewByRole;
        private Button btnEdit;
        private Button btnDelete;
        private ComboBox comboBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn Telephone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewTextBoxColumn AdditionalInformation;
    }
}
