using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrigger : MonoBehaviour
{
    public string SceneName;

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(SceneName);
    }
}
