using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Resources : MonoBehaviour
{
    // Start is called before the first frame update

    private string tcycle;
    private string tpopulate;
    private string twood;
    private string tiron;
    private string tfood;

    public Slider slider;
    public string text;
    public Text lista;
    public int cycle;
    public int populate;
    public int wood;
    public int iron;
    public float food;

    private void ConvertToText(){
        cycle = (int)slider.value;
        tcycle = " Cycle: " + cycle.ToString() + Environment.NewLine; 
        tpopulate = " Populate: " + populate.ToString() + Environment.NewLine;
        twood = " Wood: " + wood.ToString() +  Environment.NewLine;
        tiron = " Iron: " + iron.ToString() +  Environment.NewLine;
        tfood = " Food: "+ food.ToString() +  Environment.NewLine;
        text = Environment.NewLine + tcycle + tpopulate + twood + tiron + tfood;
        lista.text = text;
    }
    void Start()
    {
        ConvertToText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateCycle() {
        ConvertToText();
    }

    public void UpdatePopulation() {
        ConvertToText();
    }

    public void UpdateWood() {
        ConvertToText();
    }

    public void UpdateIron() {
        ConvertToText();
    }

    public void UpdateFood() {
        ConvertToText();
    }
}
