using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_4: MonoBehaviour
{
    private int num = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 3; i++)
        {
            num += 5+i;
        }
        Debug.Log("Total: " + num);
    }
}
