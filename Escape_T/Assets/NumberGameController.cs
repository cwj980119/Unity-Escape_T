using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGameController : MonoBehaviour
{
    int numberA,numberB,numberC;
    int answerA= -1,answerB=-1,answerC=-1;
    int StrikeCnt=0,BallCnt=0,OutCnt=0;

    void Start()
    {
        MakeNumber();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Submit(){
        if(answerA==-1||answerB==-1||answerC==-1){
            Debug.Log("답을 입력하세요");
        }
        else{
            Check();
            LightOn();
            WriteLog();
            if(StrikeCnt>=3) GameClear();
            else if(OutCnt>=6) {
                Debug.Log("실패!");
                ResetGame();
            }
        }
    }

    void ResetGame(){
        ResetAnswers();
        MakeNumber();
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
        Debug.Log(numberA);
        Debug.Log(numberB);
        Debug.Log(numberC);
    }

    private void ResetAnswers(){
        StrikeCnt=BallCnt=0;
        answerA=-1;
        answerB=-1;
        answerC=-1;
        //카드 원위치로 돌려놓는 코드 추가
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

        if(StrikeCnt<3) OutCnt++;
    }

    void LightOn(){
        // StirkeCnt light on
        // BallCnt light on
        // OutCnt light on
    }

    private void WriteLog(){
        Debug.Log("결과"+answerA+answerB+answerC+":"+BallCnt+"B "+StrikeCnt+"S");
    }

    private void GameClear(){
        // GameClear 코드 추가
    }


}
