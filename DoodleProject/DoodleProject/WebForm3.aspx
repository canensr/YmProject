<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="DoodleProject.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <th> ID </th>
                    <th> Etkinlik Konusu </th>
                    <th> Açıklama </th>
                    <th> Süre </th>
                    <th> Tarih </th>
                </tr>
                @foreach (var item in Model)
                {
                    <tr>
                        <td>@item.ActivityID</td>
                        <td>@item.ActivitySubject</td>
                        <td>@item.ActivityExplanation</td>
                        <td>@item.ActivityDuration</td>
                        <td>@item.ActivityDate</td>
                    </tr>
                }
            </table>
            <asp:RadioButton ID="RadioButton2" runat="server" />
            @Html.TextBoxFor(x => x.ActivitySubject, new { @class = "form-control" })
        </div>
    </form>
</body>
</html>

