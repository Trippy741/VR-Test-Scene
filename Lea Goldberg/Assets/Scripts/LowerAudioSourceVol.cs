using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerAudioSourceVol : MonoBehaviour
{
    public AudioSource Source;
    public bool canLower = false;

    public float lowerSpeed = 2f;

    public float minVol = 0.5f;
    public float maxVol = 0.7f;
    private void Start()
    {
        Source = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Source != null)
        {
            if (canLower)
                Source.volume = Mathf.Lerp(Source.volume, minVol, Time.deltaTime * lowerSpeed);
            else
                Source.volume = Mathf.Lerp(minVol, maxVol, Time.deltaTime * lowerSpeed);
        }
    }
    public void ToggleLowerVol()
    {
        canLower = !canLower;
    }
}
