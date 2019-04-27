using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouselook : MonoBehaviour
{
   
    public Transform FPSCameraView;
    public float Xsensitivity =0.5f;
    public float Ysensitivity=0.5f;
    private float _rotationXTemp = 0;
    private float _rotationYTemp = 0;
    private float _mouseDelay = 0.5f;
    private float _rotationX;
    private float _rotationY;
    private float _minXAngle = -360f;
    private float _maxXAngle = 360f;
    public  float _minYAngle = -80f;
    public  float _maxYAngle = 80f;
    private Vector2 _mouseDirection;
    private Vector2 _kickPower;//后座力抖动值
    Quaternion originalRot;
    /// <summary>
    /// 
    /// 
    /// </summary>
    private void Start()
    {
        originalRot = transform.localRotation;
        _kickPower = Vector2.zero;
    }
    public void SetKickPower(Vector2 kickpower)
    {
        _kickPower = kickpower;
    }
   
    private void Update()
    {
        _mouseDirection.x = PlayerInput.MouseX;
        _mouseDirection.y = PlayerInput.MouseY;
        if(CursorLock.Islock)
        {
            _kickPower.x += (0 - _kickPower.x) / 20;
            _kickPower.y += (0 - _kickPower.y) / 20;
           
            _rotationXTemp += _mouseDirection.x * Xsensitivity;
            _rotationYTemp += _mouseDirection.y * Ysensitivity;
            _rotationX = Mathf.Lerp(_rotationX, _rotationXTemp, _mouseDelay);
            _rotationY = Mathf.Lerp(_rotationY, _rotationYTemp, _mouseDelay);
            if (_rotationX >= 360 || _rotationX <= -360)
            {
                _rotationX = 0;
                _rotationXTemp = 0;
            }
            _rotationX = ClampAngle(_rotationX, _minXAngle, _maxXAngle);
            _rotationY = ClampAngle(_rotationY, _minYAngle, _maxYAngle);
            _rotationYTemp = ClampAngle(_rotationYTemp, _minYAngle, _maxYAngle);
            Quaternion xQuaternion = Quaternion.AngleAxis(_rotationX + _kickPower.x, Vector3.up);
            Quaternion yQuaternion = Quaternion.AngleAxis(_rotationY + _kickPower.y, Vector3.left);
            if (FPSCameraView)
            {
                FPSCameraView.localRotation = originalRot * Quaternion.AngleAxis(0, Vector3.up) * yQuaternion;
                this.transform.rotation = originalRot * Quaternion.AngleAxis(0, Vector3.left) * xQuaternion;
                //print("a+"+FPSCameraView.localRotation.eulerAngles);
                //print("b+"+this.transform.localRotation.eulerAngles);
               // Quaternion.Euler()
            }
            else
            {
                this.transform.localRotation = originalRot * xQuaternion * yQuaternion;
            }

        }


    }
    private float ClampAngle(float angle, float min, float max)
    {
      

        return Mathf.Clamp(angle, min, max);
    }
}




