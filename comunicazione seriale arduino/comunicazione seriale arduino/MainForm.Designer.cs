/*
 * Creato da SharpDevelop.
 * Utente: Utente
 * Data: 14/02/2023
 * Ora: 20:24
 * 
 * Per modificare questo modello usa Strumenti | Opzioni | Codice | Modifica Intestazioni Standard
 */
namespace comunicazione_seriale_arduino
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ComboBox cmbSERIALE;
		private System.Windows.Forms.Button btnOPEN;
		private System.Windows.Forms.Button btnCLOSE;
		private System.Windows.Forms.RichTextBox txtbxSEND;
		private System.Windows.Forms.RichTextBox txtbxRECEIVE;
		private System.Windows.Forms.Button btnSEND;
		private System.Windows.Forms.Button btnRECEIVE;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.cmbSERIALE = new System.Windows.Forms.ComboBox();
			this.btnOPEN = new System.Windows.Forms.Button();
			this.btnCLOSE = new System.Windows.Forms.Button();
			this.txtbxSEND = new System.Windows.Forms.RichTextBox();
			this.txtbxRECEIVE = new System.Windows.Forms.RichTextBox();
			this.btnSEND = new System.Windows.Forms.Button();
			this.btnRECEIVE = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cmbSERIALE
			// 
			this.cmbSERIALE.FormattingEnabled = true;
			this.cmbSERIALE.Location = new System.Drawing.Point(34, 35);
			this.cmbSERIALE.Name = "cmbSERIALE";
			this.cmbSERIALE.Size = new System.Drawing.Size(200, 28);
			this.cmbSERIALE.TabIndex = 0;
			// 
			// btnOPEN
			// 
			this.btnOPEN.Location = new System.Drawing.Point(250, 35);
			this.btnOPEN.Name = "btnOPEN";
			this.btnOPEN.Size = new System.Drawing.Size(79, 29);
			this.btnOPEN.TabIndex = 1;
			this.btnOPEN.Text = "APRI";
			this.btnOPEN.UseVisualStyleBackColor = true;
			this.btnOPEN.Click += new System.EventHandler(this.BtnOPENClick);
			// 
			// btnCLOSE
			// 
			this.btnCLOSE.Location = new System.Drawing.Point(342, 35);
			this.btnCLOSE.Name = "btnCLOSE";
			this.btnCLOSE.Size = new System.Drawing.Size(79, 29);
			this.btnCLOSE.TabIndex = 2;
			this.btnCLOSE.Text = "CHIUDI";
			this.btnCLOSE.UseVisualStyleBackColor = true;
			// 
			// txtbxSEND
			// 
			this.txtbxSEND.Location = new System.Drawing.Point(34, 86);
			this.txtbxSEND.Name = "txtbxSEND";
			this.txtbxSEND.Size = new System.Drawing.Size(1012, 148);
			this.txtbxSEND.TabIndex = 4;
			this.txtbxSEND.Text = "";
			// 
			// txtbxRECEIVE
			// 
			this.txtbxRECEIVE.Location = new System.Drawing.Point(34, 294);
			this.txtbxRECEIVE.Name = "txtbxRECEIVE";
			this.txtbxRECEIVE.ReadOnly = true;
			this.txtbxRECEIVE.Size = new System.Drawing.Size(1012, 148);
			this.txtbxRECEIVE.TabIndex = 5;
			this.txtbxRECEIVE.Text = "";
			// 
			// btnSEND
			// 
			this.btnSEND.Location = new System.Drawing.Point(955, 240);
			this.btnSEND.Name = "btnSEND";
			this.btnSEND.Size = new System.Drawing.Size(79, 29);
			this.btnSEND.TabIndex = 6;
			this.btnSEND.Text = "INVIO";
			this.btnSEND.UseVisualStyleBackColor = true;
			// 
			// btnRECEIVE
			// 
			this.btnRECEIVE.Location = new System.Drawing.Point(955, 448);
			this.btnRECEIVE.Name = "btnRECEIVE";
			this.btnRECEIVE.Size = new System.Drawing.Size(79, 29);
			this.btnRECEIVE.TabIndex = 7;
			this.btnRECEIVE.Text = "RICEVI";
			this.btnRECEIVE.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1080, 533);
			this.Controls.Add(this.btnRECEIVE);
			this.Controls.Add(this.btnSEND);
			this.Controls.Add(this.txtbxRECEIVE);
			this.Controls.Add(this.txtbxSEND);
			this.Controls.Add(this.btnCLOSE);
			this.Controls.Add(this.btnOPEN);
			this.Controls.Add(this.cmbSERIALE);
			this.Name = "MainForm";
			this.Text = "comunicazione seriale arduino";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);

		}
	}
}
