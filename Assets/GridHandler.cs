using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridHandler {

    public Board board;
    public string[,,] grid;


    public void generateGridArray(int field_x_variable, int field_y_variable, int properties) {
        grid = new string[field_x_variable, field_y_variable, properties];
    }

    public string GetName(int x, int y) {
        return grid[x, y, 0];
    }

    public void SetName(int x, int y) {
        grid[x, y, 0] = "Kachel(" + x + ", " + y + ")";
    }
    
    //States: 0 = empty; 1 = card
    public string GetState(int x, int y) {
        return grid[x, y, 1];
    }

    public void SetState(int x, int y, int state) {
        grid[x, y, 1] = state.ToString();
    }

    //Teams: 0 = empty; 1 = blue; 2 = red
    public string GetTeam(int x, int y) {
        return grid[x, y, 2];
    }

    public void SetTeam(int x, int y, int team) {
        grid[x, y, 2] = team.ToString();
    }


    public string GetCardID(int x, int y) {
        return grid[x, y, 3];

    }

    public void SetCardID(int x, int y, int cardID) {
        grid[x, y, 3] = cardID.ToString();
    }


    public string GetSpecial(int x, int y) {
        return grid[x, y, 4];
    }

    public void SetSpecial(int x, int y, int special) {
        grid[x, y, 4] = special.ToString();
    }
}
