<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HostelManagement._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br /><br /><br />
    <div class="d-flex justify-content-center">
    <main class="card form-control-lg bg-light p-2 w-50">
        <div class="card-header bg-transparent">
            <span class="card-subtitle">
            Login
                </span>
        </div>
        <div class="card-body">
            <section class="" aria-labelledby="wardenLogin">
               <%--<div class="row"><span class="col-12 text-center">Warden Login</span></div>--%>
                <div class="row m-2">
                    <asp:Label runat="server" CssClass="col-6" Text="User Name"></asp:Label>
                    <asp:TextBox runat="server" CssClass="col-6" ID="username"></asp:TextBox>
                     <asp:RequiredFieldValidator runat="server" ControlToValidate="username"
                        Display="Dynamic" CssClass="text-danger" ErrorMessage="Email is required" />
                    <asp:ModelErrorMessage runat="server" ModelStateKey="username" CssClass="text-error" />
                </div>
                <div class="row m-2">
                    <asp:Label runat="server" CssClass="col-6" Text="Password"></asp:Label>
                    <asp:TextBox TextMode="Password" CssClass="col-6" runat="server" ID="password"></asp:TextBox>
                     <asp:RequiredFieldValidator runat="server" ControlToValidate="password"
    Display="Dynamic" CssClass="text-danger" ErrorMessage="Password is required" />
<asp:ModelErrorMessage runat="server" ModelStateKey="password" CssClass="text-error" />
                </div>
                

            </section>
        </div>
        <div class="card-footer bg-transparent">
            <div class="row m-2 d-flex justify-content-center align-content-center">
    <asp:Button runat="server" CssClass="btn btn-success w-50" Text="login" OnClick="Unnamed3_Click" />
                <asp:Label ID="msg" runat="server"></asp:Label>
                  <asp:Panel ID="ModalPanel" runat="server" Width="500px" Visible="false">
    <asp:Label ID="ModalLabel" runat="server" Text="Login failed. Please check your credentials."></asp:Label>
    <asp:Button ID="OKButton" runat="server" Text="Close" OnClientClick="closeModalPanel()"/>
</asp:Panel>
</div>
        </div>
        <%--<div class="col-6">
            <section class="" aria-labelledby="studentLogin">
                <div class="row"><span class="col-12 text-center">Student Login</span></div>
                <div class="row m-2">
                    <asp:Label runat="server" CssClass="col-3" Text="User Name"></asp:Label>
                    <asp:TextBox runat="server" CssClass="col-6" ID="TextBox1"></asp:TextBox>
                </div>
                <div class="row m-2">
                    <asp:Label runat="server" Text="Password" CssClass="col-3"></asp:Label>
                    <asp:TextBox TextMode="Password" runat="server" CssClass="col-6" ID="TextBox2"></asp:TextBox>
                </div>
                <div class="row d-flex m-2 justify-content-center align-content-center">
                    <asp:Button runat="server" CssClass="btn btn-success w-50" Text="login" OnClick="Unnamed6_Click" />
                </div>

            </section>
        </div>--%>


    </main>
        </div>
  
<%--    <div class="modal fade" runat="server" id="exampleModal" tabindex="-1" visible="false">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel">Modal title</h5>
        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
      </div>
      <div class="modal-body">
        <!-- Modal content goes here -->
       
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
        
      </div>
    </div>
  </div>
</div>--%>
    <script type="text/javascript">
        function closeModalPanel() {
            // Get a reference to the modal panel
            var modalPanel = document.getElementById('<%= ModalPanel.ClientID %>');

            // Set the display style of the modal panel to 'none' to hide it
            modalPanel.style.display = 'none';
        }
    </script>
    <br /><br /><br /><br />
</asp:Content>
