using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManager.Pages
{
    public partial class ProductsManagmentForm : Form
    {
        public ProductsManagmentForm()
        {
            InitializeComponent();
            resizeColumns();
            startFilling();
        }

        private void startFilling()
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += fillWithData;
            worker.RunWorkerCompleted += onWorkerCompleted;
            Cursor.Current = Cursors.WaitCursor;
            worker.RunWorkerAsync();
        }

        private void onWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }
        private void fillWithData(object sender, DoWorkEventArgs e)
        {
            Common.UISynchronizer.synchronizeWithUI(productsListView, productsListView.Items.Clear);

            insertProducts();
        }

        private void insertProducts()
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var products = ctx.Products;

                foreach (var product in products)
                {
                    List<string> listItem = new List<string>(5);

                    listItem.Add(product.name);
                    listItem.Add(product.amount.ToString());
                    listItem.Add(String.Format("{0:0.00}", product.price));
                    listItem.Add(product.Categories.name);
                    listItem.Add(product.Categories1.name);


                    ListViewItem item = new ListViewItem(listItem.ToArray());
                    Common.UISynchronizer.synchronizeWithUI(productsListView, x => productsListView.Items.Add(x), item);
                    Common.UISynchronizer.synchronizeWithUI(productsListView,
                        id => productsListView.Items[productsListView.Items.Count - 1].Tag = id, product.productID);


                }
            }
        }
        private void resizeColumns()
        {
            var widthOfList = productsListView.Width;
            var amountColumns = 5;
            var widthOfColumn = widthOfList / amountColumns;

            this.columnHeader1.Width = widthOfColumn;
            this.columnHeader2.Width = widthOfColumn;
            this.columnHeader3.Width = widthOfColumn;
            this.columnHeader4.Width = widthOfColumn;
            this.columnHeader5.Width = widthOfColumn;
        }

        private void ProductsManagmentForm_Resize(object sender, EventArgs e)
        {
            this.resizeColumns();
        }
    }
}
