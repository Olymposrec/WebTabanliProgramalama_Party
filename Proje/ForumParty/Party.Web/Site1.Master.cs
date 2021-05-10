﻿using Party.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Party.Web
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            Repository<DataAccess.Categories> repoList = new Repository<DataAccess.Categories>();
            Repeater1.DataSource = repoList.List();
            Repeater1.DataBind();


            if (Session["UserName"] != null)
            {
                lbl_session.Text = Session["UserName"].ToString();
                btn_login.Visible = false;
                btn_logout.Visible = true;
                lnkbtn_MessagePage.Visible = true;
                lnkbtn_MainPage.Visible = true;
            }
            else
            {
                lnkbtn_MainPage.Visible = false;
                lnkbtn_MessagePage.Visible = false;
                btn_logout.Visible = false;
                btn_login.Visible = true;
                lbl_session.Text = "";
            }
            
        }
        protected void Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("LogInPage.aspx");
        }

        protected void LogOut_Click(object sender, EventArgs e)
        {
           
            Session.RemoveAll();
            lbl_session.Text = "";
            Response.Redirect("LogInPage.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void SearchData_Click(object sender, EventArgs e)
        {
            txt_search.Text = "Search Data Work";
        }
        protected void AddPost_Click(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                Response.Redirect("LogInPage.aspx");
            }
            else
            {
                Response.Redirect("AddPostPage.aspx");
            }
           
        }
        protected void AddPoll_Click(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                Response.Redirect("LogInPage.aspx");
            }
            else
            {
                Response.Redirect("AddPollPage.aspx");
            }
           
        }
        
        protected void ForumPage_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("HomePage.aspx");

        }
        protected void PollsPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("PollsPage.aspx");

        }
        
        protected void MessagesPage_Click(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                Response.Redirect("LogInPage.aspx");
            }
            else
            {
                Response.Redirect("MessagesPage.aspx");
            }
           

        }
        protected void HomePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");

        }
        
        protected void MainPage_Click(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                Response.Redirect("LogInPage.aspx");
            }
            else
            {
                Response.Redirect("ProfilPage.aspx");
            }

        }
        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}