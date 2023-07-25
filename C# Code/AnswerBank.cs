using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerBank : MonoBehaviour
{
   public bool isCorrect = false;
   public Quiz_Manager quiz_Manager;

   public void Answer() {
    if(isCorrect) {
        Debug.Log("Correct Answer");
        quiz_Manager.correct();
    } else {
        Debug.Log("Wrong Answer");
        quiz_Manager.wrong();
      }
   }
}
