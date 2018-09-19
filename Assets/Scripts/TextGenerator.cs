using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextGenerator : MonoBehaviour
{
    /*
     *  Tasks:
     *      1. Break down title into 2 parts. [1. Relevant meme 2. Art Flair]
     *      2. Make dates a random date range.
     */
    public Text titleAndDate;
    public Text medium;
    public Text dimension;

    public string[] titleStart;
    public string[] titleEnd;
    public string[] dateBank;
    public string[] mediumBank;
    public string[] dimensionBank;

    public void Start()
    {
        GenNewLabel();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GenNewLabel();
            print("Gen new label");
        }    
    }

    private void GenNewLabel()
    {
        string datePicker = dateBank[Random.Range(0, dateBank.Length)];
        titleAndDate.text = "<b><i>" +titleStart[Random.Range(0,titleStart.Length)]+" "+titleEnd[Random.Range(0, titleEnd.Length)]+"</i></b>"+ ", "+datePicker;
        medium.text = mediumBank[Random.Range(0, mediumBank.Length)];
        dimension.text = dimensionBank[Random.Range(0, dimensionBank.Length)];
    }
}