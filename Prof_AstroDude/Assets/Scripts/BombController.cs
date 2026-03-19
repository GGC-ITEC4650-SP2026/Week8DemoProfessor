using UnityEngine;

public class BombController : MonoBehaviour
{
    SelectorController selectCon;
    SpriteRenderer mySprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mySprite = GetComponentInChildren<SpriteRenderer>();
        selectCon = GameObject.Find("Selector").GetComponent<SelectorController>();
    }

    public void makeRed()
    {
        mySprite.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if(selectCon.selected == transform && Input.GetButtonDown("Jump"))
        {
            makeRed();
        }
    }
}
