namespace ReflectionDemo
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
			this.CarregarButton = new System.Windows.Forms.Button();
			this.ExecutarButton = new System.Windows.Forms.Button();
			this.MensagemLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// CarregarButton
			// 
			this.CarregarButton.Location = new System.Drawing.Point(12, 12);
			this.CarregarButton.Name = "CarregarButton";
			this.CarregarButton.Size = new System.Drawing.Size(117, 23);
			this.CarregarButton.TabIndex = 0;
			this.CarregarButton.Text = "Carregar plugins";
			this.CarregarButton.UseVisualStyleBackColor = true;
			this.CarregarButton.Click += new System.EventHandler(this.CarregarButton_Click);
			// 
			// ExecutarButton
			// 
			this.ExecutarButton.Location = new System.Drawing.Point(12, 41);
			this.ExecutarButton.Name = "ExecutarButton";
			this.ExecutarButton.Size = new System.Drawing.Size(117, 23);
			this.ExecutarButton.TabIndex = 1;
			this.ExecutarButton.Text = "Executar plugins";
			this.ExecutarButton.UseVisualStyleBackColor = true;
			this.ExecutarButton.Click += new System.EventHandler(this.ExecutarButton_Click);
			// 
			// MensagemLabel
			// 
			this.MensagemLabel.AutoSize = true;
			this.MensagemLabel.Location = new System.Drawing.Point(12, 71);
			this.MensagemLabel.Name = "MensagemLabel";
			this.MensagemLabel.Size = new System.Drawing.Size(0, 13);
			this.MensagemLabel.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(237, 226);
			this.Controls.Add(this.MensagemLabel);
			this.Controls.Add(this.ExecutarButton);
			this.Controls.Add(this.CarregarButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CarregarButton;
		private System.Windows.Forms.Button ExecutarButton;
		private System.Windows.Forms.Label MensagemLabel;
	}
}

