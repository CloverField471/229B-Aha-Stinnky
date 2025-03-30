using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        // เล่นเพลงที่ถูกกำหนดใน AudioSource
        audioSource.Play();
    }


}