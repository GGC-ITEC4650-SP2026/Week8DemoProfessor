using UnityEngine;

public class SelectorController : MonoBehaviour
{
    public Transform group;
    private Transform selected;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        selected = group.GetChild(0);
        transform.position = selected.position;
    }

    Transform searchDirection(Vector3 dir)
    {
        float minDist = float.MaxValue;
        Transform bestChild = null;
        for(int i = 0; i < group.childCount; i++)
        {
            Transform child = group.GetChild(i);
            Vector3 v = child.position - transform.position;
            if(v.magnitude < minDist) {
                if(dir.x * v.x > 0 || dir.y * v.y > 0)
                {
                    minDist = v.magnitude;
                    bestChild = child;
                }
            }
        }
        return bestChild;
    }

    // Update is called once per frame
    void Update()
    {
        if(selected == null)
        {
            if(group.childCount > 0) {
                selected = group.GetChild(0);
                transform.position = selected.position;
            }
            else
            {
                gameObject.SetActive(false);
            }
        }


        Transform t = null;
        if(Input.GetButtonDown("UP"))
        {
            t = searchDirection(Vector3.up);
        }
        if(Input.GetButtonDown("RIGHT"))
        {
            t = searchDirection(Vector3.right);
        }
        if(Input.GetButtonDown("DOWN"))
        {
            t = searchDirection(Vector3.down);
        }
        if(Input.GetButtonDown("LEFT"))
        {
            t = searchDirection(Vector3.left);
        }
        if(t != null)
        {
            selected = t;
            transform.position = selected.position;
        }

        if(Input.GetButtonDown("Jump"))
        {
            Destroy(selected.gameObject);
        }

        /*
        if(Input.GetButtonDown("UP"))
        {
            transform.position += Vector3.up;
        }
         if(Input.GetButtonDown("RIGHT"))
        {
            transform.position += Vector3.right;
        }
        if(Input.GetButtonDown("DOWN"))
        {
            transform.position += Vector3.down;
        }
        if(Input.GetButtonDown("LEFT"))
        {
            transform.position += Vector3.left;
        }
        */
        
    }
}
