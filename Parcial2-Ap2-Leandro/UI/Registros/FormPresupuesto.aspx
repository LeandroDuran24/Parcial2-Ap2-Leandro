<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormPresupuesto.aspx.cs" Inherits="Parcial2_Ap2_Leandro.UI.Registros.FormPresupuesto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>

    <link rel="stylesheet" href="/Content/bootstrap.min.css" />
    <link rel="stylesheet" href="/Content/bootstrap.min.js" />
    <link rel="stylesheet" href="Content/bootstrapTheme.min.css" />
</head>
<body>


    <form id="form1" runat="server">

        <h1 class="text-center">Registro Presupuesto</h1>

        <!--id-->
        <div class="text-center">
            <div>
                <label for="id">Id Presupuesto </label>
            </div>
        </div>

        <div class="text-center">

            <asp:TextBox ID="IdTextBox" runat="server"></asp:TextBox>
            <asp:Button ID="Buscar" CssClass="btn btn-danger btn-md" runat="server" Text="Buscar" Width="105px" OnClick="Buscar_Click" />

        </div>
        <!--fecha-->

        <div class="text-center">
            <div>
                <label for="fecha">Fecha</label>
            </div>
        </div>
        <div class="text-center">
            <asp:TextBox ID="FechaTextbox" runat="server" Width="300px" Height="33px"></asp:TextBox>

        </div>

        <!--descripcion-->
        <div class="text-center">
            <div>
                <label for="descripcion">Descripcion</label>
            </div>
        </div>
        <div class="text-center">
            <asp:TextBox ID="DescripcionTextbox" runat="server" Width="300px" Height="33px"></asp:TextBox>

        </div>

        <!--monto-->
        <div class="text-center">
            <div>
                <label for="monto">Monto</label>
            </div>
        </div>
        <div class="text-center">
            <asp:TextBox ID="MontoTextbox" runat="server" Width="300px" Height="33px"></asp:TextBox>

        </div>

        <!--meta-->

        <div class="text-center">
            <div>
                <label for="Meta">Meta</label>
            </div>
        </div>
        <div class="text-center">
            <asp:TextBox ID="MetaTextbox" runat="server" Width="300px" Height="33px"></asp:TextBox>
        </div>

        <!--logrado-->
        <div class="text-center">
            <div>
                <label for="logrado">Logrado</label>
            </div>
        </div>
        <div class="text-center">
            <asp:TextBox ID="LogradoTextbox" runat="server" Width="191px" Height="33px"></asp:TextBox>


            <asp:Button ID="Agregar" CssClass="btn btn-danger btn-md" runat="server" Text="Agregar" Width="105px" OnClick="Agregar_Click" />


            <br />


        </div>

        <!--tabla-->
        <div class="text-center">
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>

        <!--botones-->
        <div class="text-center">

            <asp:Button ID="Nuevo" CssClass="btn btn-danger btn-md " runat="server" Text="Nuevo" Width="125px" OnClick="Nuevo_Click" />&nbsp&nbsp
                    <asp:Button ID="guardar" CssClass="btn btn-danger btn-md " runat="server" Text="Guardar" Width="125px" OnClick="guardar_Click" />&nbsp;&nbsp&nbsp
                    <asp:Button ID="Eliminar" CssClass="btn btn-danger btn-md " runat="server" Text="Eliminar" Width="125px" />
        </div>

        <script src="/Content/jquery-2.2.0.min.js"></script>

    </form>

</body>
</html>
