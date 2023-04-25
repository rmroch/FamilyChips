using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

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
        SceneManager.LoadScene("gamemenu");
    }
    
    public void LoadChipLaunch()
    {
        SceneManager.LoadScene("main");
    }

    public void LoadCoinPusher()
    {
        SceneManager.LoadScene("CoinPusher");
    }

    public void LoadCoinStacka()
    {
        SceneManager.LoadScene("CoinStacka");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
