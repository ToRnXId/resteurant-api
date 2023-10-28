namespace ResteurantClientApp
{
    partial class MainForm
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
            this.createResteruantBTN = new System.Windows.Forms.Button();
            this.getResteurantsBTN = new System.Windows.Forms.Button();
            this.clearInformationBTN = new System.Windows.Forms.Button();
            this.responseLBL = new System.Windows.Forms.Label();
            this.createRestNameTB = new System.Windows.Forms.TextBox();
            this.createRestDescriptionTB = new System.Windows.Forms.TextBox();
            this.createRestCategoryTB = new System.Windows.Forms.TextBox();
            this.createRestContactNumberMTB = new System.Windows.Forms.MaskedTextBox();
            this.createRestHasDeliveryTB = new System.Windows.Forms.TextBox();
            this.createRestContactEmailTB = new System.Windows.Forms.TextBox();
            this.createRestNameLBL = new System.Windows.Forms.Label();
            this.createRestDescriptionLBL = new System.Windows.Forms.Label();
            this.createRestCategoryLBL = new System.Windows.Forms.Label();
            this.createRestHasDeliveryLBL = new System.Windows.Forms.Label();
            this.createRestContactEmailLBL = new System.Windows.Forms.Label();
            this.createRestContactNumberLBL = new System.Windows.Forms.Label();
            this.createRestDoneBTN = new System.Windows.Forms.Button();
            this.createRestCancelBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createResteruantBTN
            // 
            this.createResteruantBTN.Location = new System.Drawing.Point(12, 12);
            this.createResteruantBTN.Name = "createResteruantBTN";
            this.createResteruantBTN.Size = new System.Drawing.Size(110, 23);
            this.createResteruantBTN.TabIndex = 0;
            this.createResteruantBTN.Text = "Create Resteurant";
            this.createResteruantBTN.UseVisualStyleBackColor = true;
            this.createResteruantBTN.Click += new System.EventHandler(this.CreateResteruantBTN_Click);
            // 
            // getResteurantsBTN
            // 
            this.getResteurantsBTN.Location = new System.Drawing.Point(128, 12);
            this.getResteurantsBTN.Name = "getResteurantsBTN";
            this.getResteurantsBTN.Size = new System.Drawing.Size(110, 23);
            this.getResteurantsBTN.TabIndex = 1;
            this.getResteurantsBTN.Text = "Get Resteurants";
            this.getResteurantsBTN.UseVisualStyleBackColor = true;
            this.getResteurantsBTN.Click += new System.EventHandler(this.GetResteurantsBTN_Click);
            // 
            // clearInformationBTN
            // 
            this.clearInformationBTN.Location = new System.Drawing.Point(244, 12);
            this.clearInformationBTN.Name = "clearInformationBTN";
            this.clearInformationBTN.Size = new System.Drawing.Size(110, 23);
            this.clearInformationBTN.TabIndex = 2;
            this.clearInformationBTN.Text = "Clear Information";
            this.clearInformationBTN.UseVisualStyleBackColor = true;
            this.clearInformationBTN.Click += new System.EventHandler(this.ClearInformationBTN_Click);
            // 
            // responseLBL
            // 
            this.responseLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.responseLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.responseLBL.Location = new System.Drawing.Point(13, 38);
            this.responseLBL.Name = "responseLBL";
            this.responseLBL.Size = new System.Drawing.Size(341, 197);
            this.responseLBL.TabIndex = 3;
            // 
            // createRestNameTB
            // 
            this.createRestNameTB.Location = new System.Drawing.Point(12, 263);
            this.createRestNameTB.Name = "createRestNameTB";
            this.createRestNameTB.Size = new System.Drawing.Size(110, 23);
            this.createRestNameTB.TabIndex = 4;
            this.createRestNameTB.Visible = false;
            // 
            // createRestDescriptionTB
            // 
            this.createRestDescriptionTB.Location = new System.Drawing.Point(12, 314);
            this.createRestDescriptionTB.Name = "createRestDescriptionTB";
            this.createRestDescriptionTB.Size = new System.Drawing.Size(110, 23);
            this.createRestDescriptionTB.TabIndex = 5;
            this.createRestDescriptionTB.Visible = false;
            // 
            // createRestCategoryTB
            // 
            this.createRestCategoryTB.Location = new System.Drawing.Point(128, 263);
            this.createRestCategoryTB.Name = "createRestCategoryTB";
            this.createRestCategoryTB.Size = new System.Drawing.Size(110, 23);
            this.createRestCategoryTB.TabIndex = 6;
            this.createRestCategoryTB.Visible = false;
            // 
            // createRestContactNumberMTB
            // 
            this.createRestContactNumberMTB.Location = new System.Drawing.Point(244, 314);
            this.createRestContactNumberMTB.Mask = "(+48) 000-000-000";
            this.createRestContactNumberMTB.Name = "createRestContactNumberMTB";
            this.createRestContactNumberMTB.Size = new System.Drawing.Size(110, 23);
            this.createRestContactNumberMTB.TabIndex = 7;
            this.createRestContactNumberMTB.Visible = false;
            // 
            // createRestHasDeliveryTB
            // 
            this.createRestHasDeliveryTB.Location = new System.Drawing.Point(128, 314);
            this.createRestHasDeliveryTB.Name = "createRestHasDeliveryTB";
            this.createRestHasDeliveryTB.Size = new System.Drawing.Size(110, 23);
            this.createRestHasDeliveryTB.TabIndex = 8;
            this.createRestHasDeliveryTB.Visible = false;
            // 
            // createRestContactEmailTB
            // 
            this.createRestContactEmailTB.Location = new System.Drawing.Point(244, 263);
            this.createRestContactEmailTB.Name = "createRestContactEmailTB";
            this.createRestContactEmailTB.Size = new System.Drawing.Size(110, 23);
            this.createRestContactEmailTB.TabIndex = 9;
            this.createRestContactEmailTB.Visible = false;
            // 
            // createRestNameLBL
            // 
            this.createRestNameLBL.AutoSize = true;
            this.createRestNameLBL.Location = new System.Drawing.Point(13, 245);
            this.createRestNameLBL.Name = "createRestNameLBL";
            this.createRestNameLBL.Size = new System.Drawing.Size(42, 15);
            this.createRestNameLBL.TabIndex = 10;
            this.createRestNameLBL.Text = "Name:";
            this.createRestNameLBL.Visible = false;
            // 
            // createRestDescriptionLBL
            // 
            this.createRestDescriptionLBL.AutoSize = true;
            this.createRestDescriptionLBL.Location = new System.Drawing.Point(13, 296);
            this.createRestDescriptionLBL.Name = "createRestDescriptionLBL";
            this.createRestDescriptionLBL.Size = new System.Drawing.Size(70, 15);
            this.createRestDescriptionLBL.TabIndex = 11;
            this.createRestDescriptionLBL.Text = "Description:";
            this.createRestDescriptionLBL.Visible = false;
            // 
            // createRestCategoryLBL
            // 
            this.createRestCategoryLBL.AutoSize = true;
            this.createRestCategoryLBL.Location = new System.Drawing.Point(128, 245);
            this.createRestCategoryLBL.Name = "createRestCategoryLBL";
            this.createRestCategoryLBL.Size = new System.Drawing.Size(58, 15);
            this.createRestCategoryLBL.TabIndex = 12;
            this.createRestCategoryLBL.Text = "Category:";
            this.createRestCategoryLBL.Visible = false;
            // 
            // createRestHasDeliveryLBL
            // 
            this.createRestHasDeliveryLBL.AutoSize = true;
            this.createRestHasDeliveryLBL.Location = new System.Drawing.Point(128, 296);
            this.createRestHasDeliveryLBL.Name = "createRestHasDeliveryLBL";
            this.createRestHasDeliveryLBL.Size = new System.Drawing.Size(75, 15);
            this.createRestHasDeliveryLBL.TabIndex = 13;
            this.createRestHasDeliveryLBL.Text = "Has Delivery:";
            this.createRestHasDeliveryLBL.Visible = false;
            // 
            // createRestContactEmailLBL
            // 
            this.createRestContactEmailLBL.AutoSize = true;
            this.createRestContactEmailLBL.Location = new System.Drawing.Point(244, 245);
            this.createRestContactEmailLBL.Name = "createRestContactEmailLBL";
            this.createRestContactEmailLBL.Size = new System.Drawing.Size(84, 15);
            this.createRestContactEmailLBL.TabIndex = 14;
            this.createRestContactEmailLBL.Text = "Contact Email:";
            this.createRestContactEmailLBL.Visible = false;
            // 
            // createRestContactNumberLBL
            // 
            this.createRestContactNumberLBL.AutoSize = true;
            this.createRestContactNumberLBL.Location = new System.Drawing.Point(244, 296);
            this.createRestContactNumberLBL.Name = "createRestContactNumberLBL";
            this.createRestContactNumberLBL.Size = new System.Drawing.Size(99, 15);
            this.createRestContactNumberLBL.TabIndex = 15;
            this.createRestContactNumberLBL.Text = "Contact Number:";
            this.createRestContactNumberLBL.Visible = false;
            // 
            // createRestDoneBTN
            // 
            this.createRestDoneBTN.Location = new System.Drawing.Point(102, 356);
            this.createRestDoneBTN.Name = "createRestDoneBTN";
            this.createRestDoneBTN.Size = new System.Drawing.Size(75, 23);
            this.createRestDoneBTN.TabIndex = 16;
            this.createRestDoneBTN.Text = "DONE";
            this.createRestDoneBTN.UseVisualStyleBackColor = true;
            this.createRestDoneBTN.Visible = false;
            this.createRestDoneBTN.Click += new System.EventHandler(this.CreateRestDoneBTN_Click);
            // 
            // createRestCancelBTN
            // 
            this.createRestCancelBTN.Location = new System.Drawing.Point(194, 356);
            this.createRestCancelBTN.Name = "createRestCancelBTN";
            this.createRestCancelBTN.Size = new System.Drawing.Size(75, 23);
            this.createRestCancelBTN.TabIndex = 17;
            this.createRestCancelBTN.Text = "CANCEL";
            this.createRestCancelBTN.UseVisualStyleBackColor = true;
            this.createRestCancelBTN.Visible = false;
            this.createRestCancelBTN.Click += new System.EventHandler(this.CreateRestCancelBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 391);
            this.Controls.Add(this.createRestCancelBTN);
            this.Controls.Add(this.createRestDoneBTN);
            this.Controls.Add(this.createRestContactNumberLBL);
            this.Controls.Add(this.createRestContactEmailLBL);
            this.Controls.Add(this.createRestHasDeliveryLBL);
            this.Controls.Add(this.createRestCategoryLBL);
            this.Controls.Add(this.createRestDescriptionLBL);
            this.Controls.Add(this.createRestNameLBL);
            this.Controls.Add(this.createRestContactEmailTB);
            this.Controls.Add(this.createRestHasDeliveryTB);
            this.Controls.Add(this.createRestContactNumberMTB);
            this.Controls.Add(this.createRestCategoryTB);
            this.Controls.Add(this.createRestDescriptionTB);
            this.Controls.Add(this.createRestNameTB);
            this.Controls.Add(this.responseLBL);
            this.Controls.Add(this.clearInformationBTN);
            this.Controls.Add(this.getResteurantsBTN);
            this.Controls.Add(this.createResteruantBTN);
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resteurant Client App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button createResteruantBTN;
        private Button getResteurantsBTN;
        private Button clearInformationBTN;
        private Label responseLBL;
        private TextBox createRestNameTB;
        private TextBox createRestDescriptionTB;
        private TextBox createRestCategoryTB;
        private MaskedTextBox createRestContactNumberMTB;
        private TextBox createRestHasDeliveryTB;
        private TextBox createRestContactEmailTB;
        private Label createRestNameLBL;
        private Label createRestDescriptionLBL;
        private Label createRestCategoryLBL;
        private Label createRestHasDeliveryLBL;
        private Label createRestContactEmailLBL;
        private Label createRestContactNumberLBL;
        private Button createRestDoneBTN;
        private Button createRestCancelBTN;
    }
}