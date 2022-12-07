using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ModifyTextMeshPro : MonoBehaviour
{
    public TMP_Text numeroReto;
    public int numero;
    [SerializeField]
    public string challenge;

    public static string challengeType;

    // Start is called before the first frame update
    void Start()
    {
        challengeType = challenge;
        if (challengeType == "suma" || challengeType == "resta")
        {
            numero = UnityEngine.Random.Range(2, 18);
            numeroReto.text = "" + numero;
        }
        if (challengeType == "multiplicacion")
        {
            numero = UnityEngine.Random.Range(1, 98);
            numeroReto.text = "" + numero;
        }
    }
}
