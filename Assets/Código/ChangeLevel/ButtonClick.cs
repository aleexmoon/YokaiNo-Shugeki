using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    public Button myButton;
    public string sceneToLoad;

    void Start()
    {
        // Agrega un listener al botón que llama a la función LoadSceneOnClick cuando se hace clic en el botón
        Button btn = myButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadSceneOnClick);
    }

    // Esta función se llama cuando se hace clic en el botón
    void LoadSceneOnClick()
    {
        // Carga la escena especificada
        SceneManager.LoadScene(sceneToLoad);
    }
}
