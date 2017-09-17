<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="QuestionManager.aspx.cs" Inherits="EducationSystem.Admin.QuestionManager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="header">
        <h4 class="title">Topic Manager</h4>
    </div>
    <div class="content">
        <div class="row">
            <div class="col-md-4">
                <div class="card">
                    <h4>Add Topic </h4>
                    <div class="alert <%= alertType +" "+ hidden %>" id="alertDiv">
                        <asp:Label Text="" ID="alertMsg" runat="server" />
                    </div>
                    <div class="form-group">
                        <label for="txtTopicName">Topic</label>
                        <asp:DropDownList runat="server" ID="drpTopic" CssClass="form-control" required>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="txtTopicName">Question</label>
                        <textarea class="form-control" placeholder="e.g, What is ASP.NET" rows="4" runat="server" id="txtQuestion" required></textarea>
                    </div>
                    <div class="form-group">
                        <label for="isActive">Answered</label>
                        <asp:CheckBox Text="" ID="isAnswered" runat="server" />
                    </div>
                    <div class="form-group">
                        <label for="isActive">Active</label>
                        <asp:CheckBox Text="" ID="isActive" runat="server" />
                    </div>
                    <asp:Button Text="Add Question" CssClass="btn btn-primary" ID="addBtn" runat="server" OnClick="addBtn_Click" />
                </div>
            </div>
            <div class="col-md-8">
                <div class="card">
                    <h4>All Topics </h4>
                    <asp:GridView runat="server" ID="queGrid" AutoGenerateColumns="false" CssClass="table table-striped" BorderColor="#ffffff">
                        <Columns>
                            <asp:TemplateField HeaderText="Question">
                                <ItemTemplate>
                                    <asp:Label Text='<%# Bind("QuestionString") %>' ID="lblName" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Topic">
                                <ItemTemplate>
                                    <asp:Label Text='<%# Bind("TopicId") %>' ID="lblTopId" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Is Answered">
                                <ItemTemplate>
                                    <asp:CheckBox Text="" Checked='<%# Bind("isAnswered") %>' ID="chkAns" runat="server" Enabled="false" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Is Active">
                                <ItemTemplate>
                                    <asp:CheckBox Text="" Checked='<%# Bind("isActive") %>' ID="chkActive" runat="server" Enabled="false" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Created Time">
                                <ItemTemplate>
                                    <asp:Label Text='<%# Bind("CreatedDateTime") %>' ID="lblcreatedate" runat="server" Enabled="false" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
