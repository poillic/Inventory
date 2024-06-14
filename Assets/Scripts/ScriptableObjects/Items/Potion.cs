using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu( fileName = "new Potion", menuName = "Item/Potion" )]
public class Potion : Item
{
    public override void Use()
    {
        Debug.Log( "I heal" );
    }
}
