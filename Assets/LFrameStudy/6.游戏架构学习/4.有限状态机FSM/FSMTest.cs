using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace LFrameStudy
{
    public enum TRAN_INPUT
    {
        BUTTON_A,
        BUTTON_B,
        TIME_OUT,
    }
    public interface State
    {
        State HandleInput(TRAN_INPUT input);
        void EnterState();
    }

    public class IdleState : State
    {
        public void EnterState()
        {
            Debug.Log("To Idle State");
        }

        public State HandleInput(TRAN_INPUT input)
        {
            if (input == TRAN_INPUT.BUTTON_A)
            {
                return new SkillA();
            }
            else if (input == TRAN_INPUT.BUTTON_B)
            {
                return new SkillB();
            }
            return null;
        }
    }

    public class DogeState : State
    {
        public void EnterState()
        {
            Debug.Log("To Dodge State");
        }

        public State HandleInput(TRAN_INPUT input)
        {

            if (input == TRAN_INPUT.TIME_OUT)
            {
                return new IdleState();
            }
            return null;
        }
    }


    public class SkillA : State
    {
        public void EnterState()
        {
            Debug.Log("TO SkillA state");
        }

        public State HandleInput(TRAN_INPUT input)
        {
            if (input == TRAN_INPUT.BUTTON_A)
            {
                return new SkillB();
            }
            else if (input == TRAN_INPUT.TIME_OUT)
            {
                return new IdleState();
            }
            return null;
        }
    }

    public class SkillB : State
    {
        public void EnterState()
        {
            Debug.Log("TO SkillB state");
        }

        public State HandleInput(TRAN_INPUT input)
        {

            if (input == TRAN_INPUT.TIME_OUT)
            {
                return new IdleState();
            }
            return null;
        }
    }


    public class FSM
    {

        State CurrentState;

        public FSM()
        {
            CurrentState = new IdleState();
            CurrentState.EnterState();
        }

        public void HandleInput(TRAN_INPUT input)
        {
            State newState = CurrentState.HandleInput(input);
            if (newState != null)
            {
                CurrentState = newState;
                CurrentState.EnterState();
            }
        }

    }
}


