using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomButtonsLayoutView
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var list = new BindingList<Customer>();
            for (int i = 0; i < 10; i++)
                list.Add(new Customer() { ID = i, Name = "Name" + i });
            myGridControlMain.DataSource = list;
        }

        private void layoutViewCustomButtonMain_CustomButtonClick(object sender, CustomButtonEventsArgs e)
        {
            MessageBox.Show(e.CustomButton.Name);
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
