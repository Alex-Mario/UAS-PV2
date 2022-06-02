/*
 * Created by SharpDevelop.
 * User: Alex
 * Date: 6/2/2022
 * Time: 8:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UAS_PV2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private int Count=1;
		
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
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void NewToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form1 frmChild = new Form1();
			frmChild.MdiParent = this;
			frmChild.Show();
			frmChild.Text += "ChildForm #" + Count.ToString();
			Count++;
		}
		
		void CascadeToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.Cascade);
		}
		
		void HorizontalToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileHorizontal);
		}
		
		void VerticalToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileVertical);
		}
	}
}
