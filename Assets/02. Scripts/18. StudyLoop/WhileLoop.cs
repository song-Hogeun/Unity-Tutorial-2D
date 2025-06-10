using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    private int count = 0;

    void Start()
    {
        while (count < 10)
        {
            count++;

            if (count == 5)
            {
                continue;
            }
            
            Debug.Log(count);
        }
    }
}