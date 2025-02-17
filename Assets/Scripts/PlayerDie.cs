using UnityEngine;

public class PlayerDie : MonoBehaviour
{
    public GameObject endPanel;
    private string _enemy = "Enemy";
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == _enemy)
        {
            endPanel.SetActive(true);
            gameObject.SetActive(false);

        }
    }
}
