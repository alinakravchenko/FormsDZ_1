namespace FormsDZ_1
{
    partial class Form2
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxF2 = new System.Windows.Forms.TextBox();
            this.btnSearchF2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(12, 1);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(458, 244);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вводите маску поиска, например «*.doc».";
            // 
            // textBoxF2
            // 
            this.textBoxF2.Location = new System.Drawing.Point(12, 270);
            this.textBoxF2.Name = "textBoxF2";
            this.textBoxF2.Size = new System.Drawing.Size(237, 23);
            this.textBoxF2.TabIndex = 2;
            // 
            // btnSearchF2
            // 
            this.btnSearchF2.Location = new System.Drawing.Point(275, 270);
            this.btnSearchF2.Name = "btnSearchF2";
            this.btnSearchF2.Size = new System.Drawing.Size(150, 23);
            this.btnSearchF2.TabIndex = 3;
            this.btnSearchF2.Text = "Поиск";
            this.btnSearchF2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 296);
            this.Controls.Add(this.btnSearchF2);
            this.Controls.Add(this.textBoxF2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Name = "Form2";
            this.Text = "Окно поиска";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox;
        private Label label1;
        private TextBox textBoxF2;
        private Button btnSearchF2;
    }
}