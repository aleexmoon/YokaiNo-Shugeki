using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PickUp : MonoBehaviour
{
    public GameObject kunaiOnAkashi;
    public Image kunaiImage;
    public TextMeshProUGUI pickupText;

    void Start()
    {
        kunaiOnAkashi.SetActive(false);
        kunaiImage.gameObject.SetActive(false);
        pickupText.gameObject.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            pickupText.text = "Usa la tecla J para recoger el Kunai.";
            Invoke("DestroyText", 10f); 
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(Input.GetKey(KeyCode.J))
            {
                this.gameObject.SetActive(false);
                kunaiOnAkashi.SetActive(true);
                kunaiImage.gameObject.SetActive(true);
                pickupText.gameObject.SetActive(true);
                pickupText.text = "Usa el botón izquierdo del mouse para atacar.";
                Invoke("DestroyText", 15f); // Llama a la función DestroyText después de 5 segundos
            }
        }
    }

    // Función para destruir el texto
    void DestroyText()
    {
        pickupText.gameObject.SetActive(false);
    }
}

