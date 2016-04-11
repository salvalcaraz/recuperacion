using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour
{
    public int moneyValue = 2;


    void Start()
    {

        GameObject castle = GameObject.Find("Castle");
        if (castle)
            GetComponent<NavMeshAgent>().destination = castle.transform.position;
    }

    void OnTriggerEnter(Collider co)
    {
        if (co.name == "Castle")
        {
            co.GetComponentInChildren<Health>().decrease();
            GameObject.FindObjectOfType<ScoreManager>().money += moneyValue;
            Destroy(gameObject);
        }


    }
}
