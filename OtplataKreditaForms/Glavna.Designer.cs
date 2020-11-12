namespace OtplataKreditaForms
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
			this.txtGlavnica = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtStopa = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtGodina = new System.Windows.Forms.TextBox();
			this.btnIzracunaj = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.lblAnuitet = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblUkupnoKamate = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Glavnica";
			// 
			// txtGlavnica
			// 
			this.txtGlavnica.Location = new System.Drawing.Point(149, 40);
			this.txtGlavnica.Name = "txtGlavnica";
			this.txtGlavnica.Size = new System.Drawing.Size(100, 23);
			this.txtGlavnica.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(307, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Stopa (2-15%):";
			// 
			// txtStopa
			// 
			this.txtStopa.Location = new System.Drawing.Point(427, 40);
			this.txtStopa.Name = "txtStopa";
			this.txtStopa.Size = new System.Drawing.Size(100, 23);
			this.txtStopa.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(29, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "Broj godina:";
			// 
			// txtGodina
			// 
			this.txtGodina.Location = new System.Drawing.Point(149, 83);
			this.txtGodina.Name = "txtGodina";
			this.txtGodina.Size = new System.Drawing.Size(100, 23);
			this.txtGodina.TabIndex = 5;
			// 
			// btnIzracunaj
			// 
			this.btnIzracunaj.Location = new System.Drawing.Point(29, 124);
			this.btnIzracunaj.Name = "btnIzracunaj";
			this.btnIzracunaj.Size = new System.Drawing.Size(498, 23);
			this.btnIzracunaj.TabIndex = 6;
			this.btnIzracunaj.Text = "Izračunaj";
			this.btnIzracunaj.UseVisualStyleBackColor = true;
			this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 171);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 15);
			this.label4.TabIndex = 8;
			this.label4.Text = "Anuitet:";
			// 
			// lblAnuitet
			// 
			this.lblAnuitet.AutoSize = true;
			this.lblAnuitet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblAnuitet.Location = new System.Drawing.Point(115, 171);
			this.lblAnuitet.Name = "lblAnuitet";
			this.lblAnuitet.Size = new System.Drawing.Size(33, 17);
			this.lblAnuitet.TabIndex = 9;
			this.lblAnuitet.Text = "0,00";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(209, 171);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 15);
			this.label5.TabIndex = 8;
			this.label5.Text = "Ukupno kamate:";
			// 
			// lblUkupnoKamate
			// 
			this.lblUkupnoKamate.AutoSize = true;
			this.lblUkupnoKamate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblUkupnoKamate.Location = new System.Drawing.Point(321, 171);
			this.lblUkupnoKamate.Name = "lblUkupnoKamate";
			this.lblUkupnoKamate.Size = new System.Drawing.Size(33, 17);
			this.lblUkupnoKamate.TabIndex = 9;
			this.lblUkupnoKamate.Text = "0,00";
			// 
			// Glavna
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(760, 245);
			this.Controls.Add(this.lblUkupnoKamate);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblAnuitet);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnIzracunaj);
			this.Controls.Add(this.txtGodina);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtStopa);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtGlavnica);
			this.Controls.Add(this.label1);
			this.Name = "Glavna";
			this.Text = "Otplata kredita";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtGlavnica;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtStopa;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtGodina;
		private System.Windows.Forms.Button btnIzracunaj;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblAnuitet;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblUkupnoKamate;
	}
}

