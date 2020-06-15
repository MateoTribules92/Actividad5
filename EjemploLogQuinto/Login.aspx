<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EjemploLogQuinto.Login1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabezera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_mensaje" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPagina" runat="server">
    <asp:UpdatePanel ID="upanel" runat="server"> 
         <ContentTemplate>

              <div class="form-group">
                    <asp:TextBox class="form-control" type="text" placeholder="Usuario" ID="txt_Usuario" runat="server"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                     <asp:TextBox class="form-control" type="password" placeholder="Password" ID="txt_Pass" runat="server"></asp:TextBox>
                                </div>
                                <div class="container-login100-form-btn">
                            <asp:Label ID="lbl_intentos" runat="server" Text="" ForeColor="Black"></asp:Label>
                            <asp:Label ID="lbl_mensaje" runat="server" Text="" ForeColor="Red"></asp:Label>
					</div>
             
                                <!-- Change this to a button or input when using this as a form -->
                                  <asp:Button ID="btn_Entrar" class="btn btn-lg btn-success btn-block" runat="server" Text="INGRESAR" OnClick="btnEntrar_Click" /> 
					<td>

                        <asp:LinkButton ID="lnk_button" runat="server" OnClick="lnk_button_Click">Olvido su contrasena?</asp:LinkButton>
                        <asp:Button ID="btn_olvido" runat="server" Text="Recuperar" Visible="false" OnClick="btn_olvido_Click" />

             </td>

         </ContentTemplate>

    </asp:UpdatePanel>
</asp:Content>
