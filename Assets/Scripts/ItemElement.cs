using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ItemElement : MonoBehaviour
{
    public Image icon;
    public TextMeshProUGUI itemName;
    public Button removeBtn;

    public void Init( Item item )
    {
        icon.sprite = item.itemIcon;
        itemName.text = item.itemName;
    }
}
