using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerText : MonoBehaviour
{
    public DialogTrigger trigger;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            trigger.StartDialogue();
            Destroy(gameObject); // Destruye el objeto actual cuando el jugador entra en el área de Trigger
        }
    }
}
