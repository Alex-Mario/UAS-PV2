/*
 * Created by SharpDevelop.
 * User: Alex
 * Date: 5/25/2022
 * Time: 2:11 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UAS_PV2
{
	/// <summary>
	/// Description of login.
	/// </summary>
	public partial class login : Form
	{
		public login()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void LoginLoad(object sender, EventArgs e)
		{
			MaximizeBox = false;
			TxtPassword.UseSystemPasswordChar = true;
		}
		
		void BtnLoginClick(object sender, EventArgs e)
		{
			if (TxtUsername.Text == "" && TxtPassword.Text == ""){
				MessageBox.Show("Username atau Password tidak boleh kosong!","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
				TxtUsername.Focus();
			}
			
			else if (TxtUsername.Text == "admin" && TxtPassword.Text == "admin"){
				MessageBox.Show("Login Berhasil","Akses Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
				loading tampil = new loading();
				tampil.Show();
				this.Hide();
			}
			
			else {
				MessageBox.Show("Kombinasi Username dan Password Salah!","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
				Bersihkan();
				TxtUsername.Focus();
			}
		}
		
		void Bersihkan(){
			TxtUsername.Text = "";
			TxtPassword.Text = "";
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked){
				TxtPassword.UseSystemPasswordChar = false;
			}
			
			else TxtPassword.UseSystemPasswordChar = true;
			
			TxtPassword.Focus();
		}
		
		void TxtPasswordKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13){
				
				if (TxtUsername.Text == "" && TxtPassword.Text == ""){
					MessageBox.Show("Username atau Password tidak boleh kosong!","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
					TxtUsername.Focus();
				}
				
				else if (TxtUsername.Text == "admin" && TxtPassword.Text == "admin"){
					MessageBox.Show("Login Berhasil","Akses Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
					loading tampil = new loading();
					tampil.Show();
					this.Hide();
				}
				
				else {
					MessageBox.Show("Kombinasi Username dan Password Salah!","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
					Bersihkan();
					TxtUsername.Focus();
				}
			}
		}
		
		
		void TxtUsernameKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13){
				
				if (TxtUsername.Text == "" && TxtPassword.Text == ""){
					MessageBox.Show("Username atau Password tidak boleh kosong!","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
					TxtUsername.Focus();
				}
				
				else if (TxtUsername.Text == "admin" && TxtPassword.Text == "admin"){
					MessageBox.Show("Login Berhasil","Akses Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
					loading tampil = new loading();
					tampil.Show();
					this.Hide();
				}
				
				else {
					MessageBox.Show("Kombinasi Username dan Password Salah!","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
					Bersihkan();
					TxtUsername.Focus();
				}
			}
		}
		
		void CheckBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13){
				
				if(checkBox1.Checked){
					checkBox1.Checked = false;
				}
				
				else checkBox1.Checked = true;
				
				TxtPassword.Focus();
			}
		}
		
		void BtnCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
