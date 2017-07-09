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
            this.menuItem_panel = new System.Windows.Forms.Panel();
            this.menuItem_listBox = new System.Windows.Forms.ListBox();
            this.addMenuItem_button = new System.Windows.Forms.Button();
            this.filter_comboBox = new System.Windows.Forms.ComboBox();
            this.sort_comboBox = new System.Windows.Forms.ComboBox();
            this.ingredients_panel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.ingredient_listBox = new System.Windows.Forms.ListBox();
            this.removeIngredient_button = new System.Windows.Forms.Button();
            this.addIngredient_button = new System.Windows.Forms.Button();
            this.editItem_groupBox = new System.Windows.Forms.GroupBox();
            this.addType_comboxBox = new System.Windows.Forms.ComboBox();
            this.addMeal_comboBox = new System.Windows.Forms.ComboBox();
            this.saveChanges_button = new System.Windows.Forms.Button();
            this.cancelEdit_button = new System.Windows.Forms.Button();
            this.addType_pictureBox = new System.Windows.Forms.PictureBox();
            this.removeType_pictureBox = new System.Windows.Forms.PictureBox();
            this.removeMeal_pictureBox = new System.Windows.Forms.PictureBox();
            this.addMeal_pictureBox = new System.Windows.Forms.PictureBox();
            this.editTypes_listBox = new System.Windows.Forms.ListBox();
            this.editMeals_listBox = new System.Windows.Forms.ListBox();
            this.editEth_comboBox = new System.Windows.Forms.ComboBox();
            this.editName_textBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.chooseFile_button = new System.Windows.Forms.Button();
            this.saveFile_button = new System.Windows.Forms.Button();
            this.addIngredient_groupBox = new System.Windows.Forms.GroupBox();
            this.addIngredient_flowControl = new System.Windows.Forms.FlowLayoutPanel();
            this.newIngredient_textBox = new System.Windows.Forms.TextBox();
            this.addIng_button = new System.Windows.Forms.PictureBox();
            this.submitIngredients_button = new System.Windows.Forms.Button();
            this.addMenuItem_groupBox = new System.Windows.Forms.GroupBox();
            this.types_listBox = new System.Windows.Forms.ListBox();
            this.meals_listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submitMenuItem_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.ethnicity_comboBox = new System.Windows.Forms.ComboBox();
            this.ethnicity_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedItem_groupBox = new System.Windows.Forms.GroupBox();
            this.selectedTypes_listBox = new System.Windows.Forms.ListBox();
            this.selectedMeals_listBox = new System.Windows.Forms.ListBox();
            this.ethLabel = new System.Windows.Forms.Label();
            this.removeItem_button = new System.Windows.Forms.Button();
            this.editItem_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1.SuspendLayout();
            this.menuItem_panel.SuspendLayout();
            this.ingredients_panel.SuspendLayout();
            this.editItem_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addType_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeType_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeMeal_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMeal_pictureBox)).BeginInit();
            this.addIngredient_groupBox.SuspendLayout();
            this.addIngredient_flowControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addIng_button)).BeginInit();
            this.addMenuItem_groupBox.SuspendLayout();
            this.selectedItem_groupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xml";
            this.saveFileDialog1.FileName = "menu.xml";
            this.saveFileDialog1.Filter = "\"Text files (*.txt)| Xml files (*.xml)\"";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.menuItem_panel);
            this.tabPage1.Controls.Add(this.ingredients_panel);
            this.tabPage1.Controls.Add(this.editItem_groupBox);
            this.tabPage1.Controls.Add(this.chooseFile_button);
            this.tabPage1.Controls.Add(this.saveFile_button);
            this.tabPage1.Controls.Add(this.addIngredient_groupBox);
            this.tabPage1.Controls.Add(this.addMenuItem_groupBox);
            this.tabPage1.Controls.Add(this.selectedItem_groupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(946, 561);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // menuItem_panel
            // 
            this.menuItem_panel.Controls.Add(this.menuItem_listBox);
            this.menuItem_panel.Controls.Add(this.addMenuItem_button);
            this.menuItem_panel.Controls.Add(this.filter_comboBox);
            this.menuItem_panel.Controls.Add(this.sort_comboBox);
            this.menuItem_panel.Location = new System.Drawing.Point(4, 38);
            this.menuItem_panel.Name = "menuItem_panel";
            this.menuItem_panel.Size = new System.Drawing.Size(257, 527);
            this.menuItem_panel.TabIndex = 17;
            this.menuItem_panel.Visible = false;
            // 
            // menuItem_listBox
            // 
            this.menuItem_listBox.FormattingEnabled = true;
            this.menuItem_listBox.Location = new System.Drawing.Point(3, 44);
            this.menuItem_listBox.Name = "menuItem_listBox";
            this.menuItem_listBox.Size = new System.Drawing.Size(247, 446);
            this.menuItem_listBox.Sorted = true;
            this.menuItem_listBox.TabIndex = 0;
            this.menuItem_listBox.SelectedIndexChanged += new System.EventHandler(this.menuItem_listBox_SelectedIndexChanged);
            // 
            // addMenuItem_button
            // 
            this.addMenuItem_button.Location = new System.Drawing.Point(4, 496);
            this.addMenuItem_button.Name = "addMenuItem_button";
            this.addMenuItem_button.Size = new System.Drawing.Size(114, 23);
            this.addMenuItem_button.TabIndex = 6;
            this.addMenuItem_button.Text = "Add Menu Item";
            this.addMenuItem_button.UseVisualStyleBackColor = true;
            this.addMenuItem_button.Click += new System.EventHandler(this.addMenuItem_button_Click);
            // 
            // filter_comboBox
            // 
            this.filter_comboBox.FormattingEnabled = true;
            this.filter_comboBox.Location = new System.Drawing.Point(4, 17);
            this.filter_comboBox.Name = "filter_comboBox";
            this.filter_comboBox.Size = new System.Drawing.Size(121, 21);
            this.filter_comboBox.TabIndex = 8;
            // 
            // sort_comboBox
            // 
            this.sort_comboBox.FormattingEnabled = true;
            this.sort_comboBox.Location = new System.Drawing.Point(131, 17);
            this.sort_comboBox.Name = "sort_comboBox";
            this.sort_comboBox.Size = new System.Drawing.Size(119, 21);
            this.sort_comboBox.TabIndex = 10;
            // 
            // ingredients_panel
            // 
            this.ingredients_panel.Controls.Add(this.label7);
            this.ingredients_panel.Controls.Add(this.ingredient_listBox);
            this.ingredients_panel.Controls.Add(this.removeIngredient_button);
            this.ingredients_panel.Controls.Add(this.addIngredient_button);
            this.ingredients_panel.Location = new System.Drawing.Point(683, 55);
            this.ingredients_panel.Name = "ingredients_panel";
            this.ingredients_panel.Size = new System.Drawing.Size(257, 499);
            this.ingredients_panel.TabIndex = 16;
            this.ingredients_panel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ingredients";
            // 
            // ingredient_listBox
            // 
            this.ingredient_listBox.FormattingEnabled = true;
            this.ingredient_listBox.Location = new System.Drawing.Point(7, 22);
            this.ingredient_listBox.Name = "ingredient_listBox";
            this.ingredient_listBox.Size = new System.Drawing.Size(247, 446);
            this.ingredient_listBox.TabIndex = 1;
            // 
            // removeIngredient_button
            // 
            this.removeIngredient_button.Location = new System.Drawing.Point(115, 474);
            this.removeIngredient_button.Name = "removeIngredient_button";
            this.removeIngredient_button.Size = new System.Drawing.Size(109, 23);
            this.removeIngredient_button.TabIndex = 15;
            this.removeIngredient_button.Text = "Remove Ingredient";
            this.removeIngredient_button.UseVisualStyleBackColor = true;
            this.removeIngredient_button.Click += new System.EventHandler(this.removeIngredient_button_Click);
            // 
            // addIngredient_button
            // 
            this.addIngredient_button.Location = new System.Drawing.Point(0, 474);
            this.addIngredient_button.Name = "addIngredient_button";
            this.addIngredient_button.Size = new System.Drawing.Size(109, 23);
            this.addIngredient_button.TabIndex = 3;
            this.addIngredient_button.Text = "Add Ingredient";
            this.addIngredient_button.UseVisualStyleBackColor = true;
            this.addIngredient_button.Click += new System.EventHandler(this.addIngredient_button_Click);
            // 
            // editItem_groupBox
            // 
            this.editItem_groupBox.Controls.Add(this.addType_comboxBox);
            this.editItem_groupBox.Controls.Add(this.addMeal_comboBox);
            this.editItem_groupBox.Controls.Add(this.saveChanges_button);
            this.editItem_groupBox.Controls.Add(this.cancelEdit_button);
            this.editItem_groupBox.Controls.Add(this.addType_pictureBox);
            this.editItem_groupBox.Controls.Add(this.removeType_pictureBox);
            this.editItem_groupBox.Controls.Add(this.removeMeal_pictureBox);
            this.editItem_groupBox.Controls.Add(this.addMeal_pictureBox);
            this.editItem_groupBox.Controls.Add(this.editTypes_listBox);
            this.editItem_groupBox.Controls.Add(this.editMeals_listBox);
            this.editItem_groupBox.Controls.Add(this.editEth_comboBox);
            this.editItem_groupBox.Controls.Add(this.editName_textBox);
            this.editItem_groupBox.Controls.Add(this.label19);
            this.editItem_groupBox.Controls.Add(this.label18);
            this.editItem_groupBox.Controls.Add(this.label17);
            this.editItem_groupBox.Controls.Add(this.label16);
            this.editItem_groupBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editItem_groupBox.Location = new System.Drawing.Point(259, 79);
            this.editItem_groupBox.Name = "editItem_groupBox";
            this.editItem_groupBox.Size = new System.Drawing.Size(418, 446);
            this.editItem_groupBox.TabIndex = 14;
            this.editItem_groupBox.TabStop = false;
            this.editItem_groupBox.Text = "Edit Item";
            this.editItem_groupBox.Visible = false;
            // 
            // addType_comboxBox
            // 
            this.addType_comboxBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addType_comboxBox.FormattingEnabled = true;
            this.addType_comboxBox.Location = new System.Drawing.Point(259, 233);
            this.addType_comboxBox.Name = "addType_comboxBox";
            this.addType_comboxBox.Size = new System.Drawing.Size(118, 23);
            this.addType_comboxBox.TabIndex = 16;
            this.addType_comboxBox.Visible = false;
            // 
            // addMeal_comboBox
            // 
            this.addMeal_comboBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMeal_comboBox.FormattingEnabled = true;
            this.addMeal_comboBox.Location = new System.Drawing.Point(259, 107);
            this.addMeal_comboBox.Name = "addMeal_comboBox";
            this.addMeal_comboBox.Size = new System.Drawing.Size(118, 23);
            this.addMeal_comboBox.TabIndex = 15;
            this.addMeal_comboBox.Visible = false;
            // 
            // saveChanges_button
            // 
            this.saveChanges_button.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChanges_button.Location = new System.Drawing.Point(316, 394);
            this.saveChanges_button.Name = "saveChanges_button";
            this.saveChanges_button.Size = new System.Drawing.Size(96, 23);
            this.saveChanges_button.TabIndex = 14;
            this.saveChanges_button.Text = "Save Changes";
            this.saveChanges_button.UseVisualStyleBackColor = true;
            this.saveChanges_button.Click += new System.EventHandler(this.saveChanges_button_Click);
            // 
            // cancelEdit_button
            // 
            this.cancelEdit_button.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelEdit_button.Location = new System.Drawing.Point(316, 418);
            this.cancelEdit_button.Name = "cancelEdit_button";
            this.cancelEdit_button.Size = new System.Drawing.Size(96, 23);
            this.cancelEdit_button.TabIndex = 13;
            this.cancelEdit_button.Text = "Cancel";
            this.cancelEdit_button.UseVisualStyleBackColor = true;
            this.cancelEdit_button.Click += new System.EventHandler(this.cancelEdit_button_Click);
            // 
            // addType_pictureBox
            // 
            this.addType_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addType_pictureBox.Image = global::WindowsFormsApplication1.Properties.Resources.plus_5_512;
            this.addType_pictureBox.Location = new System.Drawing.Point(222, 233);
            this.addType_pictureBox.Name = "addType_pictureBox";
            this.addType_pictureBox.Size = new System.Drawing.Size(30, 27);
            this.addType_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addType_pictureBox.TabIndex = 12;
            this.addType_pictureBox.TabStop = false;
            this.addType_pictureBox.Click += new System.EventHandler(this.addType_pictureBox_Click);
            // 
            // removeType_pictureBox
            // 
            this.removeType_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeType_pictureBox.Image = global::WindowsFormsApplication1.Properties.Resources.minus;
            this.removeType_pictureBox.Location = new System.Drawing.Point(223, 266);
            this.removeType_pictureBox.Name = "removeType_pictureBox";
            this.removeType_pictureBox.Size = new System.Drawing.Size(30, 27);
            this.removeType_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.removeType_pictureBox.TabIndex = 11;
            this.removeType_pictureBox.TabStop = false;
            this.removeType_pictureBox.Click += new System.EventHandler(this.removeType_pictureBox_Click);
            // 
            // removeMeal_pictureBox
            // 
            this.removeMeal_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeMeal_pictureBox.Image = global::WindowsFormsApplication1.Properties.Resources.minus;
            this.removeMeal_pictureBox.Location = new System.Drawing.Point(222, 140);
            this.removeMeal_pictureBox.Name = "removeMeal_pictureBox";
            this.removeMeal_pictureBox.Size = new System.Drawing.Size(30, 27);
            this.removeMeal_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.removeMeal_pictureBox.TabIndex = 10;
            this.removeMeal_pictureBox.TabStop = false;
            this.removeMeal_pictureBox.Click += new System.EventHandler(this.removeMeal_pictureBox_Click);
            // 
            // addMeal_pictureBox
            // 
            this.addMeal_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMeal_pictureBox.Image = global::WindowsFormsApplication1.Properties.Resources.plus_5_512;
            this.addMeal_pictureBox.Location = new System.Drawing.Point(222, 107);
            this.addMeal_pictureBox.Name = "addMeal_pictureBox";
            this.addMeal_pictureBox.Size = new System.Drawing.Size(30, 27);
            this.addMeal_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addMeal_pictureBox.TabIndex = 8;
            this.addMeal_pictureBox.TabStop = false;
            this.addMeal_pictureBox.Click += new System.EventHandler(this.addMeal_pictureBox_Click);
            // 
            // editTypes_listBox
            // 
            this.editTypes_listBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTypes_listBox.FormattingEnabled = true;
            this.editTypes_listBox.ItemHeight = 15;
            this.editTypes_listBox.Location = new System.Drawing.Point(97, 233);
            this.editTypes_listBox.Name = "editTypes_listBox";
            this.editTypes_listBox.Size = new System.Drawing.Size(120, 184);
            this.editTypes_listBox.TabIndex = 7;
            // 
            // editMeals_listBox
            // 
            this.editMeals_listBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMeals_listBox.FormattingEnabled = true;
            this.editMeals_listBox.ItemHeight = 15;
            this.editMeals_listBox.Location = new System.Drawing.Point(97, 107);
            this.editMeals_listBox.Name = "editMeals_listBox";
            this.editMeals_listBox.Size = new System.Drawing.Size(120, 109);
            this.editMeals_listBox.TabIndex = 6;
            // 
            // editEth_comboBox
            // 
            this.editEth_comboBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editEth_comboBox.FormattingEnabled = true;
            this.editEth_comboBox.Location = new System.Drawing.Point(96, 71);
            this.editEth_comboBox.Name = "editEth_comboBox";
            this.editEth_comboBox.Size = new System.Drawing.Size(121, 23);
            this.editEth_comboBox.TabIndex = 5;
            // 
            // editName_textBox
            // 
            this.editName_textBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editName_textBox.Location = new System.Drawing.Point(96, 36);
            this.editName_textBox.Name = "editName_textBox";
            this.editName_textBox.Size = new System.Drawing.Size(122, 23);
            this.editName_textBox.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(38, 233);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 19);
            this.label19.TabIndex = 3;
            this.label19.Text = "Types";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(38, 107);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 19);
            this.label18.TabIndex = 2;
            this.label18.Text = "Meals";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 19);
            this.label17.TabIndex = 1;
            this.label17.Text = "Ethnicity";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(38, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 19);
            this.label16.TabIndex = 0;
            this.label16.Text = "Name";
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
            // addIngredient_groupBox
            // 
            this.addIngredient_groupBox.Controls.Add(this.addIngredient_flowControl);
            this.addIngredient_groupBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIngredient_groupBox.Location = new System.Drawing.Point(490, 82);
            this.addIngredient_groupBox.Name = "addIngredient_groupBox";
            this.addIngredient_groupBox.Size = new System.Drawing.Size(187, 446);
            this.addIngredient_groupBox.TabIndex = 11;
            this.addIngredient_groupBox.TabStop = false;
            this.addIngredient_groupBox.Text = "Add Ingredients";
            this.addIngredient_groupBox.Visible = false;
            // 
            // addIngredient_flowControl
            // 
            this.addIngredient_flowControl.AutoScroll = true;
            this.addIngredient_flowControl.Controls.Add(this.newIngredient_textBox);
            this.addIngredient_flowControl.Controls.Add(this.addIng_button);
            this.addIngredient_flowControl.Controls.Add(this.submitIngredients_button);
            this.addIngredient_flowControl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIngredient_flowControl.Location = new System.Drawing.Point(7, 26);
            this.addIngredient_flowControl.Name = "addIngredient_flowControl";
            this.addIngredient_flowControl.Size = new System.Drawing.Size(174, 414);
            this.addIngredient_flowControl.TabIndex = 7;
            // 
            // newIngredient_textBox
            // 
            this.newIngredient_textBox.Location = new System.Drawing.Point(3, 3);
            this.newIngredient_textBox.Name = "newIngredient_textBox";
            this.newIngredient_textBox.Size = new System.Drawing.Size(111, 23);
            this.newIngredient_textBox.TabIndex = 1;
            // 
            // addIng_button
            // 
            this.addIng_button.Image = global::WindowsFormsApplication1.Properties.Resources.plus_icon;
            this.addIng_button.Location = new System.Drawing.Point(120, 3);
            this.addIng_button.Name = "addIng_button";
            this.addIng_button.Size = new System.Drawing.Size(30, 27);
            this.addIng_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addIng_button.TabIndex = 2;
            this.addIng_button.TabStop = false;
            this.addIng_button.Click += new System.EventHandler(this.addIng_button_Click);
            // 
            // submitIngredients_button
            // 
            this.submitIngredients_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitIngredients_button.Location = new System.Drawing.Point(3, 36);
            this.submitIngredients_button.Name = "submitIngredients_button";
            this.submitIngredients_button.Size = new System.Drawing.Size(75, 28);
            this.submitIngredients_button.TabIndex = 11;
            this.submitIngredients_button.Text = "Submit";
            this.submitIngredients_button.UseVisualStyleBackColor = true;
            // 
            // addMenuItem_groupBox
            // 
            this.addMenuItem_groupBox.Controls.Add(this.types_listBox);
            this.addMenuItem_groupBox.Controls.Add(this.meals_listBox);
            this.addMenuItem_groupBox.Controls.Add(this.label1);
            this.addMenuItem_groupBox.Controls.Add(this.submitMenuItem_button);
            this.addMenuItem_groupBox.Controls.Add(this.label4);
            this.addMenuItem_groupBox.Controls.Add(this.name_textBox);
            this.addMenuItem_groupBox.Controls.Add(this.ethnicity_comboBox);
            this.addMenuItem_groupBox.Controls.Add(this.ethnicity_label);
            this.addMenuItem_groupBox.Controls.Add(this.label2);
            this.addMenuItem_groupBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMenuItem_groupBox.Location = new System.Drawing.Point(259, 82);
            this.addMenuItem_groupBox.Name = "addMenuItem_groupBox";
            this.addMenuItem_groupBox.Size = new System.Drawing.Size(225, 446);
            this.addMenuItem_groupBox.TabIndex = 4;
            this.addMenuItem_groupBox.TabStop = false;
            this.addMenuItem_groupBox.Text = "Add A New Menu Item";
            this.addMenuItem_groupBox.Visible = false;
            // 
            // types_listBox
            // 
            this.types_listBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.types_listBox.FormattingEnabled = true;
            this.types_listBox.ItemHeight = 15;
            this.types_listBox.Location = new System.Drawing.Point(96, 205);
            this.types_listBox.Name = "types_listBox";
            this.types_listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.types_listBox.Size = new System.Drawing.Size(120, 169);
            this.types_listBox.TabIndex = 17;
            // 
            // meals_listBox
            // 
            this.meals_listBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meals_listBox.FormattingEnabled = true;
            this.meals_listBox.ItemHeight = 15;
            this.meals_listBox.Location = new System.Drawing.Point(96, 91);
            this.meals_listBox.Name = "meals_listBox";
            this.meals_listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.meals_listBox.Size = new System.Drawing.Size(120, 94);
            this.meals_listBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Type(s)";
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
            this.name_textBox.TextChanged += new System.EventHandler(this.name_textBox_TextChanged);
            // 
            // ethnicity_comboBox
            // 
            this.ethnicity_comboBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ethnicity_comboBox.FormattingEnabled = true;
            this.ethnicity_comboBox.Location = new System.Drawing.Point(96, 62);
            this.ethnicity_comboBox.Name = "ethnicity_comboBox";
            this.ethnicity_comboBox.Size = new System.Drawing.Size(121, 23);
            this.ethnicity_comboBox.TabIndex = 5;
            // 
            // ethnicity_label
            // 
            this.ethnicity_label.AutoSize = true;
            this.ethnicity_label.Location = new System.Drawing.Point(4, 62);
            this.ethnicity_label.Name = "ethnicity_label";
            this.ethnicity_label.Size = new System.Drawing.Size(70, 19);
            this.ethnicity_label.TabIndex = 4;
            this.ethnicity_label.Text = "Ethnicity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Meal(s)";
            // 
            // selectedItem_groupBox
            // 
            this.selectedItem_groupBox.Controls.Add(this.selectedTypes_listBox);
            this.selectedItem_groupBox.Controls.Add(this.selectedMeals_listBox);
            this.selectedItem_groupBox.Controls.Add(this.ethLabel);
            this.selectedItem_groupBox.Controls.Add(this.removeItem_button);
            this.selectedItem_groupBox.Controls.Add(this.editItem_button);
            this.selectedItem_groupBox.Controls.Add(this.label5);
            this.selectedItem_groupBox.Controls.Add(this.label3);
            this.selectedItem_groupBox.Controls.Add(this.label8);
            this.selectedItem_groupBox.Location = new System.Drawing.Point(259, 82);
            this.selectedItem_groupBox.Name = "selectedItem_groupBox";
            this.selectedItem_groupBox.Size = new System.Drawing.Size(418, 446);
            this.selectedItem_groupBox.TabIndex = 12;
            this.selectedItem_groupBox.TabStop = false;
            this.selectedItem_groupBox.Visible = false;
            // 
            // selectedTypes_listBox
            // 
            this.selectedTypes_listBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedTypes_listBox.FormattingEnabled = true;
            this.selectedTypes_listBox.ItemHeight = 15;
            this.selectedTypes_listBox.Location = new System.Drawing.Point(96, 167);
            this.selectedTypes_listBox.Name = "selectedTypes_listBox";
            this.selectedTypes_listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.selectedTypes_listBox.Size = new System.Drawing.Size(120, 169);
            this.selectedTypes_listBox.TabIndex = 21;
            // 
            // selectedMeals_listBox
            // 
            this.selectedMeals_listBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedMeals_listBox.FormattingEnabled = true;
            this.selectedMeals_listBox.ItemHeight = 15;
            this.selectedMeals_listBox.Location = new System.Drawing.Point(96, 64);
            this.selectedMeals_listBox.Name = "selectedMeals_listBox";
            this.selectedMeals_listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.selectedMeals_listBox.Size = new System.Drawing.Size(120, 94);
            this.selectedMeals_listBox.TabIndex = 20;
            // 
            // ethLabel
            // 
            this.ethLabel.AutoSize = true;
            this.ethLabel.Location = new System.Drawing.Point(99, 40);
            this.ethLabel.Name = "ethLabel";
            this.ethLabel.Size = new System.Drawing.Size(0, 13);
            this.ethLabel.TabIndex = 19;
            // 
            // removeItem_button
            // 
            this.removeItem_button.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeItem_button.Location = new System.Drawing.Point(8, 414);
            this.removeItem_button.Name = "removeItem_button";
            this.removeItem_button.Size = new System.Drawing.Size(75, 23);
            this.removeItem_button.TabIndex = 18;
            this.removeItem_button.Text = "Remove";
            this.removeItem_button.UseVisualStyleBackColor = true;
            // 
            // editItem_button
            // 
            this.editItem_button.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editItem_button.Location = new System.Drawing.Point(8, 389);
            this.editItem_button.Name = "editItem_button";
            this.editItem_button.Size = new System.Drawing.Size(75, 23);
            this.editItem_button.TabIndex = 17;
            this.editItem_button.Text = "Edit";
            this.editItem_button.UseVisualStyleBackColor = true;
            this.editItem_button.Click += new System.EventHandler(this.editItem_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Types";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Meals";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ethnicity";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(954, 587);
            this.tabControl1.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 26);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(174, 414);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 23);
            this.textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.plus_icon;
            this.pictureBox1.Location = new System.Drawing.Point(120, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(946, 561);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.menuItem_panel.ResumeLayout(false);
            this.ingredients_panel.ResumeLayout(false);
            this.ingredients_panel.PerformLayout();
            this.editItem_groupBox.ResumeLayout(false);
            this.editItem_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addType_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeType_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeMeal_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMeal_pictureBox)).EndInit();
            this.addIngredient_groupBox.ResumeLayout(false);
            this.addIngredient_flowControl.ResumeLayout(false);
            this.addIngredient_flowControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addIng_button)).EndInit();
            this.addMenuItem_groupBox.ResumeLayout(false);
            this.addMenuItem_groupBox.PerformLayout();
            this.selectedItem_groupBox.ResumeLayout(false);
            this.selectedItem_groupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.GroupBox addMenuItem_groupBox;
        private System.Windows.Forms.ComboBox ethnicity_comboBox;
        private System.Windows.Forms.Label ethnicity_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submitMenuItem_button;
        private System.Windows.Forms.ComboBox filter_comboBox;
        private System.Windows.Forms.ComboBox sort_comboBox;
        private System.Windows.Forms.GroupBox addIngredient_groupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitIngredients_button;
        private System.Windows.Forms.ListBox meals_listBox;
        private System.Windows.Forms.ListBox types_listBox;
        private System.Windows.Forms.GroupBox selectedItem_groupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button removeItem_button;
        private System.Windows.Forms.Button editItem_button;
        private System.Windows.Forms.Label ethLabel;
        private System.Windows.Forms.ListBox selectedTypes_listBox;
        private System.Windows.Forms.ListBox selectedMeals_listBox;
        private System.Windows.Forms.GroupBox editItem_groupBox;
        private System.Windows.Forms.PictureBox removeMeal_pictureBox;
        private System.Windows.Forms.PictureBox addMeal_pictureBox;
        private System.Windows.Forms.ListBox editTypes_listBox;
        private System.Windows.Forms.ListBox editMeals_listBox;
        private System.Windows.Forms.ComboBox editEth_comboBox;
        private System.Windows.Forms.TextBox editName_textBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox removeType_pictureBox;
        private System.Windows.Forms.PictureBox addType_pictureBox;
        private System.Windows.Forms.Button saveChanges_button;
        private System.Windows.Forms.Button cancelEdit_button;
        private System.Windows.Forms.Button removeIngredient_button;
        private System.Windows.Forms.ComboBox addType_comboxBox;
        private System.Windows.Forms.ComboBox addMeal_comboBox;
        private System.Windows.Forms.Panel menuItem_panel;
        private System.Windows.Forms.Panel ingredients_panel;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

