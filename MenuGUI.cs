using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Menu
{
    public partial class MenuGUI : Form
    {
        private MenuItem selectedItem;

        public Menu menu { get; set; }
        public MenuGUI()
        {
            InitializeComponent();

            editEth_comboBox.Items.AddRange(Enum.GetNames(typeof(MenuItem.Ethnicity)));
            ethnicity_comboBox.Items.AddRange(Enum.GetNames(typeof(MenuItem.Ethnicity)));
            types_listBox.Items.AddRange(Enum.GetNames(typeof(MenuItem.FoodType)));
            meals_listBox.Items.AddRange(Enum.GetNames(typeof(MenuItem.Meal)));
        }

        /// <summary>
        /// Refresh the list of ingredients in the ingredient listbox.
        /// </summary>
        private void ReloadIngredients()
        {
            ingredient_listBox.Items.Clear();
            if (menuItem_listBox.SelectedIndex >= 0)
            {
                selectedItem = menu.GetItem(menuItem_listBox.Items[menuItem_listBox.SelectedIndex].ToString());
            }           

            foreach (var ing in selectedItem.Ingredients)
            {
                ingredient_listBox.Items.Add(ing);
            }
        }

        /// <summary>
        /// Refresh the list of menu items in the menu item listbox.
        /// </summary>
        private void ReloadMenuItems()
        {
            menuItem_listBox.Items.Clear();
            foreach (var item in menu.MenuItems)
            {
                menuItem_listBox.Items.Add(item.ItemName);
            }
        }

        /// <summary>
        /// Adds the ingredients that have been entered in the "Add Ingredients" area.
        /// </summary>
        /// <param name="IsNewItem">True if the ingredients are being added to a new item. 
        /// False if the menu item already exists.</param>
        /// <returns>The list of ingredients that have been added.</returns>
        private List<string> AddIngredients(bool IsNewItem)
        {
            var returnIngredients = new List<string>();
            foreach (Control c in addIngredient_flowControl.Controls)
            {
                if (c is TextBox)
                {
                    if (!String.IsNullOrEmpty(c.Text))
                    {
                        if (!IsNewItem)
                        {
                            selectedItem.Ingredients.Add(c.Text);
                            returnIngredients.Add(c.Text);
                        }
                        else
                        {
                            returnIngredients.Add(c.Text);
                        }
                    }
                }
            }
            addIngredient_flowControl.Controls.Clear();
            AddTextBox();

            return returnIngredients;
        }

        /// <summary>
        /// Adds a textbox to the Add Ingredient flow control. This is to allow 
        /// the user to enter multiple ingredients at once.
        /// </summary>
        private void AddTextBox()
        {
            TextBox tb = new TextBox();
            tb.Height = 20;
            tb.Width = 111;
            addIngredient_flowControl.Controls.Remove(addIng_button);
            addIngredient_flowControl.Controls.Remove(submitIngredients_button);
            addIngredient_flowControl.Controls.Add(tb);
            addIngredient_flowControl.Controls.Add(addIng_button);
            addIngredient_flowControl.Controls.Add(submitIngredients_button);
        }

        /// <summary>
        /// Display the information related to the currently selected menu item.
        /// </summary>
        private void DisplaySelectedItemInfo()
        {
            selectedItem_groupBox.Visible = true;
            selectedItem_groupBox.Text = selectedItem.ItemName;
            ethLabel.Text = selectedItem.ItemEthnicity.ToString();

            selectedMeals_listBox.Items.Clear();
            selectedMeals_listBox.Items.AddRange(selectedItem.ItemMeals_Strings().ToArray());
            selectedTypes_listBox.Items.Clear();
            selectedTypes_listBox.Items.AddRange(selectedItem.ItemTypes_Strings().ToArray());
        }

        /// <summary>
        /// Display the information that the user wants to edit.
        /// </summary>
        private void DisplayEditItemInfo()
        {
            editName_textBox.Text = selectedItem.ItemName;
            editEth_comboBox.SelectedItem = selectedItem.ItemEthnicity.ToString();

            editMeals_listBox.Items.Clear();
            editMeals_listBox.Items.AddRange(selectedItem.ItemMeals_Strings().ToArray());
            editTypes_listBox.Items.Clear();
            editTypes_listBox.Items.AddRange(selectedItem.ItemTypes_Strings().ToArray());
        }

        #region File Event Handlers
        private void chooseFile_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                List<string> itemNames = new List<string>();
                menu = new Menu(openFileDialog1.FileName);
                tabControl1.TabPages[0].Text = menu.Name;
                foreach (MenuItem mi in menu.MenuItems)
                {
                    menuItem_listBox.Items.Add(mi.ItemName);
                }
                menuItem_panel.Visible = true;
            }
        }

        private void saveFile_button_Click(object sender, EventArgs e)
        {
            string fileName = string.Empty;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;
                menu.Save(fileName);
            }
        }
        #endregion

        #region Menu Item Even Handlers
        private void submitMenuItem_button_Click(object sender, EventArgs e)
        {
            var ings = new List<string>();
            var name = name_textBox.Text;
            var eth = ethnicity_comboBox.SelectedText;
            var types = new List<string>();
            var meals = new List<string>();

            foreach (var item in types_listBox.SelectedItems)
            {
                types.Add(item.ToString());
            }
            foreach (var item in meals_listBox.SelectedItems)
            {
                meals.Add(item.ToString());
            }


            ings = AddIngredients(true);
            selectedItem = menu.AddItem(name, ings, types, meals, eth);

            name_textBox.Clear();
            ethnicity_comboBox.SelectedText = String.Empty;
            types_listBox.SelectedItems.Clear();
            meals_listBox.SelectedItems.Clear();
            menuItem_listBox.SelectedItems.Clear();
            addMenuItem_groupBox.Visible = false;
            addIngredient_groupBox.Visible = false;

            submitIngredients_button.Visible = true;
            addIngredient_button.Enabled = true;
            ReloadMenuItems();
            ReloadIngredients();
        }

        private void menuItem_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menuItem_listBox.SelectedIndex >= 0)
            {
                ingredients_panel.Visible = true;
                ReloadIngredients();
                DisplaySelectedItemInfo();
            }
        }

        private void addMenuItem_button_Click(object sender, EventArgs e)
        {
            addIngredient_button.Enabled = false;
            submitMenuItem_button.Enabled = false;

            submitIngredients_button.Visible = false;

            selectedItem_groupBox.Visible = false;
            addIngredient_groupBox.Visible = true;
            addMenuItem_groupBox.Visible = true;
        }
        #endregion

        #region Ingredient Event Handlers
        private void addIngredient_button_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                addIngredient_flowControl.Visible = true;
            }
        }

        private void addIng_button_Click(object sender, EventArgs e)
        {
            AddTextBox();
        }
        
        private void submitIngredients_button_Click(object sender, EventArgs e)
        {
            AddIngredients(false);
            ReloadIngredients();
            addIngredient_flowControl.Visible = false;
        }

        private void removeIngredient_button_Click(object sender, EventArgs e)
        {
            if (ingredient_listBox.SelectedIndex >= 0)
            {
                selectedItem.Ingredients.Remove(ingredient_listBox.SelectedItem.ToString());
                ReloadIngredients();
            }
        }
        #endregion

        #region Edit Item Event Handlers
        private void name_textBox_TextChanged(object sender, EventArgs e)
        {
            submitMenuItem_button.Enabled = !String.IsNullOrEmpty(name_textBox.Text);
        }
 
        private void editItem_button_Click(object sender, EventArgs e)
        {
            DisplayEditItemInfo();
            editItem_groupBox.Visible = true;
        }

        
        private void addMeal_pictureBox_Click(object sender, EventArgs e)
        {
            addMeal_comboBox.Items.Clear();
            foreach (var type in Enum.GetNames(typeof(MenuItem.Meal)))
            {
                if (!selectedItem.ItemMeals_Strings().Contains(type))
                {
                    addMeal_comboBox.Items.Add(type);
                }
            }
            addMeal_comboBox.Visible = true;
        }

        private void removeMeal_pictureBox_Click(object sender, EventArgs e)
        {
            if (editMeals_listBox.SelectedIndex >= 0)
            {
                MenuItem.Meal selectedMeal;
                Enum.TryParse(editMeals_listBox.SelectedItem.ToString(), out selectedMeal);
                selectedItem.ItemMeals.Remove(selectedMeal);
                DisplayEditItemInfo();
            }
        }

        private void addType_pictureBox_Click(object sender, EventArgs e)
        {
            addType_comboxBox.Items.Clear();
            foreach (var type in Enum.GetNames(typeof(MenuItem.FoodType)))
            {
                if (!selectedItem.ItemTypes_Strings().Contains(type))
                {
                    addType_comboxBox.Items.Add(type);
                }
            }
            addType_comboxBox.Visible = true;
        }

        private void removeType_pictureBox_Click(object sender, EventArgs e)
        {
            if (editTypes_listBox.SelectedIndex >= 0)
            {
                MenuItem.FoodType selectedType;
                Enum.TryParse(editTypes_listBox.SelectedItem.ToString(), out selectedType);
                selectedItem.ItemTypes.Remove(selectedType);
                DisplayEditItemInfo();
            }
        }

        private void cancelEdit_button_Click(object sender, EventArgs e)
        {
            editItem_groupBox.Visible = false;
        }

        private void saveChanges_button_Click(object sender, EventArgs e)
        {
            // TODO: Make it so that it doesn't save the other stuff until this button is clicked
            selectedItem.ItemName = editName_textBox.Text;
            Enum.TryParse(editEth_comboBox.Text, out selectedItem.ItemEthnicity);
            editItem_groupBox.Visible = false;
        }


        #endregion
    }
}
