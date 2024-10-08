using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distancias : MonoBehaviour
{
    GameObject cubo;
    GameObject cilindro;

    // Start is called before the first frame update
    void Start()
    {
        cubo = GameObject.FindWithTag("cubo_azul");
        cilindro = GameObject.FindWithTag("cilindro_verde");

        Vector3 posicion_cubo = cubo.transform.position;
        Vector3 posicion_cilindro = cilindro.transform.position;
        Debug.Log("Distancai entre cubo y cilindro: " + Vector3.Distance(posicion_cubo, posicion_cilindro));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
