namespace Twitter_Form
{
    partial class Twitter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstTweets = new System.Windows.Forms.ListBox();
            this.txtTweet = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstTweets);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tweets";
            // 
            // lstTweets
            // 
            this.lstTweets.FormattingEnabled = true;
            this.lstTweets.Location = new System.Drawing.Point(16, 20);
            this.lstTweets.Name = "lstTweets";
            this.lstTweets.Size = new System.Drawing.Size(311, 212);
            this.lstTweets.TabIndex = 0;
            // 
            // txtTweet
            // 
            this.txtTweet.Location = new System.Drawing.Point(12, 283);
            this.txtTweet.Name = "txtTweet";
            this.txtTweet.Size = new System.Drawing.Size(327, 20);
            this.txtTweet.TabIndex = 1;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(264, 319);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 357);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(16, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "...";
            // 
            // Twitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 382);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.txtTweet);
            this.Controls.Add(this.groupBox1);
            this.Name = "Twitter";
            this.Text = "Twitter Application";
            this.Load += new System.EventHandler(this.Twitter_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstTweets;
        private System.Windows.Forms.TextBox txtTweet;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Label lblStatus;
    }
}

