namespace DataBaseServiceImplementation
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCreate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDeleteByID = new System.Windows.Forms.TextBox();
            this.buttonRead = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxReadByID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUpdateByID = new System.Windows.Forms.TextBox();
            this.textBoxUpdateName = new System.Windows.Forms.TextBox();
            this.textBoxCreateName = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewSelectedPerson = new System.Windows.Forms.DataGridView();
            this.dataGridViewTablePerson = new System.Windows.Forms.DataGridView();
            this.buttonWebStop = new System.Windows.Forms.Button();
            this.buttonWebhost = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablePerson)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(226, 37);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Add";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 56);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loggin";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(119, 21);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 9;
            this.buttonConnect.Text = "connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxDeleteByID);
            this.groupBox2.Controls.Add(this.buttonRead);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxReadByID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxUpdateByID);
            this.groupBox2.Controls.Add(this.textBoxUpdateName);
            this.groupBox2.Controls.Add(this.textBoxCreateName);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.buttonUpdate);
            this.groupBox2.Controls.Add(this.buttonCreate);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 312);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Requests";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "ID";
            // 
            // textBoxDeleteByID
            // 
            this.textBoxDeleteByID.Location = new System.Drawing.Point(89, 209);
            this.textBoxDeleteByID.Name = "textBoxDeleteByID";
            this.textBoxDeleteByID.Size = new System.Drawing.Size(131, 22);
            this.textBoxDeleteByID.TabIndex = 19;
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(226, 273);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 23);
            this.buttonRead.TabIndex = 11;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Name";
            // 
            // textBoxReadByID
            // 
            this.textBoxReadByID.Location = new System.Drawing.Point(89, 274);
            this.textBoxReadByID.Name = "textBoxReadByID";
            this.textBoxReadByID.Size = new System.Drawing.Size(131, 22);
            this.textBoxReadByID.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name";
            // 
            // textBoxUpdateByID
            // 
            this.textBoxUpdateByID.Location = new System.Drawing.Point(89, 114);
            this.textBoxUpdateByID.Name = "textBoxUpdateByID";
            this.textBoxUpdateByID.Size = new System.Drawing.Size(131, 22);
            this.textBoxUpdateByID.TabIndex = 17;
            // 
            // textBoxUpdateName
            // 
            this.textBoxUpdateName.Location = new System.Drawing.Point(89, 142);
            this.textBoxUpdateName.Name = "textBoxUpdateName";
            this.textBoxUpdateName.Size = new System.Drawing.Size(131, 22);
            this.textBoxUpdateName.TabIndex = 15;
            // 
            // textBoxCreateName
            // 
            this.textBoxCreateName.Location = new System.Drawing.Point(89, 38);
            this.textBoxCreateName.Name = "textBoxCreateName";
            this.textBoxCreateName.Size = new System.Drawing.Size(131, 22);
            this.textBoxCreateName.TabIndex = 11;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(226, 212);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(226, 114);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewSelectedPerson);
            this.groupBox3.Controls.Add(this.dataGridViewTablePerson);
            this.groupBox3.Location = new System.Drawing.Point(325, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(415, 421);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DataBase View";
            // 
            // dataGridViewSelectedPerson
            // 
            this.dataGridViewSelectedPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelectedPerson.Location = new System.Drawing.Point(6, 335);
            this.dataGridViewSelectedPerson.Name = "dataGridViewSelectedPerson";
            this.dataGridViewSelectedPerson.RowTemplate.Height = 24;
            this.dataGridViewSelectedPerson.Size = new System.Drawing.Size(403, 77);
            this.dataGridViewSelectedPerson.TabIndex = 12;
            // 
            // dataGridViewTablePerson
            // 
            this.dataGridViewTablePerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTablePerson.Location = new System.Drawing.Point(6, 34);
            this.dataGridViewTablePerson.Name = "dataGridViewTablePerson";
            this.dataGridViewTablePerson.RowTemplate.Height = 24;
            this.dataGridViewTablePerson.Size = new System.Drawing.Size(403, 263);
            this.dataGridViewTablePerson.TabIndex = 0;
            // 
            // buttonWebStop
            // 
            this.buttonWebStop.Enabled = false;
            this.buttonWebStop.Location = new System.Drawing.Point(119, 401);
            this.buttonWebStop.Name = "buttonWebStop";
            this.buttonWebStop.Size = new System.Drawing.Size(101, 23);
            this.buttonWebStop.TabIndex = 23;
            this.buttonWebStop.Text = "Stop";
            this.buttonWebStop.UseVisualStyleBackColor = true;
            // 
            // buttonWebhost
            // 
            this.buttonWebhost.Location = new System.Drawing.Point(12, 401);
            this.buttonWebhost.Name = "buttonWebhost";
            this.buttonWebhost.Size = new System.Drawing.Size(101, 23);
            this.buttonWebhost.TabIndex = 22;
            this.buttonWebhost.Text = "Web hosting";
            this.buttonWebhost.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 446);
            this.Controls.Add(this.buttonWebStop);
            this.Controls.Add(this.buttonWebhost);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablePerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDeleteByID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUpdateByID;
        private System.Windows.Forms.TextBox textBoxReadByID;
        private System.Windows.Forms.TextBox textBoxUpdateName;
        private System.Windows.Forms.TextBox textBoxCreateName;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewTablePerson;
        private System.Windows.Forms.DataGridView dataGridViewSelectedPerson;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonWebStop;
        private System.Windows.Forms.Button buttonWebhost;
    }
}

