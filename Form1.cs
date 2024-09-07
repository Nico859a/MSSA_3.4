using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment3._4
{
    public partial class Form1 : Form
    {
        private List<Coffee> coffeeList = new List<Coffee>();
        private BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            CoffeeGrid();
        }

        private void CoffeeGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bindingSource;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "ID", DataPropertyName = "Id" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Name", DataPropertyName = "Name" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Type", DataPropertyName = "Type" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Size", DataPropertyName = "Size" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Roast", DataPropertyName = "Roast" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Origin", DataPropertyName = "Origin" });

            bindingSource.DataSource = coffeeList;
        }

        private void but_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Coffee coffeeClicked = (Coffee)dataGridView1.SelectedRows[0].DataBoundItem;
                coffeeList.Remove(coffeeClicked);
                bindingSource.ResetBindings(false);
            }
        }

        private void but_Add_Click(object sender, EventArgs e)
        {
            int id = coffeeList.Count + 1;
            string name = texName.Text;
            string type = texType.Text;
            string size = texSize.Text;
            string roast = texRoast.Text;
            string origin = texOrigin.Text;

            Coffee newCoffee = new Coffee(id, name, type, size, roast, origin);
            coffeeList.Add(newCoffee);
            bindingSource.ResetBindings(false);


        }
        
        public class Coffee : Beverage
        {
            public string Roast { get; set; }
            public string Origin { get; set; }

            public Coffee(int id, string name, string type, string size, string roast, string origin) : base(id, name, type, size)
            {
                this.Roast = roast;
                this.Origin = origin;
            }
        }
    }
}
