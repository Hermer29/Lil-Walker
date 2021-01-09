using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pickables;

public class Coin : Pickable
{
    protected override void PickAction(Collision other)
    {
        other.gameObject.GetComponent<Player>().IncreaseScore(1);
    }
}
