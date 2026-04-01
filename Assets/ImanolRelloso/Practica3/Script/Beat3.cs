using Unity.XR.CoreUtils;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Beat3 : MonoBehaviour
{
    public bool isHit;

    [SerializeField] private float speed;

    [SerializeField] private Vector3 areaSize;
    private Transform areaCenter;
    private Vector3 direction;

    [SerializeField] float timeToDestroy;
    private float timeAlive;

    public bool bomb;

    private void Start()
    {
        areaCenter = FindFirstObjectByType<XROrigin>().transform;

        Vector3 randomOffset = new Vector3(Random.Range(-areaSize.x / 2, areaSize.x / 2),Random.Range(-areaSize.y / 2, areaSize.y / 2), Random.Range(-areaSize.z / 2, areaSize.z / 2));

        direction = (areaCenter.position + randomOffset - transform.position).normalized;

        if(bomb) 
            transform.GetComponent<MeshRenderer>().material.color = Color.red;
    }
    private void FixedUpdate()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
    private void Update()
    {
        timeAlive += Time.deltaTime;
        if(timeToDestroy <= timeAlive)
            Destroy(gameObject);
    }
    private void OnDestroy()
    {
        if(isHit)
            BeatManager3.instance.addPoints(bomb);
    }
}