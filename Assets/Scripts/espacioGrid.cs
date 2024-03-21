using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class espacioGrid : MonoBehaviour
{
    public Button boton;
    public Text textoBoton;
    public string ladoJugador;
    public controladorJuego controladorJuegoVar;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ColocarReferenciaControladorJuego(controladorJuego controlador){
        controladorJuegoVar = controlador;
    }
    public void ColocarEspacio(){
        textoBoton.text = controladorJuegoVar.ObtenerLadoJugador();
        boton.interactable = false;
        controladorJuegoVar.FinTurno();
    }

}
