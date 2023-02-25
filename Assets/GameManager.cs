using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Question[] questions;
    private static List<Question> unansweredQuestions;
    private Question currentQuestion;
    [SerializeField]
    private TextMeshProUGUI questionText;
    [SerializeField]
    private TextMeshProUGUI aAnswerText;
    [SerializeField]
    private TextMeshProUGUI bAnswerText;
    [SerializeField]
    private TextMeshProUGUI cAnswerText;
    [SerializeField]
    private TextMeshProUGUI dAnswerText;
    [SerializeField]
    private Animator animator;
    

    [SerializeField]
    private float timeBetweenQuestions=1f;
    [SerializeField]
    private static int counter=6;
    void Start() {
        if(unansweredQuestions==null||unansweredQuestions.Count==0) {
            unansweredQuestions = questions.ToList<Question>();
        }
        SetCurrentQuestion();
        //Debug.Log(currentQuestion.question + " is " + currentQuestion.isA);
    }

    void SetCurrentQuestion() {
        int randomQuestionIndex=Random.Range(0, unansweredQuestions.Count);
        currentQuestion=unansweredQuestions[randomQuestionIndex];
        questionText.text = currentQuestion.question;
        if(currentQuestion.isA) {
            aAnswerText.text = "Correct";
            bAnswerText.text = "Incorrect";
            cAnswerText.text = "Incorrect";
            dAnswerText.text = "Incorrect";
        }
        if(currentQuestion.isB) {
            aAnswerText.text = "Incorrect";
            bAnswerText.text = "Correct";
            cAnswerText.text = "Incorrect";
            dAnswerText.text = "Incorrect";
        }
        if(currentQuestion.isC) {
            aAnswerText.text = "Incorrect";
            bAnswerText.text = "Incorrect";
            cAnswerText.text = "Correct";
            dAnswerText.text = "Incorrect";
        }
        if(currentQuestion.isD) {
            aAnswerText.text = "Incorrect";
            bAnswerText.text = "Incorrect";
            cAnswerText.text = "Incorrect";
            dAnswerText.text = "Correct";
        }
    }

    IEnumerator TransitionToNextQuestion() {
        unansweredQuestions.Remove(currentQuestion);
        yield return new WaitForSeconds(timeBetweenQuestions);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void UserSelectA() {
        animator.SetTrigger("Answered");
        if(currentQuestion.isA) {
            //Debug.Log("Correct!");
            //PlayerPrefs.SetInt("counter", PlayerPrefs.GetInt("counter")-1);
            counter-=1;
            if(counter==0) {
                animator.SetTrigger("Zero");
            }
            else {
                StartCoroutine(TransitionToNextQuestion());
            }
        }
        else {
            //Debug.Log("Incorrect!");
            //PlayerPrefs.SetInt("counter", 6);
            counter=6;
            StartCoroutine(TransitionToNextQuestion());
        }
        Debug.Log(counter);
        //StartCoroutine(TransitionToNextQuestion());
    }

    public void UserSelectB() {
        animator.SetTrigger("Answered");
        if(currentQuestion.isB) {
            //Debug.Log("Correct!");
            //PlayerPrefs.SetInt("counter", PlayerPrefs.GetInt("counter")-1);
            counter-=1;
            if(counter==0) {
                animator.SetTrigger("Zero");
            }
            else {
                StartCoroutine(TransitionToNextQuestion());
            }
        }
        else {
            //Debug.Log("Incorrect!");
            //PlayerPrefs.SetInt("counter", 6);
            counter=6;
            StartCoroutine(TransitionToNextQuestion());
        }
        Debug.Log(counter);
        //StartCoroutine(TransitionToNextQuestion());
    }

    public void UserSelectC() {
        animator.SetTrigger("Answered");
        if(currentQuestion.isC) {
            //Debug.Log("Correct!");
            //PlayerPrefs.SetInt("counter", PlayerPrefs.GetInt("counter")-1);
            counter-=1;
            if(counter==0) {
                animator.SetTrigger("Zero");
            }
            else {
                StartCoroutine(TransitionToNextQuestion());
            }
        }
        else {
            //Debug.Log("Incorrect!");
            //PlayerPrefs.SetInt("counter", 6);
            counter=6;
            StartCoroutine(TransitionToNextQuestion());
        }
        Debug.Log(counter);
        //StartCoroutine(TransitionToNextQuestion());
    }

    public void UserSelectD() {
        animator.SetTrigger("Answered");
        if(currentQuestion.isD) {
            //Debug.Log("Correct!");
            //PlayerPrefs.SetInt("counter", PlayerPrefs.GetInt("counter")-1);
            counter-=1;
            if(counter==0) {
                animator.SetTrigger("Zero");
            }
            else {
                StartCoroutine(TransitionToNextQuestion());
            }
        }
        else {
            //Debug.Log("Incorrect!");
            //PlayerPrefs.SetInt("counter", 6);
            counter=6;
            StartCoroutine(TransitionToNextQuestion());
        }
        Debug.Log(counter);
        //StartCoroutine(TransitionToNextQuestion());
    }
}
