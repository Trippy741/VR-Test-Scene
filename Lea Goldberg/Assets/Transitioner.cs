using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Transitioner : MonoBehaviour
{
    public AudioSource audioSource;
    public Renderer rend;
    UnityEvent event1;
    bool is1 = false;
    [SerializeField] [ColorUsage(true, true)] Color color;

    public UnityEvent[] events;
    public float[] eventTiming;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        event1 = new UnityEvent();
        event1.AddListener(Ping1);
        Invoke(nameof(Ping1), 24f);

        for (int i = 0; i < events.Length; i++)
        {
            StartCoroutine(waitForEventCall(events[i],eventTiming[i]));
        }

        color = rend.material.GetColor("GlowColor");
        rend.material.SetColor("GlowColor", color);
        //Invoke(nameof(Ping2), 26.5f);
        //rend.material.shader = Shader.Find("The Voice");//Gets the Shader
    }

    private void Update()
    {
        Debug.Log(Time.timeSinceLevelLoad);
        rend.material.SetColor("GlowColor", color);
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
            for (float i = num; i >= 1; i -= increment)
            {
                rend.material.SetFloat("Fill", i);
                yield return new WaitForSeconds(pause);
            }
        }

        else
        {
            for (float i = 1; i <= num; i += increment)
            {
                rend.material.SetFloat("Fill", i);
                yield return new WaitForSeconds(pause);
            }
        }
    }
    IEnumerator waitForEventCall(UnityEvent E,float waitDuration)
    {
        yield return new WaitForSeconds(waitDuration);
        E.Invoke();
        Debug.Log("Triggering event!");
    }
    void Ping1()
    {
        StartCoroutine(FillOverTime(5, 0.1f, 0.05f, false));
    }

    void Ping2()
    {
        StartCoroutine(FillOverTime(5, 0.1f, 0.05f, false));
    }
}
