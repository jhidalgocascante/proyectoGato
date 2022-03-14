using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

using gatoNameSpace;



public partial class juegoGato : System.Web.UI.Page
    {
    
        private int[,] matriz = new int[2, 2];
   
        private int estadoParticipante = -1;

    //Se genera una variable tipo matriz que utiliza viewstate para almacenar de forma persistente el valor de la clase
    private gatoControl gato
    {
        get { return ViewState["gatoControl"] != null ? (gatoControl)ViewState["gatoControl"] : new gatoControl(); }
        set { ViewState["gatoControl"] = value; }
    }

    public int valorJugador
    {
        get { return ViewState["valorJugador"] != null ? (int)ViewState["valorJugador"] : valorJugador; }
        set { ViewState["valorJugador"] = value; }
    }

    public int valorMaquina
    {
        get { return ViewState["valorMaquina"] != null ? (int)ViewState["valorMaquina"] : valorMaquina; }
        set { ViewState["valorMaquina"] = value; }
    }

    public void Page_Load(object sender, EventArgs e)
        {
            //Solo se debe cargar la primera vez que ingrese o cuando se le de al boton de reinicio
            if (!IsPostBack)
            {
                gato = new gatoControl();
                //System.Diagnostics.Debug.WriteLine("CARGA PRIMERA VEZ Page_load");
                gato.inicializarPartida(1);
                valorJugador = 0;
                valorMaquina = 1;
        }
        else
        {
            //System.Diagnostics.Debug.WriteLine("CARGA SEGUNDA VEZ Page_load");
            for (int i = 0; i < gato.Matriz.GetLength(0); i++)
                for (int j = 0; j < gato.Matriz.GetLength(1); j++)
                {
                    //Matriz[i, j] = -1;
                    System.Diagnostics.Debug.WriteLine("ENTRO A INICIARLIZAR PARTIDA:i:" + i + "-j:" + j + ":valor:" + gato.Matriz[i, j]);
                }

        }

    }

    //definimos el mensaje que se muestra en pantalla
    private void mensaje (string texto){
        ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "script", "alert('" + texto + "');", true);
    }


    //Inicializa las variables para una nueva partida
    private void reseteaPartida() {
        //Se inicializa la clase
        gato = new gatoControl();

        //Se colocan de nuevo la matriz con -1
        gato.inicializarPartida(1);

        //No existe ganador
        estadoParticipante = -1;

        //Se inicializan los botones
        btnMatriz1.Text = btnMatriz2.Text = btnMatriz3.Text = btnMatriz4.Text = btnMatriz5.Text = btnMatriz6.Text = btnMatriz7.Text = btnMatriz8.Text = btnMatriz9.Text = String.Empty;

    }

    //Siempre marcamos como X
    private void accionBoton(int x, int y, Button boton)
        {
            if (gato.Matriz[x, y] == -1)
            {
                gato.marcaMatriz(x, y);
                estadoParticipante = gato.validaGanePartida();
                //boton.Text = "X";
                if (valorJugador == 0) boton.Text = "0";
                else boton.Text = "X";


            //valorJugador = 2;
            //valorMaquina = 1;

            comprobarGanador();
            }
        }

        private void comprobarGanador()
        {
            int[] arrayJugada = gato.MejorJugadaMinMax;
            string texto;

            if (valorJugador == 0) texto = "X";
            else texto = "0";

        if (arrayJugada[0] == 0 && arrayJugada[1] == 0) btnMatriz1.Text = texto;// "0";
        if (arrayJugada[0] == 0 && arrayJugada[1] == 1) btnMatriz2.Text = texto;// "0";
        if (arrayJugada[0] == 0 && arrayJugada[1] == 2) btnMatriz3.Text = texto;// "0";

        if (arrayJugada[0] == 1 && arrayJugada[1] == 0) btnMatriz4.Text = texto;// "0";
        if (arrayJugada[0] == 1 && arrayJugada[1] == 1) btnMatriz5.Text = texto;// "0";
        if (arrayJugada[0] == 1 && arrayJugada[1] == 2) btnMatriz6.Text = texto;// "0";

        if (arrayJugada[0] == 2 && arrayJugada[1] == 0) btnMatriz7.Text = texto;// "0";
        if (arrayJugada[0] == 2 && arrayJugada[1] == 1) btnMatriz8.Text = texto;// "0";
        if (arrayJugada[0] == 2 && arrayJugada[1] == 2) btnMatriz9.Text = texto;// "0";

        if (estadoParticipante == 0)
        {
            mensaje("¡Ganaste! ¡Felicidades!");
            reseteaPartida();
        }

        if (estadoParticipante == 1)
        {
            mensaje("Perdiste, Ganó la máquina :( ");
            reseteaPartida();
        }

        if (estadoParticipante == -1 && gato.validaMatrizLlena()) {
            mensaje("¡Empate con la máquina!");
            reseteaPartida();
        }

    }

    protected void btnMatriz1_Click(object sender, EventArgs e)
        {
            accionBoton(0, 0, btnMatriz1);
            upGato.Update();
        }

        protected void btnMatriz2_Click(object sender, EventArgs e)
        {
            accionBoton(0, 1, btnMatriz2);
            upGato.Update();
        }

        protected void btnMatriz3_Click(object sender, EventArgs e)
        {
            accionBoton(0, 2, btnMatriz3);
            upGato.Update();
        }

        protected void btnMatriz4_Click(object sender, EventArgs e)
        {
            accionBoton(1, 0, btnMatriz4);
            upGato.Update();
        }

        protected void btnMatriz5_Click(object sender, EventArgs e)
        {
            accionBoton(1, 1, btnMatriz5);
            upGato.Update();
        }

        protected void btnMatriz6_Click(object sender, EventArgs e)
        {
            accionBoton(1, 2, btnMatriz6);
            upGato.Update();
        }

        protected void btnMatriz7_Click(object sender, EventArgs e)
        {
            accionBoton(2, 0, btnMatriz7);
            upGato.Update();
        }

        protected void btnMatriz8_Click(object sender, EventArgs e)
        {
            accionBoton(2, 1, btnMatriz8);
            upGato.Update();
        }

        protected void btnMatriz9_Click(object sender, EventArgs e)
        {
            accionBoton(2, 2, btnMatriz9);
            upGato.Update();
        }



    protected void Button1_Click(object sender, EventArgs e)
    {
        //Si volvemos a presionar el boton de Jugar
        reseteaPartida();
        upGato.Update();
    }

    protected void btnFichaO_Click(object sender, EventArgs e)
    {
        valorJugador = 0;
        valorMaquina = 1;
    }

    protected void btnFechaX_Click(object sender, EventArgs e)
    {
        valorJugador = 1;
        valorMaquina = 0;
    }
}
