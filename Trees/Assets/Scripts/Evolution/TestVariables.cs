using UnityEngine;
using System.Collections;

[System.Serializable]
public class Game
{

    public static Game current;
    public Tree maxHeight;
    public Tree startingEnergy;
    public Tree maxNumberOfBranches;

    public Game()
    {
        maxHeight = new Tree();
        startingEnergy = new Tree();
        maxNumberOfBranches = new Tree();
    }

}