using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AmuletoMove : MonoBehaviour
{
    public static event Action OnCollected;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 1f; // Velocidad de movimiento, puedes ajustar este valor según tus necesidades
        float offsetY = Mathf.Sin(Time.time * speed) * 2f; // La amplitud del movimiento vertical es 2 unidades, puedes ajustarlo según tus necesidades
        
        Vector3 newPosition = transform.position; // Obtén la posición actual del objeto
        newPosition.y = offsetY; // Cambia la posición en el eje Y para el movimiento vertical
        transform.position = newPosition; // Aplica la nueva posición al objeto
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnCollected?.Invoke();
            Destroy(gameObject);
        }
    }
}
