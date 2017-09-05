using UnityEngine;

[System.Serializable]
public class Book
{
    public int price;
    public string title;
    public string author;

    public Book(int p, string t, string a)
    {
        this.price = p;
        this.title = t;
        this.author = a;
    }
}

[System.Serializable]
public struct Game
{
    public int gamePrice;
    public int company;
    public int platform;
}

public class Player : MonoBehaviour
{
    public Book UnityProgramming = new Book(30,"Unity 3D","W.W.T");
    public Game UnityGaming;
}
