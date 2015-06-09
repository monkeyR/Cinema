using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Tool
    {
        public Tool()
        {

        }
        public static void resizeColumns(System.Windows.Forms.ListView listView)
        {
            int columns = listView.Columns.Count;
            int widthColumn = (listView.Width / listView.Columns.Count);

            foreach (System.Windows.Forms.ColumnHeader item in listView.Columns)
            {
                item.Width = widthColumn;
            }
        }
    }
}
