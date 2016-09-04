<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<CRUD.Models.ModeloCRUD>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Formulario Empleado
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div class="container" style="min-height:600px;">
    <% using (Html.BeginForm("FormularioEmpleado", "CRUD", FormMethod.Post, new { id = "Formulario", name = "Formulario", @role = "form", @class = "form-inline" }))
    { %>
    <div class="row">
        <%: Html.HiddenFor(model => model.empleado.EmployeeID)%>       
        <div class="form-group col-md-6" >
            <label for="txtEstado">Título de cortesía</label>
            <div class="input-group">
                <span class="input-group-addon">
                    <span class="fa fa-sort-numeric-asc"></span>
                </span>
                <%: Html.TextBoxFor(model => model.empleado.TitleOfCourtesy  , new { placeholder="Sr, Sra, Srita...",  @class = "form-control"})%> 
                <%: Html.HiddenFor(model => model.empleado.TitleOfCourtesy, new { @class = "form-control"})%>
            </div>
        </div>       
        <div class="form-group col-md-6" >
            <label for="txtEstado">Nombre del empleado</label>
            <div class="input-group">
                <span class="input-group-addon">
                    <span class="fa fa-sort-numeric-asc"></span>
                </span>
                <%: Html.TextBoxFor(model => model.empleado.FirstName  , new { placeholder="NOMBRE",  @class = "form-control", @required="required"})%> 
                <%: Html.HiddenFor(model => model.empleado.FirstName, new { @class = "form-control"})%>
            </div>
        </div>
        <div class="form-group col-md-6" >
            <label for="txtEstado">Apellido</label>
            <div class="input-group">
                <span class="input-group-addon">
                    <span class="fa fa-sort-numeric-asc"></span>
                </span>
                <%: Html.TextBoxFor(model => model.empleado.LastName  , new { placeholder="APELLIDO",  @class = "form-control", @required="required"})%> 
                <%: Html.HiddenFor(model => model.empleado.LastName, new { @class = "form-control"})%>
            </div>
        </div>
        <div class="form-group col-md-6" >
            <label for="txtEstado">Puesto</label>
            <div class="input-group">
                <span class="input-group-addon">
                    <span class="fa fa-sort-numeric-asc"></span>
                </span>
                <%: Html.TextBoxFor(model => model.empleado.Title, new { placeholder = "PUESTO", @class = "form-control" })%> 
                <%: Html.HiddenFor(model => model.empleado.Title, new { @class = "form-control"})%>
            </div>
        </div>

        
    </div>
    <div class="row  form-group" style="width:100%; margin-top:25px;">
        <div class=" col-md-12 text-left" >
            <button type="submit" class="btn btn-success"><i class="glyphicon glyphicon-save"></i> Guardar </button>
            <button type="button" class="btn btn-default" onclick="location.href='/CRUD'" ><i class="glyphicon glyphicon-remove"></i> Cancelar</button>
        </div>
    </div>
    <%} %>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
