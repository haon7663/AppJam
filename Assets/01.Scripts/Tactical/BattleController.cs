using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : Singleton<BattleController>
{
    public Player player;
    
    public HealthBarController healthBarController;
    public DamageHudController damageHudController;
    
    private void Start()
    {
        healthBarController.Connect(player.gameObject);
    }
}
