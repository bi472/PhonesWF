namespace WinFormsApp1
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
            groupBox1 = new GroupBox();
            dateTimePickerReleaseDate = new DateTimePicker();
            numericUpDownBatteryCapacity = new NumericUpDown();
            numericUpDownScreenSize = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            numericUpDownSimCards = new NumericUpDown();
            textBoxModel = new TextBox();
            osComboBox = new ComboBox();
            comboBoxManufacturer = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            groupBox2 = new GroupBox();
            richTextBoxPhoneInfo = new RichTextBox();
            label4 = new Label();
            button3 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBatteryCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScreenSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSimCards).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePickerReleaseDate);
            groupBox1.Controls.Add(numericUpDownBatteryCapacity);
            groupBox1.Controls.Add(numericUpDownScreenSize);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(numericUpDownSimCards);
            groupBox1.Controls.Add(textBoxModel);
            groupBox1.Controls.Add(osComboBox);
            groupBox1.Controls.Add(comboBoxManufacturer);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(20, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 263);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод";
            // 
            // dateTimePickerReleaseDate
            // 
            dateTimePickerReleaseDate.Location = new Point(102, 215);
            dateTimePickerReleaseDate.Name = "dateTimePickerReleaseDate";
            dateTimePickerReleaseDate.Size = new Size(200, 23);
            dateTimePickerReleaseDate.TabIndex = 7;
            // 
            // numericUpDownBatteryCapacity
            // 
            numericUpDownBatteryCapacity.Location = new Point(182, 155);
            numericUpDownBatteryCapacity.Name = "numericUpDownBatteryCapacity";
            numericUpDownBatteryCapacity.Size = new Size(120, 23);
            numericUpDownBatteryCapacity.TabIndex = 5;
            numericUpDownBatteryCapacity.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDownScreenSize
            // 
            numericUpDownScreenSize.Location = new Point(182, 121);
            numericUpDownScreenSize.Name = "numericUpDownScreenSize";
            numericUpDownScreenSize.Size = new Size(120, 23);
            numericUpDownScreenSize.TabIndex = 5;
            numericUpDownScreenSize.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 221);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 4;
            label8.Text = "Дата выхода";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 187);
            label7.Name = "label7";
            label7.Size = new Size(137, 15);
            label7.TabIndex = 4;
            label7.Text = "Операционная система";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 157);
            label6.Name = "label6";
            label6.Size = new Size(143, 15);
            label6.TabIndex = 4;
            label6.Text = "Емкость батареии (mAh)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 123);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 4;
            label5.Text = "Размер экрана";
            // 
            // numericUpDownSimCards
            // 
            numericUpDownSimCards.Location = new Point(182, 92);
            numericUpDownSimCards.Name = "numericUpDownSimCards";
            numericUpDownSimCards.Size = new Size(120, 23);
            numericUpDownSimCards.TabIndex = 3;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(182, 60);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(120, 23);
            textBoxModel.TabIndex = 2;
            // 
            // osComboBox
            // 
            osComboBox.FormattingEnabled = true;
            osComboBox.Location = new Point(182, 184);
            osComboBox.Name = "osComboBox";
            osComboBox.Size = new Size(120, 23);
            osComboBox.TabIndex = 1;
            // 
            // comboBoxManufacturer
            // 
            comboBoxManufacturer.FormattingEnabled = true;
            comboBoxManufacturer.Location = new Point(182, 31);
            comboBoxManufacturer.Name = "comboBoxManufacturer";
            comboBoxManufacturer.Size = new Size(120, 23);
            comboBoxManufacturer.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 95);
            label3.Name = "label3";
            label3.Size = new Size(126, 15);
            label3.TabIndex = 0;
            label3.Text = "Количество сим-карт";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 63);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 0;
            label2.Text = "Модель";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 34);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Производитель";
            // 
            // button1
            // 
            button1.Location = new Point(20, 325);
            button1.Name = "button1";
            button1.Size = new Size(168, 23);
            button1.TabIndex = 1;
            button1.Text = "Ввод информации";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBoxPhoneInfo);
            groupBox2.Location = new Point(349, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(417, 228);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Просмотр";
            // 
            // richTextBoxPhoneInfo
            // 
            richTextBoxPhoneInfo.Location = new Point(18, 30);
            richTextBoxPhoneInfo.Name = "richTextBoxPhoneInfo";
            richTextBoxPhoneInfo.Size = new Size(378, 179);
            richTextBoxPhoneInfo.TabIndex = 0;
            richTextBoxPhoneInfo.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 365);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // button3
            // 
            button3.Location = new Point(476, 293);
            button3.Name = "button3";
            button3.Size = new Size(212, 23);
            button3.TabIndex = 6;
            button3.Text = "Тестирование конструкторов";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 413);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBatteryCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScreenSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSimCards).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown numericUpDownSimCards;
        private TextBox textBoxModel;
        private ComboBox comboBoxManufacturer;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private GroupBox groupBox2;
        private RichTextBox richTextBoxPhoneInfo;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDownScreenSize;
        private Label label6;
        private Label label7;
        private ComboBox osComboBox;
        private Button button3;
        private DateTimePicker dateTimePickerReleaseDate;
        private Label label8;
        private NumericUpDown numericUpDownBatteryCapacity;
    }
}