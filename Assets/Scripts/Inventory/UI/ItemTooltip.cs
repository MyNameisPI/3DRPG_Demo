using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemTooltip : MonoBehaviour
{
    public Text itemName;
    public Text itemInfo;
    private RectTransform rectTransform;
    ContentSizeFitter ContentSizeFitter;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        ContentSizeFitter = GetComponent<ContentSizeFitter>();
    }
    public void SetupTooltip(ItemData_SO item)
    {
        itemName.text = item.itemName;
        itemInfo.text = item.description;
        LayoutRebuilder.ForceRebuildLayoutImmediate(GetComponent<RectTransform>());
    }

    public void ClearText()
    {
        itemName.text = string.Empty;
        itemInfo.text = string.Empty;
    }

    private void OnEnable()
    {
        
        UpdatePosition();
    }

    private void Update()
    {
        UpdatePosition();
    }
    public void UpdatePosition()
    {
        Vector3 mousePos = Input.mousePosition;

        Vector3[] corners = new Vector3[4];
        rectTransform.GetWorldCorners(corners);

        float width = corners[3].x - corners[0].x;
        float height = corners[1].y - corners[0].y;

        //rectTransform.position = mousePos + new Vector3(width / 2, -height / 2, 0);

        if (mousePos.y < height)
        {
            rectTransform.position = mousePos + Vector3.up * height * 0.6f;
        }
        else if (Screen.width - mousePos.x > width)
        {
            rectTransform.position = mousePos + Vector3.right * width * 0.6f;
        }
        else
        {
            rectTransform.position = mousePos + Vector3.left * width * 0.6f;
        }
    }
}
