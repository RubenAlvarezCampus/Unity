using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_3 : MonoBehaviour
{
    private int num = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 7; i++)
        {
            num += i;
        }
        Debug.Log("Total: "+num);
    }
}
