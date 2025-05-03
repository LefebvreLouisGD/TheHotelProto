using UnityEngine;
using UnityEngine.EventSystems;

public class SlotBehavior : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        DraggableBehavior draggableItem = dropped.GetComponent<DraggableBehavior>();
        draggableItem.parentAfterDrag = transform;
    }

}
