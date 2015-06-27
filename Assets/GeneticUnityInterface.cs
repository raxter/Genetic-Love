using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GeneticUnityInterface : MonoBehaviour
{

    public Text infoText;

    public GenericGenetic geneticAlgo;

	// Use this for initialization
	void Start ()
    {
        Debug.Log("Start");
        geneticAlgo = new GenericGenetic();
        infoText.text = "Press init to init";
	}

    public void InitPopulationCallback()
    {
        Debug.Log("InitPopulationCallback");
        geneticAlgo.InitialisePopulation();
        RefreshUI();
    }

    public void IncrementPopulationcallback()
    {
        geneticAlgo.MakeNewPopulation();
        RefreshUI();
    }

    void RefreshUI()
    {
        string info = geneticAlgo.individuals.Count.ToString() + "\n";
        info += string.Join(", ", geneticAlgo.individuals.ConvertAll((i) => i.GetFitness().ToString()).ToArray());

        infoText.text = info;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
