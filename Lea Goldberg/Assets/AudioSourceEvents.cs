using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class AudioSourceEvents : MonoBehaviour
{
    public float timeForEvent = 2f;
    public float timeForLevelChange = 40f;
    public UnityEvent OnTime = new UnityEvent();
    public UnityEvent OnLevelChange = new UnityEvent();
    public AudioSource source;

    private void Awake()
    {
        StartCoroutine(Wait());
        StartCoroutine(waitForLevelChange());
    }
    private IEnumerator waitForLevelChange()
    {
        yield return new WaitForSeconds(timeForLevelChange);
        OnLevelChange?.Invoke();
    }
    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(timeForEvent);
        OnTime?.Invoke();
    }
}
