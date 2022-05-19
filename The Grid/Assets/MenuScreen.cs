using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScreen : MonoBehaviour
{

    public void StartScene()
    {
        SceneManager.LoadScene("level1 test");
    }
}
