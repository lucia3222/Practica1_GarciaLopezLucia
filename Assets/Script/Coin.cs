using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public GameManager gameManager;
    public Text pointsText;
   

    
    void OnTriggerEnter(Collider other)
    {
        StartCoroutine("Fade");
        gameManager.points++;
        

    }
    



    IEnumerator Fade() //TRANSPARENCIA
    {
        
        for (float i = 1.0f; i >= 0f; i -= 0.2f)
        {
            Color c = pointsText.material.color;
            c.a = i;
            pointsText.material.color = c;
            yield return new WaitForSeconds(0.2f);
        }
        
        for (float i = 0f; i <= 1.00f; i += 0.2f)
        {
            Color c = pointsText.material.color;
            c.a = i;
            pointsText.material.color = c;
            yield return new WaitForSeconds(0.2f);
            
        }
        this.gameObject.SetActive(false);
       
    }
}
