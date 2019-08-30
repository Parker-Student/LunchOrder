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
            this.chkHam1 = new System.Windows.Forms.CheckBox();
            this.chkHam2 = new System.Windows.Forms.CheckBox();
            this.chkHam3 = new System.Windows.Forms.CheckBox();
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
            this.lblHamCost = new System.Windows.Forms.Label();
            this.chkZa1 = new System.Windows.Forms.CheckBox();
            this.chkZa2 = new System.Windows.Forms.CheckBox();
            this.chkZa3 = new System.Windows.Forms.CheckBox();
            this.lblZa = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.chkSal3 = new System.Windows.Forms.CheckBox();
            this.chkSal1 = new System.Windows.Forms.CheckBox();
            this.chkSal2 = new System.Windows.Forms.CheckBox();
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
            this.radHamburger.CheckedChanged += new System.EventHandler(this.radHamburger_CheckedChanged);
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
            this.radPizza.CheckedChanged += new System.EventHandler(this.radPizza_CheckedChanged);
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
            this.radSalad.CheckedChanged += new System.EventHandler(this.radSalad_CheckedChanged);
            // 
            // chkHam1
            // 
            this.chkHam1.AutoSize = true;
            this.chkHam1.Location = new System.Drawing.Point(437, 67);
            this.chkHam1.Name = "chkHam1";
            this.chkHam1.Size = new System.Drawing.Size(164, 17);
            this.chkHam1.TabIndex = 3;
            this.chkHam1.Text = "Lettuce, Tomato, and Onions";
            this.chkHam1.UseVisualStyleBackColor = true;
            this.chkHam1.Visible = false;
            this.chkHam1.CheckedChanged += new System.EventHandler(this.chkHam1_CheckedChanged);
            // 
            // chkHam2
            // 
            this.chkHam2.AutoSize = true;
            this.chkHam2.Location = new System.Drawing.Point(437, 101);
            this.chkHam2.Name = "chkHam2";
            this.chkHam2.Size = new System.Drawing.Size(163, 17);
            this.chkHam2.TabIndex = 4;
            this.chkHam2.Text = "Ketchup, Mustard, and Mayo";
            this.chkHam2.UseVisualStyleBackColor = true;
            this.chkHam2.Visible = false;
            this.chkHam2.CheckedChanged += new System.EventHandler(this.chkHam2_CheckedChanged);
            // 
            // chkHam3
            // 
            this.chkHam3.AutoSize = true;
            this.chkHam3.Location = new System.Drawing.Point(437, 135);
            this.chkHam3.Name = "chkHam3";
            this.chkHam3.Size = new System.Drawing.Size(84, 17);
            this.chkHam3.TabIndex = 5;
            this.chkHam3.Text = "French Fries";
            this.chkHam3.UseVisualStyleBackColor = true;
            this.chkHam3.Visible = false;
            this.chkHam3.CheckedChanged += new System.EventHandler(this.chkHam3_CheckedChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(437, 268);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Place Order";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(437, 320);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
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
            this.label2.Text = "Add-On Items";
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
            // lblHamCost
            // 
            this.lblHamCost.AutoSize = true;
            this.lblHamCost.Location = new System.Drawing.Point(461, 23);
            this.lblHamCost.Name = "lblHamCost";
            this.lblHamCost.Size = new System.Drawing.Size(63, 13);
            this.lblHamCost.TabIndex = 19;
            this.lblHamCost.Text = "($.75/each)";
            this.lblHamCost.Visible = false;
            // 
            // chkZa1
            // 
            this.chkZa1.AutoSize = true;
            this.chkZa1.Location = new System.Drawing.Point(432, 68);
            this.chkZa1.Name = "chkZa1";
            this.chkZa1.Size = new System.Drawing.Size(74, 17);
            this.chkZa1.TabIndex = 20;
            this.chkZa1.Text = "Pepperoni";
            this.chkZa1.UseVisualStyleBackColor = true;
            this.chkZa1.Visible = false;
            this.chkZa1.CheckedChanged += new System.EventHandler(this.chkZa1_CheckedChanged);
            // 
            // chkZa2
            // 
            this.chkZa2.AutoSize = true;
            this.chkZa2.Location = new System.Drawing.Point(432, 101);
            this.chkZa2.Name = "chkZa2";
            this.chkZa2.Size = new System.Drawing.Size(68, 17);
            this.chkZa2.TabIndex = 21;
            this.chkZa2.Text = "Sausage";
            this.chkZa2.UseVisualStyleBackColor = true;
            this.chkZa2.Visible = false;
            this.chkZa2.CheckedChanged += new System.EventHandler(this.chkZa2_CheckedChanged);
            // 
            // chkZa3
            // 
            this.chkZa3.AutoSize = true;
            this.chkZa3.Location = new System.Drawing.Point(432, 136);
            this.chkZa3.Name = "chkZa3";
            this.chkZa3.Size = new System.Drawing.Size(55, 17);
            this.chkZa3.TabIndex = 22;
            this.chkZa3.Text = "Olives";
            this.chkZa3.UseVisualStyleBackColor = true;
            this.chkZa3.Visible = false;
            this.chkZa3.CheckedChanged += new System.EventHandler(this.chkZa3_CheckedChanged);
            // 
            // lblZa
            // 
            this.lblZa.AutoSize = true;
            this.lblZa.Location = new System.Drawing.Point(461, 23);
            this.lblZa.Name = "lblZa";
            this.lblZa.Size = new System.Drawing.Size(63, 13);
            this.lblZa.TabIndex = 23;
            this.lblZa.Text = "($.50/each)";
            this.lblZa.Visible = false;
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Location = new System.Drawing.Point(461, 23);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(63, 13);
            this.lblSal.TabIndex = 24;
            this.lblSal.Text = "($.25/each)";
            this.lblSal.Visible = false;
            // 
            // chkSal3
            // 
            this.chkSal3.AutoSize = true;
            this.chkSal3.Location = new System.Drawing.Point(432, 136);
            this.chkSal3.Name = "chkSal3";
            this.chkSal3.Size = new System.Drawing.Size(86, 17);
            this.chkSal3.TabIndex = 25;
            this.chkSal3.Text = "Bread Sticks";
            this.chkSal3.UseVisualStyleBackColor = true;
            this.chkSal3.Visible = false;
            this.chkSal3.CheckedChanged += new System.EventHandler(this.chkSal3_CheckedChanged);
            // 
            // chkSal1
            // 
            this.chkSal1.AutoSize = true;
            this.chkSal1.Location = new System.Drawing.Point(432, 67);
            this.chkSal1.Name = "chkSal1";
            this.chkSal1.Size = new System.Drawing.Size(68, 17);
            this.chkSal1.TabIndex = 26;
            this.chkSal1.Text = "Croutons";
            this.chkSal1.UseVisualStyleBackColor = true;
            this.chkSal1.Visible = false;
            this.chkSal1.CheckedChanged += new System.EventHandler(this.chkSal1_CheckedChanged);
            // 
            // chkSal2
            // 
            this.chkSal2.AutoSize = true;
            this.chkSal2.Location = new System.Drawing.Point(432, 102);
            this.chkSal2.Name = "chkSal2";
            this.chkSal2.Size = new System.Drawing.Size(77, 17);
            this.chkSal2.TabIndex = 27;
            this.chkSal2.Text = "Bacon Bits";
            this.chkSal2.UseVisualStyleBackColor = true;
            this.chkSal2.Visible = false;
            this.chkSal2.CheckedChanged += new System.EventHandler(this.chkSal2_CheckedChanged);
            // 
            // LunchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkSal2);
            this.Controls.Add(this.chkSal1);
            this.Controls.Add(this.chkSal3);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.lblZa);
            this.Controls.Add(this.chkZa3);
            this.Controls.Add(this.chkZa2);
            this.Controls.Add(this.chkZa1);
            this.Controls.Add(this.lblHamCost);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.chkHam3);
            this.Controls.Add(this.chkHam2);
            this.Controls.Add(this.chkHam1);
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
        private System.Windows.Forms.CheckBox chkHam1;
        private System.Windows.Forms.CheckBox chkHam2;
        private System.Windows.Forms.CheckBox chkHam3;
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
        private System.Windows.Forms.Label lblHamCost;
        private System.Windows.Forms.CheckBox chkZa1;
        private System.Windows.Forms.CheckBox chkZa2;
        private System.Windows.Forms.CheckBox chkZa3;
        private System.Windows.Forms.Label lblZa;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.CheckBox chkSal3;
        private System.Windows.Forms.CheckBox chkSal1;
        private System.Windows.Forms.CheckBox chkSal2;
    }
}

