<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="juegoGato.aspx.cs" Inherits="juegoGato" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="383px" style="margin-top: 0px; margin-left: 67px;" BackColor="#0000CC" Width="779px">
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnMatriz1" runat="server" BackColor="White" Height="85px" Width="85px" />
        &nbsp;
        <asp:Button ID="btnMatriz2" runat="server" Height="85px" Width="85px" BackColor="White" />
        &nbsp;
        <asp:Button ID="btnMatriz3" runat="server" Height="85px" Width="85px" BackColor="White" />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnMatriz4" runat="server" Height="85px" Width="85px" BackColor="White" />
        &nbsp;
        <asp:Button ID="btnMatriz5" runat="server" Height="85px" Width="85px" BackColor="White" />
        &nbsp;
        <asp:Button ID="btnMatriz6" runat="server" Height="85px" Width="85px" BackColor="White" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblJuego" runat="server" Font-Bold="True" ForeColor="White" Text="Seleccione la ficha"></asp:Label>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnMatriz7" runat="server" Height="85px" Width="85px" BackColor="White" />
        &nbsp;
        <asp:Button ID="btnMatriz8" runat="server" Height="85px" Width="85px" BackColor="White" />
        &nbsp;
        <asp:Button ID="btnMatriz9" runat="server" Height="85px" Width="85px" BackColor="White" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnIniciaPartida" runat="server" BorderColor="Black" Font-Bold="True" Height="43px" Text="JUGAR" Width="124px" />
    </asp:Panel>
    </asp:Content>
