namespace calculatorr
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            screenLabel = new Label();
            number1Button = new Button();
            number2button = new Button();
            number3Button = new Button();
            number4Button = new Button();
            number5Button = new Button();
            number6Button = new Button();
            number7Button = new Button();
            number8Button = new Button();
            number9Button = new Button();
            number0Button = new Button();
            dotButton = new Button();
            equalButton = new Button();
            additionButton = new Button();
            subtractionButton = new Button();
            multiplicationButton = new Button();
            divisionButton = new Button();
            clearAllbutton = new Button();
            SuspendLayout();
            // 
            // screenLabel
            // 
            screenLabel.BackColor = Color.White;
            screenLabel.Font = new Font("Calibri", 30F, FontStyle.Regular, GraphicsUnit.Point);
            screenLabel.Location = new Point(12, 9);
            screenLabel.Name = "screenLabel";
            screenLabel.Size = new Size(238, 44);
            screenLabel.TabIndex = 0;
            screenLabel.Text = "0";
            screenLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // number1Button
            // 
            number1Button.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            number1Button.Location = new Point(12, 116);
            number1Button.Name = "number1Button";
            number1Button.Size = new Size(55, 55);
            number1Button.TabIndex = 1;
            number1Button.Text = "1";
            number1Button.UseVisualStyleBackColor = true;
            number1Button.Click += number1Button_Click;
            // 
            // number2button
            // 
            number2button.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            number2button.Location = new Point(73, 116);
            number2button.Name = "number2button";
            number2button.Size = new Size(55, 55);
            number2button.TabIndex = 2;
            number2button.Text = "2";
            number2button.UseVisualStyleBackColor = true;
            number2button.Click += number2button_Click;
            // 
            // number3Button
            // 
            number3Button.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            number3Button.Location = new Point(134, 116);
            number3Button.Name = "number3Button";
            number3Button.Size = new Size(55, 55);
            number3Button.TabIndex = 3;
            number3Button.Text = "3";
            number3Button.UseVisualStyleBackColor = true;
            number3Button.Click += number3Button_Click;
            // 
            // number4Button
            // 
            number4Button.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            number4Button.Location = new Point(12, 177);
            number4Button.Name = "number4Button";
            number4Button.Size = new Size(55, 55);
            number4Button.TabIndex = 4;
            number4Button.Text = "4";
            number4Button.UseVisualStyleBackColor = true;
            number4Button.Click += number4Button_Click;
            // 
            // number5Button
            // 
            number5Button.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            number5Button.Location = new Point(73, 177);
            number5Button.Name = "number5Button";
            number5Button.Size = new Size(55, 55);
            number5Button.TabIndex = 5;
            number5Button.Text = "5";
            number5Button.UseVisualStyleBackColor = true;
            number5Button.Click += number5Button_Click;
            // 
            // number6Button
            // 
            number6Button.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            number6Button.Location = new Point(134, 177);
            number6Button.Name = "number6Button";
            number6Button.Size = new Size(55, 55);
            number6Button.TabIndex = 6;
            number6Button.Text = "6";
            number6Button.UseVisualStyleBackColor = true;
            number6Button.Click += number6Button_Click;
            // 
            // number7Button
            // 
            number7Button.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            number7Button.Location = new Point(12, 238);
            number7Button.Name = "number7Button";
            number7Button.Size = new Size(55, 55);
            number7Button.TabIndex = 7;
            number7Button.Text = "7";
            number7Button.UseVisualStyleBackColor = true;
            number7Button.Click += number7Button_Click;
            // 
            // number8Button
            // 
            number8Button.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            number8Button.Location = new Point(73, 238);
            number8Button.Name = "number8Button";
            number8Button.Size = new Size(55, 55);
            number8Button.TabIndex = 8;
            number8Button.Text = "8";
            number8Button.UseVisualStyleBackColor = true;
            number8Button.Click += number8Button_Click;
            // 
            // number9Button
            // 
            number9Button.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            number9Button.Location = new Point(134, 238);
            number9Button.Name = "number9Button";
            number9Button.Size = new Size(55, 55);
            number9Button.TabIndex = 9;
            number9Button.Text = "9";
            number9Button.UseVisualStyleBackColor = true;
            number9Button.Click += number9Button_Click;
            // 
            // number0Button
            // 
            number0Button.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            number0Button.Location = new Point(12, 299);
            number0Button.Name = "number0Button";
            number0Button.Size = new Size(55, 55);
            number0Button.TabIndex = 10;
            number0Button.Text = "0";
            number0Button.UseVisualStyleBackColor = true;
            number0Button.Click += number0Button_Click;
            // 
            // dotButton
            // 
            dotButton.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dotButton.Location = new Point(73, 299);
            dotButton.Name = "dotButton";
            dotButton.Size = new Size(55, 55);
            dotButton.TabIndex = 11;
            dotButton.Text = ".";
            dotButton.UseVisualStyleBackColor = true;
            dotButton.Click += dotButton_Click;
            // 
            // equalButton
            // 
            equalButton.BackColor = Color.LavenderBlush;
            equalButton.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            equalButton.Location = new Point(134, 299);
            equalButton.Name = "equalButton";
            equalButton.Size = new Size(55, 55);
            equalButton.TabIndex = 12;
            equalButton.Text = "=";
            equalButton.UseVisualStyleBackColor = false;
            equalButton.Click += equalButton_Click;
            // 
            // additionButton
            // 
            additionButton.BackColor = Color.LavenderBlush;
            additionButton.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            additionButton.Location = new Point(195, 116);
            additionButton.Name = "additionButton";
            additionButton.Size = new Size(55, 55);
            additionButton.TabIndex = 13;
            additionButton.Text = "+";
            additionButton.UseVisualStyleBackColor = false;
            additionButton.Click += additionButton_Click;
            // 
            // subtractionButton
            // 
            subtractionButton.BackColor = Color.LavenderBlush;
            subtractionButton.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            subtractionButton.Location = new Point(195, 177);
            subtractionButton.Name = "subtractionButton";
            subtractionButton.Size = new Size(55, 55);
            subtractionButton.TabIndex = 14;
            subtractionButton.Text = "-";
            subtractionButton.UseVisualStyleBackColor = false;
            subtractionButton.Click += subtractionButton_Click;
            // 
            // multiplicationButton
            // 
            multiplicationButton.BackColor = Color.LavenderBlush;
            multiplicationButton.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            multiplicationButton.Location = new Point(195, 238);
            multiplicationButton.Name = "multiplicationButton";
            multiplicationButton.Size = new Size(55, 55);
            multiplicationButton.TabIndex = 15;
            multiplicationButton.Text = "x";
            multiplicationButton.UseVisualStyleBackColor = false;
            multiplicationButton.Click += multiplicationButton_Click;
            // 
            // divisionButton
            // 
            divisionButton.BackColor = Color.LavenderBlush;
            divisionButton.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            divisionButton.Location = new Point(195, 299);
            divisionButton.Name = "divisionButton";
            divisionButton.Size = new Size(55, 55);
            divisionButton.TabIndex = 16;
            divisionButton.Text = "/";
            divisionButton.UseVisualStyleBackColor = false;
            divisionButton.Click += divisionButton_Click;
            // 
            // clearAllbutton
            // 
            clearAllbutton.BackColor = Color.LavenderBlush;
            clearAllbutton.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            clearAllbutton.Location = new Point(12, 56);
            clearAllbutton.Name = "clearAllbutton";
            clearAllbutton.Size = new Size(55, 55);
            clearAllbutton.TabIndex = 17;
            clearAllbutton.Text = "C";
            clearAllbutton.UseVisualStyleBackColor = false;
            clearAllbutton.Click += clearAllbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(266, 371);
            Controls.Add(clearAllbutton);
            Controls.Add(divisionButton);
            Controls.Add(multiplicationButton);
            Controls.Add(subtractionButton);
            Controls.Add(additionButton);
            Controls.Add(equalButton);
            Controls.Add(dotButton);
            Controls.Add(number0Button);
            Controls.Add(screenLabel);
            Controls.Add(number9Button);
            Controls.Add(number8Button);
            Controls.Add(number7Button);
            Controls.Add(number6Button);
            Controls.Add(number5Button);
            Controls.Add(number4Button);
            Controls.Add(number3Button);
            Controls.Add(number2button);
            Controls.Add(number1Button);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Label screenLabel;
        private Button number1Button;
        private Button number2button;
        private Button number3Button;
        private Button number4Button;
        private Button number5Button;
        private Button number6Button;
        private Button number7Button;
        private Button number8Button;
        private Button number9Button;
        private Button number0Button;
        private Button dotButton;
        private Button equalButton;
        private Button additionButton;
        private Button subtractionButton;
        private Button multiplicationButton;
        private Button divisionButton;
        private Button clearAllbutton;
    }
}