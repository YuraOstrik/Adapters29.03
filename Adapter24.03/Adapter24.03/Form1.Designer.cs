namespace Adapter24._03
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 52);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "Ко-во адапторов";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(459, 275);
            button1.Name = "button1";
            button1.Size = new Size(190, 112);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(401, 52);
            label2.Name = "label2";
            label2.Size = new Size(206, 20);
            label2.TabIndex = 3;
            label2.Text = "Активных TCP-подключений";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 97);
            label3.Name = "label3";
            label3.Size = new Size(9, 20);
            label3.TabIndex = 6;
            label3.Text = "\r\n";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(474, 97);
            label4.Name = "label4";
            label4.Size = new Size(9, 20);
            label4.TabIndex = 7;
            label4.Text = "\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(142, 259);
            label5.Name = "label5";
            label5.Size = new Size(9, 20);
            label5.TabIndex = 8;
            label5.Text = "\r\n";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(60, 215);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(268, 184);
            listBox1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(116, 259);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private Label label6;
    }
}
