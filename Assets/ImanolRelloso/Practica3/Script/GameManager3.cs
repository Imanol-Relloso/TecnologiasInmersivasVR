using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public enum GameMode
{
    Easy,
    Bomb,
    Arrow
}

public class GameManager3 : MonoBehaviour
{
    public static GameManager3 instance;

    public bool doubleStick;
    public int points = 20;

    public GameMode gameMode = GameMode.Easy;


    [SerializeField] private SongBPM songBPM;
    public AudioClip song;
    public int BPM;

    private void Awake()
    {
        if(instance == null)
            instance = this;
        
        DontDestroyOnLoad(gameObject);

        ChangeSong(0);
    }
    public void Play(int gm)
    {
        switch (gm)
        {
            case 0:
                gameMode = GameMode.Easy; break;
            case 1:
                gameMode = GameMode.Bomb; break; 
            case 2:
                gameMode = GameMode.Arrow; break;
        }
        SceneManager.LoadScene("Game3");
    }
    public void ChangeStick(bool option)
    {
        if (option) 
            doubleStick = true;
        else
            doubleStick = false;
    }
    public void ChangePoints(int option)
    {
        switch (option)
        {
            case 0:
                points = 10; break;
            case 1:
                points = 20; break;
            case 2:
                points = 30; break;
            default:
                break;
        }
    }
    public void ChangeSong(int option)
    {
        songBPM.SetSong(option);
    }

    public void DestroyGM()
    {
        Destroy(gameObject);
    }
}
