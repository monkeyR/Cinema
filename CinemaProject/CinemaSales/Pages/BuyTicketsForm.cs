using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSales.Main
{
    public partial class BuyTicketsForm : Form
    {
        public BuyTicketsForm()
        {
            InitializeComponent();
        }

        private void BuyTicketsForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadAllHalls()
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var Halls = (from t in ctx.Halls
                                  select t);


                /*
                foreach (var cat in Categories)
                {
                    MainCategories.Add(cat.slug, cat.name);
                    AddButtonToCategoriesPanel(CreateButtonCategory(cat.name, cat.slug, cat.categoryID));
                }
                */
            }
        }

        private void DisplayHalls(CinemaModel.Halls halls)
        {

        }
    }
}
