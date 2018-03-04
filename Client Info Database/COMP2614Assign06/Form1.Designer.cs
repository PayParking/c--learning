namespace COMP2614Assign06
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.buttonEditRecord = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.checkBoxConfirmDeletion = new System.Windows.Forms.CheckBox();
            this.labelTotalYTDSales = new System.Windows.Forms.Label();
            this.labelCreditHoldCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewClients.Location = new System.Drawing.Point(43, 25);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.RowTemplate.Height = 28;
            this.dataGridViewClients.Size = new System.Drawing.Size(1550, 547);
            this.dataGridViewClients.TabIndex = 0;
            this.dataGridViewClients.DoubleClick += new System.EventHandler(this.dataGridViewClients_DoubleClick);
            // 
            // buttonEditRecord
            // 
            this.buttonEditRecord.Location = new System.Drawing.Point(1266, 597);
            this.buttonEditRecord.Name = "buttonEditRecord";
            this.buttonEditRecord.Size = new System.Drawing.Size(133, 34);
            this.buttonEditRecord.TabIndex = 1;
            this.buttonEditRecord.Text = "&Edit Record";
            this.buttonEditRecord.UseVisualStyleBackColor = true;
            this.buttonEditRecord.Click += new System.EventHandler(this.dataGridViewClients_DoubleClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1460, 597);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(133, 34);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // checkBoxConfirmDeletion
            // 
            this.checkBoxConfirmDeletion.Location = new System.Drawing.Point(1434, 649);
            this.checkBoxConfirmDeletion.Name = "checkBoxConfirmDeletion";
            this.checkBoxConfirmDeletion.Size = new System.Drawing.Size(158, 24);
            this.checkBoxConfirmDeletion.TabIndex = 3;
            this.checkBoxConfirmDeletion.Text = "&Confirm Deletion";
            this.checkBoxConfirmDeletion.UseVisualStyleBackColor = true;
            // 
            // labelTotalYTDSales
            // 
            this.labelTotalYTDSales.Location = new System.Drawing.Point(43, 621);
            this.labelTotalYTDSales.Name = "labelTotalYTDSales";
            this.labelTotalYTDSales.Size = new System.Drawing.Size(242, 42);
            this.labelTotalYTDSales.TabIndex = 24;
            this.labelTotalYTDSales.Text = "TotalYTDSales";
            // 
            // labelCreditHoldCount
            // 
            this.labelCreditHoldCount.Location = new System.Drawing.Point(360, 621);
            this.labelCreditHoldCount.Name = "labelCreditHoldCount";
            this.labelCreditHoldCount.Size = new System.Drawing.Size(181, 42);
            this.labelCreditHoldCount.TabIndex = 25;
            this.labelCreditHoldCount.Text = "CreditHoldCount";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1635, 703);
            this.Controls.Add(this.labelCreditHoldCount);
            this.Controls.Add(this.labelTotalYTDSales);
            this.Controls.Add(this.checkBoxConfirmDeletion);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEditRecord);
            this.Controls.Add(this.dataGridViewClients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(40);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Client Database";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Button buttonEditRecord;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.CheckBox checkBoxConfirmDeletion;
        private System.Windows.Forms.Label labelTotalYTDSales;
        private System.Windows.Forms.Label labelCreditHoldCount;
    }
}

