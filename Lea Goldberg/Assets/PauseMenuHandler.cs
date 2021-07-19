using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuHandler : MonoBehaviour
{
    public GameObject PauseMenuObject;
    private bool paused = false;
    void Start()
    {
        PauseMenuObject.SetActive(false);
    }

    public void ToggleMenu()
    {
        if (paused)
            PauseMenuObject.SetActive(false);
        if (!paused)
            PauseMenuObject.SetActive(true);
        paused = !paused;
    }
}
