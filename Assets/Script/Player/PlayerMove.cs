using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    
    private Vector3 _moveDir;
    private Vector3 _moveInput;
    public float WalkSpeed ;
    public float RunSpeed ;
    public float JumpSpeed ;
  
  
    private AudioSource _audio;
    private CharacterController _characterCrtl;
    private float _groundstick = -10f;
    public float WalkStep = 1f;
    private float _nextStep = 0;
    private AudioClip _footstep0;
    private AudioClip _footstep1;
    private bool _change;
    private void Start()
    {
        _characterCrtl = GetComponent<CharacterController>();
       
        _audio = GetComponent<AudioSource>();
       
        _change = true;
    }
  
    private void PlayFootSound()
    {
        _nextStep += _characterCrtl.velocity.sqrMagnitude * Time.deltaTime ;
        if (_nextStep > WalkStep)
        {
            //_soundAgent.PlayeOneShot(_audio, "footstep");
            AudioClip clip  = _change ? _footstep0 : _footstep1;
            _audio.PlayOneShot(clip);
            _change = !_change;
            _nextStep = 0;
        }
    }
    public void Move(Vector2 moveInput, bool isJump,bool leftshift)
    {
        PlayerInput.IsMoving = Vector2.zero == PlayerInput.Moveinput ? false : true;
        
        if (moveInput != Vector2.zero&&_characterCrtl.isGrounded)
        {
            PlayFootSound();


        }
        if (_characterCrtl)
        {
            _moveInput = moveInput.x * transform.right + moveInput.y * transform.forward;
            float speed = leftshift ? RunSpeed : WalkSpeed;
            _moveDir.x = _moveInput.x * speed;
            _moveDir.z = _moveInput.z * speed;
          
                if (_characterCrtl.isGrounded)
                {

                    _moveDir.y = _groundstick;

                    if (isJump)
                    {
                   
                        _moveDir.y = JumpSpeed;
                      
                    }
                }
                else
                {

                    _moveDir += Physics.gravity * Time.deltaTime;
                }


                _characterCrtl.Move(_moveDir * Time.deltaTime);
         

        }
    }
    private void Update()
    {
      
        Move(PlayerInput.Moveinput, PlayerInput.Jump,PlayerInput.LeftShift);

    }

}
