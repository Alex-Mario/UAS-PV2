/*
 * Created by SharpDevelop.
 * User: Alex
 * Date: 6/2/2022
 * Time: 8:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace UAS_PV2
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		MySqlConnection co = new MySqlConnection("Server = localhost; Database = data_belanja; Uid = root");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		public void ReadData(){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from data_belanja";
				DataSet ds = new DataSet();

				if (myadapter.Fill(ds,"dftpesan") > 0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "dftpesan";
				}
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void Bersihkan()
		{
			nomorTextBox.Text="";
			nameTextBox.Text="";
			hargaTextBox.Text="";
			jumlahTextBox.Text="";
			totalTextBox.Text="";
			ReadData();
		}
		
		public void InsertData(){
			
			if(nomorTextBox.Text == "" || nameTextBox.Text==""||hargaTextBox.Text==""||jumlahTextBox.Text=="" ){
				MessageBox.Show("Ada data yg kosong, harap diisi","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else if(totalTextBox.Text==""){
				MessageBox.Show("Proses Total terlebihdahulu","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			
			else{
				try{
					mycommand.Connection=co;
					mycommand.CommandText="insert into data_belanja values('"+nomorTextBox.Text+"','"+nameTextBox.Text+"','"+hargaTextBox.Text	+"','"+jumlahTextBox.Text+"','"+totalTextBox.Text+"')";
					myadapter.SelectCommand= mycommand;
					if (mycommand.ExecuteNonQuery()==1){
						MessageBox.Show("Data berhasil dimasukan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
						ReadData();
						ResetData();
					}
				}
				catch(Exception ex){
					MessageBox.Show(ex.ToString());
				}
			}
		}
		
		public void UpdateData(){
			
			if(nomorTextBox.Text == "" || nameTextBox.Text==""||hargaTextBox.Text==""||jumlahTextBox.Text=="" ){
				MessageBox.Show("Ada data yg kosong, harap diisi","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else if(totalTextBox.Text==""){
				MessageBox.Show("Proses Total terlebihdahulu","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			
			else{
				
				try{
					mycommand.Connection=co;
					mycommand.CommandText = "update data_belanja set id='"+nomorTextBox.Text+"',nama_barang='"+nameTextBox.Text+"',harga_satuan='"+hargaTextBox.Text+"',jumlah='"+jumlahTextBox.Text+"',total='"+totalTextBox.Text+"' where id ='"+nomorTextBox.Text+"'";
					myadapter.SelectCommand = mycommand;
					if (mycommand.ExecuteNonQuery()==1){
						MessageBox.Show("Data berhasil diupdate","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
						ReadData();
						ResetData();
					}
				}
				catch(Exception ex){
					MessageBox.Show(ex.ToString());
				}
			}
		}
		
		public void DeleteData(){
			try{
				mycommand.Connection=co;
				mycommand.CommandText="delete from data_belanja where id='"+nomorTextBox.Text+"'";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery()>=1){
					MessageBox.Show("Data berhasil dihapus","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
				}
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void ResetData(){
			nomorTextBox.Text="";
			nameTextBox.Text="";
			hargaTextBox.Text="";
			jumlahTextBox.Text="";
			totalTextBox.Text="";
			ReadData();
		}
		
		public void ProsesData(){
			
			if(hargaTextBox.Text == "" && jumlahTextBox.Text == ""){
				MessageBox.Show("Harga dan Jumlah tidak boleh kosong","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			
			else {
				int harga, jumlah, total;
				
				harga = Convert.ToInt32(hargaTextBox.Text);
				jumlah = Convert.ToInt32(jumlahTextBox.Text);
				
				total = (harga * jumlah);
				totalTextBox.Text = total.ToString();
				
			};
			
		}
		
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			co.Open();
			ReadData();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		
		void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
		{
			nomorTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			nameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			hargaTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			jumlahTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
		}
		
		void ResetbtnClick(object sender, EventArgs e)
		{
			ResetData();
		}
		
		
		void InsertbtnClick(object sender, EventArgs e)
		{
			InsertData();
			Bersihkan();
		}
		
		void UpdatebtnClick(object sender, EventArgs e)
		{
			UpdateData();
			Bersihkan();
		}
		
		void DeletebtnClick(object sender, EventArgs e)
		{
			DeleteData();
		}
		
		
		void ProsesbtnClick(object sender, EventArgs e)
		{
			ProsesData();
		}
		
		
		void RefreshBtnClick(object sender, EventArgs e)
		{
			Bersihkan();
		}
	}
}
