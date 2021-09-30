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
    private bool isInput;

    void Start()
    {
        // joystickcanvas = GameObject.Find("JoystickCanvas");
        // if(joystickcanvas){
        //     Debug.Log("load succesed");
        // }
        // Debug.Log("??");
        // if(instance == null)
        // {
        //     DontDestroyOnLoad(joystickcanvas);
        //     instance = this;
        //     Debug.Log("work");
        // }
        // else {
        //     Destroy(this.gameObject);
        //     Debug.Log("not work");
        // }
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
    public void OnBeginDrag(PointerEventData eventData){
        ControlJoystick(eventData);
        isInput = true;
    }

    public void OnDrag(PointerEventData eventData){
        ControlJoystick(eventData);
    }

    public void ControlJoystick(PointerEventData eventData){
        var inputDir = eventData.position - rectTransform.anchoredPosition;
        var clampedDir = inputDir.magnitude< stickRange ? inputDir : inputDir.normalized * stickRange;
        stick.anchoredPosition = clampedDir;
        inputVector = clampedDir / stickRange;
    }

    public void OnEndDrag(PointerEventData eventData){
        stick.anchoredPosition = Vector2.zero;
        isInput = false;
    }

    private void InputControlVector(){
        // Debug.Log(inputVector.x+ "/ " + inputVector.y);
        if(playerController){
            playerController.Move(inputVector);
        }
    }
}
