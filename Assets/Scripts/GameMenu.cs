using UnityEngine;
using System.Collections;

public class GameMenu : MonoBehaviour {

    public void LoadChipLaunch()
    {
        Application.LoadLevel("main");
    }

    public void LoadPachinko()
    {
        Application.LoadLevel("pachinko");
    }
}
