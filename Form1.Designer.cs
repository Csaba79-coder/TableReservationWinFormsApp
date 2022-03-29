
namespace TableReservationWinFormsApp
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
            this.listBoxGuests = new System.Windows.Forms.ListBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxGuestNumber = new System.Windows.Forms.TextBox();
            this.textBoxArrivalHour = new System.Windows.Forms.TextBox();
            this.textBoxArrivalDate = new System.Windows.Forms.TextBox();
            this.checkBoxRegGuest = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxGuests
            // 
            this.listBoxGuests.FormattingEnabled = true;
            this.listBoxGuests.ItemHeight = 15;
            this.listBoxGuests.Location = new System.Drawing.Point(78, 52);
            this.listBoxGuests.Name = "listBoxGuests";
            this.listBoxGuests.Size = new System.Drawing.Size(226, 274);
            this.listBoxGuests.TabIndex = 0;
            this.listBoxGuests.SelectedIndexChanged += new System.EventHandler(this.listBoxGuests_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(462, 80);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 23);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxGuestNumber
            // 
            this.textBoxGuestNumber.Location = new System.Drawing.Point(462, 133);
            this.textBoxGuestNumber.Name = "textBoxGuestNumber";
            this.textBoxGuestNumber.Size = new System.Drawing.Size(100, 23);
            this.textBoxGuestNumber.TabIndex = 2;
            // 
            // textBoxArrivalHour
            // 
            this.textBoxArrivalHour.Location = new System.Drawing.Point(462, 193);
            this.textBoxArrivalHour.Name = "textBoxArrivalHour";
            this.textBoxArrivalHour.Size = new System.Drawing.Size(100, 23);
            this.textBoxArrivalHour.TabIndex = 3;
            // 
            // textBoxArrivalDate
            // 
            this.textBoxArrivalDate.Location = new System.Drawing.Point(462, 281);
            this.textBoxArrivalDate.Name = "textBoxArrivalDate";
            this.textBoxArrivalDate.Size = new System.Drawing.Size(100, 23);
            this.textBoxArrivalDate.TabIndex = 4;
            // 
            // checkBoxRegGuest
            // 
            this.checkBoxRegGuest.AutoSize = true;
            this.checkBoxRegGuest.Location = new System.Drawing.Point(462, 344);
            this.checkBoxRegGuest.Name = "checkBoxRegGuest";
            this.checkBoxRegGuest.Size = new System.Drawing.Size(99, 19);
            this.checkBoxRegGuest.TabIndex = 5;
            this.checkBoxRegGuest.Text = "Regular Guest";
            this.checkBoxRegGuest.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hour";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date";
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(78, 361);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(75, 23);
            this.buttonAddItem.TabIndex = 11;
            this.buttonAddItem.Text = "Add Item";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxRegGuest);
            this.Controls.Add(this.textBoxArrivalDate);
            this.Controls.Add(this.textBoxArrivalHour);
            this.Controls.Add(this.textBoxGuestNumber);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listBoxGuests);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGuests;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxGuestNumber;
        private System.Windows.Forms.TextBox textBoxArrivalHour;
        private System.Windows.Forms.TextBox textBoxArrivalDate;
        private System.Windows.Forms.CheckBox checkBoxRegGuest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddItem;
    }
}

