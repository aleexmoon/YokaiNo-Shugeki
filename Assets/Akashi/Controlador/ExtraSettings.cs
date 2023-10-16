using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExtraSettings : MonoBehaviour
{
    public Animator playerAnim;

	void LoadSettingsScene()
    {
        SceneManager.LoadScene("Settings"); 
    }

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            LoadSettingsScene();
        }

		if(Input.GetKeyDown(KeyCode.E))
		{
			playerAnim.SetTrigger("inter");
		}
	}
}
