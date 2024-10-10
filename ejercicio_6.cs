using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio_6 : MonoBehaviour
{
    public GameObject objeto1, objeto2, objeto3;
    public Vector3 desplazamiento1, desplazamiento2, desplazamiento3;
    // Start is called before the first frame update
    void Start()
    {
        desplazamiento1 = new Vector3(0.1f, 0.1f, 0.0f);
        desplazamiento2 = new Vector3(-0.4f, -0.2f, 0.0f);
        desplazamiento3 = new Vector3(0.02f, 0.02f, 0.02f);
    }

    // Update is called once per frame
    void Update()
    {
        // Input.GetAxis() no reconoce la barra espaciadora
        if (Input.GetKeyDown(KeyCode.Space)) {
            objeto1.transform.position += desplazamiento1;
            objeto2.transform.position += desplazamiento2;
            objeto3.transform.position += desplazamiento3;
        }
    }
}
