using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScrollingText : MonoBehaviour
{
    [Range(0f, 30f)]
    public float ScrollSpeed = 2;

    [SerializeField]
    TextMeshProUGUI _originalTextMesh;

    RectTransform _originalRect;


    /// <summary>
    /// if you want spaces at the end -> put \t at the end, it will be ignored, but spaces will work
    /// </summary>
    public TextMeshProUGUI TextMesh => _originalTextMesh;

    void Awake()
    {
        if (_originalTextMesh == null)
        {
            enabled = false;
            Debug.LogWarning("Scrolling text was disabled, because no original Text was asigned.");
            return;
        }

        _originalRect = _originalTextMesh.GetComponent<RectTransform>();

    }



    void Update()
    {
        MoveTransforms();
    }


    void MoveTransforms()
    {
        float distance = ScrollSpeed * 30 * Time.deltaTime;

        
        Vector3 newPos = _originalRect.localPosition;
        newPos.y += distance;
        _originalRect.localPosition = newPos;
        
    }

}


