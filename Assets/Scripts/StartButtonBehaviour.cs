using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class StartButtonBehaviour : MonoBehaviour
{
    public void OnStartButtonClick() {
        SceneManager.LoadScene(3);
    }
}