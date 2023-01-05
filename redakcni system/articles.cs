using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace redakcni_system
{
    public class articles
    {
        public string textBox { get; set; }

        public override string ToString()
        {
            return string.Format(textBox);
        }

    }
}
