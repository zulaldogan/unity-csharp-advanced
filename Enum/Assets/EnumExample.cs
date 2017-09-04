using UnityEngine;

public class EnumExample : MonoBehaviour
{
    public enum EnemyState
    {
        Searching,
        Attacking,
        Dead
    }

    public EnemyState currentEnemyState;

    void Start()
    {
        currentEnemyState = EnemyState.Searching;
    }

    void Update()
    {
        switch (currentEnemyState)
        {
            case EnemyState.Attacking:
                Debug.Log("Attacking");
                break;
            case EnemyState.Searching:
                Debug.Log("Searching");
                break;
            case EnemyState.Dead:
                Debug.Log("Dead");
                break;
        }
    }
}
