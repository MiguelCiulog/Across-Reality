using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeypadY : MonoBehaviour
{
    public TMP_Text numeroY;
    public TMP_Text numeroX;
    public TMP_Text mensaje;
    public TMP_Text numeroReto;
    private void Start(){
        numeroY.text="Y";
        numeroReto.text="";
    }

    public void ButtonClicked(string number){
        numeroY.text = number;
        verificarCompletado();
    }

    public void verificarCompletado(){
        if (numeroX.text != "" && numeroY.text != ""){
            if (numeroX.text != "X"){
                string numReto = numeroReto.text;
                string texto1 = numeroX.text;
                string texto2 = numeroY.text;

                int numero = int.Parse(numReto);
                int num1 = int.Parse(texto1);
                int num2 = int.Parse(texto2);

                if (numero == (num1+num2)){
                    mensaje.text = "¡COMPLETADO!";
                }
            }
            
        }
    }
}
