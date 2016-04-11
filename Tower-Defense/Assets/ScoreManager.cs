using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public int money = 100;
    public Text moneyText;
    public int costeTorreta = 5;

	void Start () {
	
	}
	
	void Update () {
        moneyText.text = money.ToString();

	}
}
