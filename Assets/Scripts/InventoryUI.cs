using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InventoryUI : MonoBehaviour
{
    public GameObject ItemPrefab;
    public InventorySO inventory;

    private void Start()
    {
        Refresh();
    }

    private void Update()
    {
        
    }

    public void Refresh()
    {
        foreach(Transform child in transform )
        {
            Destroy( child.gameObject );
        }

        foreach ( Item item in inventory.items )
        {
            ItemElement i = Instantiate( ItemPrefab, transform ).GetComponent<ItemElement>();
            i.Init( item );
            i.removeBtn.onClick.AddListener( 
            delegate
            {
                inventory.RemoveItem( item );
                Refresh();
            } );
        }
    }
}
