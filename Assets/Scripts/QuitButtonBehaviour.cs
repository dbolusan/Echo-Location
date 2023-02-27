using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class QuitButtonBehaviour : MonoBehaviour
{
    public void OnQuitButtonClick() {
        Application.Quit();
    }
}