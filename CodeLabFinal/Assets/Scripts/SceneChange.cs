using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void ChangeScene(string newScene)
    {
        Debug.Log("ChangeScene Called with: + newScene");

        SceneManager.LoadScene(newScene);
    }

    public void ChangeScene(int newScene)
    {
        Debug.Log("ChangeScene Called with: + newScene");

        SceneManager.LoadScene(newScene);
    }
}
