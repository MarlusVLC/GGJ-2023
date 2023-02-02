using System;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] private string healthAccessor;
    
    private void Start()
    {
        PlayerPrefs.SetFloat("Health", health);
    }
}
