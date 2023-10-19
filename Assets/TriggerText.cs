using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerText : MonoBehaviour
{
    public DialogTrigger trigger;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player") == true)
        trigger.StartDialogue();
    }
}
