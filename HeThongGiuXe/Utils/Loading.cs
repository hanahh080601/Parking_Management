using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThongGiuXe.View;

namespace HeThongGiuXe.Utils
{
    class Loading
    {
        public static LoadingForm form {get;set;}
        public static void Start(Form parent)
        {
            if (form == null) form = new LoadingForm();
            form.Show(parent);
        }
        public static void Close()
        {
            form.Dispose();
            form = null;
        }

    }
}
