using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    class CircleArea : Form
    {
        public void FindArea()
        {
            const double П = 3.14;
            string c = "";
            int val;

            bool IsValue = int.TryParse(c, out val);

            if (IsValue)
            {
                double result = 2 * П * Convert.ToDouble(c);
                var res = result.ToString();
            }
        }
    }
}
