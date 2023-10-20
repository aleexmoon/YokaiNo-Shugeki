using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogManager : MonoBehaviour
{
    public TextMeshProUGUI messageJ;
    public TextMeshProUGUI messageS;
    public RectTransform backgroundBox;

    Message[] currentMessage;
    int activeMessage = 0;
    public static bool isActive;

    private Coroutine autoNextMessageCoroutine;
    public float autoNextMessageDelay = 10f; // Tiempo en segundos antes de cambiar automáticamente el mensaje

    public void OpenDialogue(Message[] messages)
    {
        currentMessage = messages;
        activeMessage = 0;
        isActive = true;

        Debug.Log("Mensajes a mostrar: " + messages.Length);
        DisplayMessage();
        backgroundBox.LeanScale(new Vector3(0.25f, 0.25f, 0.25f), 0.25f);

        // Iniciar la corutina para cambiar automáticamente los mensajes
        autoNextMessageCoroutine = StartCoroutine(AutoNextMessageCoroutine());
    }

    void DisplayMessage()
    {
        // Verificar si activeMessage está dentro de los límites del array
        if (activeMessage >= 0 && activeMessage < currentMessage.Length)
        {
            Message messageToDisplay = currentMessage[activeMessage];
            messageJ.text = messageToDisplay.messageJapanese;
            messageS.text = messageToDisplay.messageSpanish;
        }
        else
        {
            Debug.LogError("activeMessage está fuera de los límites del array.");
        }
    }

    public void NextMessage()
    {
        // Detener la corutina antes de mostrar el siguiente mensaje manualmente
        if (autoNextMessageCoroutine != null)
        {
            StopCoroutine(autoNextMessageCoroutine);
        }

        activeMessage++;
        if(activeMessage < currentMessage.Length)
        {
            DisplayMessage();
            // Reiniciar la corutina después de mostrar el mensaje manualmente
            autoNextMessageCoroutine = StartCoroutine(AutoNextMessageCoroutine());
        }
        else
        {
            Debug.Log("Terminó la conversación!");
            isActive = false;
            backgroundBox.LeanScale(Vector3.zero, 0.5f);
        }
    }

    IEnumerator AutoNextMessageCoroutine()
    {
        yield return new WaitForSeconds(autoNextMessageDelay);
        NextMessage();
    }

    void Start()
    {
        backgroundBox.transform.localScale = Vector3.zero;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return) && isActive == true)
        {
            NextMessage();
        }
    }
}

