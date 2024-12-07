using UnityEngine;
using UHFPS.Runtime;

public class AbrirNevera : MonoBehaviour, IDynamicUnlock, IInventorySelector
{
    public ItemGuid UnlockItem;
    private DynamicObject dynamicObject;

    public void OnTryUnlock(DynamicObject dynamicObject)
    {
        Inventory.Instance.OpenItemSelector(this);
        this.dynamicObject = dynamicObject;
    }

    public void OnInventoryItemSelect(Inventory inventory, InventoryItem selectedItem)
    {
        if (selectedItem.ItemGuid != UnlockItem)
            return;

        // unlock dynamic object
        dynamicObject.TryUnlockResult(true);
    }
    public void Unlock(DynamicObject dynamicObject)
    {
        //Inventory.Instance.OpenItemSelector(this);
        //this.dynamicObject = dynamicObject;
        dynamicObject.TryUnlockResult(true);
    }
}