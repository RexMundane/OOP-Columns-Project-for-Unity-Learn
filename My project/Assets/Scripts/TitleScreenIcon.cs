using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenIcon : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Scene Transition goes Here");
    }
}
