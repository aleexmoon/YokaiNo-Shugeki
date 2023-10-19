using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveAnimation : MonoBehaviour
{
    public GameObject player;
    public GameObject activeAnimation;
    public float animationTime;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<Collider>().enabled = false;
        activeAnimation.SetActive(true);
        player.SetActive(false);
        StartCoroutine(FinishCut());
    }

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(animationTime);
        activeAnimation.SetActive(false);
        player.SetActive(true);
    }
}
