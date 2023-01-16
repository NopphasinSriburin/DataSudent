namespace DST
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.N = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.gards = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saka = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Maxgards = new System.Windows.Forms.TextBox();
            this.Mingards = new System.Windows.Forms.TextBox();
            this.somthing = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // N
            // 
            this.N.AutoSize = true;
            this.N.Location = new System.Drawing.Point(23, 41);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(82, 20);
            this.N.TabIndex = 0;
            this.N.Text = "ชื่อ นักศึกษา";
            this.N.Click += new System.EventHandler(this.N_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "รหัสนักศึกษา";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ส่วนสูง";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "วันเกิด";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "เกรด";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "บันทึก";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(114, 41);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(244, 27);
            this.name.TabIndex = 6;
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(111, 90);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(247, 27);
            this.Id.TabIndex = 7;
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(111, 140);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(247, 27);
            this.height.TabIndex = 8;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(111, 183);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(247, 27);
            this.date.TabIndex = 9;
            this.date.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // gards
            // 
            this.gards.Location = new System.Drawing.Point(111, 225);
            this.gards.Name = "gards";
            this.gards.Size = new System.Drawing.Size(247, 27);
            this.gards.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "สาขา";
            // 
            // saka
            // 
            this.saka.Location = new System.Drawing.Point(111, 270);
            this.saka.Name = "saka";
            this.saka.Size = new System.Drawing.Size(247, 27);
            this.saka.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(451, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(300, 188);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Maxgards
            // 
            this.Maxgards.Location = new System.Drawing.Point(451, 270);
            this.Maxgards.Name = "Maxgards";
            this.Maxgards.Size = new System.Drawing.Size(190, 27);
            this.Maxgards.TabIndex = 14;
            this.Maxgards.TextChanged += new System.EventHandler(this.Maxgards_TextChanged);
            // 
            // Mingards
            // 
            this.Mingards.Location = new System.Drawing.Point(451, 314);
            this.Mingards.Name = "Mingards";
            this.Mingards.Size = new System.Drawing.Size(190, 27);
            this.Mingards.TabIndex = 15;
            // 
            // somthing
            // 
            this.somthing.Location = new System.Drawing.Point(451, 360);
            this.somthing.Name = "somthing";
            this.somthing.Size = new System.Drawing.Size(190, 27);
            this.somthing.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.somthing);
            this.Controls.Add(this.Mingards);
            this.Controls.Add(this.Maxgards);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.saka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gards);
            this.Controls.Add(this.date);
            this.Controls.Add(this.height);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.N);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label N;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox name;
        private TextBox Id;
        private TextBox height;
        private TextBox date;
        private TextBox gards;
        private Label label5;
        private TextBox saka;
        private DataGridView dataGridView1;
        private TextBox Maxgards;
        private TextBox Mingards;
        private TextBox somthing;
    }
}