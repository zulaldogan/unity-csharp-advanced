using UnityEngine;

using System.Collections.Generic;

public class ListExample : MonoBehaviour
{
    public List<int> ages = new List<int>();
    public List<GameObject> objects = new List<GameObject>();
    public List<string> myStrings = new List<string>();

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ages.Add(Random.Range(1, 100));
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ages.Remove(ages[Random.Range(0, ages.Count)]);
        }
    }
}
