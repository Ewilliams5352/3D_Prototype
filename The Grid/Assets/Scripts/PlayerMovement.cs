using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Movement code stuff
    public float speed;
    public float jumpPower;
    bool canJump;
    Rigidbody rb;

    //health stuff
    public float MaxHealth;
    float CurrentHealth;
    bool can_take_damage;
    public float invincTime;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        CurrentHealth = MaxHealth;
        can_take_damage = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (CurrentHealth > 0)
        {
            Movement();
            Jump();
        }
        Die();
    }



    void Movement()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }

    void Jump()
    {
        if (canJump == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                canJump = false;
                rb.AddForce(Vector3.up * jumpPower);
            }
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Spike"))
        {
            if(can_take_damage == true)
            {
                spikeDamage();
                StartCoroutine(invincible());
            }
        }

        if (other.gameObject.CompareTag("Ground"))
        {
            canJump = true;
        }
    }

    void spikeDamage()
    {
        CurrentHealth -= 25f;
        Debug.Log(CurrentHealth);
    }

    IEnumerator invincible()
    {
        can_take_damage = false;
        yield return new WaitForSeconds(invincTime);
        can_take_damage = true;
    }

    void Die()
    {
        //literally what im going to do after trying to code the stupid dart shooters ahhhhhhhhhhhhhhhhhhhhhhhhhhh

        //death animation

        //make screen go black

        //switch to main screen or game over screen

        //for now switch this once you get all of the above
        Destroy(gameObject);
    }
}


