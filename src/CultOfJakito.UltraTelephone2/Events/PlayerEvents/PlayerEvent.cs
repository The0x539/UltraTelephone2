﻿using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace CultOfJakito.UltraTelephone2.Events
{
    public class PlayerEvent : UKGameEvent
    {
        public NewMovement Player { get; }
        public PlayerEvent(NewMovement player)
        {
            this.Player = player;
        }
    }
}