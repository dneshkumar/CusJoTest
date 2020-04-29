<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="SampleProject.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  
    <h3>Register Here</h3>
    <br />
    <h1 style="color:green;display:none;" runat="server" id="lblresult">New User Registered Successfully!!!</h1>
   <div class="form-group">
       <label >UserName</label>
       <asp:TextBox ID="txtUsername" runat="server" cssclass="form-control"/>
   </div>
      <div class="form-group">
       <label >Email</label>
       <asp:TextBox ID="txtEmailid" runat="server" cssclass="form-control" />
   </div>
      <div class="form-group">
       <label >Password</label>
       <asp:TextBox ID="txtPassword" runat="server" cssclass="form-control"/>
   </div>

    <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-success" Text="Register" OnClick="btnSubmit_Click"/>
</asp:Content>
