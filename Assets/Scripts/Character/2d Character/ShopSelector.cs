using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Represents the show selector.
 * The shop selector acts as a 2D character, and can select items for purchase.
 */ 
public class ShopSelector : PlatformPlayerBase
{

    private bool isGrounded;

    private BasicInventory Inventory;

    private Rigidbody2D rigidbody;
    private Animator animator;

    private float groundCheckDistance = 1;

    // Start is called before the first frame update
    new void Start()
    {
        base.Start();
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody2D>();

        if(animator == null || rigidbody == null)
        {
            throw new MissingComponentException(string.Format("%s should include an %s component!", this.name, "Animator and Rigidbody2D"));
        }
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
        this.isGrounded = CheckGrounded();
        this.UpdateAnimation();
    }


    
    private bool CheckGrounded()
    {
        LayerMask layerMask = 1 << LayerMask.NameToLayer("Platform");

        Vector2 leftSource = new Vector2(this.transform.position.x - 0.5f, this.transform.position.y);
        RaycastHit2D leftCheck = Physics2D.Raycast(leftSource, new Vector2(0, -1), groundCheckDistance, layerMask);

        Vector2 rightSource = new Vector2(this.transform.position.x + 0.5f, this.transform.position.y);
        RaycastHit2D rightCheck = Physics2D.Raycast(rightSource, new Vector2(0, -1), groundCheckDistance, layerMask);

        return leftCheck || rightCheck;
    }

    private void UpdateAnimation()
    {
        animator.SetFloat("movementSpeed", Mathf.Abs(this.rigidbody.velocity.x));
        animator.SetBool("isGrounded", this.isGrounded);
    }

    public override void OnLeftPressed()
    {
        base.OnLeftPressed();
    }

    public override void OnRightPressed()
    {
        base.OnRightPressed();
    }
}
