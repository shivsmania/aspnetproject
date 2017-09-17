using EducationSystem.BLL;
using EducationSystem.DLL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EducationSystem.Admin
{
    public partial class TopicManager : System.Web.UI.Page
    {
        TopicController tc = new TopicController();
        public string alertType;
        public string hidden;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                hidden = "hidden";
                fillData();
            }
        }

        private void fillData()
        {
            topicGrid.DataSource = tc.GetAllTopics();
            topicGrid.DataBind();
        }

        protected void addBtn_Click(object sender, EventArgs e)
        {
            string path1 = "";
            Topics t1 = new Topics();
            t1.TopicName = txtTopicName.Value;
            t1.TopicDesc = txtTopicDesc.Value;
            t1.isActive = isActive.Checked;

            if (topicImg.HasFile)
            {
                string imgExt = Path.GetExtension(topicImg.PostedFile.FileName);
                if (imgExt == ".png" || imgExt == ".jpg")
                {
                    path1 = "/Uploads/Topics/" + Guid.NewGuid() + topicImg.PostedFile.FileName;
                    t1.TopicImg = path1;
                    bool flag = tc.AddTopic(t1);
                    if (flag)
                    {
                        topicImg.SaveAs(Server.MapPath(path1));
                        alertMsg.Text = "Topic added successfully.";
                        fillData();
                        SendSuccess();
                        clearAll();
                    }
                    else
                    {
                        alertMsg.Text = "Something wrong!.";
                        SendError();
                    }
                }
                else
                {
                    alertMsg.Text = "Please upload only Png and Jpg.";
                    SendError();
                }
            }
            else
            {
                alertMsg.Text = "Please upload an Image.";
                SendError();
            }

        }

        private void SendError()
        {
            hidden = "visible";
            this.alertType = "alert-danger";
        }
        private void SendSuccess()
        {
            hidden = "visible";
            this.alertType = "alert-success";
        }
        private void clearAll()
        {
            txtTopicName.Value = "";
            txtTopicDesc.Value = "";
            isActive.Checked = false;
        }
    }
}