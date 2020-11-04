namespace IzracunKamata
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
			this.btnIzracunaj = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lblIznos = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(63, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Glavnica:";
			// 
			// txtGlavnica
			// 
			this.txtGlavnica.Location = new System.Drawing.Point(148, 52);
			this.txtGlavnica.Name = "txtGlavnica";
			this.txtGlavnica.Size = new System.Drawing.Size(120, 23);
			this.txtGlavnica.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(63, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Stopa (0-20%):";
			// 
			// txtStopa
			// 
			this.txtStopa.Location = new System.Drawing.Point(148, 98);
			this.txtStopa.Name = "txtStopa";
			this.txtStopa.Size = new System.Drawing.Size(120, 23);
			this.txtStopa.TabIndex = 3;
			// 
			// btnIzracunaj
			// 
			this.btnIzracunaj.Location = new System.Drawing.Point(63, 147);
			this.btnIzracunaj.Name = "btnIzracunaj";
			this.btnIzracunaj.Size = new System.Drawing.Size(204, 23);
			this.btnIzracunaj.TabIndex = 4;
			this.btnIzracunaj.Text = "Izračunaj";
			this.btnIzracunaj.UseVisualStyleBackColor = true;
			this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(63, 200);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "Iznos:";
			// 
			// lblIznos
			// 
			this.lblIznos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblIznos.Location = new System.Drawing.Point(148, 200);
			this.lblIznos.Name = "lblIznos";
			this.lblIznos.Size = new System.Drawing.Size(100, 23);
			this.lblIznos.TabIndex = 6;
			// 
			// Glavna
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(435, 319);
			this.Controls.Add(this.lblIznos);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnIzracunaj);
			this.Controls.Add(this.txtStopa);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtGlavnica);
			this.Controls.Add(this.label1);
			this.Name = "Glavna";
			this.Text = "Izračun kamata";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtGlavnica;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtStopa;
		private System.Windows.Forms.Button btnIzracunaj;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblIznos;
	}
}

