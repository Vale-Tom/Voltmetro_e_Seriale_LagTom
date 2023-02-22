/*
 * Creato da SharpDevelop.
 * Utente: Utente
 * Data: 14/02/2023
 * Ora: 20:24
 * 
 * Per modificare questo modello usa Strumenti | Opzioni | Codice | Modifica Intestazioni Standard
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;

namespace comunicazione_seriale_arduino
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int i=0;
		SerialPort[] openports = new SerialPort[20];
		public MainForm()
		{
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			string[] porte = SerialPort.GetPortNames();
			cmbSERIALE.Items.AddRange(porte);
			cmbSERIALE.SelectedIndex=0;
		}
		void BtnOPENClick(object sender, EventArgs e)
		{
				
		}

	}
}
