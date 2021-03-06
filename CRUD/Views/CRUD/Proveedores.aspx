﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<CRUD.Models.ModeloCRUD>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Catálogo de Proveedores
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container" style="min-height:600px;">
        <div class="row centered mt grid">
            <h2>Catálogo de Proveedores</h2>
        </div>

        <button class="btn btn-theme" onclick="location.href='/CRUD/FormularioProveedor/0';" type="button">
            <i class="glyphicon glyphicon-plus"></i>
            Agregar Proveedor
        </button>

        <h2><%: Model.mensaje %></h2>

        <div class="form-panel">
            <div class="row mt">
            <div class="col-lg-12" style="overflow:auto; margin-left: 1%; width: 98%;height: 500px;">
               <% if (Model.listaProveedores != null) { %>
                       <% if (Model.listaProveedores.Count() > 0)
                          {%>
                                 <table class="table" border=0 cellpadding=0 cellspacing=0 style='border-collapse: collapse;width:100%'>
                                     <tr>
                                         <th style='width:5%;border-left:none;'>#</th>
                                         <th style='width:20%;border-left:none;'>Nombre</th>
                                         <th style='width:15%;border-left:none;'>Contacto</th>
                                         <th style='width:21%;border-left:none;'>Direccion</th>
                                         <th style='width:15%;border-left:none;'>Teléfono</th>
                                         <th style='width:10%;border-left:none;'>Estado</th>
                                         <th style='width:10%;border-left:none;'>Municipio</th>
                                         <th style='width:25%;border-left:none;'>Opciones</th>
                                     </tr>

                                    <% var i = 1; %>
                                    <% foreach (var item in Model.listaProveedores)
                                       { %>
                                    <tr>
                                        <td>
                                            <%: i++ %>
                                        </td>
                                        <td><%: item.CompanyName %></td>
                                        <td>
                                            <%: item.ContactName %>
                                        </td>
                                        <td>
                                            <%: item.Address %>
                                        </td>
                                        <td>
                                            <%: item.Phone %>
                                        </td>
                                        <td>
                                            <%: item.EstadoID %>
                                        </td>
                                        <td>
                                            <%: item.MunicipioID %>
                                        </td>
                                        <td>
                                            <button type="button" title="Editar" onclick="location.href='/CRUD/FormularioProveedor/<%: item.SupplierID %>';" >Editar</button>
                                            <button type="button" title="Eliminar"  onclick="showDelete(<%: item.SupplierID %>);" >Eliminar</button>
                                        </td>
                                    </tr>
                                    <% } %>
                              
                                 </table>

                            <%}  else {%>
                             <div class="form-group" style="margin-top:1%;">
                               <div class="alert alert-block  " style="background-color:#f68585; color:#000; ">
                                  <button type="button" class="close" data-dismiss="alert">×</button>
                                  <h4>No existen registros!</h4>
                                  <p id="P2" lingdex="103"> Favor de agregar un nuevo registro</p>
                                </div>
                             </div>
                           <%} %>
                <%} %>
                
            </div>
          </div>
        </div>

    </div>
    <input type="hidden" id="idElemento" />

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
    <script type="text/javascript">
        function showDelete(idEliminar) {
            $("#idElemento").val(idEliminar);
            if (confirm("¿Deseas eliminar el registro?!") == true) {
                Eliminar();
            }
        }
        function Eliminar() {
            location.href = '/CRUD/EliminarProveedor/' + $("#idElemento").val();
        }
    </script>
</asp:Content>