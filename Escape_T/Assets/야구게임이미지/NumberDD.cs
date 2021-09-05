using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NumberDD : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    [SerializeField] private Canvas canvas;
    public bool onSlot;
    public Vector2 InitialLoc;
    public int number;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    private void Start() {
        onSlot = false;
        InitialLoc = rectTransform.anchoredPosition; 
    }

    private void Awake() {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData) {
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData) {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData) {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts= true;
        if(!onSlot) {
            InitLoc();
        }
    }

    public void OnPointerDown(PointerEventData eventData) {

    }

    public void OnDrop(PointerEventData eventData) {
    }

    public void InitLoc(){
        rectTransform.anchoredPosition = InitialLoc;
        onSlot = true;
    }
}
