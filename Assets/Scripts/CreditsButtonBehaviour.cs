using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class CreditsButtonBehaviour : MonoBehaviour
{
    public void OnCreditsButtonClick() {
        SceneManager.LoadScene(1);
    }
}