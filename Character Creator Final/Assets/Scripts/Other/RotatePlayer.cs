// Code written by tutmo (youtube.com/tutmo)
// For help, check out the tutorial - https://youtu.be/PNWK5o9l54w

using UnityEngine;

public class RotatePlayer : MonoBehaviour
{
    // ~~ 1. Handles animation updates to rotate player

    private Animator animator;
    private Vector2[] positions;
    private int currentPosition;

    private void Start()
    {
        animator = GetComponent<Animator>();
        CreatePositions();
    }

    private void CreatePositions()
    {
        positions = new Vector2[4];
        positions[0] = new Vector2(0, -1);      // Down
        positions[1] = new Vector2(-1, 0);      // Left
        positions[2] = new Vector2(0, 1);       // Up
        positions[3] = new Vector2(1, 0);       // Right
    }

    public void RotateLeft()
    {
        if (currentPosition < positions.Length - 1)
        {
            currentPosition++;
        }
        else
        {
            currentPosition = 0;
        }

        UpdatePosition();
    }

    public void RotateRight()
    {
        if (currentPosition > 0)
        {
            currentPosition--;
        }
        else
        {
            currentPosition = positions.Length - 1;
        }

        UpdatePosition();
    }

    private void UpdatePosition()
    {
        animator.SetFloat("moveX", positions[currentPosition].x);
        animator.SetFloat("moveY", positions[currentPosition].y);
    }
}
