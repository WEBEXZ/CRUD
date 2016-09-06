<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<CRUD.Models.ModeloCRUD>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Formulario Producto
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
<div class="container" style="min-height:600px;">
    <% using (Html.BeginForm("FormularioProducto", "CRUD", FormMethod.Post, new { id = "Formulario", name = "Formulario", @role = "form", @class = "form-inline" }))
    { %>
    <div class="row">
        <%: Html.HiddenFor(model => model.producto.ProductID)%>       
        <div class="form-group col-md-6" >
            <label for="txtEstado">Nombre</label>
            <div class="input-group">
                <span class="input-group-addon">
                    <span class="fa fa-sort-numeric-asc"></span>
                </span>
                <%: Html.TextBoxFor(model => model.producto.ProductName  , new { placeholder="Arroz, Frijol...",  @class = "form-control"})%> 
                <%: Html.HiddenFor(model => model.producto.ProductName, new { @class = "form-control"})%>
            </div>
        </div>       
        <div class="form-group col-md-6" >
            <label for="txtEstado">Precio Unitario</label>
            <div class="input-group">
                <span class="input-group-addon">
                    <span class="fa fa-sort-numeric-asc"></span>
                </span>
                <%: Html.TextBoxFor(model => model.producto.UnitPrice  , new { placeholder="12",  @class = "form-control", @required="required"})%> 
                <%: Html.HiddenFor(model => model.producto.UnitPrice, new { @class = "form-control"})%>
            </div>
        </div>
        <div class="form-group col-md-6" >
            <label for="txtEstado">Unidades en Pila</label>
            <div class="input-group">
                <span class="input-group-addon">
                    <span class="fa fa-sort-numeric-asc"></span>
                </span>
                <%: Html.TextBoxFor(model => model.producto.UnitsInStock  , new { placeholder="10",  @class = "form-control", @required="required"})%> 
                <%: Html.HiddenFor(model => model.producto.UnitsInStock, new { @class = "form-control"})%>
            </div>
        </div>
        <div class="form-group col-md-6" >
            <label for="txtEstado">Unidades en Orden</label>
            <div class="input-group">
                <span class="input-group-addon">
                    <span class="fa fa-sort-numeric-asc"></span>
                </span>
                <%: Html.TextBoxFor(model => model.producto.UnitsOnOrder, new { placeholder = "1", @class = "form-control" })%> 
                <%: Html.HiddenFor(model => model.producto.UnitsOnOrder, new { @class = "form-control"})%>
            </div>
        </div>

        <div class="form-group col-md-6" >
            <label for="txtEstado">Categoría</label>
            <div class="input-group">
                <span class="input-group-addon">
                    <span class="fa fa-sort-numeric-asc"></span>
                </span>
                <%: Html.DropDownListFor(m => m.producto.CategoryID, ViewBag.nombreCategorias as SelectList, "Categorias...", new { })%>
            </div>
        </div>

        <div class="form-group col-md-6" >
            <label for="txtEstado">Proveedor</label>
            <div class="input-group">
                <span class="input-group-addon">
                    <span class="fa fa-sort-numeric-asc"></span>
                </span>
                <%: Html.DropDownListFor(m => m.producto.SupplierID, ViewBag.nombreProveedores as SelectList, "Proveedores...", new { })%>
            </div>
        </div>
    </div>
    <div class="row  form-group" style="width:100%; margin-top:25px;">
        <div class=" col-md-12 text-left" >
            <button type="submit" class="btn btn-success"><i class="glyphicon glyphicon-save"></i> Guardar</button>
            <button type="button" class="btn btn-default" onclick="location.href='/CRUD/Productos'" ><i class="glyphicon glyphicon-remove"></i> Cancelar</button>
        </div>
    </div>
    <%} %>
</div>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
