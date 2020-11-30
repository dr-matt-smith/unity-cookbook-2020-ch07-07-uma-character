using UnityEngine;
using UMA.Dynamics;

public class SpaceKeyRagDoll : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MakeRagDoll();
        }
    }
    
    private void MakeRagDoll()
    {
        Transform avatar = GetComponent<Rigidbody>().transform.root;
        UMAPhysicsAvatar physicsAvatar = avatar.GetComponent<UMAPhysicsAvatar>();
        physicsAvatar.ragdolled = true;
   }
}
