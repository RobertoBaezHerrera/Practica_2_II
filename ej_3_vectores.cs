using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ej_3_vectores : MonoBehaviour
{
    public Vector3 myVector1, myVector2;
    // Start is called before the first frame update
    void Start()
    {
        myVector1 = new Vector3(0.0f, 1.0f, 0.0f);
        myVector2 = new Vector3(1.0f, 0.0f, 1.0f);
        Debug.Log("Magnitud vector 1: " + myVector1.magnitude);
        Debug.Log("Magnitud vector 2: " + myVector2.magnitude);
        Debug.Log("Ángulo entre vectores: " + Vector3.Angle(myVector1, myVector2));
        Debug.Log("Distancia entre vectores: " + Vector3.Distance(myVector1, myVector2));
        
        if (myVector1.y > myVector2.y) {
            Debug.Log("El vector con mayor altura es el Vector 1");
        } else if (myVector1.y > myVector2.y) {
            Debug.Log("El vector con mayor altura es el Vector 2");
        } else {
            Debug.Log("Los dos vectores tienen la misma altura");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
