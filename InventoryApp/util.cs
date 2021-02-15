using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    class util
    {
        public static Random random = new Random();
        public static List<int> randomList = new List<int>();
        public static int GetUniqueId()
        {
            var tempId = random.Next(5, 100);
            if (!randomList.Contains(tempId))
                randomList.Add(tempId);
            return tempId;
        }

        public static void validateNumeric(object element, KeyPressEventArgs evt)
        {
            if (!char.IsDigit(evt.KeyChar) && !char.IsControl(evt.KeyChar))
            {
                evt.Handled = true;
            }
        }

        public static void validateDecimal(object element, KeyPressEventArgs evt)
        {
            if (!char.IsDigit(evt.KeyChar) && !char.IsControl(evt.KeyChar) && (evt.KeyChar != '.'))
            {
                evt.Handled = true;
            }

            if ((evt.KeyChar == '.') && ((element as TextBox).Text.IndexOf('.') > -1))
            {
                evt.Handled = true;
            }
        }

        public static bool isValidSave(int value, int min, int max)
        {
            if (min > max)
            {
                MessageBox.Show("Min value cannot be less than Max value");
                return false;
            }
            if (min > value || max < value)
            {
                MessageBox.Show("Inventory should be between Min and Max value");
                return false;
            }
            return true;
        }
    }
}
