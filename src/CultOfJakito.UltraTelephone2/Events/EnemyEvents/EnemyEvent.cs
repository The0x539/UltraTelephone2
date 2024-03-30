﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CultOfJakito.UltraTelephone2.Events
{
    public class EnemyEvent : UKGameEvent
    {
        public EnemyIdentifier Enemy { get; }

        public EnemyEvent(EnemyIdentifier enemy)
        {
            Enemy = enemy;
        }
    }
}