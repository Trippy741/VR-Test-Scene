using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class BasicInput : MonoBehaviour
{
    public UnityEvent OnPauseMenuButton = new UnityEvent();
    private List<InputDevice> devices;
    
    private void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevices(devices);

    }
    void Update()
    {
        PauseMenuButton();
    }
    public bool PauseMenuButton()
    {
        OnPauseMenuButton?.Invoke();
        foreach (InputDevice Controller in devices)
        {
            if (Controller != null)
            {
                Debug.Log("Pressing the pause menu button!!!");
                return Controller.TryGetFeatureValue(CommonUsages.primaryButton, out bool menuButton);
            }
        }
        return false;
    }
}
