using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsEnemy : MonoBehaviour
{
    public int damageEnemy = 20;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<HPAkashi>().TakeDamage(damageEnemy);
        }
    }
}
