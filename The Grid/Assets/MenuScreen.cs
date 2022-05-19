using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScreen : MonoBehaviour
{
    public GameObject fade;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeBlackOutSquare(false));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            StartCoroutine(FadeBlackOutSquare());
            StartCoroutine(Wait());
        }
    }

    public IEnumerator FadeBlackOutSquare(bool fadeToBlack = true, int fadeSpeed = 1)
    {
        Color objectColor = fade.GetComponent<Image>().color;
        float fadeAmount;
        Debug.Log("fade");
        if (fadeToBlack)
        {
            Debug.Log("Your inside fade to black outside while loop");
            while (fade.GetComponent<Image>().color.a < 1)
            {
                Debug.Log("Inside the while loop");
                fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);

                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                fade.GetComponent<Image>().color = objectColor;
                yield return null;
            }
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        NextScene();
    }
    public void NextScene()
    {
        SceneManager.LoadScene("level1 test");

    }

}

