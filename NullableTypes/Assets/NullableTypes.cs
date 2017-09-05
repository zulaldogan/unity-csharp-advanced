using UnityEngine;

public class NullableTypes : MonoBehaviour
{
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.Space)) ;
        {
            CreateUser("Unity 3D", null, true);
        }
    }

    void CreateUser(string name, int? age, bool isCool)
    {
        int finalAge = age ?? 26;
        Debug.Log("Name: " + name);
        Debug.Log(("IsCool :" + isCool));
        Debug.Log("Age :" + finalAge);
    }
}