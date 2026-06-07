using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class TopDownSorting : MonoBehaviour
{
    private const int Precision = 100;
    private const int MinOrder = short.MinValue;
    private const int MaxOrder = short.MaxValue;

    private SpriteRenderer sr;
    private int lastOrder;

    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void OnEnable()
    {
        UpdateSortingOrder();
    }

    void LateUpdate()
    {
        UpdateSortingOrder();
    }

    private void UpdateSortingOrder()
    {
        int order = Mathf.Clamp(-Mathf.RoundToInt(transform.position.y * Precision), MinOrder, MaxOrder);
        if (order != lastOrder)
        {
            sr.sortingOrder = order;
            lastOrder = order;
        }
    }
}