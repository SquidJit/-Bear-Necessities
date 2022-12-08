using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitHealth
{

    private bool isPlayer = false;
    //fields
    private int _currentHealth;
    private int _MaxHealth;

    //Properties
    public int Health
    {
        get
        {
            return _currentHealth;
        }
        set
        {
            _currentHealth = value;
        }
    }

    public int MaxHealth
    {
        get
        {
            return _MaxHealth;
        }
        set
        {
            _MaxHealth = value;
        }
    }

    //Constructor

    public UnitHealth(int health, int maxhealth)
    {
        _currentHealth = health;
        _MaxHealth = maxhealth;
    }

    //methods
    public void DmgUnit(int dmgAmount)
    {
        if (_currentHealth > 0)
        {
            _currentHealth -= dmgAmount;
        }
    }

    public void HealUnit(int healAmount)
    {
        if (_currentHealth < MaxHealth)
        {
            _currentHealth += healAmount;
        }
        if (_currentHealth > MaxHealth)
        {
            //consider changing if eating enemy units, should health expand?
            _currentHealth = _MaxHealth;
        }
    }

}
