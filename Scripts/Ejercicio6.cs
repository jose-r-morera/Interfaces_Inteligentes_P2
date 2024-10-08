using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{
    public Vector3 desplazamiento_cubo;
    public Vector3 desplazamiento_cilindro;
    public Vector3 desplazamiento_esfera;

    GameObject cubo;
    GameObject cilindro;
    GameObject esfera;

    // Start is called before the first frame update
    void Start()
    {
        cubo = GameObject.FindWithTag("cubo_azul");
        cilindro = GameObject.FindWithTag("cilindro_verde");
        esfera = GameObject.FindWithTag("esfera_roja");
    }

    // Update is called once per frame
    void Update()
    {
        float spaceInput = Input.GetAxis("Jump");

        // Si el valor del eje es mayor que 0, la barra espaciadora ha sido pulsada
        if (spaceInput > 0)
        {
            cubo.transform.position += desplazamiento_cubo;
            cilindro.transform.position += desplazamiento_cilindro;
            esfera.transform.position += desplazamiento_esfera;
        }
    }
}
