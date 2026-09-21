using UnityEngine;

public class BankHuruf : MonoBehaviour
{
    int urutan = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetActive();
    }

    public void Control(int i)
    {
        urutan += i;
        if (urutan > transform.childCount - 1)
            urutan = 0;
        else if (urutan < 0)
            urutan = transform.childCount - 1;
        SetActive();
    }

    public void SetActive()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
        transform.GetChild(urutan).gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
