using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Web;
using System.Web.Configuration;
using TicketServices.DAO;

namespace TicketServices.WebForm
{
    public partial class UserLogin : System.Web.UI.Page
    {
       GetData gdata = new GetData();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            try
            {

                var host = Dns.GetHostEntry(Dns.GetHostName());
                string IPAddress = (from ip in host.AddressList where ip.AddressFamily == AddressFamily.InterNetwork select ip.ToString()).FirstOrDefault();
                txtuser.Focus();
                if (!String.IsNullOrEmpty(Request.QueryString["Logout"]) && Request.QueryString["Logout"].ToString() == "True")
                {
                    HttpCookie veCook = Request.Cookies["uLoginInfo"];
                    if (veCook != null)
                    {
                        veCook.Expires = DateTime.Now.AddDays(-1d);
                        Response.Cookies.Add(veCook);
                        Response.Redirect("Default.aspx", false);
                    }
                }
                HttpCookie uLogincook = Request.Cookies["uLoginInfo"];
                if (uLogincook != null)
                {
                    Response.Redirect("Default.aspx", false);
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Please contact administrator for assistant.')</script>");
                //   al.WriteErrorLog(ex.Message, "Login Formload", "");

            }
            txtuser.Focus();
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            String iuser = txtuser.Text.Replace(" ", "");
            String ipass = txtpass.Text;
            HttpCookie uLogincook = new HttpCookie("uLoginInfo");

            try
            {
                //EncryptingappSettings(); comment out in testing
                if (isCompleteLogin())
                {
                     List<SUser> iResult = gdata.GetUsers(0, iuser, ipass);
                    if (iResult != null && iResult.Count == 1)
                    {
                        uLogincook["Name"] = iResult[0].UserName;
                        uLogincook["ID"] = iResult[0].Id.ToString();

                        Response.Cookies.Add(uLogincook);
                        Response.Redirect("Default.aspx", false);
                    }
                    else
                    {
                        Response.Write("<script LANGUAGE='JavaScript' >alert('Incorrect User Information!')</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Please contact administrator for assistant.')</script>");
                if (uLogincook != null)
                {
                    //  al.WriteErrorLog(ex.Message, "Login Click", "IP Address=" + uLoginIP["IPAddress"] + ",LoginID=" + iuser + ",Password(Before Encrypt)=+" + ipass);
                }
            }
        }
        private void EncryptingappSettings()
        {
            try
            {
                Configuration config = WebConfigurationManager.OpenWebConfiguration("~");
                ConfigurationSection configStrings = config.GetSection("appSettings");


                if (configStrings != null && configStrings.SectionInformation.IsProtected == false)
                {
                    configStrings.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                    configStrings.SectionInformation.ForceSave = true;
                    config.Save(ConfigurationSaveMode.Full);
                }
            }
            catch (Exception ex)
            {
               
            }
        }
        protected bool isCompleteLogin()
        {
            if (String.IsNullOrEmpty(txtuser.Text))
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('User Name Required!')</script>");
                txtuser.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtpass.Text))
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Password Required!')</script>");
                txtpass.Focus();
                return false;
            }
            else return true;
        }

    }
}