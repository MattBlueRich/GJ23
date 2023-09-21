using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject Word1, Word2, Word3, Word4, Word5;

    public int WordCount = 1;

    // Start is called before the first frame update
    void Start()
    {
        SpawnWord();
    }

    public void SpawnWord()
    {
        switch (WordCount)
        {
            case 1:
                // instantiate word 1
                Instantiate(Word1); //,Vector2 ())
                break;
            case 2:
                // instantiate word 2
                Instantiate(Word2);
                break;
            case 3:
                // instantiate word 3
                Instantiate(Word3);
                break;
            case 4:
                // instantiate word 4
                Instantiate(Word4);
                break;
            case 5:
                // you get the idea
                Instantiate(Word5);
                break;
            default:
                break;
        }
        WordCount++;
    }
}
