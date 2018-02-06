using UnityEngine;

namespace MeshiScript
{
    /// <summary>
    /// 敵の当たり判定処理
    /// </summary>
    public class Enemy_Hit : MonoBehaviour
    {
        void OnCollisionEnter(Collision other_col)
        {
            //>プレイヤーとの衝突処理
            if (other_col.gameObject.tag == "Player")
            {
                //>ゲームオーバー遷移
                Debug.Log("ここにゲームオーバー遷移処理");
            }
            //>車との衝突処理
            if (other_col.gameObject.tag == "Car")
            {
                Rigidbody rigid = other_col.gameObject.GetComponent<Rigidbody>();
                Vector3 impulse = (rigid.position - transform.position).normalized * 50;
                rigid.AddForce(impulse, ForceMode.Impulse);

                //>2秒後に当たった車を消す
                Destroy(other_col.gameObject, 2);
            }
        }
    }
}