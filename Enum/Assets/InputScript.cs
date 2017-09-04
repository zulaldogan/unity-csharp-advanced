using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour
{
    private EnumExample _enumExample;
  
    void Start()
    {
        _enumExample = GetComponent<EnumExample>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _enumExample.currentEnemyState = (EnumExample.EnemyState)Random.Range(0, 3);
        }
    }
}
