using System;
using System.Drawing;
using System.Net;

namespace ShortcutFolder
{
    public class WebImgGetter
    {
        public static Bitmap GetBitmapFromWeb(string url)
        {
            WebRequest wr = WebRequest.Create(url);
            WebResponse res = wr.GetResponse();
            return new Bitmap(res.GetResponseStream());
        }

        public static bool IsValidUrl(string url)
        {
            Uri uriResult;
            return Uri.TryCreate(url, UriKind.Absolute, out uriResult) &&
                    (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }
    }
}