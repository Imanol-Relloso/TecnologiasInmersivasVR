using UnityEngine;

public class StickController : MonoBehaviour
{
    [SerializeField] private GameObject DoubleStick;
    [SerializeField] private GameObject SingleStick;
    private void Start()
    {
        if (GameManager.instance == null)
            Instantiate(SingleStick);
        else 
        {
            if (GameManager.instance.doubleStick)
                Instantiate(DoubleStick, transform.position, transform.rotation);
            else
                Instantiate(SingleStick, transform.position, transform.rotation);
        }
    }
}
