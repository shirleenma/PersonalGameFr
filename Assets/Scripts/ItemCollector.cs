using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    private int watermelons = 0;
    public TextMeshProUGUI watermelonsText;
    

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Watermelon"))
        {
            Destroy(collision.gameObject);
            watermelons++;
            watermelonsText.text = "Watermelons: " + watermelons;
        }
    }
}
