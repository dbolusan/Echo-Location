using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class BackgroundButtonBehaviour : MonoBehaviour
{
    public void OnBackgroundButtonClick() {
        SceneManager.LoadScene(2);
    }
}