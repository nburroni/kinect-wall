using UnityEngine;
using System.Collections;
using Vuforia;

public class GameController : MonoBehaviour
{

    public static GameController instance = null;

    private Character characterOne = null;
    private Character characterTwo = null;

    float distance;

    void Awake ()
	{
	    if (instance == null) instance = this;
	}

    void Update()
    {
        distance = (!characterOne || !characterTwo)
            ? -1
            : Vector3.Distance(characterOne.transform.position, characterTwo.transform.position);
        if ((distance < 1.2f && distance >= 0f) && !(characterOne.Dead || characterTwo.Dead))
        {
            Debug.Log("ATTACK!");
            if (characterOne.power < characterTwo.power)
            {
                characterOne.Die();
                Debug.Log(string.Format("{0} dead.", characterOne));
            }
            else
            {
                characterTwo.Die();
                Debug.Log(string.Format("{0} dead.", characterTwo));
            }
        }
    }

    public void CharacterEnter(Character character)
    {
        if (characterOne == null)
            characterOne = character;
        else if (characterTwo == null)
            characterTwo = character;

        PrintCharacters();
    }
    public void CharacterExit(Character character)
    {
        if (characterOne == character)
        {
            characterOne = characterTwo;
            characterTwo = null;
        }
        else if (characterTwo == character)
            characterTwo = null;

        PrintCharacters();
    }

    private void PrintCharacters()
    {
        Debug.Log(string.Format("C1: {0} C2: {1} \nDistance: {2}", characterOne, characterTwo, distance));
    }
}
