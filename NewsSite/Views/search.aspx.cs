using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newsza.Models;

namespace NewsSite.Views
{
    public partial class search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["value"] != null)
                {
                    string term = Request.QueryString["value"];
                    var news = GetNewsFromAmazon.GetNewsFromCache().Where(s => s.NewsItem.Contains(term)).ToList();

                    LoadSearchArticles(news);
                }
            }
        }

        private void LoadSearchArticles(List<News.Models.NewsComponents> news)
        {
            throw new NotImplementedException();
        }
    }
}