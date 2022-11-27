
namespace Proiect
{
	partial class FormClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            this.labelInfoProduse = new System.Windows.Forms.Label();
            this.labelInfoHowTo = new System.Windows.Forms.Label();
            this.listBoxMedicamente = new System.Windows.Forms.ListBox();
            this.buttonFinalizareComanda = new System.Windows.Forms.Button();
            this.labelCantitate = new System.Windows.Forms.Label();
            this.labelMedicamentSelectat = new System.Windows.Forms.Label();
            this.labelMedicamentSelectatStatus = new System.Windows.Forms.Label();
            this.textBoxCantitate = new System.Windows.Forms.TextBox();
            this.buttonInapoi = new System.Windows.Forms.Button();
            this.labelComandaStatus = new System.Windows.Forms.Label();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.listBoxMedicamenteComanda = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelInfoProduse
            // 
            this.labelInfoProduse.AutoSize = true;
            this.labelInfoProduse.Location = new System.Drawing.Point(347, 186);
            this.labelInfoProduse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfoProduse.Name = "labelInfoProduse";
            this.labelInfoProduse.Size = new System.Drawing.Size(175, 22);
            this.labelInfoProduse.TabIndex = 0;
            this.labelInfoProduse.Text = "Produse disponibile:";
            // 
            // labelInfoHowTo
            // 
            this.labelInfoHowTo.AutoSize = true;
            this.labelInfoHowTo.BackColor = System.Drawing.SystemColors.Control;
            this.labelInfoHowTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelInfoHowTo.Location = new System.Drawing.Point(347, 35);
            this.labelInfoHowTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfoHowTo.Name = "labelInfoHowTo";
            this.labelInfoHowTo.Size = new System.Drawing.Size(1072, 134);
            this.labelInfoHowTo.TabIndex = 1;
            this.labelInfoHowTo.Text = resources.GetString("labelInfoHowTo.Text");
            // 
            // listBoxMedicamente
            // 
            this.listBoxMedicamente.FormattingEnabled = true;
            this.listBoxMedicamente.ItemHeight = 22;
            this.listBoxMedicamente.Location = new System.Drawing.Point(347, 209);
            this.listBoxMedicamente.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxMedicamente.Name = "listBoxMedicamente";
            this.listBoxMedicamente.Size = new System.Drawing.Size(818, 158);
            this.listBoxMedicamente.TabIndex = 2;
            this.listBoxMedicamente.SelectedIndexChanged += new System.EventHandler(this.listBoxMedicamente_SelectedIndexChanged);
            // 
            // buttonFinalizareComanda
            // 
            this.buttonFinalizareComanda.Location = new System.Drawing.Point(1027, 715);
            this.buttonFinalizareComanda.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFinalizareComanda.Name = "buttonFinalizareComanda";
            this.buttonFinalizareComanda.Size = new System.Drawing.Size(138, 36);
            this.buttonFinalizareComanda.TabIndex = 3;
            this.buttonFinalizareComanda.Text = "Finalizare comandă";
            this.buttonFinalizareComanda.UseVisualStyleBackColor = true;
            this.buttonFinalizareComanda.Click += new System.EventHandler(this.buttonFinalizareComanda_Click);
            // 
            // labelCantitate
            // 
            this.labelCantitate.AutoSize = true;
            this.labelCantitate.Location = new System.Drawing.Point(347, 443);
            this.labelCantitate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCantitate.Name = "labelCantitate";
            this.labelCantitate.Size = new System.Drawing.Size(182, 22);
            this.labelCantitate.TabIndex = 4;
            this.labelCantitate.Text = "Introduceți cantitatea:";
            // 
            // labelMedicamentSelectat
            // 
            this.labelMedicamentSelectat.AutoSize = true;
            this.labelMedicamentSelectat.Location = new System.Drawing.Point(347, 404);
            this.labelMedicamentSelectat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMedicamentSelectat.Name = "labelMedicamentSelectat";
            this.labelMedicamentSelectat.Size = new System.Drawing.Size(234, 22);
            this.labelMedicamentSelectat.TabIndex = 6;
            this.labelMedicamentSelectat.Text = "Medicamentul selectat este: ";
            // 
            // labelMedicamentSelectatStatus
            // 
            this.labelMedicamentSelectatStatus.AutoSize = true;
            this.labelMedicamentSelectatStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelMedicamentSelectatStatus.Location = new System.Drawing.Point(556, 404);
            this.labelMedicamentSelectatStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMedicamentSelectatStatus.Name = "labelMedicamentSelectatStatus";
            this.labelMedicamentSelectatStatus.Size = new System.Drawing.Size(0, 22);
            this.labelMedicamentSelectatStatus.TabIndex = 7;
            // 
            // textBoxCantitate
            // 
            this.textBoxCantitate.Location = new System.Drawing.Point(557, 440);
            this.textBoxCantitate.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCantitate.Name = "textBoxCantitate";
            this.textBoxCantitate.Size = new System.Drawing.Size(100, 30);
            this.textBoxCantitate.TabIndex = 8;
            this.textBoxCantitate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonInapoi
            // 
            this.buttonInapoi.Location = new System.Drawing.Point(1173, 715);
            this.buttonInapoi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInapoi.Name = "buttonInapoi";
            this.buttonInapoi.Size = new System.Drawing.Size(144, 36);
            this.buttonInapoi.TabIndex = 9;
            this.buttonInapoi.Text = "Înapoi";
            this.buttonInapoi.UseVisualStyleBackColor = true;
            this.buttonInapoi.Click += new System.EventHandler(this.buttonInapoi_Click);
            // 
            // labelComandaStatus
            // 
            this.labelComandaStatus.AutoSize = true;
            this.labelComandaStatus.Location = new System.Drawing.Point(347, 553);
            this.labelComandaStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComandaStatus.Name = "labelComandaStatus";
            this.labelComandaStatus.Size = new System.Drawing.Size(143, 22);
            this.labelComandaStatus.TabIndex = 10;
            this.labelComandaStatus.Text = "Status comandă: ";
            this.labelComandaStatus.Click += new System.EventHandler(this.labelComandaStatus_Click);
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(347, 494);
            this.buttonAdauga.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(86, 27);
            this.buttonAdauga.TabIndex = 11;
            this.buttonAdauga.Text = "Adaugă";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // listBoxMedicamenteComanda
            // 
            this.listBoxMedicamenteComanda.FormattingEnabled = true;
            this.listBoxMedicamenteComanda.ItemHeight = 22;
            this.listBoxMedicamenteComanda.Location = new System.Drawing.Point(347, 576);
            this.listBoxMedicamenteComanda.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxMedicamenteComanda.Name = "listBoxMedicamenteComanda";
            this.listBoxMedicamenteComanda.Size = new System.Drawing.Size(818, 114);
            this.listBoxMedicamenteComanda.TabIndex = 12;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Proiect.Properties.Resources.FormAngajat_Client;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1330, 764);
            this.Controls.Add(this.listBoxMedicamenteComanda);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.labelComandaStatus);
            this.Controls.Add(this.buttonInapoi);
            this.Controls.Add(this.textBoxCantitate);
            this.Controls.Add(this.labelMedicamentSelectatStatus);
            this.Controls.Add(this.labelMedicamentSelectat);
            this.Controls.Add(this.labelCantitate);
            this.Controls.Add(this.buttonFinalizareComanda);
            this.Controls.Add(this.listBoxMedicamente);
            this.Controls.Add(this.labelInfoHowTo);
            this.Controls.Add(this.labelInfoProduse);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelInfoProduse;
		private System.Windows.Forms.Label labelInfoHowTo;
		private System.Windows.Forms.ListBox listBoxMedicamente;
		private System.Windows.Forms.Button buttonFinalizareComanda;
		private System.Windows.Forms.Label labelCantitate;
		private System.Windows.Forms.Label labelMedicamentSelectat;
		private System.Windows.Forms.Label labelMedicamentSelectatStatus;
		private System.Windows.Forms.TextBox textBoxCantitate;
		private System.Windows.Forms.Button buttonInapoi;
		private System.Windows.Forms.Label labelComandaStatus;
		private System.Windows.Forms.Button buttonAdauga;
		private System.Windows.Forms.ListBox listBoxMedicamenteComanda;
	}
}