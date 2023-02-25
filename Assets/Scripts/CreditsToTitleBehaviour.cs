using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class CreditsToTitleBehaviour : MonoBehaviour
{
    public void OnTitleButtonClick() {
        SceneManager.LoadScene(0);
    }
}