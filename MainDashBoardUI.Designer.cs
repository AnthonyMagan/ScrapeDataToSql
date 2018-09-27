namespace HtmlScrapeDataToSqlTable
{
    partial class MainDashboardUI
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnImportToSql = new System.Windows.Forms.Button();
            this.btnUpdateTable = new System.Windows.Forms.Button();
            this.dgvDohlcValues = new System.Windows.Forms.DataGridView();
            this.btnAsyncUpdateTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDohlcValues)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 122);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 49);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnImportToSql
            // 
            this.btnImportToSql.Location = new System.Drawing.Point(12, 67);
            this.btnImportToSql.Name = "btnImportToSql";
            this.btnImportToSql.Size = new System.Drawing.Size(133, 49);
            this.btnImportToSql.TabIndex = 3;
            this.btnImportToSql.Text = "Import Data To Sql";
            this.btnImportToSql.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTable
            // 
            this.btnUpdateTable.Location = new System.Drawing.Point(12, 12);
            this.btnUpdateTable.Name = "btnUpdateTable";
            this.btnUpdateTable.Size = new System.Drawing.Size(133, 49);
            this.btnUpdateTable.TabIndex = 6;
            this.btnUpdateTable.Text = "Update Table with Html data";
            this.btnUpdateTable.UseVisualStyleBackColor = true;
            // 
            // dgvDohlcValues
            // 
            this.dgvDohlcValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDohlcValues.Location = new System.Drawing.Point(406, 12);
            this.dgvDohlcValues.Name = "dgvDohlcValues";
            this.dgvDohlcValues.Size = new System.Drawing.Size(782, 537);
            this.dgvDohlcValues.TabIndex = 5;
            // 
            // btnAsyncUpdateTable
            // 
            this.btnAsyncUpdateTable.Location = new System.Drawing.Point(12, 275);
            this.btnAsyncUpdateTable.Name = "btnAsyncUpdateTable";
            this.btnAsyncUpdateTable.Size = new System.Drawing.Size(133, 49);
            this.btnAsyncUpdateTable.TabIndex = 7;
            this.btnAsyncUpdateTable.Text = "Async Update Table";
            this.btnAsyncUpdateTable.UseVisualStyleBackColor = true;
            this.btnAsyncUpdateTable.Click += new System.EventHandler(this.btnAsyncUpdateTable_Click);
            // 
            // MainDashboardUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 561);
            this.Controls.Add(this.btnAsyncUpdateTable);
            this.Controls.Add(this.btnUpdateTable);
            this.Controls.Add(this.dgvDohlcValues);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnImportToSql);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainDashboardUI";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDohlcValues)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnImportToSql;
        private System.Windows.Forms.Button btnUpdateTable;
        private System.Windows.Forms.DataGridView dgvDohlcValues;
        private System.Windows.Forms.Button btnAsyncUpdateTable;
    }
}

