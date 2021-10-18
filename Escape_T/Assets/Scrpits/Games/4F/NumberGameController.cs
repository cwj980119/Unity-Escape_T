using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class NumberGameController : MonoBehaviour
{
    int numberA,numberB,numberC;
    int answerA= -1,answerB=-1,answerC=-1;
    int StrikeCnt=0,BallCnt=0,OutCnt=0;
    public GameObject [] card = new GameObject[9];
    public GameObject [] slot = new GameObject[3];
    public GameObject [] green = new GameObject[3];
    public GameObject [] yellow = new GameObject[3];
    public GameObject [] red = new GameObject[6];
    private GameObject bbgamecanvas;
    private Text logText;
    private GameObject bbclearpanel;

    void Start()
    {
        // gameObject.SetActive(false);
        MakeNumber();
        SetCardnSlot();
        SetLightsFalse();
        SetClearPanelFalse();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetCardnSlot(){
        for(int i=0;i<9;i++){
            card[i]=GameObject.Find("NumCard"+(i+1).ToString());
        }
        for(int i=0;i<3;i++){
            slot[i]=GameObject.Find("Slot"+(i+1).ToString());
        }
        for(int i=0;i<3;i++){
            green[i]=GameObject.Find("Green"+(i+1).ToString());
        }
        for(int i=0;i<3;i++){
            yellow[i]=GameObject.Find("Yellow"+(i+1).ToString());
        }
        for(int i=0;i<6;i++){
            red[i]=GameObject.Find("Red"+(i+1).ToString());
        }
        bbclearpanel = GameObject.Find("BBClearPanel");
        logText = GameObject.Find("ResultLog").GetComponent<Text>();
    }

    public void Submit(){
        if(answerA==-1||answerB==-1||answerC==-1){
            // logText.text+="답을 입력하세요\n";
            Debug.Log("답을 입력하세요");
        }
        else{
            Check();
            LightOn();
            WriteLog();
            if(StrikeCnt>=3) GameClear();
            else if(OutCnt>=6) {
                Debug.Log("실패!"); //실패 UI뜨게
                ResetGame();
            }
            else StrikeCnt=BallCnt=0;
        }
    }

    public void ResetGame(){
        OutCnt=0;
        ResetAnswers();
        ResetCard();
        MakeNumber();
        SetLightsFalse();
        ResetLog();
        //log clear 코드 추가
    }

    private void MakeNumber()
    {
        numberA = Random.Range(1,9);
        do{
            numberB = Random.Range(1,9);
        }while(numberB==numberA);
        do{
            numberC = Random.Range(1,9);
        }while(numberC==numberA||numberC==numberB);
        Debug.Log("답: "+numberA+","+numberB+","+numberC);
    }


    private void SetLightsFalse(){
        for(int i=0;i<3;i++){
            green[i].GetComponent<LightController>().TurnOff();
        }
        for(int i=0;i<3;i++){
            yellow[i].GetComponent<LightController>().TurnOff();
        }
        for(int i=0;i<6;i++){
            red[i].GetComponent<LightController>().TurnOff();
        }
    }

    private void SetClearPanelFalse(){
        bbclearpanel.GetComponent<BBClearPanelController>().PanelOff();
    }

    private void SetClearPanleTrue(){
        bbclearpanel.GetComponent<BBClearPanelController>().PanelOn();
    }

    public void ResetTable(){
        ResetAnswers();
        ResetCard();
        ResetLight();
    }

    private void ResetAnswers(){
        StrikeCnt=BallCnt=0;
        answerA=-1;
        answerB=-1;
        answerC=-1;
    }

    private void ResetCard(){
        for(int i=0;i<9;i++){
            card[i].GetComponent<NumberDD>().InitLoc();
        }
        for(int i=0;i<3;i++){
            slot[i].GetComponent<NumberSlot>().exist=true;
        }
    }

    private void ResetLight(){
        for(int i=0;i<3;i++){
            green[i].GetComponent<LightController>().TurnOff();
        }
        for(int i=0;i<3;i++){
            yellow[i].GetComponent<LightController>().TurnOff();
        }
    }

    private void ResetLog(){
        logText.text="";
    }

    private void Check(){
        if(answerA==numberA) StrikeCnt++;
        else if(answerA==numberB) BallCnt++;
        else if(answerA==numberC) BallCnt++;

        if(answerB==numberB) StrikeCnt++;
        else if(answerB==numberA) BallCnt++;
        else if(answerB==numberC) BallCnt++;

        if(answerC==numberC) StrikeCnt++;
        else if(answerC==numberA) BallCnt++;
        else if(answerC==numberB) BallCnt++;

        if(StrikeCnt<3) {
            red[OutCnt].GetComponent<LightController>().TurnOn();
            OutCnt++;
        }
    }

    void LightOn(){
        // StirkeCnt light on
        for(int i=0;i<StrikeCnt;i++) yellow[i].GetComponent<LightController>().TurnOn();
        // BallCnt light on
        for(int i=0;i<BallCnt;i++) green[i].GetComponent<LightController>().TurnOn();
    }

    private void WriteLog(){
        if(BallCnt==0&&StrikeCnt==0){
            logText.text+="OUT!\n";
        }
        else{
        logText.text+=answerA.ToString()+answerB.ToString()+answerC.ToString()+":"+BallCnt+"B "+StrikeCnt+"S\n";
        }
        Debug.Log("결과"+answerA+answerB+answerC+":"+BallCnt+"B "+StrikeCnt+"S");
    }

    private void GameClear(){
        logText.text+="Game Clear!!\n";
        // GameClear 코드 추가
        SetClearPanleTrue();
    }

    public void SetAnsA(int a){
        answerA = a;
    }

    public void SetAnsB(int b){
        answerB = b;
    }

    public void SetAnsC(int c){
        answerC = c;
    }

    public void CloseNumberGame(){
        bbgamecanvas = GameObject.Find("Canvas");
        bbgamecanvas.SetActive(false);
    }
}
