using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ejercicio_8 : MonoBehaviour
{
    GameObject cubo, esfera_cercana_cubo, esfera_lejana_cubo;
    Vector3 tamano_esfera_cercana;
    Material material_esfera_lejana;
    // Start is called before the first frame update
    void Start()
    {
        cubo = GameObject.FindGameObjectWithTag("Cubo_referencia");

        esfera_cercana_cubo = GameObject.FindGameObjectWithTag("Esferas_tipo2");
        esfera_lejana_cubo = esfera_cercana_cubo;
        float distancia_minima = Vector3.Distance(esfera_cercana_cubo.transform.position, cubo.transform.position);
        float distancia_maxima = distancia_minima;
        foreach (GameObject cada_esfera in GameObject.FindGameObjectsWithTag("Esferas_tipo2")) {
            float distancia_actual = Vector3.Distance(cada_esfera.transform.position, cubo.transform.position);
            if (distancia_actual < distancia_minima) {
                distancia_minima = distancia_actual;
                esfera_cercana_cubo = cada_esfera;
            }
            if (distancia_actual > distancia_maxima) {
                distancia_maxima = distancia_actual;
                esfera_lejana_cubo = cada_esfera;
            }
        }
        foreach (GameObject cada_esfera in GameObject.FindGameObjectsWithTag("Esferas_tipo1")) {
            float distancia_actual = Vector3.Distance(cada_esfera.transform.position, cubo.transform.position);
            if (distancia_actual > distancia_maxima) {
                distancia_maxima = distancia_actual;
                esfera_lejana_cubo = cada_esfera;
            }
        }
        material_esfera_lejana = esfera_lejana_cubo.GetComponent<Renderer>().material;
        
        // Aumentar altura de esfera de tipo2 más cercana al cubo
        tamano_esfera_cercana = esfera_cercana_cubo.GetComponent<Transform>().localScale;
        ++tamano_esfera_cercana.y;
        esfera_cercana_cubo.transform.localScale = tamano_esfera_cercana;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            // Cambiar color esfera más alejada
            material_esfera_lejana.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}