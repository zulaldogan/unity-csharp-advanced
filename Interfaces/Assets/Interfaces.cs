using UnityEngine;

public interface Idamageable<T>
{
    void Damage(T damageAmount);
}

public interface IHealable
{
    int Healt { get; set; }
}