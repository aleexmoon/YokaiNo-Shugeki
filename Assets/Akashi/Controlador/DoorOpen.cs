using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    public float speed;
    public float openPositionX;
    public float closedPositionX;
    
    public bool puedeAbrir;
    public bool abrir;

    void Start()
    {
        closedPositionX = transform.position.x;
        openPositionX = closedPositionX + 2f; // Cambia el valor 2f según la distancia que deseas que se desplace la puerta.
    }

    void Update()
    {
        if (abrir)
        {
            // Abre la puerta desplazándola en el eje X hacia openPositionX.
            transform.position = Vector3.Lerp(transform.position, new Vector3(openPositionX, transform.position.y, transform.position.z), Time.deltaTime * speed);
        }
        else
        {
            // Cierra la puerta desplazándola en el eje X hacia closedPositionX.
            transform.position = Vector3.Lerp(transform.position, new Vector3(closedPositionX, transform.position.y, transform.position.z), Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.K) && puedeAbrir)
        {
            abrir = !abrir; // Cambia el estado de abrir/cerrar al presionar el botón de fuego .
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            puedeAbrir = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            puedeAbrir = false;
        }
    }
}
