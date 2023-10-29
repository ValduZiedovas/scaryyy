using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public string Scene;

    public void OnMouseDownAsButton()
    {
        SceneManager.LoadScene(Scene);   
    }
}
