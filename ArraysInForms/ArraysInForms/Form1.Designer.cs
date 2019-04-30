namespace ArraysInForms
{
    partial class Form1
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
            this.btnTask1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxArray = new System.Windows.Forms.ListBox();
            this.lblTask = new System.Windows.Forms.Label();
            this.textBoxTask1 = new System.Windows.Forms.TextBox();
            this.textBoxTask1Instructions = new System.Windows.Forms.TextBox();
            this.btnAddNumber = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTask1
            // 
            this.btnTask1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTask1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTask1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTask1.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTask1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTask1.Location = new System.Drawing.Point(13, 39);
            this.btnTask1.Name = "btnTask1";
            this.btnTask1.Size = new System.Drawing.Size(237, 53);
            this.btnTask1.TabIndex = 0;
            this.btnTask1.Text = "Task 1";
            this.btnTask1.UseVisualStyleBackColor = false;
            this.btnTask1.Click += new System.EventHandler(this.BtnTask1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btnTask1);
            this.groupBox1.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 456);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Menu";
            // 
            // listBoxArray
            // 
            this.listBoxArray.FormattingEnabled = true;
            this.listBoxArray.ItemHeight = 16;
            this.listBoxArray.Location = new System.Drawing.Point(738, 8);
            this.listBoxArray.Name = "listBoxArray";
            this.listBoxArray.Size = new System.Drawing.Size(190, 436);
            this.listBoxArray.TabIndex = 2;
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask.Location = new System.Drawing.Point(432, 37);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(103, 37);
            this.lblTask.TabIndex = 3;
            this.lblTask.Text = "Task";
            this.lblTask.Visible = false;
            // 
            // textBoxTask1
            // 
            this.textBoxTask1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTask1.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxTask1.Location = new System.Drawing.Point(288, 204);
            this.textBoxTask1.Name = "textBoxTask1";
            this.textBoxTask1.Size = new System.Drawing.Size(417, 34);
            this.textBoxTask1.TabIndex = 4;
            this.textBoxTask1.Text = "Enter your numbers here .....";
            this.textBoxTask1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTask1.Visible = false;
            this.textBoxTask1.Click += new System.EventHandler(this.TextBoxTask1_Click);
            this.textBoxTask1.TextChanged += new System.EventHandler(this.TextBoxTask1_TextChanged);
            // 
            // textBoxTask1Instructions
            // 
            this.textBoxTask1Instructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask1Instructions.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTask1Instructions.Location = new System.Drawing.Point(288, 139);
            this.textBoxTask1Instructions.Multiline = true;
            this.textBoxTask1Instructions.Name = "textBoxTask1Instructions";
            this.textBoxTask1Instructions.ReadOnly = true;
            this.textBoxTask1Instructions.Size = new System.Drawing.Size(445, 62);
            this.textBoxTask1Instructions.TabIndex = 5;
            this.textBoxTask1Instructions.Text = "Please enter 10 numbers in the box below...";
            this.textBoxTask1Instructions.Visible = false;
            // 
            // btnAddNumber
            // 
            this.btnAddNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNumber.Location = new System.Drawing.Point(288, 245);
            this.btnAddNumber.Name = "btnAddNumber";
            this.btnAddNumber.Size = new System.Drawing.Size(417, 38);
            this.btnAddNumber.TabIndex = 6;
            this.btnAddNumber.Text = "Add number 1";
            this.btnAddNumber.UseVisualStyleBackColor = false;
            this.btnAddNumber.Visible = false;
            this.btnAddNumber.Click += new System.EventHandler(this.BtnAddNumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 453);
            this.Controls.Add(this.btnAddNumber);
            this.Controls.Add(this.textBoxTask1Instructions);
            this.Controls.Add(this.textBoxTask1);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.listBoxArray);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Arrays Tasks";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTask1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxArray;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.TextBox textBoxTask1;
        private System.Windows.Forms.TextBox textBoxTask1Instructions;
        private System.Windows.Forms.Button btnAddNumber;
    }
}

