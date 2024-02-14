using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobProjectile : MonoBehaviour
{
    [SerializeField] private float maxRange = 10.0f;
    private Vector3 pos;
    private Vector3 center;
    private Vector3 targetRelCenter;
    private Vector3 posRelCenter;
    private RaycastHit hit;
    private float timer = 0.0f;
    private PlayerInput player = PlayerInput.Instance;
    private void Start() {
        pos = transform.position;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        int layer_mask = LayerMask.GetMask("Ground");

        Physics.Raycast(ray, out hit, Mathf.Infinity, layer_mask);
        
        Vector3 target;

        if(Vector3.Distance(player.GetPlayerPosition(), hit.point) > maxRange)
        {
            Vector3 direction = hit.point - pos;
            direction.Normalize();
            target = player.GetPlayerPosition() + direction * maxRange;
            Debug.Log("Player postition: " + player.GetPlayerPosition());
            Debug.Log("Target: " + target);
        } else {
            target = hit.point;
        }

        //Center of arc
        center = (pos + hit.point) * 0.5f;

        center -=new Vector3(0, 1, 0);

        posRelCenter = pos - center;
        targetRelCenter = target - center;
    }

    private void Update() {
        transform.position = Vector3.Slerp(posRelCenter, targetRelCenter, timer += Time.deltaTime);
        transform.position += center;
    }


    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Ground"))
        {
            Destroy(this.gameObject);
        }
    }
}
