using UnityEngine;

[AddComponentMenu("NGUI/Examples/Spin With Mouse")]
public class SpinWithMouse : MonoBehaviour
{
	public Transform target;
	public float speed = 1f;

	Transform mTrans;

	void Start ()
	{
		mTrans = transform;
	}

	void OnDrag (Vector2 delta)
	{
		UICamera.currentTouch.clickNotification = UICamera.ClickNotification.None;
        print(delta);
		if (target != null)
		{
           // if (-2f < delta.y &&delta.y< 2f)
         //   {
                target.localRotation = Quaternion.Euler(0f, -0.5f * delta.x * speed, 0f) * target.localRotation;
        //    }
         //   else if(-2f < delta.x && delta.y < 2f) 
                target.localRotation = Quaternion.Euler( -0.5f * delta.y * speed,0f, 0f) * target.localRotation;
        }
		else
		{
			mTrans.localRotation = Quaternion.Euler(0f, -0.5f * delta.x * speed, 0f) * mTrans.localRotation;
		}
	}
}