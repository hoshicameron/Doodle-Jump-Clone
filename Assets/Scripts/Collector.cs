using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Platform"))
        {
            other.gameObject.transform.position=new Vector3(Random.Range(-4f,4f),Mathf.RoundToInt(player.transform.position.y+Random.Range(14,15)),0f);
        }
        else if (other.CompareTag("Spring"))
        {
            other.gameObject.transform.position=new Vector3(Random.Range(-4f,4f),Mathf.RoundToInt(player.transform.position.y+Random.Range(15,30)),0f);
        }
    }
}
