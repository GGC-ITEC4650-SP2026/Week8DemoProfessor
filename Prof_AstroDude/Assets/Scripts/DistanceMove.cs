using UnityEngine;

public class DistanceMove : MonoBehaviour
{
    public Vector3 dir;
    public float speed;

    private float distLeftToMove;
    public float moveDist;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        distLeftToMove = moveDist;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 frameStep = dir * Time.deltaTime * speed;
        distLeftToMove -= frameStep.magnitude;
        Vector3 temp = transform.position + frameStep;
        if(distLeftToMove > 0)
        {
            transform.position = temp;
        }
        else
        {
            distLeftToMove = moveDist;
            // reverse direction
            dir = -1 * dir;
        }        
    }
}
