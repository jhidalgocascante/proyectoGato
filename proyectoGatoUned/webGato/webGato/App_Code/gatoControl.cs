
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace con la clase y metodos propios de control de la matriz general
namespace gatoNameSpace{
    //Se coloca serializable para poder ser utilizado desde el elemento viewState
    [Serializable]

    public class gatoControl
    {
        private int[] mejorJugadaMinMax = new int[3];

        public int[,] Matriz { get; set; } = new int[3, 3];
        public int existeGanador { get; set; } = -1;
 
        public int[] MejorJugadaMinMax { get => mejorJugadaMinMax; set => mejorJugadaMinMax = value; }

        //Se marca la matriz 
        public void marcaMatriz(int x, int y)
        {
            if (x >= 0 && x < 3 && y >= 0 && y < 3 && Matriz[x, y] == -1 && existeGanador == -1)
            {
                Matriz[x, y] = 0;
                existeGanador = validaGanePartida();
                metodoRecursivo();//Se ejecuta proceso recursivo utilizando MinMax heuristico
            }
        }


        //Se cargan los valores de la matriz con -1
        public void inicializarPartida(int x)
        {
            if (x == 1) {
                
                for (int i = 0; i < Matriz.GetLength(0); i++)
                    for (int j = 0; j < Matriz.GetLength(1); j++)
                    {
                        Matriz[i, j] = -1;
                        
                    }
            }
            else {
               
                for (int i = 0; i < Matriz.GetLength(0); i++)
                    for (int j = 0; j < Matriz.GetLength(1); j++)
                    {
                        Matriz[i, j] = -1;
                      
                    }
                     
            }

            existeGanador = -1;
            
        }

 
        public bool validaMatrizLlena()
        {
            bool tableroCompleto = true;
            for (int i = 0; i < Matriz.GetLength(0); i++)
                for (int j = 0; j < Matriz.GetLength(1); j++)
                    if (Matriz[i, j] == -1)
                        tableroCompleto = false;


            return tableroCompleto;
        }

        public bool finalizaJuego()
        {
            bool fin = false;
            if (validaMatrizLlena() || validaGanePartida() != -1)
                fin = true;

            return fin;

        }

        //Metodo recursivo para contruir el arbol heuristico de posibilidades
        public void metodoRecursivo()
        {
            //int valorMarcaPersona
            //Se valida que no sea el fin del juego
            if (!finalizaJuego())
            {
                //Se inicializan las variables 
                int fila = 0;
                int columna = 0;
                int valorMin = -99999999;
                int valorPrueba;
                //int valorMarcaMaquina;

                /*if (valorMarcaPersona == 0)
                {
                    valorMarcaMaquina = 1;
                }
                else
                {
                    valorMarcaMaquina = 0;
                };*/
                

                //Se recorre la matriz completa para crear el arbol heuristico
                for (int i = 0; i < Matriz.GetLength(0); i++)
                    for (int j = 0; j < Matriz.GetLength(1); j++)
                      
                        if (Matriz[i, j] == -1)
                        {

                            Matriz[i, j] = 1;
                            //Matriz[i, j] = valorMarcaMaquina;

                            //Se envia a crear el arbol heuristico
                            valorPrueba = obtieneMin();
                            
                            if (valorPrueba > valorMin)
                            {
                                valorMin = valorPrueba;
                                fila = i;
                                columna = j;
                            }
                            //lo vuelve a poner en -1 porque debe quedar como estaba las posiciones
                            Matriz[i, j] = -1;
                        }
                //Matriz[fila, columna] = valorMarcaMaquina;
                Matriz[fila, columna] = 1;
                
                MejorJugadaMinMax[0] = fila;
                MejorJugadaMinMax[1] = columna;
                
            }
            //
        }

        //obtiene valor maximo
        private int obtieneMax()
        {
            if (finalizaJuego())
            {
                //Cuando exista un ganador debe retornar por la construccion del arbol de decisión
                if (validaGanePartida() != -1)
                    return -1;
                else
                    return 0;
            }

            int valorPrueba;
            int valorMin = -99999999;
            
            
            //Se recorre la matriz
            for (int i = 0; i < Matriz.GetLength(0); i++)
                for (int j = 0; j < Matriz.GetLength(1); j++)
                    //Si la posicion no ha sido tocada
                    if (Matriz[i, j] == -1)
                    {
                        //Se coloca la posicion en 1(movimiento de sistema) para entrar al proceso recursivo
                        Matriz[i, j] = 1;
                        valorPrueba = obtieneMin();
                        if (valorPrueba > valorMin)
                            valorMin = valorPrueba;

                        //Se debe colocar de nuevo a la posición original
                        Matriz[i, j] = -1;
                    }

            return valorMin;
        }

        //Obtiene valor minimo
        private int obtieneMin()
        {
            if (finalizaJuego())
            {
                //Cuando exista un ganador debe retornar por la construccion del arbol de decisión
                if (validaGanePartida() != -1)
                    return 1;
                else
                    return 0;
            }

            int valorMax = 99999999;
            int valorPrueba;

            //Se recorre la matriz completa
            for (int i = 0; i < Matriz.GetLength(0); i++)
                for (int j = 0; j < Matriz.GetLength(1); j++)

                    //Si y solo si entramos si nuestra matriz no ha sido asignada
                    if (Matriz[i, j] == -1)
                    {
                        //se coloca la posicion de juego del usuario(0)
                        Matriz[i, j] = 0;
                        valorPrueba = obtieneMax();
                        
                        if (valorPrueba < valorMax)
                            valorMax = valorPrueba;

                        //Se vuelve a la posicion sin marca
                        Matriz[i, j] = -1;
                    }
            
            return valorMax;
        }

        //Se valida si con el movimiento realizado provoca que se gane el juego
        public int validaGanePartida()
        {
            int validaPosicion = -1;

            //Valida matriz sobre posiciones horizontal y vertical
            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                //Requiero validar de forma horizontal
                if (Matriz[i, 0] != -1 && Matriz[i, 0] == Matriz[i, 1] && Matriz[i, 0] == Matriz[i, 2])
                    validaPosicion = Matriz[i, 0];
                //Requiero validar de forma vertical
                if (Matriz[0, i] != -1 && Matriz[0, i] == Matriz[1, i] && Matriz[0, i] == Matriz[2, i])
                    validaPosicion = Matriz[0, i];
            }

            //Valida matriz sobre posicion diagonal
            if (Matriz[0, 0] != -1 && Matriz[0, 0] == Matriz[1, 1] && Matriz[0, 0] == Matriz[2, 2])
                validaPosicion = Matriz[0, 0];

            if (Matriz[0, 2] != -1 && Matriz[0, 2] == Matriz[1, 1] && Matriz[0, 2] == Matriz[2, 0])
                validaPosicion = Matriz[0, 2];


            return validaPosicion;
        }


    }
}
   
 