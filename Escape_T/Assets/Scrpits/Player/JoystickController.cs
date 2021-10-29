using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickController : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler
{
    [SerializeField]
    private RectTransform stick;
    private RectTransform rectTransform;
    [SerializeField, Range(10f,150f)]
    private float stickRange;

    private GameObject joystickcanvas;
    public PlayerController playerController;
    static public JoystickController instance;
    private Vector2 inputVector;
    private bool isInput;   //check joystick working

    void Start()
    {
        inputVector = Vector2.zero;
    }
    
    private void Update() {
        if(!isInput){
            inputVector = Vector2.zero;
        }
            InputControlVector();
    }

    private void Awake() {
        rectTransform = GetComponent<RectTransform>();
    }

    //when drag start set isInput true
    public void OnBeginDrag(PointerEventData eventData){
        ControlJoystick(eventData);
        isInput = true;
    }

    public void OnDrag(PointerEventData eventData){
        ControlJoystick(eventData);
    }

     public void CancelDrag ()
    {
        inputVector = Vector2.zero;
        SetAnchorZero();
    }

    // set inputVector with joystick move
    public void ControlJoystick(PointerEventData eventData){
        var inputDir = eventData.position - rectTransform.anchoredPosition;
        var clampedDir = inputDir.magnitude< stickRange ? inputDir : inputDir.normalized * stickRange;
        stick.anchoredPosition = clampedDir;
        inputVector = clampedDir / stickRange;
    }

    // when drag end, set isInput false
    public void OnEndDrag(PointerEventData eventData){
        SetAnchorZero();
        isInput = false;
    }

    public void SetAnchorZero(){
        stick.anchoredPosition = Vector2.zero;
    }

    //call PlayerController.Move with inputVector as an argument
    private void InputControlVector(){
        if(playerController){
            playerController.Move(inputVector);
        }
    }
}
