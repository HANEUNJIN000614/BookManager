namespace EunJinBookManager
{
    partial class EunJinBookManager
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
            this.BtnBook = new eGhis.Controls.EghisButton();
            this.BtnCustomers = new eGhis.Controls.EghisButton();
            this.BtnBookRent = new eGhis.Controls.EghisButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnBook
            // 
            this.BtnBook._IconType = eGhis.Controls.IconType.None;
            this.BtnBook.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBook.Appearance.Options.UseFont = true;
            this.BtnBook.AutoFontSizeChange = true;
            this.BtnBook.ButtonActionPosition = eGhis.Controls.ButtonActionPosition.Left;
            this.BtnBook.ButtonActionType = eGhis.Controls.ButtonActionType.None;
            this.BtnBook.ImageSize = new System.Drawing.Size(0, 0);
            this.BtnBook.Location = new System.Drawing.Point(100, 156);
            this.BtnBook.Name = "BtnBook";
            this.BtnBook.PreFixedButtonSize = eGhis.Controls.PreFixedWidth.None;
            this.BtnBook.Size = new System.Drawing.Size(102, 94);
            this.BtnBook.TabIndex = 0;
            this.BtnBook.Text = "도서관리";
            // 
            // BtnCustomers
            // 
            this.BtnCustomers._IconType = eGhis.Controls.IconType.None;
            this.BtnCustomers.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomers.Appearance.Options.UseFont = true;
            this.BtnCustomers.AutoFontSizeChange = true;
            this.BtnCustomers.ButtonActionPosition = eGhis.Controls.ButtonActionPosition.Left;
            this.BtnCustomers.ButtonActionType = eGhis.Controls.ButtonActionType.None;
            this.BtnCustomers.ImageSize = new System.Drawing.Size(0, 0);
            this.BtnCustomers.Location = new System.Drawing.Point(241, 156);
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.PreFixedButtonSize = eGhis.Controls.PreFixedWidth.None;
            this.BtnCustomers.Size = new System.Drawing.Size(102, 94);
            this.BtnCustomers.TabIndex = 2;
            this.BtnCustomers.Text = "고객관리";
            // 
            // BtnBookRent
            // 
            this.BtnBookRent._IconType = eGhis.Controls.IconType.None;
            this.BtnBookRent.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBookRent.Appearance.Options.UseFont = true;
            this.BtnBookRent.AutoFontSizeChange = true;
            this.BtnBookRent.ButtonActionPosition = eGhis.Controls.ButtonActionPosition.Left;
            this.BtnBookRent.ButtonActionType = eGhis.Controls.ButtonActionType.None;
            this.BtnBookRent.ImageSize = new System.Drawing.Size(0, 0);
            this.BtnBookRent.Location = new System.Drawing.Point(382, 156);
            this.BtnBookRent.Name = "BtnBookRent";
            this.BtnBookRent.PreFixedButtonSize = eGhis.Controls.PreFixedWidth.None;
            this.BtnBookRent.Size = new System.Drawing.Size(102, 94);
            this.BtnBookRent.TabIndex = 3;
            this.BtnBookRent.Text = "대출/반납";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(209, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "도서관리시스템";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EunJinBookManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 368);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBookRent);
            this.Controls.Add(this.BtnCustomers);
            this.Controls.Add(this.BtnBook);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EunJinBookManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "도서관리시스템";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private eGhis.Controls.EghisButton BtnBook;
        private eGhis.Controls.EghisButton BtnCustomers;
        private eGhis.Controls.EghisButton BtnBookRent;
        private System.Windows.Forms.Label label1;
    }
}

