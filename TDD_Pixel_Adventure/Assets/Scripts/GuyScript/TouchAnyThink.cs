using UnityEngine;

public class TouchAnyThink : MonoBehaviour
{

    public bool touch = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        touch = true;
    }
}
