
namespace Proiect
{
	partial class FormAngajat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAngajat));
            this.labelInfoAdauga = new System.Windows.Forms.Label();
            this.labelNume = new System.Windows.Forms.Label();
            this.labelCod = new System.Windows.Forms.Label();
            this.labelTip = new System.Windows.Forms.Label();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.labelDataExpirarii = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.radioButtonPastila = new System.Windows.Forms.RadioButton();
            this.radioButtonCrema = new System.Windows.Forms.RadioButton();
            this.radioButtonSirop = new System.Windows.Forms.RadioButton();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.dateTimePickerDataExpirarii = new System.Windows.Forms.DateTimePicker();
            this.buttonAfisare = new System.Windows.Forms.Button();
            this.buttonEditare = new System.Windows.Forms.Button();
            this.buttonStergere = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelCantitate = new System.Windows.Forms.Label();
            this.listBoxMedicamente = new System.Windows.Forms.ListBox();
            this.buttonCauta = new System.Windows.Forms.Button();
            this.textBoxCantitate = new System.Windows.Forms.TextBox();
            this.openFileDialogSterge = new System.Windows.Forms.OpenFileDialog();
            this.buttonInapoi = new System.Windows.Forms.Button();
            this.labelAngajatConectat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInfoAdauga
            // 
            this.labelInfoAdauga.AutoSize = true;
            this.labelInfoAdauga.Location = new System.Drawing.Point(323, 99);
            this.labelInfoAdauga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfoAdauga.Name = "labelInfoAdauga";
            this.labelInfoAdauga.Size = new System.Drawing.Size(210, 22);
            this.labelInfoAdauga.TabIndex = 0;
            this.labelInfoAdauga.Text = "Adăugați un medicament:";
            this.labelInfoAdauga.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(360, 157);
            this.labelNume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(56, 22);
            this.labelNume.TabIndex = 1;
            this.labelNume.Text = "Nume";
            // 
            // labelCod
            // 
            this.labelCod.AutoSize = true;
            this.labelCod.Location = new System.Drawing.Point(361, 232);
            this.labelCod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCod.Name = "labelCod";
            this.labelCod.Size = new System.Drawing.Size(43, 22);
            this.labelCod.TabIndex = 2;
            this.labelCod.Text = "Cod";
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Location = new System.Drawing.Point(360, 190);
            this.labelTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(37, 22);
            this.labelTip.TabIndex = 3;
            this.labelTip.Text = "Tip";
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(327, 348);
            this.buttonAdauga.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(100, 34);
            this.buttonAdauga.TabIndex = 4;
            this.buttonAdauga.Text = "Adăugare";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // labelDataExpirarii
            // 
            this.labelDataExpirarii.AutoSize = true;
            this.labelDataExpirarii.Location = new System.Drawing.Point(361, 269);
            this.labelDataExpirarii.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDataExpirarii.Name = "labelDataExpirarii";
            this.labelDataExpirarii.Size = new System.Drawing.Size(121, 22);
            this.labelDataExpirarii.TabIndex = 5;
            this.labelDataExpirarii.Text = "Data expirării";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(478, 150);
            this.textBoxNume.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(148, 30);
            this.textBoxNume.TabIndex = 6;
            this.textBoxNume.TextChanged += new System.EventHandler(this.textBoxNume_TextChanged);
            // 
            // radioButtonPastila
            // 
            this.radioButtonPastila.AutoSize = true;
            this.radioButtonPastila.BackColor = System.Drawing.SystemColors.Control;
            this.radioButtonPastila.Location = new System.Drawing.Point(478, 188);
            this.radioButtonPastila.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonPastila.Name = "radioButtonPastila";
            this.radioButtonPastila.Size = new System.Drawing.Size(85, 26);
            this.radioButtonPastila.TabIndex = 7;
            this.radioButtonPastila.TabStop = true;
            this.radioButtonPastila.Text = "Pastilă";
            this.radioButtonPastila.UseVisualStyleBackColor = false;
            // 
            // radioButtonCrema
            // 
            this.radioButtonCrema.AutoSize = true;
            this.radioButtonCrema.BackColor = System.Drawing.SystemColors.Control;
            this.radioButtonCrema.Location = new System.Drawing.Point(571, 188);
            this.radioButtonCrema.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonCrema.Name = "radioButtonCrema";
            this.radioButtonCrema.Size = new System.Drawing.Size(83, 26);
            this.radioButtonCrema.TabIndex = 8;
            this.radioButtonCrema.TabStop = true;
            this.radioButtonCrema.Text = "Cremă";
            this.radioButtonCrema.UseVisualStyleBackColor = false;
            // 
            // radioButtonSirop
            // 
            this.radioButtonSirop.AutoSize = true;
            this.radioButtonSirop.Location = new System.Drawing.Point(662, 188);
            this.radioButtonSirop.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonSirop.Name = "radioButtonSirop";
            this.radioButtonSirop.Size = new System.Drawing.Size(75, 26);
            this.radioButtonSirop.TabIndex = 9;
            this.radioButtonSirop.TabStop = true;
            this.radioButtonSirop.Text = "Sirop";
            this.radioButtonSirop.UseVisualStyleBackColor = true;
            // 
            // textBoxCod
            // 
            this.textBoxCod.Location = new System.Drawing.Point(478, 225);
            this.textBoxCod.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(148, 30);
            this.textBoxCod.TabIndex = 10;
            this.textBoxCod.TextChanged += new System.EventHandler(this.textBoxCod_TextChanged);
            // 
            // dateTimePickerDataExpirarii
            // 
            this.dateTimePickerDataExpirarii.Location = new System.Drawing.Point(478, 263);
            this.dateTimePickerDataExpirarii.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDataExpirarii.Name = "dateTimePickerDataExpirarii";
            this.dateTimePickerDataExpirarii.Size = new System.Drawing.Size(230, 30);
            this.dateTimePickerDataExpirarii.TabIndex = 11;
            this.dateTimePickerDataExpirarii.ValueChanged += new System.EventHandler(this.dateTimePickerDataExpirarii_ValueChanged);
            // 
            // buttonAfisare
            // 
            this.buttonAfisare.Location = new System.Drawing.Point(327, 430);
            this.buttonAfisare.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAfisare.Name = "buttonAfisare";
            this.buttonAfisare.Size = new System.Drawing.Size(185, 32);
            this.buttonAfisare.TabIndex = 13;
            this.buttonAfisare.Text = "Afișare medicamente";
            this.buttonAfisare.UseVisualStyleBackColor = true;
            this.buttonAfisare.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEditare
            // 
            this.buttonEditare.Location = new System.Drawing.Point(446, 348);
            this.buttonEditare.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditare.Name = "buttonEditare";
            this.buttonEditare.Size = new System.Drawing.Size(110, 34);
            this.buttonEditare.TabIndex = 14;
            this.buttonEditare.Text = "Actualizare";
            this.buttonEditare.UseVisualStyleBackColor = true;
            this.buttonEditare.Click += new System.EventHandler(this.buttonEditare_Click);
            // 
            // buttonStergere
            // 
            this.buttonStergere.Location = new System.Drawing.Point(564, 348);
            this.buttonStergere.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStergere.Name = "buttonStergere";
            this.buttonStergere.Size = new System.Drawing.Size(100, 34);
            this.buttonStergere.TabIndex = 15;
            this.buttonStergere.Text = "Ștergere";
            this.buttonStergere.UseVisualStyleBackColor = true;
            this.buttonStergere.Click += new System.EventHandler(this.buttonStergere_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(323, 395);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 22);
            this.labelStatus.TabIndex = 17;
            // 
            // labelCantitate
            // 
            this.labelCantitate.AutoSize = true;
            this.labelCantitate.Location = new System.Drawing.Point(361, 311);
            this.labelCantitate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCantitate.Name = "labelCantitate";
            this.labelCantitate.Size = new System.Drawing.Size(80, 22);
            this.labelCantitate.TabIndex = 18;
            this.labelCantitate.Text = "Cantitate";
            // 
            // listBoxMedicamente
            // 
            this.listBoxMedicamente.FormattingEnabled = true;
            this.listBoxMedicamente.ItemHeight = 22;
            this.listBoxMedicamente.Location = new System.Drawing.Point(327, 470);
            this.listBoxMedicamente.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxMedicamente.Name = "listBoxMedicamente";
            this.listBoxMedicamente.Size = new System.Drawing.Size(755, 136);
            this.listBoxMedicamente.TabIndex = 20;
            this.listBoxMedicamente.SelectedIndexChanged += new System.EventHandler(this.listBoxMedicamente_SelectedIndexChanged);
            // 
            // buttonCauta
            // 
            this.buttonCauta.Location = new System.Drawing.Point(682, 348);
            this.buttonCauta.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCauta.Name = "buttonCauta";
            this.buttonCauta.Size = new System.Drawing.Size(100, 34);
            this.buttonCauta.TabIndex = 16;
            this.buttonCauta.Text = "Căutare";
            this.buttonCauta.UseVisualStyleBackColor = true;
            this.buttonCauta.Click += new System.EventHandler(this.button1_Cautare);
            // 
            // textBoxCantitate
            // 
            this.textBoxCantitate.Location = new System.Drawing.Point(478, 304);
            this.textBoxCantitate.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCantitate.Name = "textBoxCantitate";
            this.textBoxCantitate.Size = new System.Drawing.Size(148, 30);
            this.textBoxCantitate.TabIndex = 21;
            // 
            // openFileDialogSterge
            // 
            this.openFileDialogSterge.FileName = "Șterge";
            // 
            // buttonInapoi
            // 
            this.buttonInapoi.Location = new System.Drawing.Point(1196, 673);
            this.buttonInapoi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInapoi.Name = "buttonInapoi";
            this.buttonInapoi.Size = new System.Drawing.Size(90, 27);
            this.buttonInapoi.TabIndex = 22;
            this.buttonInapoi.Text = "Înapoi";
            this.buttonInapoi.UseVisualStyleBackColor = true;
            this.buttonInapoi.Click += new System.EventHandler(this.buttonInapoi_Click);
            // 
            // labelAngajatConectat
            // 
            this.labelAngajatConectat.AutoSize = true;
            this.labelAngajatConectat.Location = new System.Drawing.Point(32, 33);
            this.labelAngajatConectat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAngajatConectat.Name = "labelAngajatConectat";
            this.labelAngajatConectat.Size = new System.Drawing.Size(0, 22);
            this.labelAngajatConectat.TabIndex = 23;
            // 
            // FormAngajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Proiect.Properties.Resources.FormAngajat_Client1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1313, 727);
            this.Controls.Add(this.labelAngajatConectat);
            this.Controls.Add(this.buttonInapoi);
            this.Controls.Add(this.textBoxCantitate);
            this.Controls.Add(this.listBoxMedicamente);
            this.Controls.Add(this.labelCantitate);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonCauta);
            this.Controls.Add(this.buttonStergere);
            this.Controls.Add(this.buttonEditare);
            this.Controls.Add(this.buttonAfisare);
            this.Controls.Add(this.dateTimePickerDataExpirarii);
            this.Controls.Add(this.textBoxCod);
            this.Controls.Add(this.radioButtonSirop);
            this.Controls.Add(this.radioButtonCrema);
            this.Controls.Add(this.radioButtonPastila);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.labelDataExpirarii);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.labelCod);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.labelInfoAdauga);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAngajat";
            this.Text = "FormAngajat";
            this.Load += new System.EventHandler(this.FormAngajat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelInfoAdauga;
		private System.Windows.Forms.Label labelNume;
		private System.Windows.Forms.Label labelCod;
		private System.Windows.Forms.Label labelTip;
		private System.Windows.Forms.Button buttonAdauga;
		private System.Windows.Forms.Label labelDataExpirarii;
		private System.Windows.Forms.TextBox textBoxNume;
		private System.Windows.Forms.RadioButton radioButtonPastila;
		private System.Windows.Forms.RadioButton radioButtonCrema;
		private System.Windows.Forms.RadioButton radioButtonSirop;
		private System.Windows.Forms.TextBox textBoxCod;
		private System.Windows.Forms.DateTimePicker dateTimePickerDataExpirarii;
		private System.Windows.Forms.Button buttonAfisare;
		private System.Windows.Forms.Button buttonEditare;
		private System.Windows.Forms.Button buttonStergere;
		private System.Windows.Forms.Label labelStatus;
		private System.Windows.Forms.Label labelCantitate;
		private System.Windows.Forms.ListBox listBoxMedicamente;
		private System.Windows.Forms.Button buttonCauta;
		private System.Windows.Forms.TextBox textBoxCantitate;
		private System.Windows.Forms.OpenFileDialog openFileDialogSterge;
		private System.Windows.Forms.Button buttonInapoi;
		private System.Windows.Forms.Label labelAngajatConectat;
	}
}