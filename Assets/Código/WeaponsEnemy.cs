using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsEnemy : MonoBehaviour
{
    public int damageAmount = 20;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<HPAkashi>().TakeDamage(damageAmount);
        }
    }
}
