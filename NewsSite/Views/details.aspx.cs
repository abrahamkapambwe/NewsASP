using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using News.Models;
using NewsSite.Properties;
using Newsza.Models;

namespace NewsSite.Views
{
    public partial class details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["NewsID"] != null)
                {
                    string newsid = Convert.ToString(Request.QueryString["NewsID"]);
                    var news = GetNewsFromAmazon.GetNewsFromCache().Where(n => n.NewsID == Guid.Parse(newsid)).FirstOrDefault();
                    var comments = GetNewsFromAmazon.FormatedComments(Settings.Default.DomainNameComment).Where(n => n.NewsID == Convert.ToString(newsid));
                    lstComments.DataSource = comments;
                    lstComments.DataBind();
                    divNewsItem.InnerHtml = Server.HtmlDecode(news.NewsItem);
                    lblHeadline.Text = news.NewsHeadline;
                    lblNewsAdded.Text = String.Format("{0:ddd, MMMM d, yyyy}", news.NewsAdded);

                }
            }
        }
        protected void btnSubmit_Click(Object sender, EventArgs e)
        {
            Comment comment = new Comment();
            comment.NewsID = hdfNewsID.Value;
            comment.CommentID = Guid.NewGuid();
            comment.CommentItem = txtComment.Text;
            comment.Name = txtName.Text;
            comment.Email = txtEmail.Text;

            GetNewsFromAmazon.SaveComments(Settings.Default.DomainNameComment,comment);
        }
        private string  checkForVague(string comments)
        {

            if(comments.Contains("Fuck You"))
            {
               //comments= comments.Replace("Fuck You", ****);

            }else if(comments.Contains("Mother funcker"))
            {
                
            }
            return comments;
        }
    }

}