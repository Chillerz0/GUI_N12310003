namespace GUI_N12310003
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ClickMe = new System.Windows.Forms.Button();
            this.lab_Changelabel = new System.Windows.Forms.Label();
            this.btn_ChangeLabel = new System.Windows.Forms.Button();
            this.btn_Counter = new System.Windows.Forms.Button();
            this.lab_Counter = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Btnbigger = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "N12310003";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_ClickMe
            // 
            this.btn_ClickMe.BackColor = System.Drawing.Color.LightGray;
            this.btn_ClickMe.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ClickMe.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_ClickMe.Location = new System.Drawing.Point(12, 104);
            this.btn_ClickMe.Name = "btn_ClickMe";
            this.btn_ClickMe.Size = new System.Drawing.Size(319, 70);
            this.btn_ClickMe.TabIndex = 1;
            this.btn_ClickMe.Text = "按我一下";
            this.btn_ClickMe.UseVisualStyleBackColor = false;
            this.btn_ClickMe.Click += new System.EventHandler(this.btn_ClickMe_Click);
            // 
            // lab_Changelabel
            // 
            this.lab_Changelabel.AutoSize = true;
            this.lab_Changelabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Changelabel.Location = new System.Drawing.Point(203, 197);
            this.lab_Changelabel.Name = "lab_Changelabel";
            this.lab_Changelabel.Size = new System.Drawing.Size(0, 31);
            this.lab_Changelabel.TabIndex = 2;
            this.lab_Changelabel.Click += new System.EventHandler(this.btn_ChangeLabel_Click);
            // 
            // btn_ChangeLabel
            // 
            this.btn_ChangeLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_ChangeLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ChangeLabel.Location = new System.Drawing.Point(12, 187);
            this.btn_ChangeLabel.Name = "btn_ChangeLabel";
            this.btn_ChangeLabel.Size = new System.Drawing.Size(173, 51);
            this.btn_ChangeLabel.TabIndex = 3;
            this.btn_ChangeLabel.Text = "按我切換標籤";
            this.btn_ChangeLabel.UseVisualStyleBackColor = false;
            this.btn_ChangeLabel.Click += new System.EventHandler(this.btn_ChangeLabel_Click);
            // 
            // btn_Counter
            // 
            this.btn_Counter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Counter.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Counter.Location = new System.Drawing.Point(12, 256);
            this.btn_Counter.Name = "btn_Counter";
            this.btn_Counter.Size = new System.Drawing.Size(173, 51);
            this.btn_Counter.TabIndex = 5;
            this.btn_Counter.Text = "按我+1";
            this.btn_Counter.UseVisualStyleBackColor = false;
            this.btn_Counter.Click += new System.EventHandler(this.btn_Counter_Click);
            // 
            // lab_Counter
            // 
            this.lab_Counter.AutoSize = true;
            this.lab_Counter.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Counter.Location = new System.Drawing.Point(203, 266);
            this.lab_Counter.Name = "lab_Counter";
            this.lab_Counter.Size = new System.Drawing.Size(28, 31);
            this.lab_Counter.TabIndex = 4;
            this.lab_Counter.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Btnbigger
            // 
            this.Btnbigger.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btnbigger.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btnbigger.Location = new System.Drawing.Point(360, 104);
            this.Btnbigger.Name = "Btnbigger";
            this.Btnbigger.Size = new System.Drawing.Size(126, 70);
            this.Btnbigger.TabIndex = 7;
            this.Btnbigger.Text = "按鈕變大";
            this.Btnbigger.UseVisualStyleBackColor = false;
            this.Btnbigger.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(593, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 51);
            this.button2.TabIndex = 8;
            this.button2.Text = "按我複製至label";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(589, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Label";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(593, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btnbigger);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Counter);
            this.Controls.Add(this.lab_Counter);
            this.Controls.Add(this.btn_ChangeLabel);
            this.Controls.Add(this.lab_Changelabel);
            this.Controls.Add(this.btn_ClickMe);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ClickMe;
        private System.Windows.Forms.Label lab_Changelabel;
        private System.Windows.Forms.Button btn_ChangeLabel;
        private System.Windows.Forms.Button btn_Counter;
        private System.Windows.Forms.Label lab_Counter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btnbigger;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

