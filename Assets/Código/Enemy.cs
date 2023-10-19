using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public GameObject amuletoModel;
    public ParticleSystem particleSystem;
    public int HP;
    public Slider healthBar;
    public Animator animator;
    public GameObject yokai;

    void Update()
    {
        healthBar.value = HP;
    }
    
    public void TakeDamage(int damageAkashi)
    {
        HP -= damageAkashi;
        if (HP <= 0)
        {
            animator.SetTrigger("die");
            GetComponent<Collider>().enabled = false;
            DropAmuleto();
            Destroy(yokai, 5f);
        }
        else
        {
            ParticleSystem newParticleSystem = Instantiate(particleSystem, transform.position, Quaternion.identity);
            newParticleSystem.Play();
            Destroy(newParticleSystem.gameObject, 2f); // Destruye las partículas después de 1 segundo
            animator.SetTrigger("damage");
        }
    }

    void DropAmuleto()
    {
        // Asegúrate de tener una referencia válida al modelo de la moneda que deseas instanciar.
        if (amuletoModel != null)
        {
            Vector3 position = transform.position; // posición del enemigo
            GameObject amuleto = Instantiate(amuletoModel, position + new Vector3(0.3f, 0.1f, 0.3f), Quaternion.identity);
            amuleto.SetActive(true);
        }
        else
        {
            Debug.LogError("Referencia nula al modelo de la moneda. Asegúrate de asignar un modelo de moneda en el Inspector.");
        }
    }
}