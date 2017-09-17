using EducationSystem.BLL;
using EducationSystem.DLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EducationSystem.Admin
{
    public partial class QuestionManager : System.Web.UI.Page
    {
        QuestionController qc = new QuestionController();
        public string alertType;
        public string hidden;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                hidden = "hidden";
                fillData();
                fillTopics();

            }

        }

        private void fillTopics()
        {
            drpTopic.DataSource = qc.GetAllTopics();
            drpTopic.DataTextField = "TopicName";
            drpTopic.DataValueField = "TopicId";
            drpTopic.DataBind();
            drpTopic.Items.Insert(0, "Select Topic");
        }

        protected void addBtn_Click(object sender, EventArgs e)
        {
            Question q1 = new Question();
            q1.QuestionString = txtQuestion.Value;
            q1.TopicId = Convert.ToInt32(drpTopic.SelectedItem.Value);
            q1.isActive = isActive.Checked;
            q1.isAnswered = isAnswered.Checked;

            bool flag = qc.AddQuestion(q1);
            if (flag)
            {
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
        private void fillData()
        {
            queGrid.DataSource = qc.GetAllQuestions();
            queGrid.DataBind();
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
            txtQuestion.Value = "";
            isActive.Checked = false;
            isAnswered.Checked = false;
        }
    }
}