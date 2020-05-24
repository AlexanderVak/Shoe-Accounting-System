using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Shoe_Accounting_System
{
    public partial class Main_Form : Form
    {
        BindingList<Shoes> shoesList = new BindingList<Shoes>();
        MouseEventArgs mouseEvent;
        ContextMenuStrip gridContextMenu;
        int position;
        
        public Main_Form()
        {

            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = shoesList;

            ResetUIElements();

            dataGridView1.MouseClick += new MouseEventHandler(dataGridView1_MouseClick);
            SizeTxbx.Leave += new EventHandler(SizeTxbx_LostFocus);
            WeightTxtbx.Leave += new EventHandler(WeightTxtbx_LostFocus);

        }

        private void ResetUIElements()
        {
            ShoeTypeDbx.Focus();
            ShoeTypeDbx.Enabled = true;
            SizeTxbx.Enabled = false;
            WeightTxtbx.Enabled = false;
            ColorDbx.Enabled = false;
            MaterialDbx.Enabled = false;
            GenderDbx.Enabled = false;
            SoleTypeDbx.Enabled = false;
            AddShoesButton.Enabled = false;

            ShoeTypeDbx.SelectedIndex = -1;
            SizeTxbx.Clear();
            WeightTxtbx.Clear();
            ColorDbx.SelectedIndex = -1;
            MaterialDbx.SelectedIndex = -1;
            GenderDbx.SelectedIndex = -1;
            SoleTypeDbx.SelectedIndex = -1;

        }
        private void EnableUIElementsIfNeeded(ref ComboBox cbx)
        {
            SizeTxbx.Enabled = true;
            WeightTxtbx.Enabled = SizeTxbx.Text.Length != 0;
            ColorDbx.Enabled = WeightTxtbx.Text.Length != 0;
            MaterialDbx.Enabled = ColorDbx.Text.Length != 0;
            cbx.Enabled = MaterialDbx.Text.Length != 0;
            AddShoesButton.Enabled = cbx.Text.Length != 0;
        }

        private void SizeTxbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) )
                return;

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (sender.Equals(SizeTxbx))
                        WeightTxtbx.Focus();
                    else if (sender.Equals(WeightTxtbx))
                        ColorDbx.Focus();
                    else
                        ShoeTypeDbx.Focus();
                }
                return;
            }
            e.Handled = true;


        }
        private void WeightTxbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.')
                return;

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (sender.Equals(SizeTxbx))
                        WeightTxtbx.Focus();
                    else if (sender.Equals(WeightTxtbx))
                        ColorDbx.Focus();
                    else
                        ShoeTypeDbx.Focus();
                }
                return;
            }
            e.Handled = true;


        }
        private void SizeTxbx_LostFocus(object sender, EventArgs e)
        {
            UpdateUIElements();
            if (SizeTxbx.Text.Length == 0)
                return;
            try
            {
                Int32.Parse(SizeTxbx.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Please, enter numbers in field \"Size\" ");
                SizeTxbx.Clear();
            }


        }
        private void WeightTxtbx_LostFocus(object sender, EventArgs e)
        {
            UpdateUIElements();
            if (WeightTxtbx.Text.Length == 0)
                return;

            try
            {
                Double.Parse(WeightTxtbx.Text.Replace('.',','));
            }
            catch (Exception)
            {
                MessageBox.Show("Please, enter numbers in field \"Weight\" ");
                WeightTxtbx.Clear();
            }
        }

        private void ShoeTypeDbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (sender.Equals(ShoeTypeDbx))
                        SizeTxbx.Focus();
                    else if (sender.Equals(ColorDbx))
                        MaterialDbx.Focus();
                    else if (sender.Equals(MaterialDbx))
                        GenderDbx.Focus();
                    else if (sender.Equals(GenderDbx))
                    {
                        if ((ShoeTypeDbx.Text == AllShoesTypes.SPORT_SHOES || ShoeTypeDbx.Text == AllShoesTypes.SLIPPERS || ShoeTypeDbx.Text == AllShoesTypes.BOOTS))
                            ShoeTypeDbx.Focus();
                        else
                            SoleTypeDbx.Focus();
                    }
                    else
                        ShoeTypeDbx.Focus();
                }
            }

        }
        private void UpdateUIElements()
        {
            if (ShoeTypeDbx.Text.Length == 0)
                return;

            if ((ShoeTypeDbx.Text == AllShoesTypes.SPORT_SHOES || ShoeTypeDbx.Text == AllShoesTypes.SLIPPERS || ShoeTypeDbx.Text == AllShoesTypes.BOOTS))
            {
                EnableUIElementsIfNeeded(ref GenderDbx);
            }
            else if ((ShoeTypeDbx.Text == AllShoesTypes.MODEL_SHOES || ShoeTypeDbx.Text == AllShoesTypes.BROGES))
            {
                EnableUIElementsIfNeeded(ref SoleTypeDbx);
            }
            else
                AddShoesButton.Enabled = false;
        }
        private void ShoeTypeDbx_TextChanged(object sender, EventArgs e)
        {

            UpdateUIElements();

        }

        private void AddShoesButton_Click(object sender, EventArgs e)
        {

            string shoeType = ShoeTypeDbx.Text;
            int size = Convert.ToInt32(SizeTxbx.Text);
            double weight = Convert.ToDouble(WeightTxtbx.Text.Replace('.', ','));
            string color = ColorDbx.Text;
            string material = MaterialDbx.Text;
            string gender = GenderDbx.Text;
            string soleType = SoleTypeDbx.Text;



            switch (shoeType)
            {
                case AllShoesTypes.SPORT_SHOES:
                    shoesList.Add(new SportShoes(size, weight, color, material, gender));
                    break;
                case AllShoesTypes.MODEL_SHOES:
                    shoesList.Add(new ModelShoes(size, weight, color, material, soleType));
                    break;
                case AllShoesTypes.SLIPPERS:
                    shoesList.Add(new Slippers(size, weight, color, material, gender));
                    break;
                case AllShoesTypes.BROGES:
                    shoesList.Add(new Broges(size, weight, color, material, soleType));
                    break;
                case AllShoesTypes.BOOTS:
                    shoesList.Add(new Boots(size, weight, color, material, gender));
                    break;

            }
            ResetUIElements();
        }

        
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            mouseEvent = e;
            if (mouseEvent.Button == MouseButtons.Right)
            {
                gridContextMenu = new ContextMenuStrip();
                position = dataGridView1.HitTest(mouseEvent.X, mouseEvent.Y).RowIndex;

                if (position >= 0)
                {
                    gridContextMenu.Items.Add("Delete shoes").Name = "Delete Shoes";
                    gridContextMenu.Items.Add("Get typical use of shoes").Name = "Get typical use of shoes";
                }
                gridContextMenu.Show(dataGridView1, new Point(mouseEvent.X, mouseEvent.Y));

                gridContextMenu.ItemClicked += new ToolStripItemClickedEventHandler(gridContextMenu_ItemClicked);

            }
        }
        void gridContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            gridContextMenu.Close();
            switch (e.ClickedItem.Text.ToString())
            {
                case "Delete shoes":
                    {
                        DialogResult dialogRes = MessageBox.Show("Do you want to delete this shoes?", "Delete shoes", MessageBoxButtons.YesNo);

                        if (dialogRes == DialogResult.Yes)
                        {
                            shoesList.RemoveAt(position);
                        }
                    }
                    break;
                case "Get typical use of shoes":
                    {
                        MessageBox.Show(shoesList[position].GetTypicalUse());
                    }
                    break;

            }







        }
    }
}


