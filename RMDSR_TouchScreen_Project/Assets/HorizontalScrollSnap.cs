using UnityEngine;
using UnityEngine.UI;

public class HorizontalScrollSnap : MonoBehaviour
{
    public Transform[] snapPoints; // The positions to snap to (centers of text box sets)
    public RectTransform content;   // Reference to the content RectTransform

    private ScrollRect scrollRect;
    private RectTransform viewport;

    private bool isScrolling = false;

    private void Start()
    {
        scrollRect = GetComponent<ScrollRect>();
        viewport = scrollRect.viewport;

        // Set the snap points based on the positions of text box sets
        snapPoints = new Transform[content.childCount];

        float contentWidth = content.rect.width;

        for (int i = 0; i < snapPoints.Length; i++)
        {
            // Calculate snap point based on index
            float snapPointX = i * contentWidth / (snapPoints.Length - 1);

            snapPoints[i] = content.GetChild(i);

            // Set the local position directly
            snapPoints[i].localPosition = new Vector2(snapPointX, snapPoints[i].localPosition.y);

            Debug.Log($"Snap Point {i}: {snapPoints[i].position}");
        }

    }

    private void Update()
    {
        if (!isScrolling)
        {
            SnapToClosest();
        }
    }

    private void SnapToClosest()
    {
        float closestDistance = float.MaxValue;
        Transform closestTransform = null;

        // Calculate the center of the viewport
        float viewportCenter = viewport.rect.width * 0.5f;

        // Calculate the center of the content
        float contentCenter = content.rect.width * 0.5f;

        // Calculate the left and right boundaries of the content
        float leftBoundary = contentCenter - viewportCenter;
        float rightBoundary = contentCenter + viewportCenter;

        // Iterate through snap points to find the closest one
        foreach (Transform snapPoint in snapPoints)
        {
            // Calculate the distance from the center of the content to the center of the snap point
            float distance = Mathf.Abs(content.position.x + contentCenter - snapPoint.position.x);

            if (distance < closestDistance && snapPoint.position.x >= leftBoundary && snapPoint.position.x <= rightBoundary)
            {
                closestDistance = distance;
                closestTransform = snapPoint;
            }
        }

        // Snap to the closest transform
        if (closestTransform != null)
        {
            float targetX = closestTransform.position.x - contentCenter;
            targetX = Mathf.Clamp(targetX, 0, content.rect.width - viewport.rect.width);
            scrollRect.content.anchoredPosition = new Vector2(targetX, 0);
        }
    }

    public void OnScrolling()
    {
        isScrolling = true;
    }

    public void OnScrollEnd()
    {
        isScrolling = false;
    }
}