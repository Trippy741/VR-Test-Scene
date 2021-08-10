namespace RedBlueGames.Tools.TextTyper
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Talker : MonoBehaviour
    {
        [SerializeField] [Multiline(10)] string text;
        TextTyper typer;
        
        // Start is called before the first frame update
        void Start()
        {
            typer = GetComponent<TextTyper>();
            typer.TypeText(text);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}
