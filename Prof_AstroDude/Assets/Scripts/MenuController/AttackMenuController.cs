using UnityEngine;

public class AttackMenuController : MenuController
{
    public void Start()
    {
        base.Start();
        show(false);
    }

    public void swordAttack()
    {
        print("Sword Attack!");
    }
}
