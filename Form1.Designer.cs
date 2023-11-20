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
            listBox1 = new ListBox();
            richTextBoxPhoneInfo = new RichTextBox();
            label4 = new Label();
            button3 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBatteryCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScreenSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSimCards).BeginInit();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            groupBox1.Location = new Point(65, 34);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(600, 561);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод";
            // 
            // dateTimePickerReleaseDate
            // 
            dateTimePickerReleaseDate.Location = new Point(189, 459);
            dateTimePickerReleaseDate.Margin = new Padding(6);
            dateTimePickerReleaseDate.Name = "dateTimePickerReleaseDate";
            dateTimePickerReleaseDate.Size = new Size(368, 39);
            dateTimePickerReleaseDate.TabIndex = 7;
            // 
            // numericUpDownBatteryCapacity
            // 
            numericUpDownBatteryCapacity.Location = new Point(338, 331);
            numericUpDownBatteryCapacity.Margin = new Padding(6);
            numericUpDownBatteryCapacity.Name = "numericUpDownBatteryCapacity";
            numericUpDownBatteryCapacity.Size = new Size(223, 39);
            numericUpDownBatteryCapacity.TabIndex = 5;
            numericUpDownBatteryCapacity.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDownScreenSize
            // 
            numericUpDownScreenSize.Location = new Point(338, 258);
            numericUpDownScreenSize.Margin = new Padding(6);
            numericUpDownScreenSize.Name = "numericUpDownScreenSize";
            numericUpDownScreenSize.Size = new Size(223, 39);
            numericUpDownScreenSize.TabIndex = 5;
            numericUpDownScreenSize.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 471);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(152, 32);
            label8.TabIndex = 4;
            label8.Text = "Дата выхода";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 399);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(274, 32);
            label7.TabIndex = 4;
            label7.Text = "Операционная система";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 335);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(283, 32);
            label6.TabIndex = 4;
            label6.Text = "Емкость батареии (mAh)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 262);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(176, 32);
            label5.TabIndex = 4;
            label5.Text = "Размер экрана";
            // 
            // numericUpDownSimCards
            // 
            numericUpDownSimCards.Location = new Point(338, 196);
            numericUpDownSimCards.Margin = new Padding(6);
            numericUpDownSimCards.Name = "numericUpDownSimCards";
            numericUpDownSimCards.Size = new Size(223, 39);
            numericUpDownSimCards.TabIndex = 3;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(338, 128);
            textBoxModel.Margin = new Padding(6);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(219, 39);
            textBoxModel.TabIndex = 2;
            // 
            // osComboBox
            // 
            osComboBox.FormattingEnabled = true;
            osComboBox.Location = new Point(338, 393);
            osComboBox.Margin = new Padding(6);
            osComboBox.Name = "osComboBox";
            osComboBox.Size = new Size(219, 40);
            osComboBox.TabIndex = 1;
            // 
            // comboBoxManufacturer
            // 
            comboBoxManufacturer.FormattingEnabled = true;
            comboBoxManufacturer.Location = new Point(338, 66);
            comboBoxManufacturer.Margin = new Padding(6);
            comboBoxManufacturer.Name = "comboBoxManufacturer";
            comboBoxManufacturer.Size = new Size(219, 40);
            comboBoxManufacturer.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 203);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(251, 32);
            label3.TabIndex = 0;
            label3.Text = "Количество сим-карт";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 134);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 32);
            label2.TabIndex = 0;
            label2.Text = "Модель";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 73);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 32);
            label1.TabIndex = 0;
            label1.Text = "Производитель";
            // 
            // button1
            // 
            button1.Location = new Point(211, 607);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(312, 49);
            button1.TabIndex = 1;
            button1.Text = "Ввод информации";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox1);
            groupBox2.Controls.Add(richTextBoxPhoneInfo);
            groupBox2.Location = new Point(692, 51);
            groupBox2.Margin = new Padding(6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6);
            groupBox2.Size = new Size(1407, 486);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Просмотр";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(741, 64);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(642, 388);
            listBox1.TabIndex = 7;
            // 
            // richTextBoxPhoneInfo
            // 
            richTextBoxPhoneInfo.Location = new Point(33, 64);
            richTextBoxPhoneInfo.Margin = new Padding(6);
            richTextBoxPhoneInfo.Name = "richTextBoxPhoneInfo";
            richTextBoxPhoneInfo.Size = new Size(699, 377);
            richTextBoxPhoneInfo.TabIndex = 0;
            richTextBoxPhoneInfo.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(211, 693);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 32);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // button3
            // 
            button3.Location = new Point(893, 578);
            button3.Margin = new Padding(6);
            button3.Name = "button3";
            button3.Size = new Size(394, 49);
            button3.TabIndex = 6;
            button3.Text = "Тестирование конструкторов";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(22, 59);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(2561, 736);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(2545, 682);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Техника";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(2239, 526);
            button2.Name = "button2";
            button2.Size = new Size(196, 46);
            button2.TabIndex = 10;
            button2.Text = "Загрузить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(2111, 73);
            label9.Name = "label9";
            label9.Size = new Size(181, 32);
            label9.TabIndex = 9;
            label9.Text = "Изображение: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(2108, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(418, 388);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(2545, 682);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Вторая вкладка";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2595, 804);
            Controls.Add(tabControl1);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBatteryCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScreenSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSimCards).EndInit();
            groupBox2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListBox listBox1;
        private Label label9;
        private PictureBox pictureBox1;
        private Button button2;
    }
}