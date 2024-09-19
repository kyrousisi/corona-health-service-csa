namespace UserApp
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
            this.button2 = new System.Windows.Forms.Button();
            this.lbLocations = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbServiceName = new System.Windows.Forms.Label();
            this.lbAvailableCapacity = new System.Windows.Forms.ListBox();
            this.btnCancelReservation = new System.Windows.Forms.Button();
            this.lbAddress = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMakeReservation = new System.Windows.Forms.Button();
            this.btGetServiceName = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(45, 52);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Get Available Test Locations";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbLocations
            // 
            this.lbLocations.FormattingEnabled = true;
            this.lbLocations.ItemHeight = 16;
            this.lbLocations.Location = new System.Drawing.Point(45, 161);
            this.lbLocations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbLocations.Name = "lbLocations";
            this.lbLocations.Size = new System.Drawing.Size(188, 116);
            this.lbLocations.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Controls.Add(this.btGetServiceName);
            this.groupBox1.Controls.Add(this.lbServiceName);
            this.groupBox1.Location = new System.Drawing.Point(40, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(859, 113);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assignment1";
            // 
            // lbServiceName
            // 
            this.lbServiceName.AutoSize = true;
            this.lbServiceName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServiceName.Location = new System.Drawing.Point(565, 57);
            this.lbServiceName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbServiceName.Name = "lbServiceName";
            this.lbServiceName.Size = new System.Drawing.Size(131, 23);
            this.lbServiceName.TabIndex = 5;
            this.lbServiceName.Text = "<Service Name>";
            // 
            // lbAvailableCapacity
            // 
            this.lbAvailableCapacity.FormattingEnabled = true;
            this.lbAvailableCapacity.ItemHeight = 16;
            this.lbAvailableCapacity.Location = new System.Drawing.Point(275, 161);
            this.lbAvailableCapacity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbAvailableCapacity.Name = "lbAvailableCapacity";
            this.lbAvailableCapacity.Size = new System.Drawing.Size(184, 116);
            this.lbAvailableCapacity.TabIndex = 6;
            // 
            // btnCancelReservation
            // 
            this.btnCancelReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelReservation.Location = new System.Drawing.Point(45, 386);
            this.btnCancelReservation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelReservation.Name = "btnCancelReservation";
            this.btnCancelReservation.Size = new System.Drawing.Size(213, 49);
            this.btnCancelReservation.TabIndex = 8;
            this.btnCancelReservation.Text = "Cancel Reservation";
            this.btnCancelReservation.UseVisualStyleBackColor = true;
            this.btnCancelReservation.Click += new System.EventHandler(this.btnCancelReservation_Click);
            // 
            // lbAddress
            // 
            this.lbAddress.FormattingEnabled = true;
            this.lbAddress.ItemHeight = 16;
            this.lbAddress.Location = new System.Drawing.Point(500, 161);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(313, 116);
            this.lbAddress.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnMakeReservation);
            this.groupBox2.Controls.Add(this.lbAddress);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnCancelReservation);
            this.groupBox2.Controls.Add(this.lbLocations);
            this.groupBox2.Controls.Add(this.lbAvailableCapacity);
            this.groupBox2.Location = new System.Drawing.Point(40, 169);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(859, 460);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assignment 2, 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(496, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Test Center Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Available Appointment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Location (city)";
            // 
            // btnMakeReservation
            // 
            this.btnMakeReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeReservation.Location = new System.Drawing.Point(45, 315);
            this.btnMakeReservation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMakeReservation.Name = "btnMakeReservation";
            this.btnMakeReservation.Size = new System.Drawing.Size(213, 49);
            this.btnMakeReservation.TabIndex = 10;
            this.btnMakeReservation.Text = "Make Reservation";
            this.btnMakeReservation.UseVisualStyleBackColor = true;
            this.btnMakeReservation.Click += new System.EventHandler(this.btnMakeReservation_Click);
            // 
            // btGetServiceName
            // 
            this.btGetServiceName.Location = new System.Drawing.Point(76, 57);
            this.btGetServiceName.Name = "btGetServiceName";
            this.btGetServiceName.Size = new System.Drawing.Size(238, 23);
            this.btGetServiceName.TabIndex = 6;
            this.btGetServiceName.Text = "Get Service Name";
            this.btGetServiceName.UseVisualStyleBackColor = true;
            this.btGetServiceName.Click += new System.EventHandler(this.btGetServiceName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 666);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "GGD Corona Test Reservation App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lbLocations;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbAvailableCapacity;
        private System.Windows.Forms.Button btnCancelReservation;
        private System.Windows.Forms.ListBox lbAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMakeReservation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbServiceName;
        private System.Windows.Forms.Button btGetServiceName;
    }
}

