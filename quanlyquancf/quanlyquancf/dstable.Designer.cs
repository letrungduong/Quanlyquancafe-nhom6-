namespace QuanLyQuanCafe
{
    partial class dstable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>        /// Clean up any resources being used.
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
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(3, 22);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(483, 372);
            this.flpTable.TabIndex = 9;
            this.flpTable.Paint += new System.Windows.Forms.PaintEventHandler(this.flpTable_Paint);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.DodgerBlue;
            this.button14.Location = new System.Drawing.Point(526, 375);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(98, 49);
            this.button14.TabIndex = 19;
            this.button14.Text = "ĐÓNG";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.DodgerBlue;
            this.button13.Location = new System.Drawing.Point(526, 283);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(98, 49);
            this.button13.TabIndex = 18;
            this.button13.Text = "CHỨC NĂNG";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Red;
            this.button10.Location = new System.Drawing.Point(526, 22);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(98, 49);
            this.button10.TabIndex = 15;
            this.button10.Text = "KHU A";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // dstable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(648, 436);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.flpTable);
            this.Name = "dstable";
            this.Text = "fTableManager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button10;
    }
}