<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="juegoGato.aspx.cs" Inherits="juegoGato" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
       <div id="sinMover" Style="left: 288px; top: 886px">
    <div class ="container-fluid mt-3">
     <asp:Panel ID="Panel1" runat="server"   style="margin-top: 0px; margin-left: 67px;" BackColor="#0000CC" Width="100%">
    
      <asp:UpdatePanel ID="upGato" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="false"  Width="100%">
        <ContentTemplate>

            <div class="row">
                  <div class="col-md-12 text-center text-white h2">
                      Juego gato
                  </div>
          </div>
    <div class="row">
    <div class="col-md-8 d-flex justify-content-center">

    <asp:Table runat="server"> 
       <asp:TableRow>
       <asp:TableCell>
        <asp:Button ID="btnMatriz1" Style="margin: 10px; color: black; font-size: 50px; font-weight: bold; min-height: 85px; max-height: 85px; min-width: 85px; max-width: 85px;" runat="server" BackColor="White" OnClick="btnMatriz1_Click" ClientIDMode="Static" />
        </asp:TableCell>

           <asp:TableCell>
        <asp:Button ID="btnMatriz2" Style="margin: 10px; color: black; font-size: 50px; font-weight: bold; min-height: 85px; max-height: 85px; min-width: 85px; max-width: 85px;"  runat="server" BackColor="White" OnClick="btnMatriz2_Click" />
        </asp:TableCell>

           <asp:TableCell>
        <asp:Button ID="btnMatriz3" Style="margin: 10px; color: black; font-size: 50px; font-weight: bold; min-height: 85px; max-height: 85px; min-width: 85px; max-width: 85px;"  runat="server" BackColor="White" OnClick="btnMatriz3_Click" />
      </asp:TableCell>
               </asp:TableRow>
       
       
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="btnMatriz4" Style="margin: 10px; color: black; font-size: 50px; font-weight: bold; min-height: 85px; max-height: 85px; min-width: 85px; max-width: 85px;"  runat="server" BackColor="White" OnClick="btnMatriz4_Click" />
            </asp:TableCell>

            <asp:TableCell>
                <asp:Button ID="btnMatriz5" Style="margin: 10px; color: black; font-size: 50px; font-weight: bold; min-height: 85px; max-height: 85px; min-width: 85px; max-width: 85px;"  runat="server" BackColor="White" OnClick="btnMatriz5_Click" />
            </asp:TableCell>

            <asp:TableCell>
                <asp:Button ID="btnMatriz6" Style="margin: 10px; color: black; font-size: 50px; font-weight: bold; min-height: 85px; max-height: 85px; min-width: 85px; max-width: 85px;"  runat="server" BackColor="White" OnClick="btnMatriz6_Click" />
            </asp:TableCell>
         </asp:TableRow>
        
        
             <asp:TableRow>
            <asp:TableCell>
            <asp:Button ID="btnMatriz7" Style="margin: 10px; color: black; font-size: 50px; font-weight: bold; min-height: 85px; max-height: 85px; min-width: 85px; max-width: 85px;"  runat="server" BackColor="White" OnClick="btnMatriz7_Click" />
       </asp:TableCell>

                <asp:TableCell>
        <asp:Button ID="btnMatriz8" Style="margin: 10px; color: black; font-size: 50px; font-weight: bold; min-height: 85px; max-height: 85px; min-width: 85px; max-width: 85px;"  runat="server" BackColor="White" OnClick="btnMatriz8_Click" />
        </asp:TableCell>

        <asp:TableCell>
        <asp:Button ID="btnMatriz9" Style="margin: 10px; color: black; font-size: 50px; font-weight: bold; min-height: 85px; max-height: 85px; min-width: 85px; max-width: 85px;"  runat="server" BackColor="White" OnClick="btnMatriz9_Click"/>
        </asp:TableCell>
        </asp:TableRow>

     
            </asp:Table>

          </div>

        <div class="col-md-4">
            <div class="row">
                <div class="col-md-12">
                    <asp:Image ID="img_002" runat="server" Height="100px" ImageUrl="https://img2.freepng.es/20180508/owe/kisspng-cat-silhouette-clip-art-5af1bbf5a605c9.6315595115257917336801.jpg" Width="110px" />
                </div>
            </div>
            <div class="row mt-3">
                <div class="col-md-12">
                    <asp:Label ID="lblFicha" runat="server" Text="Seleccione la ficha" CssClass="text-white h4"></asp:Label>
                    <br />
                    <asp:Button ID="btnFechaX" Text="X" Style="border: currentColor; color: black; font-size: 35px; font-weight: bold; min-height: 40px; max-height: 40px; min-width: 40px; max-width: 40px; background-color: transparent;" runat="server" OnClick="btnFechaX_Click" />
                    <asp:Button ID="btnFichaO" Text="O" Style="border: currentColor; color: black; font-size: 35px; font-weight: bold; min-height: 40px; max-height: 40px; min-width: 40px; max-width: 40px; background-color: transparent;" runat="server" OnClick="btnFichaO_Click" />
                </div>
            </div>
             <div class="row mt-3">
                <div class="col-md-12">
                      <asp:Button ID="Button1" runat="server" Text="REINICIAR" OnClick="Button1_Click"  style="font-size:20px"/>
                </div>
            </div>

        </div>


        </div>
           
       </ContentTemplate>
 
</asp:UpdatePanel>
          
               
        </asp:Panel>
       



        </div>
        </div>
   
    </asp:Content>

