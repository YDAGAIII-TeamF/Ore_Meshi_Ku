using UnityEngine;
namespace MeshiScript
{
    /// <summary>
    /// 敵のアニメーション(向き)処理
    /// </summary>
    public class Enemy_Anime : MonoBehaviour
    {
        float angle;//>角度格納
        Animator enemy_annime;
        public Transform target;

        void Start()
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;
            enemy_annime = GetComponent<Animator>();
        }

        void Update()
        {
            Angle_Update();
        }

        /// <summary>
        /// オブジェクト間の角度を求める
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        float GetAngle(Vector3 p1, Vector3 p2)
        {
            float dx = p2.x - p1.x;
            float dz = p2.z - p1.z;
            float rad = Mathf.Atan2(dz, dx);
            return (rad * Mathf.Rad2Deg);
        }

        /// <summary>
        /// 向いている方向の更新
        /// </summary>
        void Angle_Update()
        {
            //>敵と自分の座標から角度を求め代入
            angle = GetAngle(transform.position, target.position);

            //>右向き
            if (angle >= -45 && angle <= 45)
            {
                enemy_annime.SetBool("Right", true);
            }
            else enemy_annime.SetBool("Right", false);

            //>左向き
            if (angle < -135 && angle >= -180 || angle > 135 && angle <= 180)
            {
                enemy_annime.SetBool("Left", true);
            }
            else enemy_annime.SetBool("Left", false);

            //>上向き
            if (angle > 45 && angle <= 135)
            {
                enemy_annime.SetBool("Up", true);
            }
            else enemy_annime.SetBool("Up", false);

            //>下向き
            if (angle < -45 && angle >= -135)
            {
                enemy_annime.SetBool("Under", true);
            }
            else enemy_annime.SetBool("Under", false);
        }
    }
}
