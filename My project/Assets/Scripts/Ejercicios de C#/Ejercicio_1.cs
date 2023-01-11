using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_1 : MonoBehaviour
{
    private int total_num = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("----Numero Pares----");
        for (int i=1; i<=100; i++)
        {
            if (i % 2 == 0) {
                Debug.Log("Numero: "+i);
            }
            else
            {
                total_num += i;
            }
        }
        Debug.Log("----Total Numeros Impares----");
        Debug.Log("Total numeros: " + total_num);

    }
}
