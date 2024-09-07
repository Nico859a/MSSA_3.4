namespace Assignment3._4
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
            this.lb_Coffeelist = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.but_delete = new System.Windows.Forms.Button();
            this.but_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.texID = new System.Windows.Forms.TextBox();
            this.texName = new System.Windows.Forms.TextBox();
            this.texType = new System.Windows.Forms.TextBox();
            this.texSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.texRoast = new System.Windows.Forms.TextBox();
            this.texOrigin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Coffeelist
            // 
            this.lb_Coffeelist.AutoSize = true;
            this.lb_Coffeelist.Font = new System.Drawing.Font("Gabriola", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Coffeelist.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lb_Coffeelist.Location = new System.Drawing.Point(561, 42);
            this.lb_Coffeelist.Name = "lb_Coffeelist";
            this.lb_Coffeelist.Size = new System.Drawing.Size(145, 59);
            this.lb_Coffeelist.TabIndex = 0;
            this.lb_Coffeelist.Text = "Coffee  List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Olive;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(355, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(520, 336);
            this.dataGridView1.TabIndex = 1;
            // 
            // but_delete
            // 
            this.but_delete.BackColor = System.Drawing.Color.OrangeRed;
            this.but_delete.Location = new System.Drawing.Point(60, 432);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(75, 23);
            this.but_delete.TabIndex = 2;
            this.but_delete.Text = "Delete";
            this.but_delete.UseVisualStyleBackColor = false;
            this.but_delete.Click += new System.EventHandler(this.but_delete_Click);
            // 
            // but_Add
            // 
            this.but_Add.BackColor = System.Drawing.Color.LightGreen;
            this.but_Add.Location = new System.Drawing.Point(200, 432);
            this.but_Add.Name = "but_Add";
            this.but_Add.Size = new System.Drawing.Size(75, 23);
            this.but_Add.TabIndex = 3;
            this.but_Add.Text = "Add";
            this.but_Add.UseVisualStyleBackColor = false;
            this.but_Add.Click += new System.EventHandler(this.but_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Size";
            // 
            // texID
            // 
            this.texID.Location = new System.Drawing.Point(127, 104);
            this.texID.Name = "texID";
            this.texID.Size = new System.Drawing.Size(100, 20);
            this.texID.TabIndex = 8;
            // 
            // texName
            // 
            this.texName.Location = new System.Drawing.Point(127, 149);
            this.texName.Name = "texName";
            this.texName.Size = new System.Drawing.Size(100, 20);
            this.texName.TabIndex = 9;
            // 
            // texType
            // 
            this.texType.Location = new System.Drawing.Point(127, 197);
            this.texType.Name = "texType";
            this.texType.Size = new System.Drawing.Size(100, 20);
            this.texType.TabIndex = 10;
            // 
            // texSize
            // 
            this.texSize.Location = new System.Drawing.Point(127, 248);
            this.texSize.Name = "texSize";
            this.texSize.Size = new System.Drawing.Size(100, 20);
            this.texSize.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Roast";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Origin";
            // 
            // texRoast
            // 
            this.texRoast.Location = new System.Drawing.Point(127, 294);
            this.texRoast.Name = "texRoast";
            this.texRoast.Size = new System.Drawing.Size(100, 20);
            this.texRoast.TabIndex = 14;
            // 
            // texOrigin
            // 
            this.texOrigin.Location = new System.Drawing.Point(127, 342);
            this.texOrigin.Name = "texOrigin";
            this.texOrigin.Size = new System.Drawing.Size(100, 20);
            this.texOrigin.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 562);
            this.Controls.Add(this.texOrigin);
            this.Controls.Add(this.texRoast);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.texSize);
            this.Controls.Add(this.texType);
            this.Controls.Add(this.texName);
            this.Controls.Add(this.texID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_Add);
            this.Controls.Add(this.but_delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lb_Coffeelist);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Coffeelist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.Button but_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texID;
        private System.Windows.Forms.TextBox texName;
        private System.Windows.Forms.TextBox texType;
        private System.Windows.Forms.TextBox texSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox texRoast;
        private System.Windows.Forms.TextBox texOrigin;
    }
}

