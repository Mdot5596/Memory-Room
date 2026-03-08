//
//using UnityEngine;
//using UnityEngine.UI;

//public class PlayerInteraction : MonoBehaviour
//{
//    [Header("References")]
//    public Camera playerCamera;
//    public Image lookImage;

 //   [Header("Settings")]
 //   public float lookDistance = 3f;

 //   void Start()
  //  {
   //     lookImage.enabled = false;
   // }

 //   void Update()
 //   {
 //       Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);
 //       RaycastHit hit;

//        if (Physics.Raycast(ray, out hit, lookDistance))
 //       {
 //           if (hit.collider.TryGetComponent(out Interactable interactable))
 //           {
 //               lookImage.enabled = true;
 //               return;
 //           }
 //       }

 //       lookImage.enabled = false;
 //   }
//}
