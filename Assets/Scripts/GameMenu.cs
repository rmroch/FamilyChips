using UnityEngine;
using System.Collections;

public class GameMenu : MonoBehaviour {
    public GameObject OptionsPanel;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("esc");
            if (OptionsPanel.activeInHierarchy)
            {
                OptionsPanel.SetActive(false);
            }
            else
            {
                OptionsPanel.SetActive(true);
            }
        }
    }

    public void LoadGameMenu()
    {
        Application.LoadLevel("gamemenu");
    }
    
    public void LoadChipLaunch()
    {
        Application.LoadLevel("main");
    }

    public void LoadPachinko()
    {
        Application.LoadLevel("pachinko");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
