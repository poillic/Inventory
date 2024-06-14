using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu( fileName = "new Sword", menuName = "Item/Sword" )]
public class Sword : Item
{
    public override void Use()
    {
        Debug.Log( "I slash people" );
    }
}
