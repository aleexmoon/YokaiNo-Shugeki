using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Message[] messages;

    public void StartDialogue()
    {
        FindObjectOfType<DialogManager>().OpenDialogue(messages);
    }
}

[System.Serializable]
public class Message
{
    public string messageJapanese;
    public string messageSpanish;
}
