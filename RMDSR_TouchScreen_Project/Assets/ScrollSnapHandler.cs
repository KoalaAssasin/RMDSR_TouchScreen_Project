using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ScrollSnapHandler : MonoBehaviour, IBeginDragHandler, IEndDragHandler
{
    public HorizontalScrollSnap horizontalScrollSnap;

    public void OnBeginDrag(PointerEventData eventData)
    {
        horizontalScrollSnap.OnScrolling();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        horizontalScrollSnap.OnScrollEnd();
    }
}