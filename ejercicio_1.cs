using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq.Expressions;
using UnityEngine;

public class ejercicio_1 : MonoBehaviour
{

    Vector3 m_MyColors;
    public int contador_frames = 0, frame_de_espera = 120;

    private Renderer m_NewRenderer;
    // Start is called before the first frame update
    void Start()
    {
        m_NewRenderer = GetComponent<Renderer>();
        m_MyColors.Set(Random.value, Random.value, Random.value);
        m_NewRenderer.material.color = new Color(m_MyColors.x, m_MyColors.y, m_MyColors.z);
    }

    // Update is called once per frame
    void Update()
    {
        ++contador_frames;
        if (contador_frames == frame_de_espera) {
            int indice_random = Random.Range(0, 3);
            m_MyColors[indice_random] = Random.value;
            m_NewRenderer.material.color = new Color(m_MyColors.x, m_MyColors.y, m_MyColors.z);
            contador_frames = 0;
        }
    }
}
