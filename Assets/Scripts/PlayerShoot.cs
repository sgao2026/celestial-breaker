using UnityEngine;
using UnityEngine.UI;

public class PlayerShoot : MonoBehaviour
{
    public GameObject preFab0;
    public GameObject preFab1;
    public Transform bulletTrash;
    public Transform bulletSpawn;

    private const float Timer = 0.1f;
    private float _currentTime = 0.1f;
    private bool _canShoot = true;

    private void Update()
    {
        TimerMethod();
        Shoot();
    }

    private void TimerMethod()
    {
        if (!_canShoot)
        {
            _currentTime -= Time.deltaTime;

            if (_currentTime < 0)
            {
                _canShoot = true;
                _currentTime = Timer;
            }
        }
    }
    private void Shoot()
    {
        if (_canShoot)
        {
            GameObject bullet;
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                bullet = Instantiate(preFab0, bulletSpawn.position, Quaternion.identity);
            } 
            else if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                bullet = Instantiate(preFab1, bulletSpawn.position, Quaternion.identity);
            } else
            {
                return;
            }

            bullet.transform.SetParent(bulletTrash);
            _canShoot = false;
        }
    }
}
