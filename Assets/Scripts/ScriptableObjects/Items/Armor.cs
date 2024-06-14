using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu( fileName = "new Armor", menuName = "Item/Armor" )]
public class Armor : Item
{
    public override void Use()
    {
        Debug.Log( "Je réduit les dégats de 5 !" );
    }


}
