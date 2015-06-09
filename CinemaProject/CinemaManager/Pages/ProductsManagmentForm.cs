using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            Common.UISynchronizer.synchronizeWithUI(listTickets, listTickets.Items.Clear);
            Common.UISynchronizer.synchronizeWithUI(listMainCategories, listMainCategories.Items.Clear);
            Common.UISynchronizer.synchronizeWithUI(listSubCategories, listSubCategories.Items.Clear);

            insertProducts();
            insertTickets();
            insertCategories();
        }


        private void insertCategories()
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var categories = ctx.Categories;

                foreach (var category in categories)
                {
                    List<string> listItem = new List<string>(5);

                    listItem.Add(category.name);

                    if (category.mainCat == false)
                    {
                        if (category.parentCat == 0)
                        {
                            listItem.Add("Brak");
                        }
                        else
                        {
                            var parentCategory = categories.FirstOrDefault(x => x.categoryID == category.parentCat);
                            listItem.Add(parentCategory.name);
                        }
                        
                    }

                    ListViewItem item = new ListViewItem(listItem.ToArray());
                    item.Tag = category.categoryID;

                    if (category.mainCat == false)
                    {
                        Common.UISynchronizer.synchronizeWithUI(listSubCategories, x => listSubCategories.Items.Add(x), item);
                    }
                    else
                    {
                        Common.UISynchronizer.synchronizeWithUI(listMainCategories, x => listMainCategories.Items.Add(x), item);
                    }
                    
                    //Common.UISynchronizer.synchronizeWithUI(listTickets,
                    //id => listTickets.Items[listTickets.Items.Count - 1].Tag = id, ticket.ticketID);
                }
            }
        }

        public static string ToSlug(string value)
        {

            value = value.ToLowerInvariant();
            var bytes = Encoding.GetEncoding("Cyrillic").GetBytes(value);
            value = Encoding.ASCII.GetString(bytes);
            value = Regex.Replace(value, @"\s", "-", RegexOptions.Compiled);
            value = Regex.Replace(value, @"[^a-z0-9\s-_]", "", RegexOptions.Compiled);
            value = value.Trim('-', '_');
            value = Regex.Replace(value, @"([-_]){2,}", "$1", RegexOptions.Compiled);

            return value;
        }

        private void insertTickets()
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var tickets = ctx.Tickets;

                foreach (var ticket in tickets)
                {
                    List<string> listItem = new List<string>(5);

                    listItem.Add(ticket.name);
                    listItem.Add(String.Format("{0:0.00}", ticket.price));

                    ListViewItem item = new ListViewItem(listItem.ToArray());
                    item.Tag = ticket.ticketID;

                    Common.UISynchronizer.synchronizeWithUI(listTickets, x => listTickets.Items.Add(x), item);
                }
            }
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

            this.columnHeader7.Width = listTickets.Width / 2;
            this.columnHeader8.Width = listTickets.Width / 2;
        }

        private void ProductsManagmentForm_Resize(object sender, EventArgs e)
        {
            this.resizeColumns();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            SubPages.AddNewMainCategory form = new SubPages.AddNewMainCategory();
            form.ShowDialog();

            Common.UISynchronizer.synchronizeWithUI(listMainCategories, listMainCategories.Items.Clear);
            Common.UISynchronizer.synchronizeWithUI(listSubCategories, listSubCategories.Items.Clear);

            insertCategories();
        }

        private void listMainCategories_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right && listMainCategories.SelectedItems.Count == 1)
            {
                ContextMenu cm = new ContextMenu();

                MenuItem editItem = new MenuItem("Edytuj");
                editItem.Click += (objectSender, args) =>
                {
                    editMainItemClick(objectSender, args);
                };
                cm.MenuItems.Add(editItem);

                MenuItem deleteItem = new MenuItem("Usuń");
                deleteItem.Click += (objectSender, args) =>
                {
                    removeMainItemClick(objectSender, args);
                };
                cm.MenuItems.Add(deleteItem);

                cm.Show(this, this.PointToClient(Cursor.Position));
            }
        }

        private void editMainItemClick(object objectSender, EventArgs args)
        {
            SubPages.EditMainCategory form = new SubPages.EditMainCategory((int)listMainCategories.SelectedItems[0].Tag);
            form.ShowDialog();

            Common.UISynchronizer.synchronizeWithUI(listMainCategories, listMainCategories.Items.Clear);
            Common.UISynchronizer.synchronizeWithUI(listSubCategories, listSubCategories.Items.Clear);

            insertCategories();
        }

        private void removeMainItemClick(object objectSender, EventArgs args)
        {
            int categoryID = (int)listMainCategories.SelectedItems[0].Tag;

            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                try
                {
                    CinemaModel.Categories categoryToRemove = ctx.Categories.FirstOrDefault(x => x.categoryID.Equals(categoryID));

                    ctx.Categories.Remove(categoryToRemove);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    showError(ex);
                }
            }

            Common.UISynchronizer.synchronizeWithUI(listMainCategories, listMainCategories.Items.Clear);
            Common.UISynchronizer.synchronizeWithUI(listSubCategories, listSubCategories.Items.Clear);

            insertCategories();
        }

        private void showError(Exception ex)
        {
            String message = "Wystąpił błąd: " + ex.Message;
            MessageBox.Show(message);
        }

        private void listSubCategories_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right && listSubCategories.SelectedItems.Count == 1)
            {
                ContextMenu cm = new ContextMenu();

                MenuItem editItem = new MenuItem("Edytuj");
                editItem.Click += (objectSender, args) =>
                {
                    editSubItemClick(objectSender, args);
                };
                cm.MenuItems.Add(editItem);

                MenuItem deleteItem = new MenuItem("Usuń");
                deleteItem.Click += (objectSender, args) =>
                {
                    removeSubItemClick(objectSender, args);
                };
                cm.MenuItems.Add(deleteItem);

                cm.Show(this, this.PointToClient(Cursor.Position));
            }
        }

        private void removeSubItemClick(object objectSender, EventArgs args)
        {
            int categoryID = (int)listSubCategories.SelectedItems[0].Tag;

            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                try
                {
                    CinemaModel.Categories categoryToRemove = ctx.Categories.FirstOrDefault(x => x.categoryID.Equals(categoryID));

                    ctx.Categories.Remove(categoryToRemove);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    showError(ex);
                }
            }

            Common.UISynchronizer.synchronizeWithUI(listMainCategories, listMainCategories.Items.Clear);
            Common.UISynchronizer.synchronizeWithUI(listSubCategories, listSubCategories.Items.Clear);

            insertCategories();
        }

        private void editSubItemClick(object objectSender, EventArgs args)
        {
            SubPages.EditSubCategory form = new SubPages.EditSubCategory((int)listSubCategories.SelectedItems[0].Tag);
            form.ShowDialog();

            Common.UISynchronizer.synchronizeWithUI(listMainCategories, listMainCategories.Items.Clear);
            Common.UISynchronizer.synchronizeWithUI(listSubCategories, listSubCategories.Items.Clear);

            insertCategories();
        }

        private void buttonAddSubCategory_Click(object sender, EventArgs e)
        {
            SubPages.AddNewSubCategory form = new SubPages.AddNewSubCategory();
            form.ShowDialog();

            Common.UISynchronizer.synchronizeWithUI(listMainCategories, listMainCategories.Items.Clear);
            Common.UISynchronizer.synchronizeWithUI(listSubCategories, listSubCategories.Items.Clear);

            insertCategories();
        }

        private void buttonAddTicket_Click(object sender, EventArgs e)
        {
            SubPages.AddNewTicket form = new SubPages.AddNewTicket();
            form.ShowDialog();

            Common.UISynchronizer.synchronizeWithUI(this.listTickets, this.listTickets.Items.Clear);

            this.insertTickets();
        }

        private void listTickets_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right && listTickets.SelectedItems.Count == 1)
            {
                ContextMenu cm = new ContextMenu();

                MenuItem editItem = new MenuItem("Edytuj");
                editItem.Click += (objectSender, args) =>
                {
                    editTicketItemClick(objectSender, args);
                };
                cm.MenuItems.Add(editItem);

                MenuItem deleteItem = new MenuItem("Usuń");
                deleteItem.Click += (objectSender, args) =>
                {
                    removeTicketItemClick(objectSender, args);
                };
                cm.MenuItems.Add(deleteItem);

                cm.Show(this, this.PointToClient(Cursor.Position));
            }
        }

        private void removeTicketItemClick(object objectSender, EventArgs args)
        {
            int ticketsID = (int)listTickets.SelectedItems[0].Tag;

            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                try
                {
                    CinemaModel.Tickets ticketToRemove = ctx.Tickets.FirstOrDefault(x => x.ticketID.Equals(ticketsID));

                    ctx.Tickets.Remove(ticketToRemove);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    showError(ex);
                }
            }

            Common.UISynchronizer.synchronizeWithUI(this.listTickets, this.listTickets.Items.Clear);

            this.insertTickets();
        }

        private void editTicketItemClick(object objectSender, EventArgs args)
        {
            SubPages.EditTicket form = new SubPages.EditTicket((int)listTickets.SelectedItems[0].Tag);
            form.ShowDialog();

            Common.UISynchronizer.synchronizeWithUI(this.listTickets, this.listTickets.Items.Clear);

            this.insertTickets();
        }

        private void addNewProductButton_Click(object sender, EventArgs e)
        {
            SubPages.AddNewProduct form = new SubPages.AddNewProduct();
            form.ShowDialog();

            Common.UISynchronizer.synchronizeWithUI(this.productsListView, this.productsListView.Items.Clear);

            this.insertProducts();
        }

        private void productsListView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right && productsListView.SelectedItems.Count == 1)
            {
                ContextMenu cm = new ContextMenu();

                MenuItem editItem = new MenuItem("Edytuj");
                editItem.Click += (objectSender, args) =>
                {
                    editProductItemClick(objectSender, args);
                };
                cm.MenuItems.Add(editItem);

                MenuItem deleteItem = new MenuItem("Usuń");
                deleteItem.Click += (objectSender, args) =>
                {
                    removeProductItemClick(objectSender, args);
                };
                cm.MenuItems.Add(deleteItem);

                cm.Show(this, this.PointToClient(Cursor.Position));
            }
        }
        private void removeProductItemClick(object objectSender, EventArgs args)
        {
            int productID = (int)productsListView.SelectedItems[0].Tag;

            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                try
                {
                    CinemaModel.Products productToRemove = ctx.Products.FirstOrDefault(x => x.productID.Equals(productID));
                    ctx.Products.Remove(productToRemove);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    showError(ex);
                }
            }

            Common.UISynchronizer.synchronizeWithUI(this.productsListView, this.productsListView.Items.Clear);

            this.insertProducts();
        }

        private void editProductItemClick(object objectSender, EventArgs args)
        {
            SubPages.EditProduct form = new SubPages.EditProduct((int)productsListView.SelectedItems[0].Tag);
            form.ShowDialog();

            Common.UISynchronizer.synchronizeWithUI(this.productsListView, this.productsListView.Items.Clear);

            this.insertProducts();
        }
    }
}
