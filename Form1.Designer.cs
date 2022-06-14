
namespace Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.display = new System.Windows.Forms.Label();
            this.num7 = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.minuss = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.clearentry = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.display.Location = new System.Drawing.Point(12, 9);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(360, 121);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num7.Location = new System.Drawing.Point(9, 134);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(68, 61);
            this.num7.TabIndex = 1;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.plus.Location = new System.Drawing.Point(230, 335);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(68, 61);
            this.plus.TabIndex = 2;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.point.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.ForeColor = System.Drawing.SystemColors.ControlText;
            this.point.Location = new System.Drawing.Point(156, 335);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(68, 61);
            this.point.TabIndex = 3;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num0.Location = new System.Drawing.Point(9, 335);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(142, 61);
            this.num0.TabIndex = 4;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.equal.Location = new System.Drawing.Point(305, 268);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(68, 128);
            this.equal.TabIndex = 5;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // minuss
            // 
            this.minuss.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.minuss.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuss.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minuss.Location = new System.Drawing.Point(231, 268);
            this.minuss.Name = "minuss";
            this.minuss.Size = new System.Drawing.Size(68, 61);
            this.minuss.TabIndex = 6;
            this.minuss.Text = "-";
            this.minuss.UseVisualStyleBackColor = false;
            this.minuss.Click += new System.EventHandler(this.minuss_Click);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num3.Location = new System.Drawing.Point(157, 268);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(68, 61);
            this.num3.TabIndex = 7;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num2.Location = new System.Drawing.Point(83, 268);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(68, 61);
            this.num2.TabIndex = 8;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num1.Location = new System.Drawing.Point(9, 268);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(68, 61);
            this.num1.TabIndex = 9;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clear.Location = new System.Drawing.Point(304, 201);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(68, 61);
            this.clear.TabIndex = 10;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.ForeColor = System.Drawing.SystemColors.ControlText;
            this.multiply.Location = new System.Drawing.Point(231, 201);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(68, 61);
            this.multiply.TabIndex = 11;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num6.Location = new System.Drawing.Point(156, 201);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(68, 61);
            this.num6.TabIndex = 12;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num5.Location = new System.Drawing.Point(82, 201);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(68, 61);
            this.num5.TabIndex = 13;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num4.Location = new System.Drawing.Point(8, 201);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(68, 61);
            this.num4.TabIndex = 14;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // clearentry
            // 
            this.clearentry.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearentry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearentry.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clearentry.Location = new System.Drawing.Point(305, 134);
            this.clearentry.Name = "clearentry";
            this.clearentry.Size = new System.Drawing.Size(68, 61);
            this.clearentry.TabIndex = 15;
            this.clearentry.Text = "CE";
            this.clearentry.UseVisualStyleBackColor = false;
            this.clearentry.Click += new System.EventHandler(this.clearentry_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.ForeColor = System.Drawing.SystemColors.ControlText;
            this.divide.Location = new System.Drawing.Point(231, 133);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(68, 61);
            this.divide.TabIndex = 16;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num9.Location = new System.Drawing.Point(157, 134);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(68, 61);
            this.num9.TabIndex = 17;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num8.Location = new System.Drawing.Point(83, 134);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(68, 61);
            this.num8.TabIndex = 18;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(386, 410);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.clearentry);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.minuss);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.point);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button minuss;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button clearentry;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num8;
    }
}

