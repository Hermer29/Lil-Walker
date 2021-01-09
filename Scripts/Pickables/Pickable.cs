using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pickables
{

public abstract class Pickable : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.GetComponent<Player>() != null)
        {
            PickAction(other);
        }
    }

    protected abstract void PickAction(Collision other);
}
}
