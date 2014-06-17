using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tenis
{
    class GenerarPuntaje
    {
        jugador uno;
        jugador dos;
        jugador juno = new jugador();
        jugador jdos = new jugador();
        String var1, var2, varf;
     

        public String marcador(String cadena){

            uno = this.juno;
            dos = this.jdos;
                          switch (cadena)
                                {
                                    case "1":
                                        var1 = "Jugador uno puntua";
                                        uno.Puntos++;
                                        puntajePartido();
                                        
                                        break;
                                       
                                    case "2":
                                        
                                       dos.Puntos++;
                                       puntajePartido();
                                       var1= "Jugador dos puntua";
                                     
                                        break;
                                    default:
                                        
                                        var1= "Jugador erroneo repita";
                                        break;
                                }
                          varf = var1 + "\n" + var2;
                          return varf;
            }



                private void puntajePartido()
                {
                    
                    if (uno.Puntos < 3 && dos.Puntos < 3)
                        var2=(" Jugador1: " + (uno.Puntos * 15).ToString() + ", Jugador2: " + (dos.Puntos * 15).ToString());
                    else if (uno.Puntos == dos.Puntos)
                        var2=("Deuce");
                    else if ((uno.Puntos == dos.Puntos + 1) && (dos.Puntos == 2))
                        var2 = ("Jugador1 40, Jugador2 30");
                    else if ((dos.Puntos == uno.Puntos + 1) && (uno.Puntos == 2))
                        var2 = ("Jugador1 30, Jugador2 40");
                    else if ((uno.Puntos == dos.Puntos + 2) && (dos.Puntos == 1))
                        var2 = ("Jugador1 40, Jugador2 15");
                    else if ((dos.Puntos == uno.Puntos + 2) && (uno.Puntos == 1))
                      var2=("Jugador1 15, Jugador2 40");
                    else if ((uno.Puntos == dos.Puntos + 3) && (dos.Puntos == 0))
                        var2 = ("Jugador1 40, Jugador2 0");
                    else if ((dos.Puntos == uno.Puntos + 3) && (uno.Puntos == 0))
                        var2 = ("Jugador1 0, Jugador2 40");
                    else if (uno.Puntos == dos.Puntos + 1)
                        var2 = ("Ventaja Jugador1");
                    else if (dos.Puntos == uno.Puntos + 1)
                        var2 = ("Ventaja Jugador2");
                    else if (uno.Puntos > dos.Puntos + 1)
                        var2 = ("Jugador1 gana");
                    else if (dos.Puntos > uno.Puntos + 1)
                        var2 = ("Jugador2 gana");
                }

      
        public bool gana(){
            uno = this.juno;
            dos = this.jdos;
            Boolean ganador=false;
            if ((uno.Puntos > 3 && uno.Puntos > dos.Puntos + 1) || (dos.Puntos > 3 && dos.Puntos > uno.Puntos + 1))
            {
                ganador = true;
            }
            
            return ganador;
        }
}
     
}
