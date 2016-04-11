using UnityEngine;
using System.Collections;

public class CastleManager : MonoBehaviour {
    public GameObject castle;
    public GameObject gameover;
    void Update() {

        if (castle == null)
        {
            Time.timeScale = 0;
            gameover.SetActive(true);
        }
                }
}
