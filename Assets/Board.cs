using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using MySqlLite;

public class Board : MonoBehaviour {

    public int size = 51;
    public int field_x_variable = 51;
    public int field_y_variable = 51;
    public int property = 5;


    //string GameobejctName = "Kachel (" + x + "," + y ")");

    //Pos1 = Koord x
    //Pos2 = Koord y
    //Pos3 = 0 Name 1 State; 2 Team; 3 CardID 4 Special 

    sqlcontroller sqlcontroller = new sqlcontroller();

    GridHandler GridHandler;

    // Use this for initialization
    void Start() {


        Debug.Log("Der Pfad lautet: " + sqlcontroller.databasepath());

        for (int x = 0; x < field_x_variable; x++) {
            Debug.Log("Vorschleife 1");
            for (int y = 0; y < field_y_variable; y++) {
                Debug.Log("Vorschleife 2");
                GameObject tile = GameObject.CreatePrimitive(PrimitiveType.Quad);
                tile.transform.position = new Vector2(x + 0.5f, y + 0.5f);
                tile.transform.parent = this.transform;
                //tile.name = ("Kachel (" + (i + 1) + "," + (j + 1) + ")");
                tile.name = string.Format("Kachel ({0},{1})", x + 1, y + 1);
                //grid[x, y, 0] = "Kachel (" + x + "," + y + ")";
                GridHandler.SetName(x, y);

                GameObject.Find("test");

                GridHandler.grid[0, 0, 1] = "1";

                if (x == (size / 2) && y == (size / 2)) {
                    tile.GetComponent<Renderer>().material.color = Color.red;
                    GridHandler.SetCardID(x,y,-1);
                    Debug.Log("Startpunkt gesetzt");
                } else {
                    tile.GetComponent<Renderer>().material.color = Color.green;
                    GridHandler.SetCardID(x, y, 0);
                    GridHandler.SetState(x, y, 0);
                    GridHandler.SetTeam(x,y,-1);
                 }
            }
        }

        sqlcontroller.connectionClose();

        float camsize = size / 2 + 0.5f;
        Camera.main.transform.position = new Vector3(camsize, camsize, 10);
        Camera.main.orthographicSize = camsize;
    }

    // Update is called once per frame
    void Update() {

    }
}
