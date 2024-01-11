namespace Econtact
{
    partial class Econtact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Econtact));
            myCharlotte = new PictureBox();
            label1 = new Label();
            nameBox = new TextBox();
            nameLabel = new Label();
            contactLabel = new Label();
            contactBox = new TextBox();
            emailLabel = new Label();
            emailBox = new TextBox();
            genderComboBox = new ComboBox();
            labelGender = new Label();
            submitButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            clearButton = new Button();
            idLabel = new Label();
            idBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)myCharlotte).BeginInit();
            SuspendLayout();
            // 
            // myCharlotte
            // 
            myCharlotte.Image = (Image)resources.GetObject("myCharlotte.Image");
            myCharlotte.Location = new Point(45, 33);
            myCharlotte.Name = "myCharlotte";
            myCharlotte.Size = new Size(315, 326);
            myCharlotte.SizeMode = PictureBoxSizeMode.StretchImage;
            myCharlotte.TabIndex = 0;
            myCharlotte.TabStop = false;
            myCharlotte.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(416, 33);
            label1.Name = "label1";
            label1.Size = new Size(578, 31);
            label1.TabIndex = 1;
            label1.Text = "Hello my name is Charlotte, please take care of me";
            label1.Click += label1_Click;
            // 
            // nameBox
            // 
            nameBox.CausesValidation = false;
            nameBox.Location = new Point(492, 132);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(304, 27);
            nameBox.TabIndex = 2;
            nameBox.TextChanged += textBox1_TextChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(416, 135);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(72, 20);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Fullname:";
            nameLabel.Click += label2_Click;
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Location = new Point(425, 180);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new Size(63, 20);
            contactLabel.TabIndex = 5;
            contactLabel.Text = "Contact:";
            // 
            // contactBox
            // 
            contactBox.CausesValidation = false;
            contactBox.Location = new Point(492, 177);
            contactBox.Name = "contactBox";
            contactBox.Size = new Size(304, 27);
            contactBox.TabIndex = 4;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(437, 228);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(49, 20);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email:";
            // 
            // emailBox
            // 
            emailBox.CausesValidation = false;
            emailBox.Location = new Point(492, 225);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(304, 27);
            emailBox.TabIndex = 6;
            // 
            // genderComboBox
            // 
            genderComboBox.CausesValidation = false;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "Male", "Female", "Crossiant" });
            genderComboBox.Location = new Point(492, 268);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(151, 28);
            genderComboBox.TabIndex = 8;
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Location = new Point(426, 271);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(60, 20);
            labelGender.TabIndex = 9;
            labelGender.Text = "Gender:";
            labelGender.Click += label2_Click_1;
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.DarkOliveGreen;
            submitButton.ForeColor = SystemColors.Control;
            submitButton.Location = new Point(492, 312);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(94, 29);
            submitButton.TabIndex = 10;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = false;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.DarkSlateBlue;
            updateButton.ForeColor = SystemColors.Control;
            updateButton.Location = new Point(592, 312);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(94, 29);
            updateButton.TabIndex = 11;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Maroon;
            deleteButton.ForeColor = SystemColors.Control;
            deleteButton.Location = new Point(692, 312);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 12;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(792, 312);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 29);
            clearButton.TabIndex = 13;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(461, 91);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(25, 20);
            idLabel.TabIndex = 15;
            idLabel.Text = "Id:";
            // 
            // idBox
            // 
            idBox.CausesValidation = false;
            idBox.Location = new Point(492, 88);
            idBox.Name = "idBox";
            idBox.Size = new Size(94, 27);
            idBox.TabIndex = 14;
            // 
            // Econtact
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 450);
            Controls.Add(idLabel);
            Controls.Add(idBox);
            Controls.Add(clearButton);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(submitButton);
            Controls.Add(labelGender);
            Controls.Add(genderComboBox);
            Controls.Add(emailLabel);
            Controls.Add(emailBox);
            Controls.Add(contactLabel);
            Controls.Add(contactBox);
            Controls.Add(nameLabel);
            Controls.Add(nameBox);
            Controls.Add(label1);
            Controls.Add(myCharlotte);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Econtact";
            Text = "Econtact";
            Load += Econtact_Load;
            ((System.ComponentModel.ISupportInitialize)myCharlotte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox myCharlotte;
        private Label label1;
        private TextBox nameBox;
        private Label nameLabel;
        private Label contactLabel;
        private TextBox contactBox;
        private Label emailLabel;
        private TextBox emailBox;
        private ComboBox genderComboBox;
        private Label labelGender;
        private Button submitButton;
        private Button updateButton;
        private Button deleteButton;
        private Button clearButton;
        private Label idLabel;
        private TextBox idBox;
    }
}
