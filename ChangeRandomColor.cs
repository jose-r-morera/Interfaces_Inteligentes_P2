using NUnit.Framework.Constraints;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRandomColor : MonoBehaviour
{
    public int frames_wait_color = 120;
    public Color object_color;
    public int frame_counter;
    private Renderer rd;

    // Start is called before the first frame update
    void Start()
    {
        object_color = get_random_color();
        frame_counter = 0;
        rd = GetComponent<Renderer>();
    }
    
    // Update is called once per frame
    void Update()
    {
        ++frame_counter;
        if (frame_counter == frames_wait_color)
        {
            object_color = get_random_color();
            rd.material.color = object_color;
            frame_counter = 0;
        }
    }

    Color get_random_color()
    {
        return new Color(Random.Range(0f, 1.0f), Random.Range(0f, 1.0f), Random.Range(0f, 1.0f));
    }
}
