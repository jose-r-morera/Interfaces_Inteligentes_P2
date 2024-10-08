using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8Mod : MonoBehaviour
{
    private GameObject[] esferas_tipo2;
    private GameObject cubo;
    private Renderer esfera_mas_lejana_renderer;
    private GameObject cilindro;

    // Start is called before the first frame update
    void Start()
    {
        esferas_tipo2 = GameObject.FindGameObjectsWithTag("esfera_tipo2");
        cubo = GameObject.FindWithTag("cubo_azul");
        cilindro = GameObject.FindWithTag("cilindro_verde");

        float distancia_min = Vector3.Distance(esferas_tipo2[0].transform.position, cubo.transform.position);
        float distancia_max = distancia_min;
        
        GameObject esfera_mas_cercana = esferas_tipo2[0];
        GameObject esfera_mas_lejana = esfera_mas_cercana;

        foreach (GameObject esfera in esferas_tipo2)
        {
            float distancia = Vector3.Distance(esfera.transform.position, cubo.transform.position);
            if (distancia < distancia_min) {
                distancia_min = distancia;
                esfera_mas_cercana = esfera;
            } else if (distancia > distancia_max) {
                distancia_max = distancia;
                esfera_mas_lejana = esfera;
            }
        }

        // Incrementar altura
        esfera_mas_cercana.transform.localScale += new Vector3(0f, 1f, 0f);
        // Intercambiar posición
        Vector3 auxiliar_intercambio = esfera_mas_cercana.transform.position;
        esfera_mas_cercana.transform.position = cilindro.transform.position;
        cilindro.transform.position = auxiliar_intercambio;
        // Cambiar color
        Renderer esfera_mas_cercana_renderer = esfera_mas_cercana.GetComponent<Renderer>();
        esfera_mas_cercana_renderer.material.color = GetRandomColor();

        // Guardar renderer
        esfera_mas_lejana_renderer = esfera_mas_lejana.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.Space)) {
            esfera_mas_lejana_renderer.material.color = GetRandomColor();
        }
    }

        Color GetRandomColor()
    {
       return new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
}
