﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Logic.Battles {
    public class EnemyEntity : BattleEntity {

        //To be called every tick? Maybe too many function calls...
        public override void Action() {
            if (!CanAct()) {
                AddTick();
                return;
            }
            //TODO: Implement choices
            Debug.Log("Enemy attacks!");
        }

        public EnemyEntity(int hp, int atk, int def, int spd) {
            Health = hp;
            Attack = atk;
            Defense = def;
            Speed = spd;
        }

    }
}
