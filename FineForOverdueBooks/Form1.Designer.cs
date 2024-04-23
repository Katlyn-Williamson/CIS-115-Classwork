namespace FineForOverdueBooks
{
    partial class FineForOverdueBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FineForOverdueBooks));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BooksCheckedOutEntry = new System.Windows.Forms.TextBox();
            this.DaysLateEntry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFindOutFine = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Overdue Book Fine:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(90, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 62);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of books checked out:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BooksCheckedOutEntry
            // 
            this.BooksCheckedOutEntry.Location = new System.Drawing.Point(157, 375);
            this.BooksCheckedOutEntry.Name = "BooksCheckedOutEntry";
            this.BooksCheckedOutEntry.Size = new System.Drawing.Size(100, 41);
            this.BooksCheckedOutEntry.TabIndex = 2;
            // 
            // DaysLateEntry
            // 
            this.DaysLateEntry.Location = new System.Drawing.Point(483, 375);
            this.DaysLateEntry.Name = "DaysLateEntry";
            this.DaysLateEntry.Size = new System.Drawing.Size(100, 41);
            this.DaysLateEntry.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(416, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 62);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of days late:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFindOutFine
            // 
            this.btnFindOutFine.Location = new System.Drawing.Point(253, 483);
            this.btnFindOutFine.Name = "btnFindOutFine";
            this.btnFindOutFine.Size = new System.Drawing.Size(230, 45);
            this.btnFindOutFine.TabIndex = 5;
            this.btnFindOutFine.Text = "Find Out Fine";
            this.btnFindOutFine.UseVisualStyleBackColor = true;
            this.btnFindOutFine.Click += new System.EventHandler(this.btnFindOutFine_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 46);
            this.label4.TabIndex = 6;
            // 
            // FineForOverdueBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1208, 647);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFindOutFine);
            this.Controls.Add(this.DaysLateEntry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BooksCheckedOutEntry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FineForOverdueBooks";
            this.Text = "Fine For Overdue Books";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BooksCheckedOutEntry;
        private System.Windows.Forms.TextBox DaysLateEntry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFindOutFine;
        private System.Windows.Forms.Label label4;
    }
}

