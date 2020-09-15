using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIGameHandler : MonoBehaviour
{
    

    public void ClickExit(){
        Application.Quit();
        Debug.Log("Clickexit");
    }

    public void NewScene(){
        SceneManager.LoadScene("Story");
        Debug.Log("Story Scene called");

    }

    public void progamiz(){
        Application.OpenURL("https://www.programiz.com/c-programming#introduction");
    }
    public void wiki(){
        Application.OpenURL("https://en.wikipedia.org/wiki/C_(programming_language)");
    }
    public void tutpoint(){
        Application.OpenURL("https://www.tutorialspoint.com/cprogramming/index.htm");
    }
}
