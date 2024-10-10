using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio_7 : MonoBehaviour
{
    GameObject cubo, cilindro;
    Material material_cubo, material_cilindro;
    // Start is called before the first frame update
    void Start()
    {
        cubo = GameObject.FindGameObjectWithTag("Cubo");
        cilindro = GameObject.FindGameObjectWithTag("Cilindro");
        material_cubo = cubo.GetComponent<Renderer>().material;
        material_cilindro = cilindro.GetComponent<Renderer>().material;

    }

    // Update is called once per frame
    void Update()
    {
        // Pulsa C cambia color Cubo
        if (Input.GetKeyDown(KeyCode.C)) {
            material_cubo.color = new Color(Random.value, Random.value, Random.value);
        }
        // Pulsa flecha de arriba cambia color Cilindro
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            material_cilindro.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
