using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsSwitch : MonoBehaviour
{
    public void TitleToCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void CreditsToTitle()
    {
        SceneManager.LoadScene("TitleScreen");
    }
}
