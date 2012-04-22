using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NewsSite.Properties;
using Newsza.Models;

namespace NewsSite.Views
{
    public partial class multimediaItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (Request.QueryString["VideoId"] != null)
                {
                    string videoid = Convert.ToString(Request.QueryString["VideoId"]);
                    var multimedia =
                        GetNewsFromAmazon.GetVideosFromCache(Settings.Default.SouthAfricaVideo).Where(
                            t => t.VideoId == Guid.Parse(videoid)).ToList();
                }
            }
        }
        protected string GetYouTubeScript(string id)
        {
            string scr = @"<object width='320' height='240'> ";
            scr = scr + @"<param name='movie' value='http://www.youtube.com/v/" + id + "'></param> ";
            scr = scr + @"<param name='allowFullScreen' value='true'></param> ";
            scr = scr + @"<param name='allowscriptaccess' value='always'></param> ";
            scr = scr + @"<embed src='http://www.youtube.com/v/" + id + "' ";
            scr = scr + @"type='application/x-shockwave-flash' allowscriptaccess='always' ";
            scr = scr + @"allowfullscreen='true' width='320' height='240'> ";
            scr = scr + @"</embed></object>";
            return scr;
        }
    }
}