using UnityEngine;

public class BushRussling : MonoBehaviour
{
    [SerializeField] AudioClip[] sounds;
    [SerializeField] AudioSource audioSource;
    [SerializeField] Vector2 pitchChangeRange;

    private void OnTriggerEnter(Collider other)
    {
        if (sounds.Length > 0 && !audioSource.isPlaying)
        {
            audioSource.pitch = Random.Range(pitchChangeRange.x, pitchChangeRange.y);
            audioSource.clip = sounds[Random.Range(0, sounds.Length)];
            audioSource.Play();
        }
    }

}
