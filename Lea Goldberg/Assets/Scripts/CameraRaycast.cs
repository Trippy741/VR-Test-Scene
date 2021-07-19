using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class CameraRaycast : MonoBehaviour
{
    public UnityEvent onLook = new UnityEvent();
    public LayerMask raycastTargetLayer;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1000))
        {
            if (hit.collider != null) onLook?.Invoke();
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawRay(transform.position,transform.forward * 1000);
    }
}
