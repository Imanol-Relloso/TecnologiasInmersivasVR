using UnityEngine;

public class SongBPM : MonoBehaviour
{
    [SerializeField] private int[] BPM;
    [SerializeField] private AudioClip[] Songs;

    public void SetSong(int song)
    {
        GameManager3.instance.song = Songs[song]; 
        GameManager3.instance.BPM = BPM[song];
    }
}
