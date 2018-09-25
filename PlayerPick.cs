
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerPick: MonoBehaviour
{

   
    public Text countText;
    public Text gameOverText;
  

    
    private int count;

    void Start()
    {
        count = 0;
        SetCountText();
       
    }

   

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
        if(other.gameObject.CompareTag("Enemy"))
        {
            gameOverText.text = "GAME OVER!";
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
       
    }
}