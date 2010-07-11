﻿<%@ Control Language="C#" Inherits="Orchard.Mvc.ViewUserControl<IEnumerable<Orchard.ContentTypes.ViewModels.EditPartFieldViewModel>>" %>
<%
if (Model.Any()) { %>
    <fieldset><%
        foreach (var field in Model) {
            var f = field; %>
            <%:Html.EditorFor(m => f, "Field", field.Prefix) %><%
        } %>
    </fieldset><%
} %>