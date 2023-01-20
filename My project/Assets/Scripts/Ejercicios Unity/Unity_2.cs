using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unity_2 : MonoBehaviour
{
    private GameObject esfera;

    // Start is called before the first frame update
    void Start()
    {
        esfera = GameObject.FindGameObjectWithTag("Esfera_Quitar");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            esfera.SetActive(false);
        }
    }
}
