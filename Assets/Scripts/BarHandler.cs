using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BarHandler : MonoBehaviour
{
    public GameObject bars;
    public GameObject trophy;
    public static bool isGameFinshed = false;
    public static bool isBarDown = false;
    public int numberOfActiveButtons = 0;
    public Canvas canva;

    public void HandleBars()
    {
        if (numberOfActiveButtons >= 3)
        {
            Vector3 newPos = (Vector3.down);
            bars.transform.Translate(newPos, Space.World);
            disableBoxCollider(bars);
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
        handleScoreUpdate(numberOfActiveButtons);
        HandleBars();
    }

    public void substractNumberOfActiveButtons()
    {
        numberOfActiveButtons -= 1;
        handleScoreUpdate(numberOfActiveButtons);
        HandleBars();
    }

    private void handleScoreUpdate(int numScore)
    {
        if (!isGameFinshed)
        {
            GameObject tempObject = GameObject.Find("Canvas");
            if (tempObject != null)
            {
                canva = tempObject.GetComponent<Canvas>();
                TextMeshProUGUI uwu = tempObject.GetComponentInChildren<TextMeshProUGUI>();
                uwu.text = numScore + "/3";
            }
        }
    }

    private void disableBoxCollider(GameObject go)
    {
        BoxCollider[] allChildren = go.GetComponentsInChildren<BoxCollider>();
        foreach (BoxCollider child in allChildren)
        {
            child.enabled = false;
        }
    }
}
