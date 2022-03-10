namespace JokeGenerator
{
	partial class Home
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
			this.lbl_head = new System.Windows.Forms.Label();
			this.btn_get = new System.Windows.Forms.Button();
			this.btn_mode = new System.Windows.Forms.Button();
			this.btn_info = new System.Windows.Forms.Button();
			this.lbl_joke = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_head
			// 
			this.lbl_head.AutoSize = true;
			this.lbl_head.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_head.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lbl_head.Font = new System.Drawing.Font("Segoe UI", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
			this.lbl_head.ForeColor = System.Drawing.Color.Black;
			this.lbl_head.Location = new System.Drawing.Point(12, 23);
			this.lbl_head.Name = "lbl_head";
			this.lbl_head.Size = new System.Drawing.Size(237, 62);
			this.lbl_head.TabIndex = 0;
			this.lbl_head.Text = "Joke Box ";
			this.lbl_head.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lbl_head.Click += new System.EventHandler(this.lbl_head_Click);
			// 
			// btn_get
			// 
			this.btn_get.BackColor = System.Drawing.Color.White;
			this.btn_get.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btn_get.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_get.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btn_get.Location = new System.Drawing.Point(391, 383);
			this.btn_get.Name = "btn_get";
			this.btn_get.Size = new System.Drawing.Size(134, 58);
			this.btn_get.TabIndex = 4;
			this.btn_get.Text = "GET ";
			this.btn_get.UseVisualStyleBackColor = false;
			this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
			// 
			// btn_mode
			// 
			this.btn_mode.BackColor = System.Drawing.Color.White;
			this.btn_mode.FlatAppearance.BorderSize = 0;
			this.btn_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_mode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btn_mode.Image = global::JokeGenerator.Properties.Resources.icons8_do_not_disturb_ios_24;
			this.btn_mode.Location = new System.Drawing.Point(809, 23);
			this.btn_mode.Name = "btn_mode";
			this.btn_mode.Size = new System.Drawing.Size(60, 62);
			this.btn_mode.TabIndex = 5;
			this.btn_mode.UseVisualStyleBackColor = false;
			this.btn_mode.Click += new System.EventHandler(this.btn_mode_Click);
			// 
			// btn_info
			// 
			this.btn_info.BackColor = System.Drawing.Color.White;
			this.btn_info.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_info.FlatAppearance.BorderSize = 0;
			this.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_info.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.btn_info.Image = global::JokeGenerator.Properties.Resources.icons8_info_24;
			this.btn_info.Location = new System.Drawing.Point(809, 477);
			this.btn_info.Name = "btn_info";
			this.btn_info.Size = new System.Drawing.Size(64, 53);
			this.btn_info.TabIndex = 6;
			this.btn_info.UseVisualStyleBackColor = false;
			this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
			// 
			// lbl_joke
			// 
			this.lbl_joke.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbl_joke.Location = new System.Drawing.Point(267, 99);
			this.lbl_joke.MaximumSize = new System.Drawing.Size(600, 400);
			this.lbl_joke.Name = "lbl_joke";
			this.lbl_joke.Size = new System.Drawing.Size(416, 249);
			this.lbl_joke.TabIndex = 3;
			this.lbl_joke.Text = "Jokes to the rescue....";
			this.lbl_joke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_joke.Click += new System.EventHandler(this.lbl_joke_Click);
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(911, 551);
			this.Controls.Add(this.btn_info);
			this.Controls.Add(this.btn_mode);
			this.Controls.Add(this.btn_get);
			this.Controls.Add(this.lbl_joke);
			this.Controls.Add(this.lbl_head);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Home";
			this.Opacity = 0.85D;
			this.Text = "Joke Box";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label lbl_head;
		private Button btn_get;
		private Button btn_mode;
		private Button btn_info;
		private Label lbl_joke;
	}
}