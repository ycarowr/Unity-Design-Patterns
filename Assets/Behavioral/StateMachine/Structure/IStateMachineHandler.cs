﻿using UnityEngine;

namespace Patterns.StateMachine
{
    /// <summary>
    ///     Handler for the FSM. Usually the class which holds the FSM.
    /// </summary>
    public interface IStateMachineHandler
    {
        PushDownAutomata Fsm { get; }
        MonoBehaviour MonoBehaviour { get; }
    }
}