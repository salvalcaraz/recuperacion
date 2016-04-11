using UnityEngine;
using System.Collections;

public class Buildplace : MonoBehaviour
{
    public BuildingManager bm;
    public GameObject towerPrefab;

    void OnMouseUpAsButton()
    {
        GameObject g = (GameObject)Instantiate(towerPrefab);
        g.transform.position = transform.position + Vector3.up;

        ScoreManager sm = GameObject.FindObjectOfType<ScoreManager>();
            if (sm.money < bm.selectedTower.GetComponent<Tower>().cost) {
            Debug.Log("not enough money");  
            return;
        }
        sm.money -= bm.selectedTower.GetComponent<Tower>().cost;

    }
 }