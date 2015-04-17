using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [ComVisible(true)]
    public class ObjectForScriptingHelper
    {

        MainWindow mExternalWPF;
        public ObjectForScriptingHelper(MainWindow w)
        {
            this.mExternalWPF = w;
        }
        
        // Methods here are able to be invoked from the 
        // javascript using window.external.MethodName

        public void SaveData(object JSON)
        {
            if(!System.IO.Directory.Exists("C:\\WPFBrowser"))
                System.IO.Directory.CreateDirectory("C:\\WPFBrowser");

            System.IO.File.WriteAllText("C:\\WPFBrowser\\data.JSON", JSON.ToString());
        }

        public string LoadData()
        {
            string r = "";
            if(System.IO.File.Exists("C:\\WPFBrowser\\data.JSON"))
            {
                r = System.IO.File.ReadAllText("C:\\WPFBrowser\\data.JSON");
            }
            return r;
        }
    }
}
