using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levitator : MonoBehaviour
{
    [Range(1, 10)]
    public float heightMagMultiplier = 3f;
    [Range(1, 10)]
    public float heightTimeMultiplier = 2f;

    [Range(1,10)]
    public float rotationMagMultiplier = 3f;
    [Range(1, 10)]
    public float rotationTimeMultiplier = 2f;
    public GameObject[] Objects;
    
    void Update()
    {
        foreach (GameObject obj in Objects)
        {
            int randBit = Random.Range(0, 2);
            if (randBit == 0)
            {
                //X Rotation
                obj.transform.rotation = Quaternion.Euler(Time.deltaTime, 0, 0);
            } else
            {
                //Z Rotation
                obj.transform.rotation = Quaternion.Euler(0,0,Time.deltaTime);
            }

            obj.transform.position = transform.position + new Vector3(0,heightMagMultiplier * Mathf.Sin(Time.deltaTime * heightTimeMultiplier),0);
        }
    }
}
