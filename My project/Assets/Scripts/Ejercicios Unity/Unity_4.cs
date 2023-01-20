using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unity_4 : MonoBehaviour
{
    public GameObject esfera;
    private Renderer colorEsfera;
    // Start is called before the first frame update
    void Start()
    {
        colorEsfera = esfera.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            colorEsfera.material.SetColor("_Color", Color.red);
        }
    }
}
