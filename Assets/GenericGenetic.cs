using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GeneticIndividual
{
    float fitnessHACK = 0;
    // sets the individual to a random one
    public void MakeRandom()
    {
        // todo
        fitnessHACK = Random.Range(0f, 100f);
    }

    public float GetFitness()
    {
        // todo
        return fitnessHACK;
    }

    public void Mutate()
    {
        // todo
        fitnessHACK += Random.Range(-1, 1);
    }

    public void SetFromParents(GeneticIndividual a, GeneticIndividual b)
    {
        // todo
        fitnessHACK = (a.GetFitness() + b.GetFitness()) / 2; 
    }
}

public class GenericGenetic
{
    public List<GeneticIndividual> individuals = new List<GeneticIndividual>();

    public int population = 50;

    public void InitialisePopulation()
    {
        individuals = new List<GeneticIndividual>();
    
        for (int i = 0 ; i < population ; i++)
        {
            individuals.Add(new GeneticIndividual());
        }
    }

    public void MakeNewPopulation()
    {
        List<GeneticIndividual> newIndividuals = new List<GeneticIndividual>();

        // TODO make the genetic stuff and crossover etc

        // temp, just make a new population
        for (int i = 0 ; i < individuals.Count ; i++)
        {
            GeneticIndividual child = new GeneticIndividual();
            child.SetFromParents(individuals[i], individuals[i]);
            newIndividuals.Add(child);
        }
        individuals.Clear();
        individuals.AddRange(newIndividuals);
    }
}
