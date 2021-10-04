using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpectPosition : MonoBehaviour
{
    public GameObject Player;
    public GameObject Place;
    GameObject Student;
    GameObject Witch;

    void Strat()
    {
        Student = GameObject.Find("student");
        Witch = GameObject.Find("Pyo");

        Player = Student;
        Place = Witch;

        Player.transform.position = Place.transform.position;
    }
}
