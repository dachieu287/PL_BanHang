using System.Collections;
using System.Windows.Forms;

namespace GUI
{
    public class ListViewColumnSorter : IComparer
    {
        public int SortColumn { get; set; }
        public SortOrder Order { get; set; }
        private readonly CaseInsensitiveComparer ObjectCompare;

        public ListViewColumnSorter()
        {
            SortColumn = 0;
            Order = SortOrder.None;
            ObjectCompare = new CaseInsensitiveComparer();
        }
        public int Compare(object x, object y)
        {
            int compareResult;
            ListViewItem itemX = x as ListViewItem;
            ListViewItem itemY = y as ListViewItem;

            bool isNumberX = int.TryParse(itemX.SubItems[SortColumn].Text, out int numberX);
            bool isNumberY = int.TryParse(itemY.SubItems[SortColumn].Text, out int numberY);
            if (isNumberX && isNumberY)
            {
                compareResult = ObjectCompare.Compare(numberX, numberY);
            }
            else
            {
                compareResult = ObjectCompare.Compare(itemX.SubItems[SortColumn].Text, itemY.SubItems[SortColumn].Text);
            }
            

            if (Order == SortOrder.Ascending)
            {
                return compareResult;
            }
            else if (Order == SortOrder.Descending)
            {
                return -compareResult;
            }
            else
            {
                return 0;
            }
        }
    }
}
