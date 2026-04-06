using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private Transform _camera;
    void Start()
    {
        _camera = FindFirstObjectByType<Camera>().transform;

        gameObject.SetActive(false); 
    }
    public bool isActive()
    {
        return gameObject.activeSelf;
    }
    public void Activate()
    {
        gameObject.SetActive(true);

        SongManager.instance.Pause();

        transform.position = _camera.position + _camera.forward;
        transform.rotation = Quaternion.LookRotation(_camera.forward);

        Time.timeScale = 0.0f;
    }
    public void Desactivate()
    {
        gameObject.SetActive(false);
        SongManager.instance.Play();
        Time.timeScale = 1.0f;
    }
    public void MenuPrincipal()
    {
        SceneManager.LoadScene("Menu3");
        gameObject.SetActive(false);
        GameManager3.instance.DestroyGM();
        Time.timeScale = 1.0f;
    }
}
