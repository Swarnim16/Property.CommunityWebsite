using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property.Community_OwnerPages
{
    public class BaseClass
    {
        public static void Do_Login()
        {
            //BrowserUtility.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            String userName = "vincent.nguyen@mvpstudio.co.nz";
            String password = "ntmv2682";
            LoginPage.Go_To_Login_Page();
            LoginPage.Enter_LoginData(userName, password);
            LoginPage.Can_Click_Login();
            BrowserUtility.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);

        }

        
    }
}
