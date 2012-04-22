using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using News.Models;
using Newsza.Models;

namespace NewsSite.Views
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                LoadNewsHeadline();
            }
        }

        private void LoadNewsHeadline()
        {

            var news = GetNewsFromAmazon.GetNewsFromCache().Where(t => t.Category == Categories.POLITICS).OrderByDescending(s=>s.NewsAdded).ToList();
            lstPoliticsHeadline.DataSource = news.Skip(4).Take(10);
            lstPoliticsHeadline.DataBind();
            lstPolitics.DataSource = news.Take(4);
            lstPolitics.DataBind();


            var newsbusinessheadline = GetNewsFromAmazon.GetNewsFromCache().Where(t => t.Category == Categories.BUSINESS).OrderByDescending(s => s.NewsAdded).ToList();
            lstBusiness.DataSource = newsbusinessheadline.Take(4);
            lstBusiness.DataBind();
            lstBusinessHeadline.DataSource = newsbusinessheadline.Skip(4).Take(10);
            lstBusinessHeadline.DataBind();


            var newstechnology = GetNewsFromAmazon.GetNewsFromCache().Where(t => t.Category == Categories.TECHNOLOGY).OrderByDescending(s => s.NewsAdded).ToList();
            lstTechnology.DataSource = newstechnology.Take(4);
            lstTechnology.DataBind();
            lstTechnologyHeadlines.DataSource = newstechnology.Skip(4).Take(10);
            lstTechnologyHeadlines.DataBind();

            var newsSport = GetNewsFromAmazon.GetNewsFromCache().Where(t => t.Category == Categories.SPORT).OrderByDescending(s => s.NewsAdded).ToList();
            lstSports.DataSource = newsSport.Take(4);
            lstSports.DataBind();
            lstSportsHeadline.DataSource = newsSport.Skip(4).Take(10);
            lstSportsHeadline.DataBind();

            var newsentertainment = GetNewsFromAmazon.GetNewsFromCache().Where(t => t.Category == Categories.ENTERTAINMENT).OrderByDescending(s => s.NewsAdded).ToList();

            lstEntertainment.DataSource = newsentertainment.Take(4);
            lstEntertainment.DataBind();
            lstEntertainmentHeadlines.DataSource = newsentertainment.Skip(4).Take(10);
            lstEntertainmentHeadlines.DataBind();


        }
        protected void lstPolitics_itemDatabound(object sender, ListViewItemEventArgs e)
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
        protected void lstPoliticsHeadline_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                NewsComponents newsComponents = (NewsComponents)e.Item.DataItem;

                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;

            }
        }

        protected void lstBusiness_itemDatabound(object sender, ListViewItemEventArgs e)
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
        protected void lstBusinessHeadline_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                NewsComponents newsComponents = (NewsComponents)e.Item.DataItem;

                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;

            }
        }

        protected void lstTechnology_itemDatabound(object sender, ListViewItemEventArgs e)
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
        protected void lstTechnologyHeadlines_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                NewsComponents newsComponents = (NewsComponents)e.Item.DataItem;

                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;

            }
        }

        protected void lstSports_itemDatabound(object sender, ListViewItemEventArgs e)
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
        protected void lstSportsHeadline_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                NewsComponents newsComponents = (NewsComponents)e.Item.DataItem;

                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;

            }
        }

        protected void lstEntertainment_itemDatabound(object sender, ListViewItemEventArgs e)
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
        protected void lstEntertainmentHeadlines_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                NewsComponents newsComponents = (NewsComponents)e.Item.DataItem;

                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;

            }
        }

    }
}