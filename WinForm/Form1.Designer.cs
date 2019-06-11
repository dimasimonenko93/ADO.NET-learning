namespace WinForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_SaveToDatabase = new System.Windows.Forms.Button();
            this.btn_SaveToXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(475, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_SaveToDatabase
            // 
            this.btn_SaveToDatabase.Location = new System.Drawing.Point(652, 399);
            this.btn_SaveToDatabase.Name = "btn_SaveToDatabase";
            this.btn_SaveToDatabase.Size = new System.Drawing.Size(136, 39);
            this.btn_SaveToDatabase.TabIndex = 1;
            this.btn_SaveToDatabase.Text = "Save";
            this.btn_SaveToDatabase.UseVisualStyleBackColor = true;
            this.btn_SaveToDatabase.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // btn_SaveToXML
            // 
            this.btn_SaveToXML.Location = new System.Drawing.Point(510, 399);
            this.btn_SaveToXML.Name = "btn_SaveToXML";
            this.btn_SaveToXML.Size = new System.Drawing.Size(136, 39);
            this.btn_SaveToXML.TabIndex = 2;
            this.btn_SaveToXML.Text = "Save to XML";
            this.btn_SaveToXML.UseVisualStyleBackColor = true;
            this.btn_SaveToXML.Click += new System.EventHandler(this.Btn_SaveToXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SaveToXML);
            this.Controls.Add(this.btn_SaveToDatabase);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_SaveToDatabase;
        private System.Windows.Forms.Button btn_SaveToXML;
    }
}

