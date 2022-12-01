using UnityEngine;
using TMPro;
public class CameraFollow : MonoBehaviour
{
    private float speed = 1;
    private bool isStop = true;
    private float timeSpeed;
    private int score;
    private int record;
    public float startTimeSpeed;
    public Transform VPos;
    public TextMeshProUGUI ScoreTxt;
    public TextMeshProUGUI ScoreTxt2;
    void Start()
    {
        record = PlayerPrefs.GetInt("Record");
    }
    void Update()
    {
        ScoreTxt.text = "ñ÷¸ò: " + score;
        ScoreTxt2.text = "Ëó÷øèé ñ÷¸ò: " + record;
        if (transform.position.y >= 0)
        {
            score = (int)transform.position.y;  
        }
        if (score >= record)
        {
            record = score;
            PlayerPrefs.SetInt("Record", record);
            PlayerPrefs.Save();
        }
        if (VPos.transform.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, VPos.position.y, transform.position.z);
        }

        if (timeSpeed <= 0)
        {
            if (isStop == true)
            {
                if (speed >= 0)
                {
                    speed -= 0.0039f;
                    GetComponent<Camera>().backgroundColor = new Color(0, speed, 255);
                }
                isStop = false;
            }
            timeSpeed = startTimeSpeed;
        }
        else
        {
            timeSpeed -= Time.deltaTime;
            isStop = true;
        }
    }
}
