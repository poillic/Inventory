using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu( fileName = "new Armor", menuName = "Item/Armor" )]
public class Armor : Item
{
    public override void Use()
    {
        Debug.Log( "Je r�duit les d�gats de 5 !" );
    }


}
