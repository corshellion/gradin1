namespace GradinNo1
{
    partial class Form1
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
            this.cblevel = new System.Windows.Forms.ComboBox();
            this.cbgaji = new System.Windows.Forms.ComboBox();
            this.cbnegara = new System.Windows.Forms.ComboBox();
            this.hitung = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbnama = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gajiakhir = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // cblevel
            // 
            this.cblevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblevel.FormattingEnabled = true;
            this.cblevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cblevel.Location = new System.Drawing.Point(50, 180);
            this.cblevel.Name = "cblevel";
            this.cblevel.Size = new System.Drawing.Size(209, 33);
            this.cblevel.TabIndex = 0;
            this.cblevel.Text = "Pilih Level Anda";
            // 
            // cbgaji
            // 
            this.cbgaji.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbgaji.FormattingEnabled = true;
            this.cbgaji.Items.AddRange(new object[] {
            "2000000",
            "5000000",
            "8000000",
            "10000000",
            "11000000"});
            this.cbgaji.Location = new System.Drawing.Point(50, 141);
            this.cbgaji.Name = "cbgaji";
            this.cbgaji.Size = new System.Drawing.Size(209, 33);
            this.cbgaji.TabIndex = 2;
            this.cbgaji.Text = "Gaji Anda";
            // 
            // cbnegara
            // 
            this.cbnegara.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnegara.FormattingEnabled = true;
            this.cbnegara.Items.AddRange(new object[] {
            "Asia",
            "Europe",
            "North America"});
            this.cbnegara.Location = new System.Drawing.Point(50, 221);
            this.cbnegara.Name = "cbnegara";
            this.cbnegara.Size = new System.Drawing.Size(209, 33);
            this.cbnegara.TabIndex = 3;
            this.cbnegara.Text = "Pilih Negara Anda";
            // 
            // hitung
            // 
            this.hitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitung.Location = new System.Drawing.Point(110, 260);
            this.hitung.Name = "hitung";
            this.hitung.Size = new System.Drawing.Size(120, 28);
            this.hitung.TabIndex = 4;
            this.hitung.Text = "Hitung Gaji Akhir";
            this.hitung.UseVisualStyleBackColor = true;
            this.hitung.Click += new System.EventHandler(this.hitung_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "> 7 Jt (10%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "> 4jt < 7 Jt (20%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "<4 Jt (40%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Keterangan Penambahan Gaji";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Keterangan Pajak";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Asia (2%)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Europe(2.5%)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "North America (3%)";
            // 
            // cbnama
            // 
            this.cbnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnama.FormattingEnabled = true;
            this.cbnama.Items.AddRange(new object[] {
            "Anto",
            "Andi",
            "Budi",
            "Nita",
            "Bagus"});
            this.cbnama.Location = new System.Drawing.Point(50, 101);
            this.cbnama.Name = "cbnama";
            this.cbnama.Size = new System.Drawing.Size(209, 33);
            this.cbnama.TabIndex = 13;
            this.cbnama.Text = "Nama Anda";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Perhitungan Gaji Akhir";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(66, 314);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 24);
            this.label10.TabIndex = 15;
            this.label10.Text = "Gaji Akhir:";
            // 
            // gajiakhir
            // 
            this.gajiakhir.AutoSize = true;
            this.gajiakhir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gajiakhir.Location = new System.Drawing.Point(167, 314);
            this.gajiakhir.Name = "gajiakhir";
            this.gajiakhir.Size = new System.Drawing.Size(20, 24);
            this.gajiakhir.TabIndex = 16;
            this.gajiakhir.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(294, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Keterangan Bonus";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(314, 250);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Level 1 200 rb";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(314, 268);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Level 2 500 rb";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(314, 284);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Level 3 1 jt";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(489, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(236, 305);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 376);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gajiakhir);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbnama);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hitung);
            this.Controls.Add(this.cbnegara);
            this.Controls.Add(this.cbgaji);
            this.Controls.Add(this.cblevel);
            this.Name = "Form1";
            this.Text = "Perhitungan Gaji Akhir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cblevel;
        private System.Windows.Forms.ComboBox cbgaji;
        private System.Windows.Forms.ComboBox cbnegara;
        private System.Windows.Forms.Button hitung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbnama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label gajiakhir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListView listView1;
    }
}

