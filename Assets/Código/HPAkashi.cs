using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPAkashi : MonoBehaviour
{
    public Slider healthBar;
    public int HP = 100; 
    public Animator animator;

    void Update()
    {
        healthBar.value = HP;
    }

    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;
        if (HP <= 0)
        {
            animator.SetTrigger("die");
            GetComponent<Collider>().enabled = false;
        }
        else 
        {
            animator.SetTrigger("damage");
        }
    }
}
