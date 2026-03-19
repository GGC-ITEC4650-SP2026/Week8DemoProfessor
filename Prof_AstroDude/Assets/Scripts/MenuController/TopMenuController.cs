using UnityEngine;
using UnityEngine.UI;

public class TopMenuController : MenuController
{
    public void activateSubMenu(GameObject g)
    {
        activateBtns(false);
        g.GetComponent<MenuController>().show(true);
        evs.SetSelectedGameObject(
            g.GetComponentInChildren<Button>().gameObject);
    }
}

