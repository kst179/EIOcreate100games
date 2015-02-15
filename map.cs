using UnityEngine;
using System.Collections;

public class map : MonoBehaviour
{
	private const int map_size = 100;
	public int[,] m = new int[map_size, map_size];
	public int[,] traffic = new int[map_size, map_size];
	public int[,] unit = new int[map_size, map_size];
	public GameObject warrior;
	public GameObject war_position;
	public int move_point = 5;

	void Start (){
		for (int i = 0; i < 100; i++) {
			for (int j = 0; j < 100; j++){
				m[i, j] = 1;
			}
		}
		Vector3 start_position = new Vector3(-49, 1, -49);
		warrior.transform.localPosition = start_position;
		war_position.transform.localPosition = new Vector3 (-49, 0, -49);
		unit [0, 0] = 1;
	}

	void Update (){
		
	}

	void track (int pos_x, int pos_y){
		for (int i = 0; i < map_size; i++) {
			for (int j = 0; j < map_size; j++){
				traffic[i, j] = 0;
			}
		}
		traffic [pos_x, pos_y] = move_point;
		move (pos_x, pos_y);
	}

	void move (int pos_x, int pos_y){
		if (pos_x > 1 && traffic[pos_x - 1, pos_y] < traffic[pos_x, pos_y] - m[pos_x - 1, pos_y] && unit[pos_x - 1, pos_y] == 0){
			traffic[pos_x - 1, pos_y] = traffic[pos_x, pos_y] - m[pos_x - 1, pos_y];
			move(pos_x - 1, pos_y);
		}
		if (pos_x < 99 && traffic[pos_x + 1, pos_y] < traffic[pos_x, pos_y] - m[pos_x + 1, pos_y] && unit[pos_x + 1, pos_y] == 0){
			traffic[pos_x + 1, pos_y] = traffic[pos_x, pos_y] - m[pos_x + 1, pos_y];
			move(pos_x + 1, pos_y);
		}
		if (pos_y > 1 && traffic[pos_x, pos_y - 1] < traffic[pos_x, pos_y] - m[pos_x, pos_y - 1] && unit[pos_x, pos_y - 1] == 0){
			traffic[pos_x, pos_y - 1] = traffic[pos_x, pos_y] - m[pos_x, pos_y - 1];
			move(pos_x, pos_y - 1);
		}
		if (pos_y < 99 && traffic[pos_x, pos_y + 1] < traffic[pos_x, pos_y] - m[pos_x, pos_y + 1] && unit[pos_x, pos_y + 1] == 0){
			traffic[pos_x, pos_y + 1] = traffic[pos_x, pos_y] - m[pos_x, pos_y + 1];
			move(pos_x, pos_y + 1);
		}
	}

}

