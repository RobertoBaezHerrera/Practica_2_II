using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej_5_distancia : MonoBehaviour
{
    GameObject cubo, cilindro;
    // Start is called before the first frame update
    void Start()
    {
        // Los métodos con FindWithTag simepre dentro de Start o Update
        // ya que los objetos no están completamente incializados fuera de estas funciones
        cubo = GameObject.FindWithTag("Cubo");
        cilindro = GameObject.FindWithTag("Cilindro");
        Debug.Log("Distancia entre esfera y cubo: " + Vector3.Distance(transform.position, cubo.transform.position));
        Debug.Log("Distancia entre esfera y cilindro: " + Vector3.Distance(transform.position, cilindro.transform.position));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
