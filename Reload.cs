﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
    public void LoadScene4()
    {
        SceneManager.LoadScene("Fase4");
    }
}
