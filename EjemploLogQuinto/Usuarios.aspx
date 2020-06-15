<%@ Page Title="" Language="C#" MasterPageFile="~/Usuarios.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="EjemploLogQuinto.Usuarios1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabezera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_mensaje" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Contenido" runat="server">
    <asp:UpdatePanel ID="upanel" runat="server"> 
         <ContentTemplate>
              <section class="first-section">
          <div class="container">
            <div class="row">
              <div class="col-md-12">
                <div class="text-content">
                  <h2>BIENVENIDOS</h2>
                  <div class="line-dec"></div>

                    <br />
                <br />
                <br />
				
        <table class ="auto-style2">
        <tr>
            <td class=" text-left">Bienvenido al sistema:
                <asp:Label ID="lbl_mensaje" runat="server" ForeColor="White" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="text-left">
            <asp:Button ID="btn_Cerrar" runat="server"  ForeColor="Black" Text="Cerrar Session" OnClick="btn_Cerrar_Click" />
        </td>
        </tr>

	</table>
                    <br />
                    <br />

                    
    <div>
    
       
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">Calculadora </td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Numero 1 :</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                   
                    
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Numero 2 :</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" ></asp:TextBox>
                                    </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="+" />
                    &nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="-" />
                    &nbsp;<asp:Button ID="Button4" runat="server" Text="*" OnClick="Button4_Click" />
                    &nbsp;<asp:Button ID="Button5" runat="server" Text="/" OnClick="Button5_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Limpiar" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Resultado :</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
           
        </table>
    
       
    




    </div>
    

                  
                </div>
              </div>
            </div>
          </div>
        </section>

        <script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"></script>
        <script>window.jQuery || document.write('<script src="tem/js/vendor/jquery-1.11.2.min.js"><\/script>')</script>

        <script src="tem/js/vendor/bootstrap.min.js"></script>

        <script src="tem/js/plugins.js"></script>
        <script src="tem/js/main.js"></script>

             </ContentTemplate>
        </asp:UpdatePanel>
</asp:Content>
