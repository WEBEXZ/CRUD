<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<CRUD.Models.ModeloCRUD>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Formulario Proveedor
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div class="container" style="min-height:600px;">
    <% using (Html.BeginForm("FormularioProveedor", "CRUD", FormMethod.Post, new { id = "Formulario", name = "Formulario", @role = "form", @class = "form-inline" }))
    { %>
    <div class="row">
        <%: Html.HiddenFor(model => model.proveedor.SupplierID)%>       
        <div class="form-group col-md-6" >
            <label for="txtEstado">Nombre</label>
            <div class="input-group">
                <span class="input-group-addon">
                    <span class="fa fa-sort-numeric-asc"></span>
                </span>
                <%: Html.TextBoxFor(model => model.proveedor.CompanyName  , new { placeholder="Empresa...",  @class = "form-control"})%> 
                <%: Html.HiddenFor(model => model.proveedor.CompanyName, new { @class = "form-control"})%>
            </div>
        </div>       
        <div class="form-group col-md-6" >
            <label for="txtEstado">Contacto</label>
            <div class="input-group">
                <span class="input-group-addon">
                    <span class="fa fa-sort-numeric-asc"></span>
                </span>
                <%: Html.TextBoxFor(model => model.proveedor.ContactName  , new { placeholder="Contacto",  @class = "form-control", @required="required"})%> 
                <%: Html.HiddenFor(model => model.proveedor.ContactName, new { @class = "form-control"})%>
            </div>
        </div>
        <div class="form-group col-md-6" >
            <label for="txtEstado">Dirección</label>
            <div class="input-group">
                <span class="input-group-addon">
                    <span class="fa fa-sort-numeric-asc"></span>
                </span>
                <%: Html.TextBoxFor(model => model.proveedor.Address  , new { placeholder="Dirección",  @class = "form-control", @required="required"})%> 
                <%: Html.HiddenFor(model => model.proveedor.Address, new { @class = "form-control"})%>
            </div>
        </div>
        <div class="form-group col-md-6" >
            <label for="txtEstado">Teléfono</label>
            <div class="input-group">
                <span class="input-group-addon">
                    <span class="fa fa-sort-numeric-asc"></span>
                </span>
                <%: Html.TextBoxFor(model => model.proveedor.Phone, new { placeholder = "Teléfono", @class = "form-control" })%> 
                <%: Html.HiddenFor(model => model.proveedor.Phone, new { @class = "form-control"})%>
            </div>
        </div>

        
    </div>
    <div class="row  form-group" style="width:100%; margin-top:25px;">
        <div class=" col-md-12 text-left" >
            <button type="submit" class="btn btn-success"><i class="glyphicon glyphicon-save"></i> Guardar </button>
            <button type="button" class="btn btn-default" onclick="location.href='/CRUD/Proveedores'" ><i class="glyphicon glyphicon-remove"></i> Cancelar</button>
        </div>
    </div>
    <%} %>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
