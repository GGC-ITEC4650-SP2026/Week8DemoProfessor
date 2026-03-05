using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D myBod;
    MouseController mouse;
    Animator myAnim;

    public bool facingRight;

    // Start is called before the first frame update
    void Start()
    {
        mouse = GameObject.Find("Main Camera").GetComponent<MouseController>();
        myBod = GetComponent<Rigidbody2D>();
        myAnim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        myBod.linearVelocity = 5 * (new Vector2(h, v));

        facingRight = mouse.getWorldPos().x > transform.position.x;
        if(facingRight)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        myAnim.SetBool("RUNNING", myBod.linearVelocity.magnitude > 0);


    }
}
