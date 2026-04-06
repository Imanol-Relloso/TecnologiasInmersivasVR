using UnityEngine;

public class SongManager : MonoBehaviour
{
    public static SongManager instance;

    [SerializeField] private AudioSource audioSource;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    private void Start()
    {
        audioSource.clip = GameManager3.instance.song;
        audioSource.Play();
    }

    public void Pause()
    {
        audioSource.Pause();
    }
    public void Play()
    {
        audioSource.Play();
    }
}
