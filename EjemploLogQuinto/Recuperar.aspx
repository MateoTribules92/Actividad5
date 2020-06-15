<%@ Page Title="" Language="C#" MasterPageFile="~/Recuperar.Master" AutoEventWireup="true" CodeBehind="Recuperar.aspx.cs" Inherits="EjemploLogQuinto.Recuperar1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabezera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_mensaje" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPagina" runat="server">
    <asp:UpdatePanel ID="upanel" runat="server"> 
         <ContentTemplate>

              <div class="form-group">
                    <asp:TextBox class="form-control" type="text" placeholder="Correo" ID="txt_Usuario_Recuperar" runat="server"></asp:TextBox>
                                </div>
                                
                                </div>
                                <div class="container-login100-form-btn">
                           <asp:Label ID="lbl_envio" runat="server" Text="" ForeColor="Green"></asp:Label>
                            <asp:Label ID="lbl_error" runat="server" Text="" ForeColor="Red"></asp:Label>
					</div>
                                <!-- Change this to a button or input when using this as a form -->
                                  <asp:Button ID="btn_recuperar" class="btn btn-lg btn-success btn-block" BackColor="LightCoral" runat="server" Text="RECUPERAR" OnClick="btnRecuperar_Click" /> 
				
         </ContentTemplate>

    </asp:UpdatePanel>
</asp:Content>
