namespace PersonWindows
{
    partial class PersonEditForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label personDateBirthLabel;
            System.Windows.Forms.Label personFirstNameLabel;
            System.Windows.Forms.Label personSecondNameLabel;
            System.Windows.Forms.Label professionIDLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.personDateBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.personFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.personSecondNameTextBox = new System.Windows.Forms.TextBox();
            this.personInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professionIDComboBox = new System.Windows.Forms.ComboBox();
            this.professionlistbildingSource = new System.Windows.Forms.BindingSource(this.components);
            personDateBirthLabel = new System.Windows.Forms.Label();
            personFirstNameLabel = new System.Windows.Forms.Label();
            personSecondNameLabel = new System.Windows.Forms.Label();
            professionIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionlistbildingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(124, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(349, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // personDateBirthLabel
            // 
            personDateBirthLabel.AutoSize = true;
            personDateBirthLabel.Location = new System.Drawing.Point(61, 53);
            personDateBirthLabel.Name = "personDateBirthLabel";
            personDateBirthLabel.Size = new System.Drawing.Size(93, 13);
            personDateBirthLabel.TabIndex = 8;
            personDateBirthLabel.Text = "Person Date Birth:";
            // 
            // personDateBirthDateTimePicker
            // 
            this.personDateBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personInfoBindingSource, "PersonDateBirth", true));
            this.personDateBirthDateTimePicker.Location = new System.Drawing.Point(160, 49);
            this.personDateBirthDateTimePicker.Name = "personDateBirthDateTimePicker";
            this.personDateBirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.personDateBirthDateTimePicker.TabIndex = 9;
            // 
            // personFirstNameLabel
            // 
            personFirstNameLabel.AutoSize = true;
            personFirstNameLabel.Location = new System.Drawing.Point(58, 78);
            personFirstNameLabel.Name = "personFirstNameLabel";
            personFirstNameLabel.Size = new System.Drawing.Size(96, 13);
            personFirstNameLabel.TabIndex = 9;
            personFirstNameLabel.Text = "Person First Name:";
            // 
            // personFirstNameTextBox
            // 
            this.personFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personInfoBindingSource, "PersonFirstName", true));
            this.personFirstNameTextBox.Location = new System.Drawing.Point(160, 75);
            this.personFirstNameTextBox.Name = "personFirstNameTextBox";
            this.personFirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.personFirstNameTextBox.TabIndex = 10;
            // 
            // personSecondNameLabel
            // 
            personSecondNameLabel.AutoSize = true;
            personSecondNameLabel.Location = new System.Drawing.Point(40, 114);
            personSecondNameLabel.Name = "personSecondNameLabel";
            personSecondNameLabel.Size = new System.Drawing.Size(114, 13);
            personSecondNameLabel.TabIndex = 10;
            personSecondNameLabel.Text = "Person Second Name:";
            // 
            // personSecondNameTextBox
            // 
            this.personSecondNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personInfoBindingSource, "PersonSecondName", true));
            this.personSecondNameTextBox.Location = new System.Drawing.Point(160, 111);
            this.personSecondNameTextBox.Name = "personSecondNameTextBox";
            this.personSecondNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.personSecondNameTextBox.TabIndex = 11;
            // 
            // personInfoBindingSource
            // 
            this.personInfoBindingSource.DataSource = typeof(PersonLibrary.PersonInfo);
            // 
            // professionIDLabel
            // 
            professionIDLabel.AutoSize = true;
            professionIDLabel.Location = new System.Drawing.Point(81, 154);
            professionIDLabel.Name = "professionIDLabel";
            professionIDLabel.Size = new System.Drawing.Size(73, 13);
            professionIDLabel.TabIndex = 11;
            professionIDLabel.Text = "Profession ID:";
            // 
            // professionIDComboBox
            // 
            this.professionIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.personInfoBindingSource, "ProfessionID", true));
            this.professionIDComboBox.DataSource = this.professionlistbildingSource;
            this.professionIDComboBox.DisplayMember = "ProfessionName";
            this.professionIDComboBox.FormattingEnabled = true;
            this.professionIDComboBox.Location = new System.Drawing.Point(160, 151);
            this.professionIDComboBox.Name = "professionIDComboBox";
            this.professionIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.professionIDComboBox.TabIndex = 12;
            this.professionIDComboBox.ValueMember = "ProfessionID";
            // 
            // professionlistbildingSource
            // 
            this.professionlistbildingSource.DataSource = typeof(PersonLibrary.PersonList);
            // 
            // PersonEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(professionIDLabel);
            this.Controls.Add(this.professionIDComboBox);
            this.Controls.Add(personSecondNameLabel);
            this.Controls.Add(this.personSecondNameTextBox);
            this.Controls.Add(personFirstNameLabel);
            this.Controls.Add(this.personFirstNameTextBox);
            this.Controls.Add(personDateBirthLabel);
            this.Controls.Add(this.personDateBirthDateTimePicker);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "PersonEditForm";
            this.Text = "Карточка сотрудника";
            this.Load += new System.EventHandler(this.PersonEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionlistbildingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource personInfoBindingSource;
        private System.Windows.Forms.DateTimePicker personDateBirthDateTimePicker;
        private System.Windows.Forms.TextBox personFirstNameTextBox;
        private System.Windows.Forms.TextBox personSecondNameTextBox;
        private System.Windows.Forms.ComboBox professionIDComboBox;
        private System.Windows.Forms.BindingSource professionlistbildingSource;
    }
}