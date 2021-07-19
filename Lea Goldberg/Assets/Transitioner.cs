using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transitioner : MonoBehaviour
{
    public AudioSource audioSource;
    public Renderer rend;
    bool is1 = false;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.shader = Shader.Find("The Voice");//Gets the Shader
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (audioSource.time >= 5f)
        {
            is1 = true; ;
        }

        if (is1)
        {
            Debug.LogError("bruh");
            StartCoroutine(Transition());
        }
        //Debug.Log(audio.timeSamples);
    }

    IEnumerator Transition()
    {
        for (float ft = 1f; ft >= 0; ft -= 0.1f)
        {
            rend.material.SetFloat(rend.material.shader.name, 1f);
            Debug.Log("ft");
            yield return new WaitForSeconds(.1f);
        }
    }
}
