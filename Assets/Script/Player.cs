using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private float _health;

    private float _maxHealth = 100;
    private float _damage = 10;
    private float _heal = 10;

    public UnityAction EventChangedHealth;
    public float Health => _health;
    public float MaxHealth => _maxHealth;

    public void TakeDamage()
    {
        _health -= _damage;
        _health = Mathf.Clamp(_health, 0, _maxHealth);

        EventChangedHealth?.Invoke();
    }

    public void TakeHeal()
    {
        _health += _heal;
        _health = Mathf.Clamp(_health, 0, _maxHealth);

        EventChangedHealth?.Invoke();
    }
}
