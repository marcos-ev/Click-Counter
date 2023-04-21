namespace TimerClicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            star = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            reset = new Button();
            SuspendLayout();
            // 
            // star
            // 
            star.BackColor = Color.Transparent;
            star.BackgroundImage = (Image)resources.GetObject("star.BackgroundImage");
            star.BackgroundImageLayout = ImageLayout.Stretch;
            star.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            star.FlatAppearance.BorderSize = 0;
            star.FlatAppearance.MouseDownBackColor = Color.Transparent;
            star.FlatAppearance.MouseOverBackColor = Color.Transparent;
            star.FlatStyle = FlatStyle.Flat;
            star.ForeColor = Color.Transparent;
            star.Location = new Point(12, 164);
            star.Name = "star";
            star.Size = new Size(147, 128);
            star.TabIndex = 0;
            star.UseVisualStyleBackColor = false;
            star.Click += star_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(0, 5);
            label1.Name = "label1";
            label1.Size = new Size(308, 35);
            label1.TabIndex = 1;
            label1.Text = "Timer: ";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(0, 35);
            label2.Name = "label2";
            label2.Size = new Size(308, 40);
            label2.TabIndex = 2;
            label2.Text = "Clicks:";
            // 
            // reset
            // 
            reset.BackColor = Color.Transparent;
            reset.BackgroundImage = (Image)resources.GetObject("reset.BackgroundImage");
            reset.BackgroundImageLayout = ImageLayout.Stretch;
            reset.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            reset.FlatAppearance.BorderSize = 0;
            reset.FlatAppearance.MouseDownBackColor = Color.Transparent;
            reset.FlatAppearance.MouseOverBackColor = Color.Transparent;
            reset.FlatStyle = FlatStyle.Flat;
            reset.ForeColor = Color.Transparent;
            reset.Location = new Point(203, 209);
            reset.Name = "reset";
            reset.Size = new Size(59, 57);
            reset.TabIndex = 3;
            reset.UseVisualStyleBackColor = false;
            reset.Click += reset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(320, 315);
            Controls.Add(reset);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(star);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button star;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Button reset;
    }
}