using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject amuletoModel;
    public int HP = 100; 
    public Animator animator;
    
    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;
        if (HP <= 0)
        {
            animator.SetTrigger("die");
            GetComponent<Collider>().enabled = false;
            DropAmuleto();
        }
        else
        {
            animator.SetTrigger("damage");
        }
    }

    void DropAmuleto()
    {
        // Asegúrate de tener una referencia válida al modelo de la moneda que deseas instanciar.
        if (amuletoModel != null)
        {
            Vector3 position = transform.position; // posición del enemigo
            GameObject amuleto = Instantiate(amuletoModel, position + new Vector3(0.0f, 0.1f, 0.0f), Quaternion.identity);
            amuleto.SetActive(true);
        }
        else
        {
            Debug.LogError("Referencia nula al modelo de la moneda. Asegúrate de asignar un modelo de moneda en el Inspector.");
        }
    }
}