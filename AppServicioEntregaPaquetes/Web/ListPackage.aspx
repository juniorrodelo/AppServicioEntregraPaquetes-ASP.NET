<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListPackage.aspx.cs" Inherits="AppServicioEntregaPaquetes.Web.ListPackage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:FormView ID="FormView1" runat="server" AllowPaging="True" DataSourceID="ObjectDataSource1">
            <EditItemTemplate>
                Code:
                <asp:TextBox ID="CodeTextBox" runat="server" Text='<%# Bind("Code") %>' />
                <br />
                Weight:
                <asp:TextBox ID="WeightTextBox" runat="server" Text='<%# Bind("Weight") %>' />
                <br />
                CostXGrams:
                <asp:TextBox ID="CostXGramsTextBox" runat="server" Text='<%# Bind("CostXGrams") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Actualizar" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
            </EditItemTemplate>
            <InsertItemTemplate>
                Code:
                <asp:TextBox ID="CodeTextBox" runat="server" Text='<%# Bind("Code") %>' />
                <br />
                Weight:
                <asp:TextBox ID="WeightTextBox" runat="server" Text='<%# Bind("Weight") %>' />
                <br />
                CostXGrams:
                <asp:TextBox ID="CostXGramsTextBox" runat="server" Text='<%# Bind("CostXGrams") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insertar" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
            </InsertItemTemplate>
            <ItemTemplate>
                Code:
                <asp:Label ID="CodeLabel" runat="server" Text='<%# Bind("Code") %>' />
                <br />
                Weight:
                <asp:Label ID="WeightLabel" runat="server" Text='<%# Bind("Weight") %>' />
                <br />
                CostXGrams:
                <asp:Label ID="CostXGramsLabel" runat="server" Text='<%# Bind("CostXGrams") %>' />
                <br />

            </ItemTemplate>
        </asp:FormView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getPackages" TypeName="AppServicioEntregaPaquetes.Datos.PackagesRepositories"></asp:ObjectDataSource>
    
    </div>
    </form>
</body>
</html>
