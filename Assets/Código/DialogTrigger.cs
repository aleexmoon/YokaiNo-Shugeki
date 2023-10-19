using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Message[] message;

    public void StartDialogue()
    {
        FindObjectOfType<DialogueManager>().OpenDialogue(message);
    }
}

[System.Serializable]
public class Message
{
    public string messageJapanese;
    public string messageSpanish;
}