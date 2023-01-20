using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unity_1 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.SetActive(false);
        }
    }
}
