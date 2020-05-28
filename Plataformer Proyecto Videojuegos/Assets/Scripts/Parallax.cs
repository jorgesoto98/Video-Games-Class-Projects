using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float length, startpos;
    public GameObject Follow;
    public float parallaxEffect;

    void Start()
    {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        float temp = (Follow.transform.position.x * (1 - parallaxEffect));
        float dist = (Follow.transform.position.x * parallaxEffect);

        transform.position = new Vector3(startpos + dist, 0 , -1);

        if (temp > startpos + length) { startpos += length; }
        else if (temp < startpos - length) { startpos -= length; };
    }

}
