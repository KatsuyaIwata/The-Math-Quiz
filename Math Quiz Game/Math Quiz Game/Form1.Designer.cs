namespace Math_Quiz_Game
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
            this.components = new System.ComponentModel.Container();
            this.Time_Label = new System.Windows.Forms.Label();
            this.Time_Remaining_Label = new System.Windows.Forms.Label();
            this.Plus_Left_Label = new System.Windows.Forms.Label();
            this.Plus_Equal_Label = new System.Windows.Forms.Label();
            this.Plus_Right_Label = new System.Windows.Forms.Label();
            this.Plus_Label = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.NumericUpDown();
            this.Subtract = new System.Windows.Forms.NumericUpDown();
            this.Subtract_Label = new System.Windows.Forms.Label();
            this.Subtract_Right_Label = new System.Windows.Forms.Label();
            this.Subtract_Equal_Label = new System.Windows.Forms.Label();
            this.Subtract_Left_Label = new System.Windows.Forms.Label();
            this.Divide = new System.Windows.Forms.NumericUpDown();
            this.Divide_Label = new System.Windows.Forms.Label();
            this.Divide_Right_Label = new System.Windows.Forms.Label();
            this.Divide_Equal_Label = new System.Windows.Forms.Label();
            this.Divide_Left_Label = new System.Windows.Forms.Label();
            this.Multiply = new System.Windows.Forms.NumericUpDown();
            this.Multiply_Label = new System.Windows.Forms.Label();
            this.Multiply_Right_Label = new System.Windows.Forms.Label();
            this.Multiply_Equal_Label = new System.Windows.Forms.Label();
            this.Multiply_Left_Label = new System.Windows.Forms.Label();
            this.Start_Button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Subtract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Divide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Multiply)).BeginInit();
            this.SuspendLayout();
            // 
            // Time_Label
            // 
            this.Time_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Time_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_Label.Location = new System.Drawing.Point(343, 13);
            this.Time_Label.Name = "Time_Label";
            this.Time_Label.Size = new System.Drawing.Size(200, 30);
            this.Time_Label.TabIndex = 0;
            // 
            // Time_Remaining_Label
            // 
            this.Time_Remaining_Label.AutoSize = true;
            this.Time_Remaining_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_Remaining_Label.Location = new System.Drawing.Point(99, 11);
            this.Time_Remaining_Label.Name = "Time_Remaining_Label";
            this.Time_Remaining_Label.Size = new System.Drawing.Size(230, 32);
            this.Time_Remaining_Label.TabIndex = 1;
            this.Time_Remaining_Label.Text = "Time Remaining:";
            // 
            // Plus_Left_Label
            // 
            this.Plus_Left_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plus_Left_Label.Location = new System.Drawing.Point(28, 74);
            this.Plus_Left_Label.Name = "Plus_Left_Label";
            this.Plus_Left_Label.Size = new System.Drawing.Size(60, 50);
            this.Plus_Left_Label.TabIndex = 2;
            this.Plus_Left_Label.Text = "?";
            this.Plus_Left_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Plus_Equal_Label
            // 
            this.Plus_Equal_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plus_Equal_Label.Location = new System.Drawing.Point(351, 74);
            this.Plus_Equal_Label.Name = "Plus_Equal_Label";
            this.Plus_Equal_Label.Size = new System.Drawing.Size(60, 50);
            this.Plus_Equal_Label.TabIndex = 3;
            this.Plus_Equal_Label.Text = "=";
            this.Plus_Equal_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Plus_Right_Label
            // 
            this.Plus_Right_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plus_Right_Label.Location = new System.Drawing.Point(250, 74);
            this.Plus_Right_Label.Name = "Plus_Right_Label";
            this.Plus_Right_Label.Size = new System.Drawing.Size(60, 50);
            this.Plus_Right_Label.TabIndex = 4;
            this.Plus_Right_Label.Text = "?";
            this.Plus_Right_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Plus_Label
            // 
            this.Plus_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plus_Label.Location = new System.Drawing.Point(137, 74);
            this.Plus_Label.Name = "Plus_Label";
            this.Plus_Label.Size = new System.Drawing.Size(60, 50);
            this.Plus_Label.TabIndex = 5;
            this.Plus_Label.Text = "+";
            this.Plus_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sum
            // 
            this.Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum.Location = new System.Drawing.Point(443, 79);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(100, 41);
            this.Sum.TabIndex = 2;
            // 
            // Subtract
            // 
            this.Subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtract.Location = new System.Drawing.Point(443, 147);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(100, 41);
            this.Subtract.TabIndex = 3;
            // 
            // Subtract_Label
            // 
            this.Subtract_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtract_Label.Location = new System.Drawing.Point(137, 142);
            this.Subtract_Label.Name = "Subtract_Label";
            this.Subtract_Label.Size = new System.Drawing.Size(60, 50);
            this.Subtract_Label.TabIndex = 10;
            this.Subtract_Label.Text = "-";
            this.Subtract_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Subtract_Right_Label
            // 
            this.Subtract_Right_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtract_Right_Label.Location = new System.Drawing.Point(250, 142);
            this.Subtract_Right_Label.Name = "Subtract_Right_Label";
            this.Subtract_Right_Label.Size = new System.Drawing.Size(60, 50);
            this.Subtract_Right_Label.TabIndex = 9;
            this.Subtract_Right_Label.Text = "?";
            this.Subtract_Right_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Subtract_Equal_Label
            // 
            this.Subtract_Equal_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtract_Equal_Label.Location = new System.Drawing.Point(351, 142);
            this.Subtract_Equal_Label.Name = "Subtract_Equal_Label";
            this.Subtract_Equal_Label.Size = new System.Drawing.Size(60, 50);
            this.Subtract_Equal_Label.TabIndex = 8;
            this.Subtract_Equal_Label.Text = "=";
            this.Subtract_Equal_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Subtract_Left_Label
            // 
            this.Subtract_Left_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtract_Left_Label.Location = new System.Drawing.Point(28, 142);
            this.Subtract_Left_Label.Name = "Subtract_Left_Label";
            this.Subtract_Left_Label.Size = new System.Drawing.Size(60, 50);
            this.Subtract_Left_Label.TabIndex = 7;
            this.Subtract_Left_Label.Text = "?";
            this.Subtract_Left_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide.Location = new System.Drawing.Point(443, 216);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(100, 41);
            this.Divide.TabIndex = 4;
            // 
            // Divide_Label
            // 
            this.Divide_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide_Label.Location = new System.Drawing.Point(137, 211);
            this.Divide_Label.Name = "Divide_Label";
            this.Divide_Label.Size = new System.Drawing.Size(60, 50);
            this.Divide_Label.TabIndex = 15;
            this.Divide_Label.Text = "/";
            this.Divide_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Divide_Right_Label
            // 
            this.Divide_Right_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide_Right_Label.Location = new System.Drawing.Point(250, 211);
            this.Divide_Right_Label.Name = "Divide_Right_Label";
            this.Divide_Right_Label.Size = new System.Drawing.Size(60, 50);
            this.Divide_Right_Label.TabIndex = 14;
            this.Divide_Right_Label.Text = "?";
            this.Divide_Right_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Divide_Equal_Label
            // 
            this.Divide_Equal_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide_Equal_Label.Location = new System.Drawing.Point(351, 211);
            this.Divide_Equal_Label.Name = "Divide_Equal_Label";
            this.Divide_Equal_Label.Size = new System.Drawing.Size(60, 50);
            this.Divide_Equal_Label.TabIndex = 13;
            this.Divide_Equal_Label.Text = "=";
            this.Divide_Equal_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Divide_Left_Label
            // 
            this.Divide_Left_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide_Left_Label.Location = new System.Drawing.Point(28, 211);
            this.Divide_Left_Label.Name = "Divide_Left_Label";
            this.Divide_Left_Label.Size = new System.Drawing.Size(60, 50);
            this.Divide_Left_Label.TabIndex = 12;
            this.Divide_Left_Label.Text = "?";
            this.Divide_Left_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply.Location = new System.Drawing.Point(443, 287);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(100, 41);
            this.Multiply.TabIndex = 5;
            // 
            // Multiply_Label
            // 
            this.Multiply_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply_Label.Location = new System.Drawing.Point(137, 282);
            this.Multiply_Label.Name = "Multiply_Label";
            this.Multiply_Label.Size = new System.Drawing.Size(60, 50);
            this.Multiply_Label.TabIndex = 20;
            this.Multiply_Label.Text = "*";
            this.Multiply_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Multiply_Right_Label
            // 
            this.Multiply_Right_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply_Right_Label.Location = new System.Drawing.Point(250, 282);
            this.Multiply_Right_Label.Name = "Multiply_Right_Label";
            this.Multiply_Right_Label.Size = new System.Drawing.Size(60, 50);
            this.Multiply_Right_Label.TabIndex = 19;
            this.Multiply_Right_Label.Text = "?";
            this.Multiply_Right_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Multiply_Equal_Label
            // 
            this.Multiply_Equal_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply_Equal_Label.Location = new System.Drawing.Point(351, 282);
            this.Multiply_Equal_Label.Name = "Multiply_Equal_Label";
            this.Multiply_Equal_Label.Size = new System.Drawing.Size(60, 50);
            this.Multiply_Equal_Label.TabIndex = 18;
            this.Multiply_Equal_Label.Text = "=";
            this.Multiply_Equal_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Multiply_Left_Label
            // 
            this.Multiply_Left_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply_Left_Label.Location = new System.Drawing.Point(28, 282);
            this.Multiply_Left_Label.Name = "Multiply_Left_Label";
            this.Multiply_Left_Label.Size = new System.Drawing.Size(60, 50);
            this.Multiply_Left_Label.TabIndex = 17;
            this.Multiply_Left_Label.Text = "?";
            this.Multiply_Left_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Start_Button
            // 
            this.Start_Button.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Button.Location = new System.Drawing.Point(250, 392);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(94, 45);
            this.Start_Button.TabIndex = 1;
            this.Start_Button.Text = "Start!";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(578, 449);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Multiply_Label);
            this.Controls.Add(this.Multiply_Right_Label);
            this.Controls.Add(this.Multiply_Equal_Label);
            this.Controls.Add(this.Multiply_Left_Label);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Divide_Label);
            this.Controls.Add(this.Divide_Right_Label);
            this.Controls.Add(this.Divide_Equal_Label);
            this.Controls.Add(this.Divide_Left_Label);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Subtract_Label);
            this.Controls.Add(this.Subtract_Right_Label);
            this.Controls.Add(this.Subtract_Equal_Label);
            this.Controls.Add(this.Subtract_Left_Label);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Plus_Label);
            this.Controls.Add(this.Plus_Right_Label);
            this.Controls.Add(this.Plus_Equal_Label);
            this.Controls.Add(this.Plus_Left_Label);
            this.Controls.Add(this.Time_Remaining_Label);
            this.Controls.Add(this.Time_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Math Quiz Game - Lets Check You Skill";
            ((System.ComponentModel.ISupportInitialize)(this.Sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Subtract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Divide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Multiply)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Time_Label;
        private System.Windows.Forms.Label Time_Remaining_Label;
        private System.Windows.Forms.Label Plus_Left_Label;
        private System.Windows.Forms.Label Plus_Equal_Label;
        private System.Windows.Forms.Label Plus_Right_Label;
        private System.Windows.Forms.Label Plus_Label;
        private System.Windows.Forms.NumericUpDown Sum;
        private System.Windows.Forms.NumericUpDown Subtract;
        private System.Windows.Forms.Label Subtract_Label;
        private System.Windows.Forms.Label Subtract_Right_Label;
        private System.Windows.Forms.Label Subtract_Equal_Label;
        private System.Windows.Forms.Label Subtract_Left_Label;
        private System.Windows.Forms.NumericUpDown Divide;
        private System.Windows.Forms.Label Divide_Label;
        private System.Windows.Forms.Label Divide_Right_Label;
        private System.Windows.Forms.Label Divide_Equal_Label;
        private System.Windows.Forms.Label Divide_Left_Label;
        private System.Windows.Forms.NumericUpDown Multiply;
        private System.Windows.Forms.Label Multiply_Label;
        private System.Windows.Forms.Label Multiply_Right_Label;
        private System.Windows.Forms.Label Multiply_Equal_Label;
        private System.Windows.Forms.Label Multiply_Left_Label;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Timer timer1;
    }
}

