using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragDrop : MonoBehaviour
{
    bool isDrag;
    Transform focus;
    private Camera cam;
    Vector3 screenPos;
    Vector3 offset;
    RaycastHit hit;
    Ray ray;
    [SerializeField]
    private float maxDistance = 2f;
    public AudioClip winClip;
    public AudioSource audioSource;

    private void Start()
    {
        isDrag = false;
        cam = Camera.main;
    }
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && isDrag == true)
        {
            isDrag = false;
        }
        else if (Input.GetMouseButtonDown(0))
        {
            ray = cam.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction, new Color(100, 100, 100));
            if (Physics.Raycast(ray.origin, ray.direction, out hit))
            {
                if (hit.distance > maxDistance)
                {
                    return;
                }
                focus = hit.collider.transform;
                Debug.Log(focus.tag);
                if (hit.transform.tag != "Interactable")
                {
                    return;
                }

                if (focus.name == "Trophy")
                {
                    if (BarHandler.isBarDown == false)
                    {
                        return;
                    }
                    audioSource.PlayOneShot(winClip);
                    SceneManager.LoadScene("LevelSelectScene");
                }

                screenPos = cam.WorldToScreenPoint(focus.position);
                offset = focus.position - cam.ScreenToWorldPoint(
                    new Vector3(
                        Input.mousePosition.x,
                        Input.mousePosition.y,
                        screenPos.z
                        )
                    );
                isDrag = true;
            }
        }
        else if (isDrag == true)
        {
            var currentScreenPos = new Vector3(
                Input.mousePosition.x,
                Input.mousePosition.y,
                screenPos.z
            );
            Vector3 currentPos = cam.ScreenToWorldPoint(
                currentScreenPos
            ) + offset;
            focus.position = currentPos;
        }
    }
}
