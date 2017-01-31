using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IDisposable
{
    public class HtmlDownloader
    {
        private StreamWriter sr;

        public HtmlDownloader(string path)
        {
            sr = new StreamWriter(path);
        }

        public void Save(string url)
        {
            if(url == null)
            {
                throw new ArgumentNullException(nameof(url));
            }

            var uri = new Uri(url);

            var html = "<html><head></head><body>Hello</<body>></html>";

            sr.Write(html);

        }
    }
}
