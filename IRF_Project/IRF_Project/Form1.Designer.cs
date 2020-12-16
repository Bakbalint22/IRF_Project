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
            this.btnForwards = new System.Windows.Forms.Button();
            this.btnMidfilders = new System.Windows.Forms.Button();
            this.btnDefenders = new System.Windows.Forms.Button();
            this.btnGoalkeepers = new System.Windows.Forms.Button();
            this.btnAnimation = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbllu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(577, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(656, 79);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(99, 34);
            this.buttonWrite.TabIndex = 1;
            this.buttonWrite.Text = "Write";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // btnForwards
            // 
            this.btnForwards.Location = new System.Drawing.Point(12, 364);
            this.btnForwards.Name = "btnForwards";
            this.btnForwards.Size = new System.Drawing.Size(99, 34);
            this.btnForwards.TabIndex = 3;
            this.btnForwards.Text = "Forwards";
            this.btnForwards.UseVisualStyleBackColor = true;
            this.btnForwards.Click += new System.EventHandler(this.btnForwards_Click);
            // 
            // btnMidfilders
            // 
            this.btnMidfilders.Location = new System.Drawing.Point(151, 364);
            this.btnMidfilders.Name = "btnMidfilders";
            this.btnMidfilders.Size = new System.Drawing.Size(99, 34);
            this.btnMidfilders.TabIndex = 4;
            this.btnMidfilders.Text = "Midfilders";
            this.btnMidfilders.UseVisualStyleBackColor = true;
            this.btnMidfilders.Click += new System.EventHandler(this.btnMidfilders_Click);
            // 
            // btnDefenders
            // 
            this.btnDefenders.Location = new System.Drawing.Point(301, 364);
            this.btnDefenders.Name = "btnDefenders";
            this.btnDefenders.Size = new System.Drawing.Size(99, 34);
            this.btnDefenders.TabIndex = 5;
            this.btnDefenders.Text = "Defenders";
            this.btnDefenders.UseVisualStyleBackColor = true;
            this.btnDefenders.Click += new System.EventHandler(this.btnDefenders_Click);
            // 
            // btnGoalkeepers
            // 
            this.btnGoalkeepers.Location = new System.Drawing.Point(446, 364);
            this.btnGoalkeepers.Name = "btnGoalkeepers";
            this.btnGoalkeepers.Size = new System.Drawing.Size(99, 34);
            this.btnGoalkeepers.TabIndex = 6;
            this.btnGoalkeepers.Text = "Goal-Keepers";
            this.btnGoalkeepers.UseVisualStyleBackColor = true;
            this.btnGoalkeepers.Click += new System.EventHandler(this.btnGoalkeepers_Click);
            // 
            // btnAnimation
            // 
            this.btnAnimation.Location = new System.Drawing.Point(643, 338);
            this.btnAnimation.Name = "btnAnimation";
            this.btnAnimation.Size = new System.Drawing.Size(119, 73);
            this.btnAnimation.TabIndex = 7;
            this.btnAnimation.Text = "Simulate Match";
            this.btnAnimation.UseVisualStyleBackColor = true;
            this.btnAnimation.Click += new System.EventHandler(this.btnAnimation_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(656, 12);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(99, 34);
            this.btnReload.TabIndex = 8;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbllu
            // 
            this.lbllu.AutoSize = true;
            this.lbllu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllu.Location = new System.Drawing.Point(111, 9);
            this.lbllu.Name = "lbllu";
            this.lbllu.Size = new System.Drawing.Size(151, 25);
            this.lbllu.TabIndex = 10;
            this.lbllu.Text = "The starting XI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbllu);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnAnimation);
            this.Controls.Add(this.btnGoalkeepers);
            this.Controls.Add(this.btnDefenders);
            this.Controls.Add(this.btnMidfilders);
            this.Controls.Add(this.btnForwards);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonWrite;
        
        private System.Windows.Forms.Button btnForwards;
        private System.Windows.Forms.Button btnMidfilders;
        private System.Windows.Forms.Button btnDefenders;
        private System.Windows.Forms.Button btnGoalkeepers;
        private System.Windows.Forms.Button btnAnimation;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbllu;
    }
}

