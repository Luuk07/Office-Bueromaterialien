using CDS.Classes;
using CDS.Enumerations;
using Office_Büromaterialienbestellung.Classes.Records;
using Office_Büromaterialienbestellung.Classes.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Office_Büromaterialienbestellung
{
    public partial class FormMain : Form
    {
        public CclSvcMain SvcMain;

        public ListView ListViewAllProducts
        {
            get { return listViewAllProducts; }
        }

        public FormMain()
        {
            SvcMain = new CclSvcMain();
            InitializeComponent();
            InitListView(ListViewAllProducts);

            getAllDataFromDataStorage();

            this.MaximizeBox = false;
            this.MaximumSize = this.Size;
        }
        private void InitListView(ListView _clTarget)
        {
            _clTarget.View = View.Details;
            _clTarget.FullRowSelect = true;
            _clTarget.GridLines = true;

            _clTarget.Columns.Add("Produktname");
            _clTarget.Columns.Add("Menge");
            _clTarget.Columns.Add("Benutzername");
        }
        public void getAllDataFromDataStorage()
        {
            var products = SvcMain.Products;
            fromProductsStorageInListView(products.ToList());
        } 

        public void fromProductsStorageInListView(List<CclRecProduct> products)
        {
            foreach (var item in products)
            {
                //Nur Vorbestellte Artikel anzeigen
                if (item.IsPreOrdered)
                {
                    var lvi = new ListViewItem(item.ProductName);
                    lvi.SubItems.Add(item.Amount.ToString());
                    lvi.SubItems.Add(item.UserName);
                    lvi.Tag = item;
                    ListViewAllProducts.Items.Add(lvi);
                    continue;
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Irgendwie die ListView aktualisieren

        }

        private void allesBestellt_Click(object sender, EventArgs e)
        {
            //Alles Löschen und auf Bestellt setzten 
            SvcMain.SetAllOrdered();
            ListViewAllProducts.Clear();
        }

        private void listViewAllProducts_DoubleClick(object sender, EventArgs e)
        {
            if (listViewAllProducts.SelectedItems.Count > 0)
            {
                var products = SvcMain.Products;
                var item = listViewAllProducts.SelectedItems[0];
                string listViewId = item.SubItems[0].Text;
                CclRecProduct tagProd = item.Tag as CclRecProduct;
                if (tagProd == null)
                    return;
                var prodInTable = products.FirstOrDefault(p => p.OrderID == tagProd.OrderID);

                if (prodInTable != null && prodInTable.IsPreOrdered == true)
                {
                    var result = MessageBox.Show("Möchten Sie diesen Eintrag wirklich bestellen?", "Eintrag bestellen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                        return;
                    SvcMain.OnIsOrdered(prodInTable);
                    ListViewAllProducts.Items.Remove(item);
                }
            }
        }

        private void buttonReceived_Click(object sender, EventArgs e)
        {

        }
    }
}
