using UnityEngine;

public class HurufController : MonoBehaviour
{
    float x, y;
    public GameObject BankHuruf;
    public int kontrol;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        x = transform.localScale.x;
        y = transform.localScale.y;
    }
    private void OnMouseDown()
    {
        GetComponent<AudioSource>().Play();
        transform.localScale = new Vector2(x * 1.2f, y / 1.2f); 
    }

    private void OnMouseUp()
    {
        transform.localScale = new Vector2(x, y);
        BankHuruf.GetComponent<BankHuruf>().Control(kontrol);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
