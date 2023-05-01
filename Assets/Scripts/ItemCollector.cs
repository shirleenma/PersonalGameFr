using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private int watermelons = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Watermelon"))
        {
            Destroy(collision.gameObject);
            watermelons++;
            Debug.Log("Watermelon: " + watermelons);
        }
    }
}
