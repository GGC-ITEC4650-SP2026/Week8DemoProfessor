using UnityEngine;

public class BombController : MonoBehaviour
{
    SpriteRenderer mySprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mySprite = GetComponentInChildren<SpriteRenderer>();        
    }

    public void makeRed()
    {
        mySprite.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
