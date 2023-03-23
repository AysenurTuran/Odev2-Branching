using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private AudioClip clicksound;
    private int count = 0;
    

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Collectible"))
        {
            Debug.Log(count);
            count *= 4;
            AudioSource.PlayClipAtPoint(clicksound,col.transform.position);
            Destroy(col.gameObject);
        }
    }
}
