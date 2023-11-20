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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            label4 = new Label();
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
            phoneTypeComboBox = new ComboBox();
            comboBoxManufacturer = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            groupBox2 = new GroupBox();
            listBox1 = new ListBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox4 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            label9 = new Label();
            groupBox3 = new GroupBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            tabPage2 = new TabPage();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBatteryCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScreenSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSimCards).BeginInit();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
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
            groupBox1.Controls.Add(phoneTypeComboBox);
            groupBox1.Controls.Add(comboBoxManufacturer);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(35, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 291);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 68);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 8;
            label4.Text = "Тип устройства";
            // 
            // dateTimePickerReleaseDate
            // 
            dateTimePickerReleaseDate.Location = new Point(107, 253);
            dateTimePickerReleaseDate.Name = "dateTimePickerReleaseDate";
            dateTimePickerReleaseDate.Size = new Size(195, 23);
            dateTimePickerReleaseDate.TabIndex = 7;
            // 
            // numericUpDownBatteryCapacity
            // 
            numericUpDownBatteryCapacity.Location = new Point(182, 195);
            numericUpDownBatteryCapacity.Name = "numericUpDownBatteryCapacity";
            numericUpDownBatteryCapacity.Size = new Size(120, 23);
            numericUpDownBatteryCapacity.TabIndex = 5;
            numericUpDownBatteryCapacity.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDownScreenSize
            // 
            numericUpDownScreenSize.Location = new Point(182, 161);
            numericUpDownScreenSize.Name = "numericUpDownScreenSize";
            numericUpDownScreenSize.Size = new Size(120, 23);
            numericUpDownScreenSize.TabIndex = 5;
            numericUpDownScreenSize.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 259);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 4;
            label8.Text = "Дата выхода";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 227);
            label7.Name = "label7";
            label7.Size = new Size(137, 15);
            label7.TabIndex = 4;
            label7.Text = "Операционная система";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 197);
            label6.Name = "label6";
            label6.Size = new Size(143, 15);
            label6.TabIndex = 4;
            label6.Text = "Емкость батареии (mAh)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 163);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 4;
            label5.Text = "Размер экрана";
            // 
            // numericUpDownSimCards
            // 
            numericUpDownSimCards.Location = new Point(182, 132);
            numericUpDownSimCards.Name = "numericUpDownSimCards";
            numericUpDownSimCards.Size = new Size(120, 23);
            numericUpDownSimCards.TabIndex = 3;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(182, 100);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(120, 23);
            textBoxModel.TabIndex = 2;
            // 
            // osComboBox
            // 
            osComboBox.FormattingEnabled = true;
            osComboBox.Location = new Point(182, 224);
            osComboBox.Name = "osComboBox";
            osComboBox.Size = new Size(120, 23);
            osComboBox.TabIndex = 1;
            // 
            // phoneTypeComboBox
            // 
            phoneTypeComboBox.FormattingEnabled = true;
            phoneTypeComboBox.Location = new Point(109, 65);
            phoneTypeComboBox.Name = "phoneTypeComboBox";
            phoneTypeComboBox.Size = new Size(193, 23);
            phoneTypeComboBox.TabIndex = 1;
            // 
            // comboBoxManufacturer
            // 
            comboBoxManufacturer.FormattingEnabled = true;
            comboBoxManufacturer.Location = new Point(109, 31);
            comboBoxManufacturer.Name = "comboBoxManufacturer";
            comboBoxManufacturer.Size = new Size(193, 23);
            comboBoxManufacturer.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 135);
            label3.Name = "label3";
            label3.Size = new Size(126, 15);
            label3.TabIndex = 0;
            label3.Text = "Количество сим-карт";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 103);
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
            button1.Location = new Point(114, 313);
            button1.Name = "button1";
            button1.Size = new Size(168, 23);
            button1.TabIndex = 1;
            button1.Text = "Ввод информации";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox1);
            groupBox2.Location = new Point(364, 16);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(359, 291);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Просмотр списка";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(5, 23);
            listBox1.Margin = new Padding(2, 1, 2, 1);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(348, 259);
            listBox1.TabIndex = 7;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 28);
            tabControl1.Margin = new Padding(2, 1, 2, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1059, 581);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox4);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2, 1, 2, 1);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 1, 2, 1);
            tabPage1.Size = new Size(1051, 553);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Техника";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button4);
            groupBox4.Controls.Add(button3);
            groupBox4.Controls.Add(label9);
            groupBox4.Location = new Point(364, 313);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(359, 67);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "Работа с файлами";
            // 
            // button4
            // 
            button4.Location = new Point(202, 37);
            button4.Name = "button4";
            button4.Size = new Size(151, 23);
            button4.TabIndex = 1;
            button4.Text = "Загрузить из файла";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(6, 37);
            button3.Name = "button3";
            button3.Size = new Size(157, 23);
            button3.TabIndex = 1;
            button3.Text = "Выгрузить в файл";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 19);
            label9.Name = "label9";
            label9.Size = new Size(190, 15);
            label9.TabIndex = 0;
            label9.Text = "Прошло времени с даты выхода:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(button2);
            groupBox3.Location = new Point(729, 16);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(310, 291);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Просмотр изображения";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(279, 234);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(104, 260);
            button2.Margin = new Padding(2, 1, 2, 1);
            button2.Name = "button2";
            button2.Size = new Size(106, 22);
            button2.TabIndex = 10;
            button2.Text = "Загрузить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2, 1, 2, 1);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 1, 2, 1);
            tabPage2.Size = new Size(1051, 553);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Вторая вкладка";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 619);
            Controls.Add(tabControl1);
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
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
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
        private Label label5;
        private NumericUpDown numericUpDownScreenSize;
        private Label label6;
        private Label label7;
        private ComboBox osComboBox;
        private DateTimePicker dateTimePickerReleaseDate;
        private Label label8;
        private NumericUpDown numericUpDownBatteryCapacity;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListBox listBox1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label4;
        private ComboBox phoneTypeComboBox;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label9;
        private Button button4;
        private Button button3;
    }
}