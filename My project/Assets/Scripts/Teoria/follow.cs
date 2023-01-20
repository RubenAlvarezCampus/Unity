using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{

    public GameObject objetivo;
    private Vector3 distanciaRelativa;

    // Start is called before the first frame update
    void Start()
    {
        distanciaRelativa= transform.position - objetivo.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
           transform.position = objetivo.transform.position + distanciaRelativa;
    }
}
