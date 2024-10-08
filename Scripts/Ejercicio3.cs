using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    public Vector3 vectorA = new Vector3(0.0f, 1.0f, 0.0f);
    public Vector3 vectorB = new Vector3(2.0f, 0.0f, 3.0f);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Magnitud VectorA: " + vectorA.magnitude);
        Debug.Log("Magnitud VectorB: " + vectorB.magnitude);

        Debug.Log("El ángulo entre los vectores es: " + Vector3.Angle(vectorA, vectorB));

        Debug.Log("La distancia entre los vectores es: " + Vector3.Distance(vectorA, vectorB));

        if (vectorA.y > vectorB.y) 
        {
        Debug.Log("El vector más alto es el VectorA");
        } else if (vectorA.y < vectorB.y) {
            Debug.Log("El vector más alto es el VectorB");
        } else {
            Debug.Log("Los dos vectores están a la misma altura");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
