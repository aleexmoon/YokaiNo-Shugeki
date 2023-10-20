using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
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

        Debug.Log("Juego guardado. Posición del jugador: " + playerPosition);
    }

    public void LoadGame()
    {
        // Carga la posición del jugador desde PlayerPrefs
        float playerX = PlayerPrefs.GetFloat("PlayerX");
        float playerY = PlayerPrefs.GetFloat("PlayerY");
        float playerZ = PlayerPrefs.GetFloat("PlayerZ");

        // Establece la posición del jugador al valor guardado
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.transform.position = new Vector3(playerX, playerY, playerZ);
        // Carga otros datos del juego según sea necesario
        // ...

        Debug.Log("Juego cargado. Nueva posición del jugador: " + player.transform.position);
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