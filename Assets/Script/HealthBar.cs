using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _player.ChangingHealth += OnChangingHealth;
    }

    private void OnDisable()
    {
        _player.ChangingHealth -= OnChangingHealth;
    }

    private void OnChangingHealth()
    {
        float target = _player.Health / _player.MaxHealth;
        _image.DOFillAmount(target, _image.fillAmount);
    }
}
