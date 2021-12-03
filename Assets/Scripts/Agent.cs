using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    [SerializeField] private Sight sight;

    void Awake()
    {
        sight.OnEnterVision += EnteredVision;
        sight.OnLeaveVision += LeftVision;
    }

    void EnteredVision(object sender, VisionEventArgs args)
    {
        Debug.Log($"{gameObject.name} sighted {args.collider.gameObject.name}");
    }
    
    void LeftVision(object sender, VisionEventArgs args)
    {
        Debug.Log($"{gameObject.name} is no longer seeing {args.collider.gameObject.name}");
    }

    void FixedUpdate()
    {
        // To move the agent 
        // transform.Translate(new Vector3(Time.fixedDeltaTime, 0f, 0f));
        
        UpdateState();
        Reason();
        Act();
    }

    void UpdateState()
    {
        foreach (Collider collider in sight.inSight)
        {
            
        }
    }

    void Reason()
    {
        
    }

    void Act()
    {
        
    }
}
