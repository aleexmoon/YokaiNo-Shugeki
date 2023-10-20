using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioSource audioSourceToPlay;
    public AudioSource audioSourceToMute;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !audioSourceToPlay.isPlaying)
        {
            audioSourceToPlay.Play();

            // Mutea el otro AudioSource si está sonando
            if (audioSourceToMute.isPlaying)
            {
                audioSourceToMute.volume = 0f; // Establece el volumen a 0 para silenciar el sonido
            }
        }
    }
}
