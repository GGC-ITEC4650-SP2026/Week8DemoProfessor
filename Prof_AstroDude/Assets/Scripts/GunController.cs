using UnityEngine;

public class GunController : MonoBehaviour
{
    MouseController mouse;
    PlayerController player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      mouse = GameObject.Find("Main Camera").GetComponent<MouseController>();  
      player = GetComponentInParent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 shotDir = mouse.getWorldPos() - transform.position;
        if(player.facingRight) {
            transform.right = shotDir;
        }
        else
        {
            transform.right = -shotDir;
        }
    }
}
