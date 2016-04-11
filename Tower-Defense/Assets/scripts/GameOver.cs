using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour
{


    public void MaintMenu()
    {
        Application.LoadLevel(0);
    }

    public void TryAgain()
    {
        Application.LoadLevel(1);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
