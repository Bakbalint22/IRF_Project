namespace IRF_Project
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.Reload = new System.Windows.Forms.Button();
            this.btnForwards = new System.Windows.Forms.Button();
            this.btnMidfilders = new System.Windows.Forms.Button();
            this.btnDefenders = new System.Windows.Forms.Button();
            this.btnGoalkeepers = new System.Windows.Forms.Button();
            this.btnAnimation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(577, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(656, 103);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(99, 34);
            this.buttonWrite.TabIndex = 1;
            this.buttonWrite.Text = "Write";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // Reload
            // 
            this.Reload.Location = new System.Drawing.Point(656, 46);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(99, 34);
            this.Reload.TabIndex = 2;
            this.Reload.Text = "Reload";
            this.Reload.UseVisualStyleBackColor = true;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // btnForwards
            // 
            this.btnForwards.Location = new System.Drawing.Point(12, 364);
            this.btnForwards.Name = "btnForwards";
            this.btnForwards.Size = new System.Drawing.Size(99, 34);
            this.btnForwards.TabIndex = 3;
            this.btnForwards.Text = "Forwards";
            this.btnForwards.UseVisualStyleBackColor = true;
            this.btnForwards.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMidfilders
            // 
            this.btnMidfilders.Location = new System.Drawing.Point(151, 364);
            this.btnMidfilders.Name = "btnMidfilders";
            this.btnMidfilders.Size = new System.Drawing.Size(99, 34);
            this.btnMidfilders.TabIndex = 4;
            this.btnMidfilders.Text = "Midfilders";
            this.btnMidfilders.UseVisualStyleBackColor = true;
            this.btnMidfilders.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDefenders
            // 
            this.btnDefenders.Location = new System.Drawing.Point(301, 364);
            this.btnDefenders.Name = "btnDefenders";
            this.btnDefenders.Size = new System.Drawing.Size(99, 34);
            this.btnDefenders.TabIndex = 5;
            this.btnDefenders.Text = "Defenders";
            this.btnDefenders.UseVisualStyleBackColor = true;
            this.btnDefenders.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnGoalkeepers
            // 
            this.btnGoalkeepers.Location = new System.Drawing.Point(446, 364);
            this.btnGoalkeepers.Name = "btnGoalkeepers";
            this.btnGoalkeepers.Size = new System.Drawing.Size(99, 34);
            this.btnGoalkeepers.TabIndex = 6;
            this.btnGoalkeepers.Text = "Goal-Keepers";
            this.btnGoalkeepers.UseVisualStyleBackColor = true;
            this.btnGoalkeepers.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAnimation
            // 
            this.btnAnimation.Location = new System.Drawing.Point(643, 338);
            this.btnAnimation.Name = "btnAnimation";
            this.btnAnimation.Size = new System.Drawing.Size(119, 73);
            this.btnAnimation.TabIndex = 7;
            this.btnAnimation.Text = "Animation";
            this.btnAnimation.UseVisualStyleBackColor = true;
            this.btnAnimation.Click += new System.EventHandler(this.btnAnimation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnimation);
            this.Controls.Add(this.btnGoalkeepers);
            this.Controls.Add(this.btnDefenders);
            this.Controls.Add(this.btnMidfilders);
            this.Controls.Add(this.btnForwards);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Button Reload;
        private System.Windows.Forms.Button btnForwards;
        private System.Windows.Forms.Button btnMidfilders;
        private System.Windows.Forms.Button btnDefenders;
        private System.Windows.Forms.Button btnGoalkeepers;
        private System.Windows.Forms.Button btnAnimation;
    }
}

