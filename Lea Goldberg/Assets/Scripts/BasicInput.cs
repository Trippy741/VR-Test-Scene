using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class BasicInput : MonoBehaviour
{
    private XRController Controller;
    public UnityEvent OnPauseMenuButton = new UnityEvent();
    private void Start()
    {
        Controller = GetComponent<XRController>();
    }
    void Update()
    {
        PauseMenuButton();
    }
    public bool PauseMenuButton()
    {
        OnPauseMenuButton?.Invoke();
        return Controller.inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool menuButton);
    }
}
