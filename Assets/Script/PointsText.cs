using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsText : MonoBehaviour
{
    public Text pointsText;
    public GameManager gameManager;
    public Coin coin;


    private void Update()
    {
        pointsText.text = "points" + gameManager.GetPunt();
       
    }
    
}
