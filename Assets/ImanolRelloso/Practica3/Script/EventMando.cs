using UnityEngine;
using UnityEngine.InputSystem;

public class EventMando : MonoBehaviour
{
    [SerializeField] private InputActionReference menuActionReference;

    private void Start()
    {
        DontDestroyOnLoad(transform);
    }

    private void OnEnable()
    {
        menuActionReference.action.performed += OnMenuButtonPressed;
    }

    private void OnDisable()
    {
        menuActionReference.action.performed -= OnMenuButtonPressed;
    }

    private void OnMenuButtonPressed(InputAction.CallbackContext context)
    {
        
    }
}
