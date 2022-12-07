using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ModifyTextMeshPro : MonoBehaviour
{
    public TMP_Text numeroReto ;
    // public TMP_Text numeroX;
    // public TMP_Text numeroY;
    // public TMP_Text mensaje;
    public int numero;


    // Start is called before the first frame update
    void Start()
    {
        // mensaje.text="";
        numero = UnityEngine.Random.Range(2,18);
        numeroReto.text+=numero;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
