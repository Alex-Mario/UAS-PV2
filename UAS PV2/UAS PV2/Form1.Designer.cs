/*
 * Created by SharpDevelop.
 * User: Alex
 * Date: 6/2/2022
 * Time: 8:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UAS_PV2
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.totalTextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.Prosesbtn = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.Resetbtn = new System.Windows.Forms.Button();
			this.Deletebtn = new System.Windows.Forms.Button();
			this.Updatebtn = new System.Windows.Forms.Button();
			this.Insertbtn = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.jumlahTextBox = new System.Windows.Forms.TextBox();
			this.hargaTextBox = new System.Windows.Forms.TextBox();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.nomorTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// totalTextBox
			// 
			this.totalTextBox.Enabled = false;
			this.totalTextBox.Location = new System.Drawing.Point(118, 237);
			this.totalTextBox.Name = "totalTextBox";
			this.totalTextBox.ReadOnly = true;
			this.totalTextBox.Size = new System.Drawing.Size(214, 20);
			this.totalTextBox.TabIndex = 37;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label8.Location = new System.Drawing.Point(12, 237);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 36;
			this.label8.Text = "Total";
			// 
			// Prosesbtn
			// 
			this.Prosesbtn.BackColor = System.Drawing.Color.LightGreen;
			this.Prosesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.Prosesbtn.Location = new System.Drawing.Point(199, 280);
			this.Prosesbtn.Name = "Prosesbtn";
			this.Prosesbtn.Size = new System.Drawing.Size(117, 33);
			this.Prosesbtn.TabIndex = 35;
			this.Prosesbtn.Text = "Proses";
			this.Prosesbtn.UseVisualStyleBackColor = false;
			this.Prosesbtn.Click += new System.EventHandler(this.ProsesbtnClick);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(627, 447);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(287, 23);
			this.label6.TabIndex = 33;
			this.label6.Text = "Alex Mario Simanjuntak   (201401034)";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.label5.Location = new System.Drawing.Point(357, 18);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(340, 37);
			this.label5.TabIndex = 32;
			this.label5.Text = "DAFTAR BELANJA";
			// 
			// Resetbtn
			// 
			this.Resetbtn.BackColor = System.Drawing.Color.Cyan;
			this.Resetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Resetbtn.Location = new System.Drawing.Point(199, 319);
			this.Resetbtn.Name = "Resetbtn";
			this.Resetbtn.Size = new System.Drawing.Size(117, 34);
			this.Resetbtn.TabIndex = 31;
			this.Resetbtn.Text = "Refresh";
			this.Resetbtn.UseVisualStyleBackColor = false;
			this.Resetbtn.Click += new System.EventHandler(this.ResetbtnClick);
			// 
			// Deletebtn
			// 
			this.Deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Deletebtn.Location = new System.Drawing.Point(43, 280);
			this.Deletebtn.Name = "Deletebtn";
			this.Deletebtn.Size = new System.Drawing.Size(117, 34);
			this.Deletebtn.TabIndex = 30;
			this.Deletebtn.Text = "Delete";
			this.Deletebtn.UseVisualStyleBackColor = false;
			this.Deletebtn.Click += new System.EventHandler(this.DeletebtnClick);
			// 
			// Updatebtn
			// 
			this.Updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Updatebtn.Location = new System.Drawing.Point(43, 320);
			this.Updatebtn.Name = "Updatebtn";
			this.Updatebtn.Size = new System.Drawing.Size(117, 33);
			this.Updatebtn.TabIndex = 29;
			this.Updatebtn.Text = "Update";
			this.Updatebtn.UseVisualStyleBackColor = false;
			this.Updatebtn.Click += new System.EventHandler(this.UpdatebtnClick);
			// 
			// Insertbtn
			// 
			this.Insertbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.Insertbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Insertbtn.Location = new System.Drawing.Point(118, 375);
			this.Insertbtn.Name = "Insertbtn";
			this.Insertbtn.Size = new System.Drawing.Size(119, 59);
			this.Insertbtn.TabIndex = 28;
			this.Insertbtn.Text = "Insert";
			this.Insertbtn.UseVisualStyleBackColor = false;
			this.Insertbtn.Click += new System.EventHandler(this.InsertbtnClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(357, 68);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(541, 356);
			this.dataGridView1.TabIndex = 27;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellClick);
			// 
			// jumlahTextBox
			// 
			this.jumlahTextBox.Location = new System.Drawing.Point(118, 194);
			this.jumlahTextBox.Name = "jumlahTextBox";
			this.jumlahTextBox.Size = new System.Drawing.Size(214, 20);
			this.jumlahTextBox.TabIndex = 26;
			// 
			// hargaTextBox
			// 
			this.hargaTextBox.Location = new System.Drawing.Point(118, 149);
			this.hargaTextBox.Name = "hargaTextBox";
			this.hargaTextBox.Size = new System.Drawing.Size(214, 20);
			this.hargaTextBox.TabIndex = 25;
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(118, 106);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(214, 20);
			this.nameTextBox.TabIndex = 24;
			// 
			// nomorTextBox
			// 
			this.nomorTextBox.Location = new System.Drawing.Point(118, 68);
			this.nomorTextBox.Name = "nomorTextBox";
			this.nomorTextBox.Size = new System.Drawing.Size(214, 20);
			this.nomorTextBox.TabIndex = 23;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label4.Location = new System.Drawing.Point(12, 197);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 22;
			this.label4.Text = "Jumlah";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label3.Location = new System.Drawing.Point(12, 152);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 21;
			this.label3.Text = "Harga Satuan";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label2.Location = new System.Drawing.Point(12, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 20;
			this.label2.Text = "Nama Barang";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.Location = new System.Drawing.Point(12, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 19;
			this.label1.Text = "ID Kode";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SkyBlue;
			this.ClientSize = new System.Drawing.Size(936, 489);
			this.Controls.Add(this.totalTextBox);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.Prosesbtn);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Resetbtn);
			this.Controls.Add(this.Deletebtn);
			this.Controls.Add(this.Updatebtn);
			this.Controls.Add(this.Insertbtn);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.jumlahTextBox);
			this.Controls.Add(this.hargaTextBox);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.nomorTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox nomorTextBox;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.TextBox hargaTextBox;
		private System.Windows.Forms.TextBox jumlahTextBox;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button Insertbtn;
		private System.Windows.Forms.Button Updatebtn;
		private System.Windows.Forms.Button Deletebtn;
		private System.Windows.Forms.Button Resetbtn;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button Prosesbtn;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox totalTextBox;
	}
}
