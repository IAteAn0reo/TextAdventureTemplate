using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Template : MonoBehaviour
{
	public TextMeshProUGUI storyText;
	public TextMeshProUGUI choiceText;

	enum States
	{
		RoomZero, RoomOne, RoomTwo
	}
	States myState;

	private void Update()
	{
		switch (myState)
		{
			case States.RoomZero:
				if (Input.GetKey("e"))
				{
					Room1();
				}
				break;
			case States.RoomOne:
				if (Input.GetKey("r"))
				{
					Room0();
				}
				else if (Input.GetKey("e"))
				{
					Room2();
				}
				break;
		}
	}

	void Room0()
	{
		myState = States.RoomZero;

		storyText.text = "This is room 0";
		choiceText.text = "Next Room - Press E";
	}

	void Room1()
	{
		myState = States.RoomOne;

		storyText.text = "This is room 1";
		choiceText.text = "Previous Room - Press R <br> Next Room - Press E";
	}

	void Room2()
	{
		myState = States.RoomTwo;

		storyText.text = "This is room 2 <br> You win!";
		choiceText.text = "";
	}
}
