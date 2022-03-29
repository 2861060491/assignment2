using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanManager : MonoBehaviour
{
    public GameObject human;
    public float value = 0;
    public Vector3 sizeChange;
    

    public void MoveLeft()
    {
        value = value - 0.1f;
        human.transform.position = new Vector3(value, 0, 0);
    }

    public void MoveRight()
    {
        value = value + 0.1f;
        human.transform.position = new Vector3(value, 0, 0);
    }

    public void MoveUp()
    {
        value = value - 0.1f;
        human.transform.position = new Vector3(0, 0, value);
    }

    public void MoveDown()
    {
        value = value + 0.1f;
        human.transform.position = new Vector3(0, 0, value);
    }

    public void RotateLeft()
    {
        human.transform.Rotate(0f, 20f, 0f);
    }

    public void RotateRight()
    {
        human.transform.Rotate(0f, -20f, 0f);
    }

    public int a = 0;

    public void InsA()
    {
        a = a + 1;
    }

    public void GrowHuman()
    {
        InsA();
        human.transform.localScale = new Vector3(a, a, a);
    }

    public void RelA()
    {
        a = 0;
    }

    public  void RelV()
    {
        value = 0;
    }

    public void ResetHuman()
    {
        RelA();
        RelV();
        human.transform.position = new Vector3(0, 0, 0);
        human.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        human.transform.localScale = new Vector3(1, 1, 1);
    }
}

