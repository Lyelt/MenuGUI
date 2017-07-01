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
        }

        private void ReloadIngredients()
        {
            if (menuItem_listBox.SelectedIndex >= 0)
            {
                ingredient_listBox.Items.Clear();
                selectedItem = menu.GetItem(menuItem_listBox.Items[menuItem_listBox.SelectedIndex].ToString());

                foreach (var ing in selectedItem.Ingredients)
                {
                    ingredient_listBox.Items.Add(ing);
                }
            }
        }

        private void ReloadMenuItems()
        {
            menuItem_listBox.Items.Clear();
            foreach (var item in menu.MenuItems)
            {
                menuItem_listBox.Items.Add(item.ItemName);
            }
        }

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
            }
        }

        private void saveFile_button_Click(object sender, EventArgs e)
        {
            string saveDir = string.Empty;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveDir = saveFileDialog1.FileName;
                DirectoryInfo dir = new DirectoryInfo(saveDir);
                if (!dir.Exists)
                {
                    dir.Create();
                }

                menu.Save(saveDir);
            }
        }

        private void menuItem_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Selected item in listbox
            ReloadIngredients();
        }

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
            foreach (Control c in addIngredient_flowControl.Controls)
            {   
                if (c is TextBox)
                {
                    if (!String.IsNullOrEmpty(c.Text))
                    {
                        selectedItem.Ingredients.Add(c.Text);
                    }
                }           
            }
            addIngredient_flowControl.Controls.Clear();
            AddTextBox();
            ReloadIngredients();
            addIngredient_flowControl.Visible = false;
        }

        private void addMenuItem_button_Click(object sender, EventArgs e)
        {
            addMenuItem_groupBox.Visible = true;
            ethnicity_comboBox.Items.AddRange(Enum.GetNames(typeof(MenuItem.Ethnicity)));
            types_listBox.Items.AddRange(Enum.GetNames(typeof(MenuItem.FoodType)));
            meals_listBox.Items.AddRange(Enum.GetNames(typeof(MenuItem.Meal)));
        }

        private void submitMenuItem_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(name_textBox.Text))
            {
                MessageBox.Show("Please enter a name for the menu item.", "Item Name Not Found");
                return;
            }
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

            menu.AddItem(name, null, types, meals, eth);

            name_textBox.Clear();
            addMenuItem_groupBox.Visible = false;
            ReloadMenuItems();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
