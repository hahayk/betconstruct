using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace IDisposable
{
    public class HtmlDownloader :System.IDisposable
    {
        private StreamWriter sr;
        private WebClient wc = new WebClient();
        
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

            var html = wc.DownloadString(uri);

            //var html = "<html><head></head><body>Hello</<body>></html>";

            sr.Write(html);

        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    sr.Dispose();
                    wc.Dispose();

                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                sr = null;
                wc = null;

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        ~HtmlDownloader()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(false);
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
