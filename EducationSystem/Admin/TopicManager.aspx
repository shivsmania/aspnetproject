<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="TopicManager.aspx.cs" Inherits="EducationSystem.Admin.TopicManager" %>

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
                        <label for="txtTopicName">Topic Name</label>
                        <input type="text" class="form-control" placeholder="Topic Name" runat="server" id="txtTopicName" required />
                    </div>
                    <div class="form-group">
                        <label for="txtTopicDesc">Topic Decription</label>
                        <textarea class="form-control" rows="5" runat="server" id="txtTopicDesc"></textarea>
                    </div>
                    <div class="form-group">
                        <label for="topicImg">Add Image</label>
                        <asp:FileUpload runat="server" ID="topicImg" required></asp:FileUpload>
                    </div>
                    <div class="form-group">
                        <label for="isActive">Active</label>
                        <asp:CheckBox Text="" ID="isActive" runat="server" />
                    </div>
                    <asp:Button Text="Add Topic" CssClass="btn btn-primary" ID="addBtn" runat="server" OnClick="addBtn_Click" />
                </div>
            </div>
            <div class="col-md-8">
                <div class="card">
                    <h4>All Topics </h4>
                    <asp:GridView runat="server" ID="topicGrid" AutoGenerateColumns="false" CssClass="table table-striped" BorderColor="#ffffff">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Image ImageUrl='<%# Bind("TopicImg") %>' ID="lblImg" runat="server" CssClass="img-circle" Width="50" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Topic Name">
                                <ItemTemplate>
                                    <asp:Label Text='<%# Bind("TopicName") %>' ID="lblName" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Topic Desc">
                                <ItemTemplate>
                                    <asp:Label Text='<%# Bind("TopicDesc") %>' ID="lblDesc" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Is Active">
                                <ItemTemplate>
                                    <asp:CheckBox Text="" Checked='<%# Bind("isActive") %>' ID="chkActive" runat="server" Enabled="false"/>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
