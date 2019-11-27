using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyYup2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Currency currency = new Currency();
            cmbInputCurrency.Items.AddRange(currency.currencies.Keys.ToArray());
        }

        private void cmbInputCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCurrenciesToListView();
        }

        private void LoadCurrenciesToListView()
        {
            lstOutputCurrencies.Items.Clear();
            int sira = 0;
            Currency currency = new Currency();
            try
            {
                Dictionary<string, decimal> outputCurrencies = currency.Convert(decimal.Parse(txtInputValue.Text), cmbInputCurrency.Text);


                foreach (var item in outputCurrencies)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = item.Key;
                    ListViewItem.ListViewSubItem listViewSubItem = new ListViewItem.ListViewSubItem();
                    listViewSubItem.Text = $"{item.Value:0.##}";
                    listViewItem.SubItems.Add(listViewSubItem);
                    //if(sira%2==0)
                    //listViewItem.BackColor = Color.Azure;
                    //else
                    //listViewItem.BackColor = Color.Red;
                    listViewItem.BackColor = (sira % 2 == 0) ? Color.LightSkyBlue : Color.LightGreen;
                    lstOutputCurrencies.Items.Add(listViewItem);
                    sira++;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                txtInputValue.Text = "";
            }
        }
    }
}
