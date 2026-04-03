using Unity.XR.CoreUtils;
using UnityEngine;

public class ArrowBeat : Beat3
{
    [SerializeField] public Collider firstTrigger;
    [SerializeField] public Collider secondTrigger;

    private bool firstTriggered = false;

    private Quaternion[] rotations = { 
        Quaternion.identity,
        Quaternion.Euler(0f, 0f, 90f) , 
        Quaternion.Euler(0f, 0f, 180f) , 
        Quaternion.Euler(0f, 0f, 270f) 
    };

    protected override void Start()
    {
        base.Start();

        transform.localRotation = rotations[Random.Range(0, rotations.Length)];
    }
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }
    protected override void Update()
    {
        base.Update();
    }
    protected override void OnDestroy()
    {
        base.OnDestroy();
    }

    public void TryHit(Collider trigger)
    {
        if (trigger == firstTrigger)
        {
            firstTriggered = true;
        }
        else if (trigger == secondTrigger && firstTriggered)
        {
            isHit = true;
            Destroy(gameObject);
        }
    }
}
