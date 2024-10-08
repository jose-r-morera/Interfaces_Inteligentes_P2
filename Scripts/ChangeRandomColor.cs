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
        object_color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        frame_counter = 0;
        rd = GetComponent<Renderer>();
        rd.material.color = object_color;
    }
    
    // Update is called once per frame
    void Update()
    {
        ++frame_counter;
        if (frame_counter == frames_wait_color)
        {
            object_color = change_color_random_position(object_color);
            rd.material.color = object_color;
            frame_counter = 0;
        }
    }

    Color change_color_random_position(Color current_color)
    {
        // Elegir qué posicion se cambia
        int color_component = Random.Range(0, 3);

        Color modified_color = current_color;

        // Modificar la componente elegida
        switch (color_component)
        {
            case 0: // Red
                modified_color.r = Random.Range(0f, 1f);
                break;
            case 1: // Green
                modified_color.g = Random.Range(0f, 1f);
                break;
            case 2: // Blue
                modified_color.b = Random.Range(0f, 1f);
                break;
        }

        return modified_color;
    }
}
