namespace CustomerVoicemailSystem
{
    partial class Correspondence
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCorrespondence = new System.Windows.Forms.DataGridView();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnUpdateRecord = new System.Windows.Forms.Button();
            this.btnInsertRecord = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.Label();
            this.cbCorrespondenceType = new System.Windows.Forms.ComboBox();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCorrespondence = new System.Windows.Forms.Button();
            this.chbFollowUp = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrespondence)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCorrespondence
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCorrespondence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCorrespondence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCorrespondence.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCorrespondence.Location = new System.Drawing.Point(287, 30);
            this.dgvCorrespondence.Name = "dgvCorrespondence";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCorrespondence.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCorrespondence.Size = new System.Drawing.Size(626, 403);
            this.dgvCorrespondence.TabIndex = 21;
            this.dgvCorrespondence.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(25, 270);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(206, 31);
            this.btnViewAll.TabIndex = 20;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnView);
            // 
            // btnUpdateRecord
            // 
            this.btnUpdateRecord.Location = new System.Drawing.Point(131, 233);
            this.btnUpdateRecord.Name = "btnUpdateRecord";
            this.btnUpdateRecord.Size = new System.Drawing.Size(100, 31);
            this.btnUpdateRecord.TabIndex = 18;
            this.btnUpdateRecord.Text = "Update";
            this.btnUpdateRecord.UseVisualStyleBackColor = true;
            this.btnUpdateRecord.Click += new System.EventHandler(this.btnUpdate);
            // 
            // btnInsertRecord
            // 
            this.btnInsertRecord.Location = new System.Drawing.Point(25, 233);
            this.btnInsertRecord.Name = "btnInsertRecord";
            this.btnInsertRecord.Size = new System.Drawing.Size(100, 31);
            this.btnInsertRecord.TabIndex = 17;
            this.btnInsertRecord.Text = "Insert";
            this.btnInsertRecord.UseVisualStyleBackColor = true;
            this.btnInsertRecord.Click += new System.EventHandler(this.btnInsert);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Date";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(110, 144);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 13;
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(110, 118);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(121, 20);
            this.tbTime.TabIndex = 12;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(110, 92);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(121, 20);
            this.tbDate.TabIndex = 11;
            // 
            // cbType
            // 
            this.cbType.AutoSize = true;
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.Location = new System.Drawing.Point(32, 174);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(40, 16);
            this.cbType.TabIndex = 23;
            this.cbType.Text = "Type";
            // 
            // cbCorrespondenceType
            // 
            this.cbCorrespondenceType.FormattingEnabled = true;
            this.cbCorrespondenceType.Location = new System.Drawing.Point(110, 171);
            this.cbCorrespondenceType.Name = "cbCorrespondenceType";
            this.cbCorrespondenceType.Size = new System.Drawing.Size(121, 21);
            this.cbCorrespondenceType.TabIndex = 24;
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(110, 65);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(121, 21);
            this.cbCustomer.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Customer";
            // 
            // btnCorrespondence
            // 
            this.btnCorrespondence.Location = new System.Drawing.Point(25, 307);
            this.btnCorrespondence.Name = "btnCorrespondence";
            this.btnCorrespondence.Size = new System.Drawing.Size(206, 31);
            this.btnCorrespondence.TabIndex = 27;
            this.btnCorrespondence.Text = "View Correspondence";
            this.btnCorrespondence.UseVisualStyleBackColor = true;
            this.btnCorrespondence.Click += new System.EventHandler(this.btnCorrespondence_click);
            // 
            // chbFollowUp
            // 
            this.chbFollowUp.AutoSize = true;
            this.chbFollowUp.Location = new System.Drawing.Point(99, 198);
            this.chbFollowUp.Name = "chbFollowUp";
            this.chbFollowUp.Size = new System.Drawing.Size(132, 17);
            this.chbFollowUp.TabIndex = 29;
            this.chbFollowUp.Text = "Have we followed up?";
            this.chbFollowUp.UseVisualStyleBackColor = true;
            // 
            // Correspondence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 463);
            this.Controls.Add(this.chbFollowUp);
            this.Controls.Add(this.btnCorrespondence);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.cbCorrespondenceType);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.dgvCorrespondence);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnUpdateRecord);
            this.Controls.Add(this.btnInsertRecord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.tbDate);
            this.Location = new System.Drawing.Point(331, 130);
            this.Name = "Correspondence";
            this.Text = "Correspondence";
            this.Load += new System.EventHandler(this.Correspondence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrespondence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCorrespondence;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnUpdateRecord;
        private System.Windows.Forms.Button btnInsertRecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label cbType;
        private System.Windows.Forms.ComboBox cbCorrespondenceType;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCorrespondence;
        private System.Windows.Forms.CheckBox chbFollowUp;
    }
}