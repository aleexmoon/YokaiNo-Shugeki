using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HPAkashi : MonoBehaviour
{
    public Slider healthBarAkashi;
    public ParticleSystem particleSystem;
    public int hpAkashi = 100; 
    public Animator animator;

    void Update()
    {
        healthBarAkashi.value = hpAkashi;
    }

    public void TakeDamage(int damageEnemy)
    {
        hpAkashi -= damageEnemy;
        if (hpAkashi <= 0)
        {
            animator.SetTrigger("die");
            GetComponent<Collider>().enabled = false;
            SceneManager.LoadScene("EndGame");
        }
        else 
        {
            ParticleSystem newParticleSystem = Instantiate(particleSystem, transform.position, Quaternion.identity);
            newParticleSystem.Play();
            Destroy(newParticleSystem.gameObject, 2f); // Destruye las partículas después de 1 segundo
            animator.SetTrigger("damage");
        }
    }
}
