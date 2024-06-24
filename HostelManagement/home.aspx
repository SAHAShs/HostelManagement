<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="HostelManagement.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:DropDownList ID="dp_list" AutoPostBack="true" runat="server"   OnSelectedIndexChanged="Unnamed_SelectedIndexChanged">
        <asp:ListItem Text="warden" Value="warden" Selected="True"></asp:ListItem>
        <asp:ListItem Text="student" Value="student" ></asp:ListItem>

    </asp:DropDownList>
   <asp:GridView runat="server" ID="data" AllowPaging="true"  ShowHeaderWhenEmpty="true" EmptyDataText="No record found" OnRowCommand="data_RowCommand" CssClass="w-50 table">
    <Columns>
        <asp:TemplateField>
            <ItemTemplate>
                <asp:LinkButton ID="editButton" runat="server" CommandName="Edit" Text="Edit" />
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField>
            <ItemTemplate>
                
                <asp:LinkButton ID="deleteButton" runat="server" CommandName="Delete" Text="Delete" OnClientClick="return confirm('Are you sure you want to delete this record?');" />
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField>
            <ItemTemplate>
                <asp:LinkButton ID="lockButton" runat="server" CommandName="Lock" Text="Lock" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
</asp:Content>
