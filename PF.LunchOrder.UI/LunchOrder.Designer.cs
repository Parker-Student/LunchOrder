namespace PF.LunchOrder.UI
{
    partial class LunchOrder
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
            this.radHamburger = new System.Windows.Forms.RadioButton();
            this.radPizza = new System.Windows.Forms.RadioButton();
            this.radSalad = new System.Windows.Forms.RadioButton();
            this.chkOpt1 = new System.Windows.Forms.CheckBox();
            this.chkOpt2 = new System.Windows.Forms.CheckBox();
            this.chkOpt3 = new System.Windows.Forms.CheckBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radHamburger
            // 
            this.radHamburger.AutoSize = true;
            this.radHamburger.Location = new System.Drawing.Point(96, 67);
            this.radHamburger.Name = "radHamburger";
            this.radHamburger.Size = new System.Drawing.Size(113, 17);
            this.radHamburger.TabIndex = 0;
            this.radHamburger.TabStop = true;
            this.radHamburger.Text = "Hamburger - $6.95";
            this.radHamburger.UseVisualStyleBackColor = true;
            // 
            // radPizza
            // 
            this.radPizza.AutoSize = true;
            this.radPizza.Location = new System.Drawing.Point(96, 101);
            this.radPizza.Name = "radPizza";
            this.radPizza.Size = new System.Drawing.Size(86, 17);
            this.radPizza.TabIndex = 1;
            this.radPizza.TabStop = true;
            this.radPizza.Text = "Pizza - $5.95";
            this.radPizza.UseVisualStyleBackColor = true;
            // 
            // radSalad
            // 
            this.radSalad.AutoSize = true;
            this.radSalad.Location = new System.Drawing.Point(96, 135);
            this.radSalad.Name = "radSalad";
            this.radSalad.Size = new System.Drawing.Size(88, 17);
            this.radSalad.TabIndex = 2;
            this.radSalad.TabStop = true;
            this.radSalad.Text = "Salad - $4.95";
            this.radSalad.UseVisualStyleBackColor = true;
            // 
            // chkOpt1
            // 
            this.chkOpt1.AutoSize = true;
            this.chkOpt1.Location = new System.Drawing.Point(437, 67);
            this.chkOpt1.Name = "chkOpt1";
            this.chkOpt1.Size = new System.Drawing.Size(164, 17);
            this.chkOpt1.TabIndex = 3;
            this.chkOpt1.Text = "Lettuce, Tomato, and Onions";
            this.chkOpt1.UseVisualStyleBackColor = true;
            // 
            // chkOpt2
            // 
            this.chkOpt2.AutoSize = true;
            this.chkOpt2.Location = new System.Drawing.Point(437, 101);
            this.chkOpt2.Name = "chkOpt2";
            this.chkOpt2.Size = new System.Drawing.Size(163, 17);
            this.chkOpt2.TabIndex = 4;
            this.chkOpt2.Text = "Ketchup, Mustard, and Mayo";
            this.chkOpt2.UseVisualStyleBackColor = true;
            // 
            // chkOpt3
            // 
            this.chkOpt3.AutoSize = true;
            this.chkOpt3.Location = new System.Drawing.Point(437, 135);
            this.chkOpt3.Name = "chkOpt3";
            this.chkOpt3.Size = new System.Drawing.Size(84, 17);
            this.chkOpt3.TabIndex = 5;
            this.chkOpt3.Text = "French Fries";
            this.chkOpt3.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(437, 268);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Place Order";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(437, 320);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(36, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 171);
            this.label3.TabIndex = 10;
            this.label3.Text = "Order Total";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 171);
            this.label1.TabIndex = 11;
            this.label1.Text = "Main Course";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(391, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 171);
            this.label2.TabIndex = 12;
            this.label2.Text = "Add-On Items ($.75/each)";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(66, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "SubTotal:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(51, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tax (7.75%):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(69, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Order Total:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubTotal.Location = new System.Drawing.Point(163, 244);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(94, 23);
            this.lblSubTotal.TabIndex = 16;
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTax
            // 
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTax.Location = new System.Drawing.Point(163, 284);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(94, 23);
            this.lblTax.TabIndex = 17;
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(163, 324);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(94, 23);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LunchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.chkOpt3);
            this.Controls.Add(this.chkOpt2);
            this.Controls.Add(this.chkOpt1);
            this.Controls.Add(this.radSalad);
            this.Controls.Add(this.radPizza);
            this.Controls.Add(this.radHamburger);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "LunchOrder";
            this.Text = "Lunch Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radHamburger;
        private System.Windows.Forms.RadioButton radPizza;
        private System.Windows.Forms.RadioButton radSalad;
        private System.Windows.Forms.CheckBox chkOpt1;
        private System.Windows.Forms.CheckBox chkOpt2;
        private System.Windows.Forms.CheckBox chkOpt3;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
    }
}

