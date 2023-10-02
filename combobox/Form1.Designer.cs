namespace combobox
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.llblNet = new System.Windows.Forms.Label();
            this.cmDogru = new System.Windows.Forms.ComboBox();
            this.cmYanlıs = new System.Windows.Forms.ComboBox();
            this.btnhHapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yalıs sayı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dogru Sayı";
            // 
            // llblNet
            // 
            this.llblNet.AutoSize = true;
            this.llblNet.Location = new System.Drawing.Point(5, 85);
            this.llblNet.Name = "llblNet";
            this.llblNet.Size = new System.Drawing.Size(47, 13);
            this.llblNet.TabIndex = 2;
            this.llblNet.Text = "Net Sayı";
            // 
            // cmDogru
            // 
            this.cmDogru.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cmDogru.FormattingEnabled = true;
            this.cmDogru.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19"});
            this.cmDogru.Location = new System.Drawing.Point(76, 6);
            this.cmDogru.Name = "cmDogru";
            this.cmDogru.Size = new System.Drawing.Size(121, 21);
            this.cmDogru.TabIndex = 3;
            // 
            // cmYanlıs
            // 
            this.cmYanlıs.FormattingEnabled = true;
            this.cmYanlıs.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19"});
            this.cmYanlıs.Location = new System.Drawing.Point(76, 50);
            this.cmYanlıs.Name = "cmYanlıs";
            this.cmYanlıs.Size = new System.Drawing.Size(121, 21);
            this.cmYanlıs.TabIndex = 4;
            // 
            // btnhHapla
            // 
            this.btnhHapla.Location = new System.Drawing.Point(58, 96);
            this.btnhHapla.Name = "btnhHapla";
            this.btnhHapla.Size = new System.Drawing.Size(115, 47);
            this.btnhHapla.TabIndex = 5;
            this.btnhHapla.Text = "Net Hsapla";
            this.btnhHapla.UseVisualStyleBackColor = true;
            this.btnhHapla.Click += new System.EventHandler(this.btnhHapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnhHapla);
            this.Controls.Add(this.cmYanlıs);
            this.Controls.Add(this.cmDogru);
            this.Controls.Add(this.llblNet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label llblNet;
        private System.Windows.Forms.ComboBox cmDogru;
        private System.Windows.Forms.ComboBox cmYanlıs;
        private System.Windows.Forms.Button btnhHapla;
    }
}

