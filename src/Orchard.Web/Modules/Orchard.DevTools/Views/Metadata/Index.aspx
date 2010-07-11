<%@ Page Language="C#" Inherits="Orchard.Mvc.ViewPage<MetadataIndexViewModel>" %>

<%@ Import Namespace="Orchard.DevTools.ViewModels" %>
<style title="text/css">
    ul
    {
        margin-left: 12px;
    }
</style>
<h1>
    Metadata</h1>
<h2>
    Content Type Definitions</h2>
<ul>
    <%foreach (var type in Model.TypeDefinitions) {%>
    <li>
        <%:type.Name %>
        <ul>
            <%foreach (var part in type.Parts) {%>
            <li>
                <%:part.PartDefinition.Name %></li>
            <%
                }%>
        </ul>
    </li>
    <%
        }%>
</ul>
<h2>
    Content Part Definitions</h2>
<ul>
    <%foreach (var part in Model.PartDefinitions) {%>
    <li>
        <%:part.Name %></li>
    <%
        }%>
</ul>
<h2>
Exported as xml</h2>
<% using (Html.BeginFormAntiForgeryPost()) { %>
<%:Html.TextAreaFor(m=>m.ExportText, new{style="width:100%;height:640px;"}) %>
<br />
<input class="button primaryAction" type="submit" value="<%: T("Merge Changes") %>" />
<%} %>
