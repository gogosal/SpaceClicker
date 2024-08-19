
namespace SpaceClicker.Forms
{
    partial class FormSettings
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
            this.btnSetBind = new System.Windows.Forms.Button();
            this.tbBind = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSetBind
            // 
            this.btnSetBind.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetBind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetBind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetBind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSetBind.Location = new System.Drawing.Point(91, 82);
            this.btnSetBind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSetBind.Name = "btnSetBind";
            this.btnSetBind.Size = new System.Drawing.Size(139, 54);
            this.btnSetBind.TabIndex = 0;
            this.btnSetBind.Text = "Set Bind";
            this.btnSetBind.UseVisualStyleBackColor = false;
            this.btnSetBind.Click += new System.EventHandler(this.btnSetBind_Click);
            this.btnSetBind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSetBind_KeyDown);
            // 
            // tbBind
            // 
            this.tbBind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBind.Location = new System.Drawing.Point(289, 82);
            this.tbBind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBind.Multiline = true;
            this.tbBind.Name = "tbBind";
            this.tbBind.ReadOnly = true;
            this.tbBind.Size = new System.Drawing.Size(138, 54);
            this.tbBind.TabIndex = 1;
            this.tbBind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnApply
            // 
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnApply.Location = new System.Drawing.Point(109, 177);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(104, 38);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(303, 177);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 38);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 267);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tbBind);
            this.Controls.Add(this.btnSetBind);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetBind;
        private System.Windows.Forms.TextBox tbBind;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
    }
}