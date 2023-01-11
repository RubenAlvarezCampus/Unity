using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_2 : MonoBehaviour
{
    private int num = 8;
    // Start is called before the first frame update
    void Start()
    {
        do
        {
            Debug.Log(num);
            num += 8;
        } while (num <= 500);
    }
}
