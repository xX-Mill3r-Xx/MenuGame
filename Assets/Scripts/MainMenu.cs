using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    private bool activeMenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            activeMenu = !activeMenu;
            pauseMenu.SetActive(activeMenu);
        }
    }

    public void startGame()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void ExitOptions(GameObject sair)
    {
        sair.SetActive(false);
    }

    public void ActiveOptionsMenu(GameObject ativar)
    {
        ativar.SetActive(true);
    }
}
