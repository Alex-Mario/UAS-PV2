/*
 * Created by SharpDevelop.
 * User: Alex
 * Date: 6/2/2022
 * Time: 9:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UAS_PV2
{
	/// <summary>
	/// Description of loading.
	/// </summary>
	public partial class loading : Form
	{
		public loading()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void ProgressBar2Click(object sender, EventArgs e)
		{
			
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			if(progressBar2.Value == 100){
				timer1.Enabled = false;
				MainForm formHome = new MainForm();
				formHome.Show();
				this.Hide();
			}
			
			else{
				progressBar2.Value += 2;
			}
		}
	}
}
