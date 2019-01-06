using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * A base class used for representing a player in a platformer world.
 */ 
public class PlatformPlayerBase : MonoBehaviour, IControllable
{
    public float movementSpeed = 7.5f;
    public float jumpVelocity = 16.5f;
    protected float interactRadius = 50;

    Rigidbody2D rigidBody;

    // Start is called before the first frame update
    protected void Start()
    {
        this.rigidBody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    protected void Update()
    {

    }

    public virtual void OnDownPressed()
    {

    }

    public virtual void OnFirePressed()
    {
        
    }

    public virtual void OnInteractPressed()
    {
     
        LayerMask interactableLayerMask = 1 << LayerMask.NameToLayer("Interactable");

        Collider2D[] colliders = Physics2D.OverlapCircleAll(this.transform.position, interactRadius, interactableLayerMask);
        Debug.Log(colliders.Length);

        for(int i = 0; i < colliders.Length; i++)
        {
            Debug.Log(colliders[i].gameObject.name);
            IInteractable interactable = colliders[i].GetComponent<MonoBehaviour>() as IInteractable;

            if(interactable != null)
            {
                interactable.interact();
            }

        
        }

    }

    public virtual void OnJumpPressed()
    {
        rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpVelocity);
    }

    public virtual void OnLeftPressed()
    {
        rigidBody.velocity = new Vector2(-movementSpeed, rigidBody.velocity.y);
        this.transform.localScale = new Vector2(-1, transform.localScale.y);
    }

    public virtual void OnMenuPressed()
    {
        throw new System.NotImplementedException("Method Stub");
    }

    public virtual void OnPausePressed()
    {
        throw new System.NotImplementedException();
    }

    public virtual void OnRightPressed()
    {
        rigidBody.velocity = new Vector2(movementSpeed, rigidBody.velocity.y);
        this.transform.localScale = new Vector2(1, transform.localScale.y);
    }

    public virtual void OnUpPressed()
    {

    }
}
