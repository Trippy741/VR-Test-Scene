﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Transitioner : MonoBehaviour
{
    public AudioSource audioSource;
    public Renderer rend;
    UnityEvent event1;
    bool is1 = false;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        event1 = new UnityEvent();
        event1.AddListener(Ping1);
        Invoke(nameof(Ping1), 24f);
        //rend.material.shader = Shader.Find("The Voice");//Gets the Shader
    }

    IEnumerator FillOverTime(float num, float increment, float pause, bool isReverse)
    {
        if (isReverse)
        {
            for (float i = num; i >= 0; i -= increment)
            {
                rend.material.SetFloat("Fill", i);
                yield return new WaitForSeconds(pause);
            }
        }

        else
        {
            for (float i = 0; i <= num; i += increment)
            {
                rend.material.SetFloat("Fill", i);
                yield return new WaitForSeconds(pause);
            }
        }        
    }

    IEnumerator ColorOverTime(float num, float increment, float pause, bool isReverse)
    {
        if (isReverse)
        {
            for (float i = num; i >= 0; i -= increment)
            {
                rend.material.SetColor("GlowColor", Color.green);
                yield return new WaitForSeconds(pause);
            }
        }

        else
        {
            for (float i = 0; i <= num; i += increment)
            {
                rend.material.SetFloat("Fill", i);
                yield return new WaitForSeconds(pause);
            }
        }
    }

    void Ping1()
    {
        StartCoroutine(FillOverTime(5, 0.1f, 0.05f, true));
    }
}
