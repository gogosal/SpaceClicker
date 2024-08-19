
namespace SpaceClicker.Forms
{
    partial class FormClickTest
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
            this.components = new System.ComponentModel.Container();
            this.tbClicks = new System.Windows.Forms.TextBox();
            this.tbTimer = new System.Windows.Forms.TextBox();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimerClick = new System.Windows.Forms.Timer(this.components);
            this.AutoUpdate = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tbClicks
            // 
            this.tbClicks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbClicks.Location = new System.Drawing.Point(229, 22);
            this.tbClicks.Multiline = true;
            this.tbClicks.Name = "tbClicks";
            this.tbClicks.ReadOnly = true;
            this.tbClicks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbClicks.Size = new System.Drawing.Size(100, 35);
            this.tbClicks.TabIndex = 0;
            this.tbClicks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTimer
            // 
            this.tbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbTimer.Location = new System.Drawing.Point(53, 22);
            this.tbTimer.Multiline = true;
            this.tbTimer.Name = "tbTimer";
            this.tbTimer.ReadOnly = true;
            this.tbTimer.Size = new System.Drawing.Size(100, 35);
            this.tbTimer.TabIndex = 1;
            this.tbTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStartTest
            // 
            this.btnStartTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTest.Location = new System.Drawing.Point(53, 94);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(276, 81);
            this.btnStartTest.TabIndex = 2;
            this.btnStartTest.Text = "Click Here to Start CpsTest";
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(84, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Timer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(259, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Click\'s";
            // 
            // TimerClick
            // 
            this.TimerClick.Interval = 1;
            this.TimerClick.Tick += new System.EventHandler(this.TimerClick_Tick);
            // 
            // AutoUpdate
            // 
            this.AutoUpdate.Interval = 1;
            this.AutoUpdate.Tick += new System.EventHandler(this.AutoUpdate_Tick);
            // 
            // FormClickTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 217);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartTest);
            this.Controls.Add(this.tbTimer);
            this.Controls.Add(this.tbClicks);
            this.Name = "FormClickTest";
            this.Text = "ClickTest";
            this.Load += new System.EventHandler(this.FormClickTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbClicks;
        private System.Windows.Forms.TextBox tbTimer;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer TimerClick;
        private System.Windows.Forms.Timer AutoUpdate;
    }
}