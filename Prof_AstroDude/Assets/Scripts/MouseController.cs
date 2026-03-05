using UnityEngine;

public class MouseController : MonoBehaviour
{
    Camera myCam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myCam = GetComponent<Camera>();
    }

    public Vector3 getWorldPos()
    {
        Vector3 p = myCam.ScreenToWorldPoint(Input.mousePosition);
        p.z = 0;
        return p;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
