using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CubeScene : MonoBehaviour
{
    public void ButtonClicked()
    {
        SceneManager.LoadScene("CubeScene");
    }
}