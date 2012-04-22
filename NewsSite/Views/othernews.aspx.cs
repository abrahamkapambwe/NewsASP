using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using News.Models;
using Newsza.Models;

namespace NewsSite.Views
{
    public partial class othernews : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["category"] != null)
                {
                    string category = Convert.ToString(Request.QueryString["category"]);
                    switch (category)
                    {
                        case Categories.BUSINESS:
                            var newsb =
                                GetNewsFromAmazon.GetNewsFromCache().Where(t => t.Category == Categories.BUSINESS).
                                    ToList();
                            LoadNewsArticles(newsb);
                            break;
                        case Categories.ENTERTAINMENT:
                            var newse =
                                GetNewsFromAmazon.GetNewsFromCache().Where(t => t.Category == Categories.ENTERTAINMENT).
                                    ToList();
                            LoadNewsArticles(newse);
                            break;
                        case Categories.TECHNOLOGY:
                            var newst =
                                GetNewsFromAmazon.GetNewsFromCache().Where(t => t.Category == Categories.TECHNOLOGY).
                                    ToList();
                            LoadNewsArticles(newst);
                            break;
                        case Categories.LIFESTYLE:
                            var newsl =
                                GetNewsFromAmazon.GetNewsFromCache().Where(t => t.Category == Categories.LIFESTYLE).
                                    ToList();
                            LoadNewsArticles(newsl);
                            break;
                        case Categories.GOSSIP:
                            var newsg =
                                GetNewsFromAmazon.GetNewsFromCache().Where(t => t.Category == Categories.GOSSIP).ToList();
                            LoadNewsArticles(newsg);
                            break;
                        case Categories.POLITICS:
                            var newsp =
                                GetNewsFromAmazon.GetNewsFromCache().Where(t => t.Category == Categories.POLITICS).
                                    ToList();
                            LoadNewsArticles(newsp);
                            break;
                        case Categories.SPORT:
                            var newss =
                                GetNewsFromAmazon.GetNewsFromCache().Where(t => t.Category == Categories.SPORT).ToList();
                            LoadNewsArticles(newss);
                            break;
                    }
                }
            }
        }

        private void LoadNewsArticles(List<NewsComponents> news)
        {
            lstothernews.DataSource = news;
            lstothernews.DataBind();
        }
        protected void lstothernews_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                NewsComponents newsComponents = (NewsComponents)e.Item.DataItem;
                Image img = (Image)e.Item.FindControl("imgPhoto");
                if (newsComponents.Images.Any())
                    img.ImageUrl = newsComponents.Images[0].Url;
                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;

                HyperLink linksummary = (HyperLink)e.Item.FindControl("linksummary");
                linksummary.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;

            }
        }
    }
}