using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimiento : MonoBehaviour
{
    public float Speed;
    private AudioSource sound;
    // Update is called once per frame

    private void Start()
    {
        sound= GetComponent<AudioSource>();
    }
    void Update()
    {
        float movH = Input.GetAxis("Horizontal");
        float movV = Input.GetAxis("Vertical");

        //Ejercicio 1 -- Mover la esfera
        //transform.Translate(movH, 0, movV);

        //Ejercicio 2 -- Aplicar time.deltatimne
        transform.Translate(movH * Speed * Time.deltaTime,0,movV * Speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemigo")
        {
            Destroy(collision.gameObject);
            sound.Play();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Target")
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("Unity_1");
        }
    }
}
