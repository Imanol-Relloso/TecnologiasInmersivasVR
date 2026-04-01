using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool doubleStick;
    public int points = 20;
    public bool easy = false;

    private void Awake()
    {
        if(instance == null)
            instance = this;

        DontDestroyOnLoad(gameObject);
    }
    public void Play(bool eas)
    {
        easy = eas;
        SceneManager.LoadScene("Game");
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
}
