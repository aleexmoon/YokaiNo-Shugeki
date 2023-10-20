using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class isNotCheckpoint : MonoBehaviour
{
    public string scenename;
 
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Cargando escena: " + scenename);
            SceneManager.LoadScene(scenename);
        }
    }
}