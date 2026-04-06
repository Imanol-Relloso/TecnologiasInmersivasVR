using UnityEngine;
using UnityEngine.XR;


public class StickController3 : MonoBehaviour
{
    [SerializeField] private GameObject DoubleStick;
    [SerializeField] private GameObject SingleStick;
    private void Awake()
    {

        if (GameManager3.instance == null)
            Instantiate(SingleStick);
        else 
        {
            if (GameManager3.instance.doubleStick)
                Instantiate(DoubleStick, transform.position, transform.rotation);
            else
                Instantiate(SingleStick, transform.position, transform.rotation);
        }
    }
}
