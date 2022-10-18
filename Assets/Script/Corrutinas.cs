using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Corrutinas : MonoBehaviour
{
    public Image img;
    //crono
    public const float MAX_TIME = 3.0F;
    private float currentTime = 0.0f;//crono

    void Start()
    {
        StartCoroutine(Fade());
    }

    IEnumerator Fade() //TRANSPARENCIA
    {

        for (float i = 1.0f; i >= 0f; i -= 0.1f)
        {
            Color c = img.material.color;
            c.a = i;
            img.material.color = c;
            yield return new WaitForSeconds(0.5f);
        }
    }
    //crono
    void Update()
    {
        currentTime += Time.deltaTime; // currentTime -= Time.deltaTime; CUENTA REGRESIVA
        if (currentTime > MAX_TIME)    //if (currentTime <= 0f)
        {
            Debug.LogError("TIEMPO");//error tiempo
        }
    }
    //crono
    //cada update tien un detatime distinto ( update, lateupdate fixedupdate)
}
