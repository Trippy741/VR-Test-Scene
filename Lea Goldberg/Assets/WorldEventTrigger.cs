using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class WorldEventTrigger : MonoBehaviour
{
    public UnityEvent OnTrigger;
    public Animator triggerAnimator;
    public string animationTriggerName;

    private void OnTriggerEnter(Collider other)
    {
        if(OnTrigger != null)
            OnTrigger.Invoke();
        if(triggerAnimator != null)
            triggerAnimator.SetTrigger(animationTriggerName);
    }
}
