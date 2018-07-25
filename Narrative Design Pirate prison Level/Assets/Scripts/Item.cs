using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new item", menuName = "Inventory/item")]
public class Item : ScriptableObject {

    new public string name = "New item";
    public Sprite icon = null;
    public bool isDefaultitem = false;

    public virtual void Use()
    {
        Debug.Log("using" + name);
    }
}
