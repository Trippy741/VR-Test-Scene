using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TypeWriterScript : MonoBehaviour
{
    [SerializeField] [TextArea] public string[] lines;
    public TextMeshProUGUI[] textArr;
    [Range(0,5)]
    public float delayBtwChar = 2f;
    public float delayBtwText = 10f;
    private int textIndex = 0;
    private int lineIndex = 0;
    private bool isTyping = false;

    public AudioSource typingAudioSource;
    public AudioClip[] typingSound;

    private void Start()
    {
        foreach (TextMeshProUGUI t in textArr)
        {
            t.text = "";
        }
    }
    public void startText()
    {
        if (isTyping == true)
        {
            //Starting the typeWriterEffect
            StartCoroutine(TypeText(textArr[lineIndex], lines[lineIndex].ToCharArray()));
        }
    }
    public IEnumerator TypeText(TextMeshProUGUI tmp,char[] arr)
    {
        foreach (char c in arr)
        {
            tmp.text += c;
            if(typingAudioSource != null)
                typingAudioSource.PlayOneShot(typingSound[Random.Range(0,typingSound.Length)]);
            //A delay between each character
            yield return new WaitForSeconds(delayBtwChar);
        }
        //A delay between each text
        yield return new WaitForSeconds(delayBtwText);
        textIndex++;
        lineIndex++;
    }
}
