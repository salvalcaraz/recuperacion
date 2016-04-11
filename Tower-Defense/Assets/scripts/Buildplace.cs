using UnityEngine;
using System.Collections;

public class Buildplace : MonoBehaviour
{
    public BuildingManager bm;
    public GameObject towerPrefab;
    bool invocar = true;
    ScoreManager sm;

    void Start()
    {
        sm = GameObject.FindObjectOfType<ScoreManager>();
    }
    void Update()
    {
        if (sm.money < 5) { invocar = false; }
    }

    void OnMouseUpAsButton()
    {
        bool gastar = true;


        if (invocar)
        {
            GameObject g = (GameObject)Instantiate(towerPrefab);
            g.transform.position = transform.position + Vector3.up;
            sm.money = sm.money - sm.costeTorreta;
        }


        if (gastar)
        {
            
            gastar = false;
        }

    }
}