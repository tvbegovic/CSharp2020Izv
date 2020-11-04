namespace ProsjekOcjena
{
	partial class Glavna
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtOcjenaC = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtOcjenaCPlus = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtOcjenaCSharp = new System.Windows.Forms.TextBox();
			this.btnIzracunaj = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.lblProsjek = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(49, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ocjena C:";
			// 
			// txtOcjenaC
			// 
			this.txtOcjenaC.Location = new System.Drawing.Point(133, 38);
			this.txtOcjenaC.Name = "txtOcjenaC";
			this.txtOcjenaC.Size = new System.Drawing.Size(100, 23);
			this.txtOcjenaC.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(49, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "Ocjena C++:";
			// 
			// txtOcjenaCPlus
			// 
			this.txtOcjenaCPlus.Location = new System.Drawing.Point(133, 87);
			this.txtOcjenaCPlus.Name = "txtOcjenaCPlus";
			this.txtOcjenaCPlus.Size = new System.Drawing.Size(100, 23);
			this.txtOcjenaCPlus.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(49, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 15);
			this.label3.TabIndex = 0;
			this.label3.Text = "Ocjena C#:";
			// 
			// txtOcjenaCSharp
			// 
			this.txtOcjenaCSharp.Location = new System.Drawing.Point(133, 133);
			this.txtOcjenaCSharp.Name = "txtOcjenaCSharp";
			this.txtOcjenaCSharp.Size = new System.Drawing.Size(100, 23);
			this.txtOcjenaCSharp.TabIndex = 2;
			// 
			// btnIzracunaj
			// 
			this.btnIzracunaj.Location = new System.Drawing.Point(49, 181);
			this.btnIzracunaj.Name = "btnIzracunaj";
			this.btnIzracunaj.Size = new System.Drawing.Size(292, 23);
			this.btnIzracunaj.TabIndex = 3;
			this.btnIzracunaj.Text = "Izračunaj";
			this.btnIzracunaj.UseVisualStyleBackColor = true;
			this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(49, 224);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "Prosjek: ";
			// 
			// lblProsjek
			// 
			this.lblProsjek.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblProsjek.Location = new System.Drawing.Point(124, 220);
			this.lblProsjek.Name = "lblProsjek";
			this.lblProsjek.Size = new System.Drawing.Size(124, 21);
			this.lblProsjek.TabIndex = 4;
			// 
			// Glavna
			// 
			this.AcceptButton = this.btnIzracunaj;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(619, 298);
			this.Controls.Add(this.lblProsjek);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnIzracunaj);
			this.Controls.Add(this.txtOcjenaCSharp);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtOcjenaCPlus);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtOcjenaC);
			this.Name = "Glavna";
			this.Text = "Prosjek ocjena";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtOcjenaC;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtOcjenaCPlus;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtOcjenaCSharp;
		private System.Windows.Forms.Button btnIzracunaj;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblProsjek;
	}
}

