using UnityEngine;
using System.Collections;

public class CastleManager : MonoBehaviour {
    public GameObject castle;

    void Update() {

        if (castle == null)
        {
            Application.LoadLevel(02);
        }
                }
}
