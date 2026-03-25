using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool doubleStick;
    private void Awake()
    {
        if(instance == null)
            instance = this;

        DontDestroyOnLoad(gameObject);
    }
    public void StartEasy()
    {
        SceneManager.LoadScene("Facil");
    }
    public void StartDifficult()
    {
        SceneManager.LoadScene("Complicado");
    }
    public void ChangeStick()
    {
        if (doubleStick) 
            doubleStick = false;
        else
            doubleStick = true;
    }
}
