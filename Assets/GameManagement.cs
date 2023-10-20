using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    private Vector3 playerPosition;

    void Start()
    {
        // Guarda la posición actual del jugador
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    public void SaveGame()
    {
        // Guarda la posición del jugador en PlayerPrefs
        PlayerPrefs.SetFloat("PlayerX", playerPosition.x);
        PlayerPrefs.SetFloat("PlayerY", playerPosition.y);
        PlayerPrefs.SetFloat("PlayerZ", playerPosition.z);
        // Guarda otros datos del juego según sea necesario
        // ...

        // Guarda los datos en PlayerPrefs
        PlayerPrefs.Save();
    }

    public void LoadGame()
    {
        // Carga la posición del jugador desde PlayerPrefs
        float playerX = PlayerPrefs.GetFloat("PlayerX");
        float playerY = PlayerPrefs.GetFloat("PlayerY");
        float playerZ = PlayerPrefs.GetFloat("PlayerZ");

        // Establece la posición del jugador al valor guardado
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(playerX, playerY, playerZ);
        // Carga otros datos del juego según sea necesario
        // ...
    }

    public void OnSaveButtonClick()
    {
        SaveGame();
    }

    public void OnLoadButtonClick()
    {
        LoadGame();
    }

}
