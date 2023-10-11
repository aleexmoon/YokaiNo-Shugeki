using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class NextSceneWithVideo : MonoBehaviour
{
    public string sceneName;
    public VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.playOnAwake = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(PlayVideoAndLoadScene());
        }
    }

    IEnumerator PlayVideoAndLoadScene()
    {
        videoPlayer.Play();
        yield return new WaitForSeconds(10f); // Espera 10 segundos (duración del video)

        SceneManager.LoadScene(sceneName); // Carga la siguiente escena
    }
}
