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
            // TODO: This line of code loads data into the 'countriesDBDataSet.Countries' table. You can move, or remove it, as needed.
            this.countriesTableAdapter.Fill(this.countriesDBDataSet.Countries);
        }

        private void layoutViewCustomButtonMain_CustomButtonClick(object sender, CustomButtonEventsArgs e)
        {
            MessageBox.Show(e.CustomButton.Name);
        }
    }
}
