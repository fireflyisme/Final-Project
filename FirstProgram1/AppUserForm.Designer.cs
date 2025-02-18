namespace FirstProgram1
{
    partial class AppUserForm
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
            textBoxName = new MaterialSkin.Controls.MaterialTextBox2();
            textBoxUserName = new MaterialSkin.Controls.MaterialTextBox2();
            comboBoxProgram = new MaterialSkin.Controls.MaterialComboBox();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.AnimateReadOnly = false;
            textBoxName.BackgroundImageLayout = ImageLayout.None;
            textBoxName.CharacterCasing = CharacterCasing.Normal;
            textBoxName.Depth = 0;
            textBoxName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxName.HideSelection = true;
            textBoxName.Hint = "Enter name";
            textBoxName.LeadingIcon = null;
            textBoxName.Location = new Point(24, 86);
            textBoxName.MaxLength = 32767;
            textBoxName.MouseState = MaterialSkin.MouseState.OUT;
            textBoxName.Name = "textBoxName";
            textBoxName.PasswordChar = '\0';
            textBoxName.PrefixSuffixText = null;
            textBoxName.ReadOnly = false;
            textBoxName.RightToLeft = RightToLeft.No;
            textBoxName.SelectedText = "";
            textBoxName.SelectionLength = 0;
            textBoxName.SelectionStart = 0;
            textBoxName.ShortcutsEnabled = true;
            textBoxName.Size = new Size(312, 48);
            textBoxName.TabIndex = 0;
            textBoxName.TabStop = false;
            textBoxName.TextAlign = HorizontalAlignment.Left;
            textBoxName.TrailingIcon = null;
            textBoxName.UseSystemPasswordChar = false;
            // 
            // textBoxUserName
            // 
            textBoxUserName.AnimateReadOnly = false;
            textBoxUserName.BackgroundImageLayout = ImageLayout.None;
            textBoxUserName.CharacterCasing = CharacterCasing.Normal;
            textBoxUserName.Depth = 0;
            textBoxUserName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxUserName.HideSelection = true;
            textBoxUserName.Hint = "Enter username";
            textBoxUserName.LeadingIcon = null;
            textBoxUserName.Location = new Point(24, 173);
            textBoxUserName.MaxLength = 32767;
            textBoxUserName.MouseState = MaterialSkin.MouseState.OUT;
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.PasswordChar = '\0';
            textBoxUserName.PrefixSuffixText = null;
            textBoxUserName.ReadOnly = false;
            textBoxUserName.RightToLeft = RightToLeft.No;
            textBoxUserName.SelectedText = "";
            textBoxUserName.SelectionLength = 0;
            textBoxUserName.SelectionStart = 0;
            textBoxUserName.ShortcutsEnabled = true;
            textBoxUserName.Size = new Size(312, 48);
            textBoxUserName.TabIndex = 1;
            textBoxUserName.TabStop = false;
            textBoxUserName.TextAlign = HorizontalAlignment.Left;
            textBoxUserName.TrailingIcon = null;
            textBoxUserName.UseSystemPasswordChar = false;
            // 
            // comboBoxProgram
            // 
            comboBoxProgram.AutoResize = false;
            comboBoxProgram.BackColor = Color.FromArgb(255, 255, 255);
            comboBoxProgram.Depth = 0;
            comboBoxProgram.DrawMode = DrawMode.OwnerDrawVariable;
            comboBoxProgram.DropDownHeight = 174;
            comboBoxProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProgram.DropDownWidth = 121;
            comboBoxProgram.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboBoxProgram.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboBoxProgram.FormattingEnabled = true;
            comboBoxProgram.Hint = "Select Program";
            comboBoxProgram.IntegralHeight = false;
            comboBoxProgram.ItemHeight = 43;
            comboBoxProgram.Location = new Point(24, 260);
            comboBoxProgram.MaxDropDownItems = 4;
            comboBoxProgram.MouseState = MaterialSkin.MouseState.OUT;
            comboBoxProgram.Name = "comboBoxProgram";
            comboBoxProgram.Size = new Size(312, 49);
            comboBoxProgram.StartIndex = 0;
            comboBoxProgram.TabIndex = 2;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(128, 350);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(97, 36);
            materialButton1.TabIndex = 3;
            materialButton1.Text = "SAVE USER";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(374, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(747, 306);
            dataGridView1.TabIndex = 4;
            // 
            // AppUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 545);
            Controls.Add(dataGridView1);
            Controls.Add(materialButton1);
            Controls.Add(comboBoxProgram);
            Controls.Add(textBoxUserName);
            Controls.Add(textBoxName);
            Name = "AppUserForm";
            Text = "AppUserForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 textBoxName;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxUserName;
        private MaterialSkin.Controls.MaterialComboBox comboBoxProgram;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dataGridView1;
    }
}