using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   public Transform target;
   public Vector3 shift;
   
   private void FixedUpdate()
   {
      if(target == null)
         return;
      
      transform.position = target.transform.position + shift;
   }
}
