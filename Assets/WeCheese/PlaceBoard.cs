using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using TMPro;

public class PlaceBoard : MonoBehaviour
{
    public Transform cursor;
    public GameObject board_object;
    public AudioClip spawn_sound_effect;
    public TextMeshProUGUI Display1;
    public TextMeshProUGUI Display2;
    public TextMeshProUGUI Display3;
    public TextMeshProUGUI Display4;
    public TextMeshProUGUI Displaya;
    public GameObject chess;
    public GameObject chess1;
    public GameObject chess2;
    //public GameObject[] all_my_chess;
    //public GameObject[] all_enemy_chess;
    public static bool board_placed = false;

    void Start()
    {
    }

    void Update()
    {

        //Display2.text = string.Format("chess : {0} {1} {2}",
        //    chess.transform.position.x, chess.transform.position.y, chess.transform.position.z);
        //Display3.text = string.Format("chess : {0} {1} {2}",
        //    chess1.transform.position.x, chess1.transform.position.y, chess1.transform.position.z);
        //Display4.text = string.Format("chess : {0} {1} {2}",
        //    chess2.transform.position.x, chess2.transform.position.y, chess2.transform.position.z);

    }

    public void PlaceBoardAtCursor()
    {
        board_placed = true;
        board_object.transform.SetPositionAndRotation(cursor.position, cursor.rotation);
        board_object.transform.Translate(Vector3.down * 0.003f, Space.Self);


        //Displaya.text = string.Format("board pos: {0} {1} {2}",
        //    board_object.transform.position.x, board_object.transform.position.y, board_object.transform.position.z);

        //chess.transform.SetPositionAndRotation(board_object.transform.position + new Vector3(-0.597f, 0.028f, -0.611f), board_object.transform.rotation);
        //chess1.transform.SetPositionAndRotation(board_object.transform.position + new Vector3(-0.461f, 0.028f, -0.611f), board_object.transform.rotation);

        AudioSource.PlayClipAtPoint(spawn_sound_effect, Camera.main.transform.position);
    }

    public void RotateClockwise()
    {
        board_object.transform.Rotate(0f, 10f, 0f, Space.Self);
    }

    public void RotateUnClockwise()
    {
        board_object.transform.Rotate(0f, -10f, 0f, Space.Self);
    }


    //public void DisplayLocation()
    //{
    //    Display.text = string.Format("cursor position: {0} {1} {2}", 
    //        cursor.position.x, cursor.position.y, cursor.position.z);
    //}

    //public void PrintHelloWorldFromPython()
    //{
    //    Vector3 vec = MyPythonScript.Run(new Vector3(2.0f, 2.0f, 2.0f));
    //    Display.text = string.Format("$x value: {0}", vec.x);

    //}
}
