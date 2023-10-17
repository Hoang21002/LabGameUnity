using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RifleWeapon : MonoBehaviour
{
    public int _damageDealt = 50;
    private int _totalDamageDealt = 0;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Ray mouseRay = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hitInfo;
            if (Physics.Raycast(mouseRay, out hitInfo))
            {
                Health enemyHealth = hitInfo.transform.GetComponent<Health>();
                if (enemyHealth != null)
                {
                    enemyHealth.Damage(_damageDealt);

                    // Cập nhật tổng thương tích
                    _totalDamageDealt += _damageDealt;

                    // Kiểm tra nếu tổng thương tích đạt 150, chuyển scene
                    if (_totalDamageDealt >= 300)
                    {
                        SceneManager.LoadScene(2); // Thay "YourNextScene" bằng tên scene bạn muốn chuyển đến
                    }
                }
            }
        }
    }
}
