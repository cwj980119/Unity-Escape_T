using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElevatorChange : MonoBehaviour
{
    public void Elevatorclick()
    {
        SceneManager.LoadScene("ElevatorButton");

        Invoke("Elevator2", 2);

        void Elevator2()
        {
            SceneManager.LoadScene("Elevator2");
        }

        Invoke("Elevator7", 2);

        void Elevator7()
        {
            SceneManager.LoadScene("Elevator7");
        }
        Invoke("Elevator5", 2);

        void Elevator5()
        {
            SceneManager.LoadScene("Elevator5");
        }
    }
}
