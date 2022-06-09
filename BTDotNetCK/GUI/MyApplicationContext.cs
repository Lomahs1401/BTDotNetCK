using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTDotNetCK.GUI
{
    class MyApplicationContext : ApplicationContext
    {
        private void onFormClosed(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                ExitThread();
            }
        }

        public MyApplicationContext()
        {
            var forms = new List<Form>()
            {
                new FormLogin(),
            };

            foreach (var form in forms)
            {
                form.FormClosed += onFormClosed;
            }

            forms[0].Show();
        }
    }
}