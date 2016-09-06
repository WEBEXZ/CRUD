<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<CRUD.Models.ModeloCRUD>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Formulario Categorias
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div class="container" style="min-height:600px;">
    <% using (Html.BeginForm("FormularioCategoria", "CRUD", FormMethod.Post, new { id = "Formulario", name = "Formulario", @role = "form", @class = "form-inline" }))
    { %>
    <div class="row">
        <%: Html.HiddenFor(model => model.categoria.CategoryID)%>       
        <div class="form-group col-md-6" >
            <label for="txtEstado">Nombre</label>
            <div class="input-group">
                <span class="input-group-addon">
                    <span class="fa fa-sort-numeric-asc"></span>
                </span>
                <%: Html.TextBoxFor(model => model.categoria.CategoryName  , new { placeholder="Demostracion...",  @class = "form-control"})%> 
                <%: Html.HiddenFor(model => model.categoria.CategoryName, new { @class = "form-control"})%>
            </div>
        </div>       
        <div class="form-group col-md-6" >
            <label for="txtEstado">Descripción</label>
            <div class="input-group">
                <span class="input-group-addon">
                    <span class="fa fa-sort-numeric-asc"></span>
                </span>
                <%: Html.TextBoxFor(model => model.categoria.Description  , new { placeholder="Demostracion",  @class = "form-control", @required="required"})%> 
                <%: Html.HiddenFor(model => model.categoria.Description, new { @class = "form-control"})%>
            </div>
        </div>
        <div class="form-group col-md-6" >
            <label for="txtEstado">Imagen</label>
            <div class="input-group">
                <span class="input-group-addon">
                    <span class="fa fa-sort-numeric-asc"></span>
                </span>
            </div>
        </div>
    </div>
    <div class="row  form-group" style="width:100%; margin-top:25px;">
        <div class=" col-md-12 text-left" >
            <button type="submit" class="btn btn-success"><i class="glyphicon glyphicon-save"></i> Guardar </button>
            <button type="button" class="btn btn-default" onclick="location.href='/CRUD/Categorias'" ><i class="glyphicon glyphicon-remove"></i> Cancelar</button>
        </div>
    </div>
    <%} %>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
