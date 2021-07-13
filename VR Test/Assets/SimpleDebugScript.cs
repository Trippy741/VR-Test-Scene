using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleDebugScript : MonoBehaviour
{
    public void Log(GameObject gameObject)
    {
        Debug.Log("Touched the safety helmet with the: " + gameObject.name + "!");
    }
}
