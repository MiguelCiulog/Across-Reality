using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarHandler : MonoBehaviour
{
    public GameObject bars;
    private bool isBarDown = false;
    public int numberOfActiveButtons = 0;
    public void HandleBars()
    {
        if (numberOfActiveButtons >= 3)
        {
            Vector3 newPos = (Vector3.down);
            Debug.Log(newPos);
            bars.transform.Translate(newPos, Space.World);
            isBarDown = true;
        }
        else if (numberOfActiveButtons != 3 && isBarDown == true)
        {
            isBarDown = false;
            Vector3 newPos = (Vector3.up);
            bars.transform.Translate(newPos, Space.World);
        }
    }

    public void addNumberOfActiveButtons()
    {
        numberOfActiveButtons += 1;
        HandleBars();
    }

    public void substractNumberOfActiveButtons()
    {
        numberOfActiveButtons -= 1;
        HandleBars();
    }
}
