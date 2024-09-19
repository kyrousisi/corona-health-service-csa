namespace GGDTestCenterAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTestCapacity = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIncreaseCampacity = new System.Windows.Forms.Button();
            this.lbAvailableService = new System.Windows.Forms.ListBox();
            this.lbLocations = new System.Windows.Forms.ListBox();
            this.btnGetTestCenters = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lbTestCapacity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbAddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnIncreaseCampacity);
            this.groupBox1.Controls.Add(this.lbAvailableService);
            this.groupBox1.Controls.Add(this.lbLocations);
            this.groupBox1.Controls.Add(this.btnGetTestCenters);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // lbTestCapacity
            // 
            this.lbTestCapacity.FormattingEnabled = true;
            resources.ApplyResources(this.lbTestCapacity, "lbTestCapacity");
            this.lbTestCapacity.Name = "lbTestCapacity";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lbAddress
            // 
            this.lbAddress.FormattingEnabled = true;
            resources.ApplyResources(this.lbAddress, "lbAddress");
            this.lbAddress.Name = "lbAddress";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnIncreaseCampacity
            // 
            resources.ApplyResources(this.btnIncreaseCampacity, "btnIncreaseCampacity");
            this.btnIncreaseCampacity.Name = "btnIncreaseCampacity";
            this.btnIncreaseCampacity.UseVisualStyleBackColor = true;
            this.btnIncreaseCampacity.Click += new System.EventHandler(this.btnIncreaseCampacity_Click);
            // 
            // lbAvailableService
            // 
            this.lbAvailableService.FormattingEnabled = true;
            resources.ApplyResources(this.lbAvailableService, "lbAvailableService");
            this.lbAvailableService.Name = "lbAvailableService";
            // 
            // lbLocations
            // 
            this.lbLocations.FormattingEnabled = true;
            resources.ApplyResources(this.lbLocations, "lbLocations");
            this.lbLocations.Name = "lbLocations";
            // 
            // btnGetTestCenters
            // 
            resources.ApplyResources(this.btnGetTestCenters, "btnGetTestCenters");
            this.btnGetTestCenters.Name = "btnGetTestCenters";
            this.btnGetTestCenters.UseVisualStyleBackColor = true;
            this.btnGetTestCenters.Click += new System.EventHandler(this.btnGetTestCenters_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGetTestCenters;
        private System.Windows.Forms.ListBox lbLocations;
        private System.Windows.Forms.ListBox lbAvailableService;
        private System.Windows.Forms.Button btnIncreaseCampacity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbTestCapacity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

