using Unity.XR.CoreUtils;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Beat3 : MonoBehaviour
{
    public bool isHit;

    [SerializeField] protected float speed;

    [SerializeField] protected Vector3 areaSize;
    protected Transform areaCenter;
    protected Vector3 direction;

    [SerializeField] protected float timeToDestroy;
    protected float timeAlive;

    public bool bomb;

    protected virtual void Start()
    {
        areaCenter = FindFirstObjectByType<Camera>().transform;

        Vector3 randomOffset = new Vector3(Random.Range(-areaSize.x / 2, areaSize.x / 2),Random.Range(-areaSize.y / 2, areaSize.y / 2), Random.Range(-areaSize.z / 2, areaSize.z / 2));

        direction = (areaCenter.position + randomOffset - transform.position).normalized;

        if(bomb) 
            transform.GetComponent<MeshRenderer>().material.color = Color.red;
    }
    protected virtual void FixedUpdate()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
    protected virtual void Update()
    {
        timeAlive += Time.deltaTime;
        if(timeToDestroy <= timeAlive)
            Destroy(gameObject);
    }
    protected virtual void OnDestroy()
    {
        if(isHit)
            BeatManager3.instance.addPoints(bomb);
    }
}