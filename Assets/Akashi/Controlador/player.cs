using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public Animator playerAnim;
	public Rigidbody playerRigid;
	public float w_speed, wb_speed, olw_speed, rn_speed, ro_speed;
	public bool walking;
	public Transform playerTrans;
	
	void FixedUpdate()
	{
		if(Input.GetKey(KeyCode.S)){
			playerRigid.velocity = -transform.forward * 3 * w_speed * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.W)){
			playerRigid.velocity = -transform.forward * 3 * wb_speed * Time.deltaTime;
		}
	}

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

		if(Input.GetKeyDown(KeyCode.W)){
			playerAnim.SetTrigger("run");
			playerAnim.ResetTrigger("idle");
			walking = true;
			//steps1.SetActive(true);
		}

		if(Input.GetKeyUp(KeyCode.W)){
			playerAnim.ResetTrigger("run");
			playerAnim.SetTrigger("idle");
			walking = false;
			//steps1.SetActive(false);
		}
		if(Input.GetKeyDown(KeyCode.S)){
			playerAnim.SetTrigger("couch");
			playerAnim.ResetTrigger("idle");
			//steps1.SetActive(true);
		}
		if(Input.GetKeyUp(KeyCode.S)){
			playerAnim.ResetTrigger("couch");
			playerAnim.SetTrigger("idle");
			//steps1.SetActive(false);
		}
		if(Input.GetKeyDown(KeyCode.K)){
			playerAnim.SetTrigger("attack");
			playerAnim.ResetTrigger("idle");
			//steps1.SetActive(true);
		}
		if(Input.GetKeyUp(KeyCode.K)){
			playerAnim.ResetTrigger("attack");
			playerAnim.SetTrigger("idle");
			//steps1.SetActive(false);
		}

		if(Input.GetKeyDown(KeyCode.E)){
			playerAnim.SetTrigger("inter");
			playerAnim.ResetTrigger("idle");
			//steps1.SetActive(true);
		}
		if(Input.GetKeyUp(KeyCode.K)){
			playerAnim.ResetTrigger("inter");
			playerAnim.SetTrigger("idle");
			//steps1.SetActive(false);
		}	
		if(Input.GetKeyDown(KeyCode.Space)){
			playerAnim.SetTrigger("jump");
			playerAnim.ResetTrigger("idle");
			//steps1.SetActive(true);
		}
		if(Input.GetKeyUp(KeyCode.Space)){
			playerAnim.ResetTrigger("jump");
			playerAnim.SetTrigger("idle");
			//steps1.SetActive(false);
		}
		if(Input.GetKey(KeyCode.A)){
			playerTrans.Rotate(0, -ro_speed * Time.deltaTime, 0);
		}
		if(Input.GetKey(KeyCode.D)){
			playerTrans.Rotate(0, ro_speed * Time.deltaTime, 0);
		}
        if (walking)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                w_speed = w_speed + rn_speed;
                playerAnim.SetTrigger("run");
                playerAnim.ResetTrigger("walk");
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                w_speed = olw_speed;
                playerAnim.ResetTrigger("run");
                playerAnim.SetTrigger("walk");
            }
        }
	}
}
