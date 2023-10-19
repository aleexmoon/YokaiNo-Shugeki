using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI messageJ;
    public TextMeshProUGUI messageS;
    public RectTransform backgroundBox;

    Message[] currentMessage;
    int activeMessage = 0;
    public static bool isActive = false;

    public void OpenDialogue(Message[] messages)
    {
        currentMessage = messages;
        activeMessage = 0;
        isActive = true;
        DisplayMessage(); 
    }

    void DisplayMessage()
    {
        Message messageToDisplay = currentMessage[activeMessage];
        messageJ.text = messageToDisplay.messageJapanese;
        messageS.text = messageToDisplay.messageSpanish;
    }
    
    public void NextMessage()
    {
        activeMessage++;
        if (activeMessage < currentMessage.Length)
        {
            DisplayMessage();
        }
        else
        {
            isActive = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isActive == true)
        {
            NextMessage();

        }
    }
}
