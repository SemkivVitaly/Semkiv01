namespace task2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioLights = new System.Windows.Forms.RadioButton();
            this.radioNorml = new System.Windows.Forms.RadioButton();
            this.buttonRender = new System.Windows.Forms.Button();
            this.buttonColorSet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSetX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMain = new System.Windows.Forms.ComboBox();
            this.listBoxMain = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(451, 9);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 23);
            this.addbutton.TabIndex = 2;
            this.addbutton.Text = "add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(532, 9);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 23);
            this.deletebutton.TabIndex = 3;
            this.deletebutton.Text = "delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1021, 613);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioLights);
            this.panel1.Controls.Add(this.radioNorml);
            this.panel1.Controls.Add(this.buttonRender);
            this.panel1.Controls.Add(this.buttonColorSet);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxSetX);
            this.panel1.Controls.Add(this.deletebutton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.addbutton);
            this.panel1.Controls.Add(this.comboBoxMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 40);
            this.panel1.TabIndex = 7;
            // 
            // radioLights
            // 
            this.radioLights.AutoSize = true;
            this.radioLights.Location = new System.Drawing.Point(176, 20);
            this.radioLights.Name = "radioLights";
            this.radioLights.Size = new System.Drawing.Size(53, 17);
            this.radioLights.TabIndex = 18;
            this.radioLights.TabStop = true;
            this.radioLights.Text = "Lights";
            this.radioLights.UseVisualStyleBackColor = true;
            // 
            // radioNorml
            // 
            this.radioNorml.AutoSize = true;
            this.radioNorml.Location = new System.Drawing.Point(176, 3);
            this.radioNorml.Name = "radioNorml";
            this.radioNorml.Size = new System.Drawing.Size(52, 17);
            this.radioNorml.TabIndex = 17;
            this.radioNorml.TabStop = true;
            this.radioNorml.Text = "Norml";
            this.radioNorml.UseVisualStyleBackColor = true;
            // 
            // buttonRender
            // 
            this.buttonRender.Location = new System.Drawing.Point(613, 9);
            this.buttonRender.Name = "buttonRender";
            this.buttonRender.Size = new System.Drawing.Size(75, 23);
            this.buttonRender.TabIndex = 16;
            this.buttonRender.Text = "render";
            this.buttonRender.UseVisualStyleBackColor = true;
            this.buttonRender.Click += new System.EventHandler(this.buttonRender_Click_1);
            // 
            // buttonColorSet
            // 
            this.buttonColorSet.Location = new System.Drawing.Point(733, 10);
            this.buttonColorSet.Name = "buttonColorSet";
            this.buttonColorSet.Size = new System.Drawing.Size(75, 23);
            this.buttonColorSet.TabIndex = 15;
            this.buttonColorSet.Text = "set color";
            this.buttonColorSet.UseVisualStyleBackColor = true;
            this.buttonColorSet.Click += new System.EventHandler(this.buttonColorSet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Radius";
            // 
            // textBoxSetX
            // 
            this.textBoxSetX.Location = new System.Drawing.Point(345, 11);
            this.textBoxSetX.Name = "textBoxSetX";
            this.textBoxSetX.Size = new System.Drawing.Size(100, 20);
            this.textBoxSetX.TabIndex = 13;
            this.textBoxSetX.Text = "50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Figure";
            // 
            // comboBoxMain
            // 
            this.comboBoxMain.FormattingEnabled = true;
            this.comboBoxMain.Items.AddRange(new object[] {
            "circle",
            "square",
            "triangle"});
            this.comboBoxMain.Location = new System.Drawing.Point(49, 12);
            this.comboBoxMain.Name = "comboBoxMain";
            this.comboBoxMain.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMain.TabIndex = 7;
            // 
            // listBoxMain
            // 
            this.listBoxMain.FormattingEnabled = true;
            this.listBoxMain.Location = new System.Drawing.Point(814, 0);
            this.listBoxMain.Name = "listBoxMain";
            this.listBoxMain.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxMain.Size = new System.Drawing.Size(204, 30);
            this.listBoxMain.TabIndex = 15;
            this.listBoxMain.SelectedIndexChanged += new System.EventHandler(this.listBoxMain_SelectedIndexChanged);
            this.listBoxMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxMain_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 613);
            this.Controls.Add(this.listBoxMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Semkiv.lab1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMain;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxSetX;
        private System.Windows.Forms.ListBox listBoxMain;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button buttonColorSet;
        private System.Windows.Forms.Button buttonRender;
        private System.Windows.Forms.RadioButton radioLights;
        private System.Windows.Forms.RadioButton radioNorml;
    }
}

