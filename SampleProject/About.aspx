<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="SampleProject.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Assign Pages to Users</h2>
    <br />

    <asp:DropDownList ID="drpUsers" runat="server" CssClass="form-control" OnSelectedIndexChanged="drpUsers_SelectedIndexChanged" AutoPostBack="true">
    <asp:ListItem Selected="True" Text="--Select--" Value="--Select--"></asp:ListItem>
    <asp:ListItem Text="User1" Value="User1"></asp:ListItem>
    <asp:ListItem Text="User2" Value="User2"></asp:ListItem>
    <asp:ListItem Text="User3" Value="User3"></asp:ListItem>
    <asp:ListItem Text="User4" Value="User4"></asp:ListItem>
        </asp:DropDownList>

    <div class="col-lg-12" style="margin-top:3%;margin-bottom:3%;">
        <asp:UpdatePanel ID="page1" runat="server">
            <ContentTemplate>
                <div class="row">
                <div class="col-lg-2 " >
                <asp:Label ID="lblpage1" runat="server" Width="" Text="Page 1" />
                </div>
                    <div class="col-lg-1 ">
                <input ID="Page1LinkToggle" runat="server" type="checkbox"  data-toggle="toggle" data-on="Allow" data-off="Deny" data-onstyle="success" data-offstyle="warning">
           </div> </div>
            </ContentTemplate>
        </asp:UpdatePanel>

        <asp:UpdatePanel ID="page2" runat="server">
            <ContentTemplate>
                <div class="row">
                <div class="col-lg-2 " >
                <asp:Label ID="lblpage2" runat="server" Width="" Text="Page 2"  />
                </div>
                    <div class="col-lg-1 ">
                <input ID="Page2LinkToggle" runat="server" type="checkbox"  data-toggle="toggle" data-on="Allow" data-off="Deny" data-onstyle="success" data-offstyle="warning">
           </div> </div>
            </ContentTemplate>
        </asp:UpdatePanel>

        <asp:UpdatePanel ID="page3" runat="server">
            <ContentTemplate>
                <div class="row">
                <div class="col-lg-2 " >
                <asp:Label ID="lblpage3" runat="server" Width="" Text="Page 3" />
                </div>
                    <div class="col-lg-1 ">
                <input ID="Page3LinkToggle" runat="server" type="checkbox" data-toggle="toggle" data-on="Allow" data-off="Deny" data-onstyle="success" data-offstyle="warning">
           </div> </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
     <h1 style="color:green;display:none;" runat="server" id="lblresult">Saved Successfully!!!</h1>

    <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-success" OnClick="btnSubmit_Click"/>
</asp:Content>
