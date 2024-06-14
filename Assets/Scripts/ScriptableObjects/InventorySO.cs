using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu( fileName = "new Inventory", menuName = "Item/Inventory" )]
public class InventorySO : ScriptableObject
{
    public List<Item> items = new List<Item>();
    public void AddItem( Item item )
    {
        items.Add( Instantiate( item ) );
    }

    public void RemoveItem( Item item )
    {
        items.Remove( item );
    }
}
