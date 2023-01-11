using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidad;
    [SerializeField] //Muestra las variables privadas
    private int fuerza;
    void Start()
    {
        fuerza = 5;
        Debug.Log(fuerza+"f");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
