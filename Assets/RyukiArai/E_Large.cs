using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Large : EnemyBase
{
    public override void Action() { }
    private void OnTriggerExit2D(Collider2D collision)
    {
        vec *= -1;
    }
}
