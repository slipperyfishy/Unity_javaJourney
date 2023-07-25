using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Quiz_Manager : MonoBehaviour {

    public List <QuizBank> QB;
    public GameObject[] options;
    public int currentQuestions;

    public GameObject Question_Format;
    public GameObject LScore_Page;
    public GameObject WScore_Page;

    public TextMeshProUGUI QuestionTxt;
    public TextMeshProUGUI LScoreTxt;
    public TextMeshProUGUI WScoreTxt;

    int totalQuestions = 0;
    public int score;

    private void Start() {
        totalQuestions = QB.Count;
        LScore_Page.SetActive(false);
        WScore_Page.SetActive(false);
        generateQuestion();
    }

    private void retry() {
        int i = 0;
        while (score <= 8) {
            if (i != 4 ) {
                continue;
                i++;
            }
        SceneManager.LoadScene(0);
        }
    }

    void gameOver() {
        Question_Format.SetActive(false);
        if (score <= 8) {
            LScore_Page.SetActive(true);
            LScoreTxt.text = score + "/"+ totalQuestions;
        } else {
          WScore_Page.SetActive(true);
          WScoreTxt.text = score + "/"+ totalQuestions;
          Debug.Log ("To the minigame");
          Debug.Log ("To the minigame");
          Debug.Log ("To the minigame");
          Debug.Log ("To the minigame");
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
          }
    }

    public void correct() {
        score += 1;
        QB.RemoveAt(currentQuestions);
        generateQuestion();
    }

    public void wrong() {
        generateQuestion();
        QB.RemoveAt(currentQuestions);
    }

    void SetAnswers() {
        for (int i = 0; i < options.Length; i++) {
            options[i].GetComponent<AnswerBank>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = QB[currentQuestions].Answers[i];

            if(QB[currentQuestions].correctAnswer == i+1) {
                options[i].GetComponent<AnswerBank>().isCorrect = true;
            }
        }
    }

    void generateQuestion() {

        if(QB.Count >0) {
            currentQuestions = Random.Range(0,QB.Count);
            QuestionTxt.text = QB[currentQuestions].Question;

            SetAnswers();
        } else {
            Debug.Log ("Out of Questions");
            gameOver();
        }
    }
}
