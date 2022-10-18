using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    FileStream fs;
    StreamWriter sw;
    StreamReader sr;

    public int points = 0;

    void Start()
    {

        points = GetPunt();
        if (!instance)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }



    }
    void Update()
    {
        fs = File.Create(Application.persistentDataPath + "/text.txt"); 
        sw = new StreamWriter(fs);
        sw.WriteLine("points" + GetPunt());//escribir

        sw.Close(); //guardar lo que se escribe
        fs.Close();
        sr = new StreamReader(Application.persistentDataPath + "/text.txt"); 
    }

    public int GetPunt()
    {
        return points;
    }

}
