using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{

    public EventSystem evs;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        evs = GameObject.Find("EventSystem").GetComponent<EventSystem>();
    }

    public void show(bool on)
    {
        gameObject.SetActive(on);
    }

    public void activateBtns(bool on)
    {
        foreach(Button b in GetComponentsInChildren<Button>())
        {
            b.interactable = on;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
