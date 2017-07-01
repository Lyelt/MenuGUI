namespace Menu
{
    partial class MenuGUI
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addIngredient_flowControl = new System.Windows.Forms.FlowLayoutPanel();
            this.newIngredient_textBox = new System.Windows.Forms.TextBox();
            this.addIng_button = new System.Windows.Forms.PictureBox();
            this.submitIngredients_button = new System.Windows.Forms.Button();
            this.chooseFile_button = new System.Windows.Forms.Button();
            this.addIngredient_button = new System.Windows.Forms.Button();
            this.addMenuItem_groupBox = new System.Windows.Forms.GroupBox();
            this.submitMenuItem_button = new System.Windows.Forms.Button();
            this.meals_listBox = new System.Windows.Forms.ListBox();
            this.types_listBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.ethnicity_comboBox = new System.Windows.Forms.ComboBox();
            this.ethnicity_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addMenuItem_button = new System.Windows.Forms.Button();
            this.ingredient_listBox = new System.Windows.Forms.ListBox();
            this.menuItem_listBox = new System.Windows.Forms.ListBox();
            this.saveFile_button = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.filter_comboBox = new System.Windows.Forms.ComboBox();
            this.sort_comboBox = new System.Windows.Forms.ComboBox();
            this.tabPage1.SuspendLayout();
            this.addIngredient_flowControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addIng_button)).BeginInit();
            this.addMenuItem_groupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "menu.txt";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.sort_comboBox);
            this.tabPage1.Controls.Add(this.filter_comboBox);
            this.tabPage1.Controls.Add(this.addIngredient_flowControl);
            this.tabPage1.Controls.Add(this.chooseFile_button);
            this.tabPage1.Controls.Add(this.addIngredient_button);
            this.tabPage1.Controls.Add(this.addMenuItem_groupBox);
            this.tabPage1.Controls.Add(this.addMenuItem_button);
            this.tabPage1.Controls.Add(this.ingredient_listBox);
            this.tabPage1.Controls.Add(this.menuItem_listBox);
            this.tabPage1.Controls.Add(this.saveFile_button);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(946, 561);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // addIngredient_flowControl
            // 
            this.addIngredient_flowControl.AutoScroll = true;
            this.addIngredient_flowControl.Controls.Add(this.newIngredient_textBox);
            this.addIngredient_flowControl.Controls.Add(this.addIng_button);
            this.addIngredient_flowControl.Controls.Add(this.submitIngredients_button);
            this.addIngredient_flowControl.Location = new System.Drawing.Point(490, 82);
            this.addIngredient_flowControl.Name = "addIngredient_flowControl";
            this.addIngredient_flowControl.Size = new System.Drawing.Size(187, 446);
            this.addIngredient_flowControl.TabIndex = 7;
            this.addIngredient_flowControl.Visible = false;
            // 
            // newIngredient_textBox
            // 
            this.newIngredient_textBox.Location = new System.Drawing.Point(3, 3);
            this.newIngredient_textBox.Name = "newIngredient_textBox";
            this.newIngredient_textBox.Size = new System.Drawing.Size(111, 20);
            this.newIngredient_textBox.TabIndex = 1;
            // 
            // addIng_button
            // 
            this.addIng_button.Image = global::WindowsFormsApplication1.Properties.Resources.plus_icon;
            this.addIng_button.Location = new System.Drawing.Point(120, 3);
            this.addIng_button.Name = "addIng_button";
            this.addIng_button.Size = new System.Drawing.Size(30, 22);
            this.addIng_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addIng_button.TabIndex = 2;
            this.addIng_button.TabStop = false;
            this.addIng_button.Click += new System.EventHandler(this.addIng_button_Click);
            // 
            // submitIngredients_button
            // 
            this.submitIngredients_button.Location = new System.Drawing.Point(3, 31);
            this.submitIngredients_button.Name = "submitIngredients_button";
            this.submitIngredients_button.Size = new System.Drawing.Size(75, 23);
            this.submitIngredients_button.TabIndex = 3;
            this.submitIngredients_button.Text = "Submit";
            this.submitIngredients_button.UseVisualStyleBackColor = true;
            this.submitIngredients_button.Click += new System.EventHandler(this.submitIngredients_button_Click);
            // 
            // chooseFile_button
            // 
            this.chooseFile_button.Location = new System.Drawing.Point(16, 9);
            this.chooseFile_button.Name = "chooseFile_button";
            this.chooseFile_button.Size = new System.Drawing.Size(75, 23);
            this.chooseFile_button.TabIndex = 4;
            this.chooseFile_button.Text = "Choose File";
            this.chooseFile_button.UseVisualStyleBackColor = true;
            this.chooseFile_button.Click += new System.EventHandler(this.chooseFile_button_Click);
            // 
            // addIngredient_button
            // 
            this.addIngredient_button.Location = new System.Drawing.Point(683, 534);
            this.addIngredient_button.Name = "addIngredient_button";
            this.addIngredient_button.Size = new System.Drawing.Size(156, 23);
            this.addIngredient_button.TabIndex = 3;
            this.addIngredient_button.Text = "Add Ingredient";
            this.addIngredient_button.UseVisualStyleBackColor = true;
            this.addIngredient_button.Click += new System.EventHandler(this.addIngredient_button_Click);
            // 
            // addMenuItem_groupBox
            // 
            this.addMenuItem_groupBox.Controls.Add(this.submitMenuItem_button);
            this.addMenuItem_groupBox.Controls.Add(this.meals_listBox);
            this.addMenuItem_groupBox.Controls.Add(this.types_listBox);
            this.addMenuItem_groupBox.Controls.Add(this.label4);
            this.addMenuItem_groupBox.Controls.Add(this.name_textBox);
            this.addMenuItem_groupBox.Controls.Add(this.ethnicity_comboBox);
            this.addMenuItem_groupBox.Controls.Add(this.ethnicity_label);
            this.addMenuItem_groupBox.Controls.Add(this.label2);
            this.addMenuItem_groupBox.Controls.Add(this.label1);
            this.addMenuItem_groupBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMenuItem_groupBox.Location = new System.Drawing.Point(259, 82);
            this.addMenuItem_groupBox.Name = "addMenuItem_groupBox";
            this.addMenuItem_groupBox.Size = new System.Drawing.Size(225, 446);
            this.addMenuItem_groupBox.TabIndex = 4;
            this.addMenuItem_groupBox.TabStop = false;
            this.addMenuItem_groupBox.Text = "Add A New Menu Item";
            this.addMenuItem_groupBox.Visible = false;
            // 
            // submitMenuItem_button
            // 
            this.submitMenuItem_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitMenuItem_button.Location = new System.Drawing.Point(142, 385);
            this.submitMenuItem_button.Name = "submitMenuItem_button";
            this.submitMenuItem_button.Size = new System.Drawing.Size(75, 28);
            this.submitMenuItem_button.TabIndex = 10;
            this.submitMenuItem_button.Text = "Submit";
            this.submitMenuItem_button.UseVisualStyleBackColor = true;
            this.submitMenuItem_button.Click += new System.EventHandler(this.submitMenuItem_button_Click);
            // 
            // meals_listBox
            // 
            this.meals_listBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meals_listBox.FormattingEnabled = true;
            this.meals_listBox.ItemHeight = 15;
            this.meals_listBox.Location = new System.Drawing.Point(97, 245);
            this.meals_listBox.Name = "meals_listBox";
            this.meals_listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.meals_listBox.Size = new System.Drawing.Size(120, 124);
            this.meals_listBox.TabIndex = 9;
            // 
            // types_listBox
            // 
            this.types_listBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.types_listBox.FormattingEnabled = true;
            this.types_listBox.ItemHeight = 15;
            this.types_listBox.Location = new System.Drawing.Point(97, 118);
            this.types_listBox.Name = "types_listBox";
            this.types_listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.types_listBox.Size = new System.Drawing.Size(121, 109);
            this.types_listBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textBox.Location = new System.Drawing.Point(97, 35);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(121, 23);
            this.name_textBox.TabIndex = 6;
            // 
            // ethnicity_comboBox
            // 
            this.ethnicity_comboBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ethnicity_comboBox.FormattingEnabled = true;
            this.ethnicity_comboBox.Location = new System.Drawing.Point(97, 77);
            this.ethnicity_comboBox.Name = "ethnicity_comboBox";
            this.ethnicity_comboBox.Size = new System.Drawing.Size(121, 23);
            this.ethnicity_comboBox.TabIndex = 5;
            // 
            // ethnicity_label
            // 
            this.ethnicity_label.AutoSize = true;
            this.ethnicity_label.Location = new System.Drawing.Point(5, 77);
            this.ethnicity_label.Name = "ethnicity_label";
            this.ethnicity_label.Size = new System.Drawing.Size(70, 19);
            this.ethnicity_label.TabIndex = 4;
            this.ethnicity_label.Text = "Ethnicity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Meal(s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type(s)";
            // 
            // addMenuItem_button
            // 
            this.addMenuItem_button.Location = new System.Drawing.Point(7, 534);
            this.addMenuItem_button.Name = "addMenuItem_button";
            this.addMenuItem_button.Size = new System.Drawing.Size(114, 23);
            this.addMenuItem_button.TabIndex = 6;
            this.addMenuItem_button.Text = "Add Menu Item";
            this.addMenuItem_button.UseVisualStyleBackColor = true;
            this.addMenuItem_button.Click += new System.EventHandler(this.addMenuItem_button_Click);
            // 
            // ingredient_listBox
            // 
            this.ingredient_listBox.FormattingEnabled = true;
            this.ingredient_listBox.Location = new System.Drawing.Point(683, 82);
            this.ingredient_listBox.Name = "ingredient_listBox";
            this.ingredient_listBox.Size = new System.Drawing.Size(247, 446);
            this.ingredient_listBox.TabIndex = 1;
            // 
            // menuItem_listBox
            // 
            this.menuItem_listBox.FormattingEnabled = true;
            this.menuItem_listBox.Location = new System.Drawing.Point(6, 82);
            this.menuItem_listBox.Name = "menuItem_listBox";
            this.menuItem_listBox.Size = new System.Drawing.Size(247, 446);
            this.menuItem_listBox.Sorted = true;
            this.menuItem_listBox.TabIndex = 0;
            this.menuItem_listBox.SelectedIndexChanged += new System.EventHandler(this.menuItem_listBox_SelectedIndexChanged);
            // 
            // saveFile_button
            // 
            this.saveFile_button.Location = new System.Drawing.Point(97, 9);
            this.saveFile_button.Name = "saveFile_button";
            this.saveFile_button.Size = new System.Drawing.Size(75, 23);
            this.saveFile_button.TabIndex = 5;
            this.saveFile_button.Text = "Save File";
            this.saveFile_button.UseVisualStyleBackColor = true;
            this.saveFile_button.Click += new System.EventHandler(this.saveFile_button_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(954, 587);
            this.tabControl1.TabIndex = 7;
            // 
            // filter_comboBox
            // 
            this.filter_comboBox.FormattingEnabled = true;
            this.filter_comboBox.Location = new System.Drawing.Point(7, 55);
            this.filter_comboBox.Name = "filter_comboBox";
            this.filter_comboBox.Size = new System.Drawing.Size(121, 21);
            this.filter_comboBox.TabIndex = 8;
            // 
            // sort_comboBox
            // 
            this.sort_comboBox.FormattingEnabled = true;
            this.sort_comboBox.Location = new System.Drawing.Point(134, 55);
            this.sort_comboBox.Name = "sort_comboBox";
            this.sort_comboBox.Size = new System.Drawing.Size(119, 21);
            this.sort_comboBox.TabIndex = 10;
            // 
            // MenuGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1058, 639);
            this.Controls.Add(this.tabControl1);
            this.Name = "MenuGUI";
            this.Text = "Menu";
            this.tabPage1.ResumeLayout(false);
            this.addIngredient_flowControl.ResumeLayout(false);
            this.addIngredient_flowControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addIng_button)).EndInit();
            this.addMenuItem_groupBox.ResumeLayout(false);
            this.addMenuItem_groupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button chooseFile_button;
        private System.Windows.Forms.Button addIngredient_button;
        private System.Windows.Forms.Button addMenuItem_button;
        private System.Windows.Forms.ListBox ingredient_listBox;
        private System.Windows.Forms.ListBox menuItem_listBox;
        private System.Windows.Forms.Button saveFile_button;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.FlowLayoutPanel addIngredient_flowControl;
        private System.Windows.Forms.TextBox newIngredient_textBox;
        private System.Windows.Forms.PictureBox addIng_button;
        private System.Windows.Forms.Button submitIngredients_button;
        private System.Windows.Forms.GroupBox addMenuItem_groupBox;
        private System.Windows.Forms.ComboBox ethnicity_comboBox;
        private System.Windows.Forms.Label ethnicity_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox meals_listBox;
        private System.Windows.Forms.ListBox types_listBox;
        private System.Windows.Forms.Button submitMenuItem_button;
        private System.Windows.Forms.ComboBox filter_comboBox;
        private System.Windows.Forms.ComboBox sort_comboBox;
    }
}

