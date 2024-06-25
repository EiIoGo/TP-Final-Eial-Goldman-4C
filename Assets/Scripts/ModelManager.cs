using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelManager : MonoBehaviour
{
    public GameObject[] models;
    public int currentIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            NextModel();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            PreviousModel();
        }
    }

    void NextModel()
    {
        models[currentIndex].SetActive(false);
        if (currentIndex == models.Length - 1)
        {
            currentIndex = 0;
        }
        models[++currentIndex].SetActive(true);
    }

    void PreviousModel()
    {
        models[currentIndex].SetActive(false);
        if (currentIndex == 0)
        {
            currentIndex = models.Length - 1;
        }
        models[--currentIndex].SetActive(true);
    }
}
