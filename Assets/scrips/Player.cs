using UnityEngine;

public class Player : MonoBehaviour
{

[SerializeField]

private Transform gunPosition;

private void OnTriggerEnter(Collider other)

    {
      if (other.CompareTag("gun"))
        {
       other.GetComponent<Gun>().GrabGun(gunPosition);
        }  
    }
     
}


