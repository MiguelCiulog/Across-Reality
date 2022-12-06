using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScaler : MonoBehaviour
{
    [SerializeField]
    private float defaultHeight = 2f;

    [SerializeField]
    private Camera userCamera;

    private void Resize()
    {
        // float headHeight = userCamera.transform.localPosition.y;
        // Debug.Log(headHeight);
        // float scale = defaultHeight / headHeight;

        // transform.localScale = Vector3.one * scale;
    }

    void OnEnable()
    {
        Resize();
    }
}
