using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject drawer;
    private bool switchBool = true;

    public void ToDraw()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Settings");
    }

    public void ActivateDrawer()
    {
        switchBool = !switchBool;
        if (switchBool == true)
            drawer.SetActive(true);
        if (switchBool == false)
            drawer.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
