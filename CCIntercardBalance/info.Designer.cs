
namespace CCIntercardBalance
{
    partial class info
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
            this.lblcardnumber = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblborder = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.txtBonusCash = new System.Windows.Forms.TextBox();
            this.txtTokens = new System.Windows.Forms.TextBox();
            this.txtBonusTokens = new System.Windows.Forms.TextBox();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.qtyoneattraction = new System.Windows.Forms.NumericUpDown();
            this.qtytwoattraction = new System.Windows.Forms.NumericUpDown();
            this.qtythreeattraction = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.qtyoneattraction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtytwoattraction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtythreeattraction)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcardnumber
            // 
            this.lblcardnumber.AutoSize = true;
            this.lblcardnumber.Location = new System.Drawing.Point(12, 9);
            this.lblcardnumber.Name = "lblcardnumber";
            this.lblcardnumber.Size = new System.Drawing.Size(72, 13);
            this.lblcardnumber.TabIndex = 0;
            this.lblcardnumber.Text = "Card Number:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(90, 6);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(257, 20);
            this.txtInput.TabIndex = 1;
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // lblborder
            // 
            this.lblborder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblborder.Location = new System.Drawing.Point(15, 29);
            this.lblborder.Name = "lblborder";
            this.lblborder.Size = new System.Drawing.Size(500, 2);
            this.lblborder.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(353, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(162, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Find";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(63, 37);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(38, 13);
            this.lblname.TabIndex = 4;
            this.lblname.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Account Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Redeemable Cash:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bonus Cash:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tokens:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Bonus Tokens:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Points:";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(107, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 20);
            this.txtName.TabIndex = 13;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(107, 60);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(179, 20);
            this.txtFirstName.TabIndex = 14;
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(107, 86);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(179, 20);
            this.txtLastName.TabIndex = 15;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Enabled = false;
            this.txtAccountNumber.Location = new System.Drawing.Point(107, 112);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(179, 20);
            this.txtAccountNumber.TabIndex = 16;
            // 
            // txtCash
            // 
            this.txtCash.Enabled = false;
            this.txtCash.Location = new System.Drawing.Point(393, 34);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(179, 20);
            this.txtCash.TabIndex = 17;
            // 
            // txtBonusCash
            // 
            this.txtBonusCash.Enabled = false;
            this.txtBonusCash.Location = new System.Drawing.Point(393, 60);
            this.txtBonusCash.Name = "txtBonusCash";
            this.txtBonusCash.Size = new System.Drawing.Size(179, 20);
            this.txtBonusCash.TabIndex = 18;
            // 
            // txtTokens
            // 
            this.txtTokens.Enabled = false;
            this.txtTokens.Location = new System.Drawing.Point(393, 89);
            this.txtTokens.Name = "txtTokens";
            this.txtTokens.Size = new System.Drawing.Size(179, 20);
            this.txtTokens.TabIndex = 19;
            // 
            // txtBonusTokens
            // 
            this.txtBonusTokens.Enabled = false;
            this.txtBonusTokens.Location = new System.Drawing.Point(393, 118);
            this.txtBonusTokens.Name = "txtBonusTokens";
            this.txtBonusTokens.Size = new System.Drawing.Size(179, 20);
            this.txtBonusTokens.TabIndex = 20;
            // 
            // txtPoints
            // 
            this.txtPoints.Enabled = false;
            this.txtPoints.Location = new System.Drawing.Point(393, 146);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(179, 20);
            this.txtPoints.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "1 Attraction:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(168, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "2 Attraction:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(316, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "3 Attraction:";
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(15, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(500, 2);
            this.label12.TabIndex = 25;
            // 
            // qtyoneattraction
            // 
            this.qtyoneattraction.Enabled = false;
            this.qtyoneattraction.Location = new System.Drawing.Point(90, 191);
            this.qtyoneattraction.Name = "qtyoneattraction";
            this.qtyoneattraction.Size = new System.Drawing.Size(72, 20);
            this.qtyoneattraction.TabIndex = 26;
            // 
            // qtytwoattraction
            // 
            this.qtytwoattraction.Enabled = false;
            this.qtytwoattraction.Location = new System.Drawing.Point(238, 191);
            this.qtytwoattraction.Name = "qtytwoattraction";
            this.qtytwoattraction.Size = new System.Drawing.Size(72, 20);
            this.qtytwoattraction.TabIndex = 27;
            // 
            // qtythreeattraction
            // 
            this.qtythreeattraction.Enabled = false;
            this.qtythreeattraction.Location = new System.Drawing.Point(386, 191);
            this.qtythreeattraction.Name = "qtythreeattraction";
            this.qtythreeattraction.Size = new System.Drawing.Size(72, 20);
            this.qtythreeattraction.TabIndex = 28;
            // 
            // info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 224);
            this.Controls.Add(this.qtythreeattraction);
            this.Controls.Add(this.qtytwoattraction);
            this.Controls.Add(this.qtyoneattraction);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.txtBonusTokens);
            this.Controls.Add(this.txtTokens);
            this.Controls.Add(this.txtBonusCash);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblborder);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblcardnumber);
            this.Name = "info";
            this.Text = "Card Info";
            ((System.ComponentModel.ISupportInitialize)(this.qtyoneattraction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtytwoattraction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtythreeattraction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcardnumber;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblborder;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.TextBox txtBonusCash;
        private System.Windows.Forms.TextBox txtTokens;
        private System.Windows.Forms.TextBox txtBonusTokens;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown qtyoneattraction;
        private System.Windows.Forms.NumericUpDown qtytwoattraction;
        private System.Windows.Forms.NumericUpDown qtythreeattraction;
    }
}

