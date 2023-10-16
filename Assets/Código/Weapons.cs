using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    public int damageAmount = 20;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Yokai")
        {
            other.GetComponent<Enemy>().TakeDamage(damageAmount);
        }
    }
}
