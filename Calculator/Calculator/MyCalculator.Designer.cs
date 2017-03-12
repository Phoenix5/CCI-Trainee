﻿namespace Calculator
{
    partial class MyCalculator
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
            this.btnNum0 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnOpEquals = new System.Windows.Forms.Button();
            this.btnOpDot = new System.Windows.Forms.Button();
            this.btnOpSubtract = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnOpMultiply = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnOpDivide = new System.Windows.Forms.Button();
            this.btnbackSpace = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBlank = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnOpAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNum0
            // 
            this.btnNum0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum0.Location = new System.Drawing.Point(80, 168);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(71, 40);
            this.btnNum0.TabIndex = 21;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.Operand_Pressed);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 40);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonblk2_Click);
            // 
            // btnOpEquals
            // 
            this.btnOpEquals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpEquals.Location = new System.Drawing.Point(234, 168);
            this.btnOpEquals.Name = "btnOpEquals";
            this.btnOpEquals.Size = new System.Drawing.Size(110, 40);
            this.btnOpEquals.TabIndex = 19;
            this.btnOpEquals.Text = "=";
            this.btnOpEquals.UseVisualStyleBackColor = true;
            this.btnOpEquals.Click += new System.EventHandler(this.Operator_Pressed);
            // 
            // btnOpDot
            // 
            this.btnOpDot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpDot.Location = new System.Drawing.Point(157, 168);
            this.btnOpDot.Name = "btnOpDot";
            this.btnOpDot.Size = new System.Drawing.Size(71, 40);
            this.btnOpDot.TabIndex = 18;
            this.btnOpDot.Text = ".";
            this.btnOpDot.UseVisualStyleBackColor = true;
            this.btnOpDot.Click += new System.EventHandler(this.Operand_Pressed);
            // 
            // btnOpSubtract
            // 
            this.btnOpSubtract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpSubtract.Location = new System.Drawing.Point(234, 81);
            this.btnOpSubtract.Name = "btnOpSubtract";
            this.btnOpSubtract.Size = new System.Drawing.Size(110, 37);
            this.btnOpSubtract.TabIndex = 12;
            this.btnOpSubtract.Text = "-";
            this.btnOpSubtract.UseVisualStyleBackColor = true;
            this.btnOpSubtract.Click += new System.EventHandler(this.Operator_Pressed);
            // 
            // btnNum6
            // 
            this.btnNum6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum6.Location = new System.Drawing.Point(157, 81);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(71, 37);
            this.btnNum6.TabIndex = 11;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.Operand_Pressed);
            // 
            // btnNum5
            // 
            this.btnNum5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum5.Location = new System.Drawing.Point(80, 81);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(71, 37);
            this.btnNum5.TabIndex = 10;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.Operand_Pressed);
            // 
            // btnNum4
            // 
            this.btnNum4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum4.Location = new System.Drawing.Point(3, 81);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(71, 37);
            this.btnNum4.TabIndex = 9;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.Operand_Pressed);
            // 
            // btnOpMultiply
            // 
            this.btnOpMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpMultiply.Location = new System.Drawing.Point(234, 39);
            this.btnOpMultiply.Name = "btnOpMultiply";
            this.btnOpMultiply.Size = new System.Drawing.Size(110, 36);
            this.btnOpMultiply.TabIndex = 8;
            this.btnOpMultiply.Text = "*";
            this.btnOpMultiply.UseVisualStyleBackColor = true;
            this.btnOpMultiply.Click += new System.EventHandler(this.Operator_Pressed);
            // 
            // btnNum3
            // 
            this.btnNum3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum3.Location = new System.Drawing.Point(157, 39);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(71, 36);
            this.btnNum3.TabIndex = 7;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.Operand_Pressed);
            // 
            // btnNum2
            // 
            this.btnNum2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum2.Location = new System.Drawing.Point(80, 39);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(71, 36);
            this.btnNum2.TabIndex = 6;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.Operand_Pressed);
            // 
            // btnNum1
            // 
            this.btnNum1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum1.Location = new System.Drawing.Point(3, 39);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(71, 36);
            this.btnNum1.TabIndex = 5;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.Operand_Pressed);
            // 
            // btnOpDivide
            // 
            this.btnOpDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpDivide.Location = new System.Drawing.Point(234, 3);
            this.btnOpDivide.Name = "btnOpDivide";
            this.btnOpDivide.Size = new System.Drawing.Size(110, 30);
            this.btnOpDivide.TabIndex = 4;
            this.btnOpDivide.Text = "/";
            this.btnOpDivide.UseVisualStyleBackColor = true;
            this.btnOpDivide.Click += new System.EventHandler(this.Operator_Pressed);
            // 
            // btnbackSpace
            // 
            this.btnbackSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnbackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackSpace.Location = new System.Drawing.Point(157, 3);
            this.btnbackSpace.Name = "btnbackSpace";
            this.btnbackSpace.Size = new System.Drawing.Size(71, 30);
            this.btnbackSpace.TabIndex = 3;
            this.btnbackSpace.Text = "<-";
            this.btnbackSpace.UseVisualStyleBackColor = true;
            this.btnbackSpace.Click += new System.EventHandler(this.btnbackSpace_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(80, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "C";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBlank
            // 
            this.btnBlank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBlank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlank.Location = new System.Drawing.Point(3, 3);
            this.btnBlank.Name = "btnBlank";
            this.btnBlank.Size = new System.Drawing.Size(71, 30);
            this.btnBlank.TabIndex = 1;
            this.btnBlank.UseVisualStyleBackColor = true;
            this.btnBlank.Click += new System.EventHandler(this.btnBlank_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum7.Location = new System.Drawing.Point(3, 124);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(71, 38);
            this.btnNum7.TabIndex = 16;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.Operand_Pressed);
            // 
            // btnNum8
            // 
            this.btnNum8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum8.Location = new System.Drawing.Point(80, 124);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(71, 38);
            this.btnNum8.TabIndex = 15;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.Operand_Pressed);
            // 
            // btnNum9
            // 
            this.btnNum9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum9.Location = new System.Drawing.Point(157, 124);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(71, 38);
            this.btnNum9.TabIndex = 13;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.Operand_Pressed);
            // 
            // btnOpAdd
            // 
            this.btnOpAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpAdd.Location = new System.Drawing.Point(234, 124);
            this.btnOpAdd.Name = "btnOpAdd";
            this.btnOpAdd.Size = new System.Drawing.Size(110, 38);
            this.btnOpAdd.TabIndex = 17;
            this.btnOpAdd.Text = "+";
            this.btnOpAdd.UseVisualStyleBackColor = true;
            this.btnOpAdd.Click += new System.EventHandler(this.Operator_Pressed);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnNum0, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnOpEquals, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnOpDot, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnOpSubtract, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNum6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNum5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNum4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnOpMultiply, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNum3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNum2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNum1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnOpDivide, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnbackSpace, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBlank, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNum7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNum8, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNum9, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnOpAdd, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.06161F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.90521F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.37915F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.85308F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.85308F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(347, 211);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(0, 0);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(347, 38);
            this.txtDisplay.TabIndex = 3;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text
            // 
            this.text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.text.Location = new System.Drawing.Point(0, 0);
            this.text.Name = "text";
            this.text.ReadOnly = true;
            this.text.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.text.Size = new System.Drawing.Size(151, 20);
            this.text.TabIndex = 6;
            this.text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MyCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 249);
            this.Controls.Add(this.text);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtDisplay);
            this.Name = "MyCalculator";
            this.Text = "calculator";
            this.Load += new System.EventHandler(this.MyCalculator_Load);
            this.Click += new System.EventHandler(this.MyCalculator_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnOpEquals;
        private System.Windows.Forms.Button btnOpDot;
        private System.Windows.Forms.Button btnOpSubtract;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnOpMultiply;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnOpDivide;
        private System.Windows.Forms.Button btnbackSpace;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBlank;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnOpAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TextBox text;
    }
}

