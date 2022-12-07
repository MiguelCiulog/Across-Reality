using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeypadX : MonoBehaviour
{
    public TMP_Text numeroX;
    public TMP_Text numeroY;
    public TMP_Text mensaje;
    public TMP_Text numeroReto;
    private void Start(){
        numeroX.text="X";
    }

    public void ButtonClicked(string number){
        numeroX.text = number;
        verificarCompletado();
        
    }

    public void verificarCompletado(){
        if (numeroX.text != "" && numeroY.text != ""){
            if (numeroY.text != "Y"){
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
