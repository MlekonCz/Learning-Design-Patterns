using UnityEngine;
using UnityEngine.Pool;

public class Launcher : MonoBehaviour
{
  [SerializeField] private Bullet bulletPrefab;
  private IObjectPool<Bullet> _bulletPool;
  
  
  private void Awake()
  {
      _bulletPool = new ObjectPool<Bullet>(CreateBullet,
          OnGet,OnRelease,OnBulletDestroy,maxSize:10);
  }
  private void Update()
  {
      if (Input.GetKeyDown(KeyCode.Space))
      {
          _bulletPool.Get();
      }
  }
  

  private Bullet CreateBullet()
  {
      Bullet bullet = Instantiate(bulletPrefab);
      bullet.SetPool(_bulletPool);
      return bullet;
  }
  private void OnGet(Bullet bullet)
  {
      bullet.gameObject.SetActive(true);
      bullet.transform.position = transform.position;
  }
  private void OnRelease(Bullet bullet)
  {
      bullet.gameObject.SetActive(false);
  }
  private void OnBulletDestroy(Bullet bullet)
  {
   Destroy(bullet.gameObject);
  }
 
}
