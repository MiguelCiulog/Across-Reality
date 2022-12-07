using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarHandler : MonoBehaviour
{
    public GameObject bars;
    public GameObject trophy;
    public static bool isBarDown = false;
    public int numberOfActiveButtons = 0;
    public void HandleBars()
    {
        if (numberOfActiveButtons >= 3)
        {
            Vector3 newPos = (Vector3.down);
            bars.transform.Translate(newPos, Space.World);
            isBarDown = true;
            Rigidbody rb_trophy = trophy.GetComponent<Rigidbody>();
            rb_trophy.constraints = RigidbodyConstraints.None;
        }
        else if (numberOfActiveButtons != 3 && isBarDown == true)
        {
            isBarDown = false;
            Vector3 newPos = (Vector3.up);
            bars.transform.Translate(newPos, Space.World);
            Rigidbody rb_trophy = trophy.GetComponent<Rigidbody>();
            rb_trophy.constraints = RigidbodyConstraints.FreezeAll;
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
