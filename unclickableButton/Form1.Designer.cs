namespace unclickableButton
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
            unclickableButton = new Button();
            SuspendLayout();
            // 
            // unclickableButton
            // 
            unclickableButton.Location = new Point(0, 0);
            unclickableButton.Name = "unclickableButton";
            unclickableButton.Size = new Size(100, 40);
            unclickableButton.TabIndex = 0;
            unclickableButton.Text = "Tıklayamazsın";
            unclickableButton.UseVisualStyleBackColor = true;
            unclickableButton.Click += unclickableButton_Click;
            unclickableButton.MouseEnter += unclickableButton_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 361);
            Controls.Add(unclickableButton);
            MinimumSize = new Size(250, 150);
            Name = "Form1";
            Text = "Form1";
            ResizeBegin += Form1_ResizeBegin;
            ResizeEnd += Form1_ResizeEnd;
            Resize += Form1_Resize;
            ResumeLayout(false);
        }

        #endregion

        private Button unclickableButton;
    }
}