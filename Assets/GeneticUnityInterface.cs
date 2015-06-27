using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GeneticUnityInterface : MonoBehaviour
{

    public Text infoText;

    public GenericGenetic geneticAlgo;

	// Use this for initialization
	void Start () {
        geneticAlgo = new GenericGenetic();
	}

    public void InitPopulationCallback()
    {
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
        string info = string.Join(", ", geneticAlgo.individuals.ConvertAll((i) => i.GetFitness().ToString()).ToArray());

        infoText.text = info;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
