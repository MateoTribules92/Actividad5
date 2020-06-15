<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="EjemploLogQuinto.Admin1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabezera" runat="server">
    <style type="text/css">
        .auto-style1 {
            left: 0px;
            top: 0px;
        }
        .auto-style2 {
            width: 100%;
            height: 68px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_mensaje" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Contenido" runat="server">

    <asp:UpdatePanel ID="upanel" runat="server"> 
         <ContentTemplate>
             <div class="fh5co-loader"></div>
	
	<div id="page" class="auto-style1">
	<nav class="fh5co-nav" role="navigation">
		<!-- <div class="top-menu"> -->
			<div class="container">
				<div class="row">
					<div class="col-xs-12 text-center logo-wrap">
						<div id="fh5co-logo"><a href="index.html">Administrador<span>.</span></a></div>
					</div>
					<div class="col-xs-12 text-center menu-1 menu-wrap">
						<ul>
							<li class="active"><a href="index.html">Usuarios</a></li>
							<li><a href="menu.html">Tipo Usuarios</a></li>
							<li><a href="reservation.html">Proveedor</a></li>
							<li><a href="about.html">Producto</a></li>
							<li><a href="contact.html">Reportes</a></li>
						</ul>
					</div>
				</div>
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
			</div>
		<!-- </div> -->
	</nav>
        
	
	
	<!-- jQuery -->
	<script src="js/jquery.min.js"></script>
	<!-- jQuery Easing -->
	<script src="js/jquery.easing.1.3.js"></script>
	<!-- Bootstrap -->
	<script src="js/bootstrap.min.js"></script>
	<!-- Waypoints -->
	<script src="js/jquery.waypoints.min.js"></script>
	<!-- Waypoints -->
	<script src="js/jquery.stellar.min.js"></script>
	<!-- Flexslider -->
	<script src="js/jquery.flexslider-min.js"></script>
	<!-- Main -->
	<script src="js/main.js"></script>



             </ContentTemplate>
        </asp:UpdatePanel>
</asp:Content>
