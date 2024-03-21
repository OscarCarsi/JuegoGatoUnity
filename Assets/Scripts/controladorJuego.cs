using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controladorJuego : MonoBehaviour
{
    public Text[] listaBotones;
    private string ladoJugador;
    public GameObject panelFinJuego;   
    public Text textoFinJuego;
    private int cuentaMovimiento;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Awake(){
        ColocarRefControladorBotones();
        ladoJugador = "X";
        panelFinJuego.SetActive(false);
        cuentaMovimiento = 0;
    }
    public void ColocarRefControladorBotones(){
        for (int i = 0; i < listaBotones.Length; i++)
        {
            listaBotones[i].GetComponentInParent<espacioGrid>().ColocarReferenciaControladorJuego(this);
        }
    }
    public string ObtenerLadoJugador(){
        return ladoJugador;
    }
    public void CambioJugador(){
        if(ladoJugador == "X"){
            ladoJugador = "O";
        }else{
            ladoJugador = "X";
        }
    }

    public void FinTurno(){
        cuentaMovimiento++;
        if(cuentaMovimiento > 8){
            ColocarTextoFinJuego("Empate!");
        }
        //Horizontales
        if(listaBotones[0].text == ladoJugador && listaBotones[1].text == ladoJugador && listaBotones[2].text == ladoJugador){
            FinJuego();
        }
        if(listaBotones[7].text == ladoJugador && listaBotones[4].text == ladoJugador && listaBotones[8].text == ladoJugador){
            FinJuego();
        }
        if(listaBotones[3].text == ladoJugador && listaBotones[5].text == ladoJugador && listaBotones[6].text == ladoJugador){
            FinJuego();
        }
        //Verticales
        if(listaBotones[3].text == ladoJugador && listaBotones[1].text == ladoJugador && listaBotones[7].text == ladoJugador){
            FinJuego();
        }
        if(listaBotones[0].text == ladoJugador && listaBotones[8].text == ladoJugador && listaBotones[5].text == ladoJugador){
            FinJuego();
        }
        if(listaBotones[4].text == ladoJugador && listaBotones[6].text == ladoJugador && listaBotones[2].text == ladoJugador){
            FinJuego();
        }
        //Diagonales
        if(listaBotones[0].text == ladoJugador && listaBotones[3].text == ladoJugador && listaBotones[4].text == ladoJugador){
            FinJuego();
        }
        if(listaBotones[0].text == ladoJugador && listaBotones[6].text == ladoJugador && listaBotones[7].text == ladoJugador){
            FinJuego();
        }
        CambioJugador();
    }
    public void FinJuego(){
        for (int i = 0; i < listaBotones.Length; i++)
        {
            listaBotones[i].GetComponentInParent<Button>().interactable = false;
        }
        ColocarTextoFinJuego(ladoJugador + " Ganó!");
    }
    void ColocarTextoFinJuego(string valor){
        panelFinJuego.SetActive(true);
        textoFinJuego.text = valor;
    }
}
