using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace badanie_ksiag_wieczystych
{
    public class Firefox
    {
        public string pathFirefox { get; }
        public string pageUri { get; }

        public Firefox()
        {
            this.pathFirefox = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            this.pageUri = @"https://przegladarka-ekw.ms.gov.pl/eukw_prz/KsiegiWieczyste/wyszukiwanieKW?komunikaty=true&kontakt=true&okienkoSerwisowe=false";
        }
    
        public Firefox(string path_firefox,string page_uri)
        {
            this.pathFirefox = path_firefox;
            this.pageUri = page_uri;
        }

        public void startFirefox()
        {
            Process process = new Process();
            process.StartInfo.FileName = this.pathFirefox;
            process.StartInfo.Arguments = this.pageUri;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            process.Start();
        }

        public void startFirefox(string uri)
        {
            Process process = new Process();
            process.StartInfo.FileName = this.pathFirefox;
            process.StartInfo.Arguments = uri;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            process.Start();
        }

    }
}
