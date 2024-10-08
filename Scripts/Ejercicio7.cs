using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7 : MonoBehaviour
{
    GameObject cubo;
    GameObject cilindro;
    Renderer cubo_renderer;
    Renderer cilindro_renderer;
    
    // Start is called before the first frame update
    void Start()
    {
        cubo = GameObject.FindWithTag("cubo_azul");
        cilindro = GameObject.FindWithTag("cilindro_verde");

        cubo_renderer = cubo.GetComponent<Renderer>();
        cilindro_renderer = cilindro.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)) {
            cilindro_renderer.material.color = GetRandomColor();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            cubo_renderer.material.color = GetRandomColor();
        }
    }

    Color GetRandomColor()
    {
       return new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
}
