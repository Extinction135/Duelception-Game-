// DuelceptionGame.cpp : This file contains the 'main' function. Program execution begins and ends there.
// Turned-Based Combat Game. Created by Ronil Sedani.

#include "pch.h"
#include <iostream>
#include <iostream>
#include <string>
#include <cstdlib>
#include <ctime>
#include <Windows.h>
#include <conio.h>
#include <iomanip>
using namespace std;


class Player {
public:
	int health;
	int StartHealth;  //Starting Health of Player
	int PlayerDamage1;
	int PlayerDamage2;
	int healthRegen;

	Player() {
		health = 600;
		StartHealth = 600;
		PlayerDamage1 = 170;
		PlayerDamage2 = 50;
		healthRegen = 170;
	}

	int PlayerAttack1() {	//Player's 1st ability.
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 11); //light blue (Text colour)
		cout << right << setw(55) << "You used Divine Power!" << endl;
		cout << right << setw(36) << "You dealt " << PlayerDamage1 << " damage to the Enemy!" << endl;
		return PlayerDamage1;
	}

	int PlayerAttack2() {	//Player's 2nd ability.
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 11); //light blue
		cout << right << setw(55) << "You used Healing Touch!" << endl;
		cout << right << setw(36) << "You dealt " << PlayerDamage2 << " damage to the Enemy!" << endl;
		cout << right << setw(32) << "You gained back " << healthRegen << " Health! (Unless you're at full health.) " << endl;
		health = (health + healthRegen >= StartHealth) ? StartHealth : health + healthRegen;  //verification check to ensure player's health does not exceed StartingHeath when gaining back health.
		return PlayerDamage2;												//Grants 170 health back to Player.
	}

};


class Enemy {
public:
	int health;
	int StartHealth;  //Starting Health of Enemy
	int damage;
	int healthRegen;

	Enemy() {
		health = 600;
		StartHealth = 600;
		healthRegen = 300;
	}

	int attack() {
		int i = 0;
		srand(time(0));
		i = (rand() % 100) + 1; //Process to select a random number between 1 and 100.
		if (i >= 75) {			//Enemy has 25% chance of using this ability.
			health = (health + healthRegen >= StartHealth) ? StartHealth : health + healthRegen; //verification check to ensure player's health does not exceed StartingHeath when gaining back health.
			damage = 0;																			
			cout << endl;
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 12); //light red
			cout << right << setw(54) << "Enemy used Restore and gained " << healthRegen <<" Health!" << endl;
			cout << right << setw(44) << "You took " << damage << " damage!" << endl;

		}
		else {				//Enemy's second ability. This ability is used 75% of the time.
			cout << endl;
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 12); // light red
			cout << right << setw(56) << "Enemy used Fire Breath!" << endl;
			srand(time(0));						  //Picks a random number between 100 - 300.
			damage = rand() % (301 - 100) + 100;  //Enemy's damage ranges from 100 - 300.
			cout << right << setw(44) << "You took  " << damage << " damage!" << endl;

		}
		return damage;
	}

};


void BattleSetUp() {
	Player player;
	Enemy enemy;

	system("CLS");
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 14); //light yellow
	cout << R"(
		 ___        _    _    _             _                         
		| _ ) __ _ | |_ | |_ | | ___       /_\   _ _  ___  _ _   __ _ 
		| _ \/ _` ||  _||  _|| |/ -_)     / _ \ | '_|/ -_)| ' \ / _` |
		|___/\__,_| \__| \__||_|\___|    /_/ \_\|_|  \___||_||_|\__,_|
    )" << endl;

	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 13); //light purple
	cout << R"(
	   \\\|||///				<>=======()           
	  .  =======				(/\___   /|\\          ()==========<>_
	 / \| O   O |				      \_/ | \\        //|\   ______/ \)
	 \ / \`___'/				        \_|  \\      // | \_/
	/ #   _| |_				          \|\/|\_   //  /\/
	/(#) (     )				           (oo)\ \_//  /
	/ #\//|* *|\\				          //_/\_\/ /  |
	/ #\/(  *  )/		 VS		         @@/  |=\  \  |
	/ #   =====				              \_=\_ \ |
	/ #   ( U )				                \==\ \|\_ 
	/ #   || ||				             __(\===\(  )\
	/ #   || ||				            (((~) __(_/   |
	/ #   || ||				                 (((~) \  /
	/.#---'| |`----.			                 ______/ /
	/`#----' `-----'			                 '------'
	)" << endl;
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 7); //white
}


void Battle()
{
	Player player;	//Declaring class object.
	Enemy enemy;	//Declaring class object.
	int round = 0;
	int selection;
	BattleSetUp();	//Calls function to set up graphics for battle.

	do {
		int input;
		round = round + 1;	//Game Rounds counter.
		system("CLS");
		BattleSetUp();
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 10); //light green
		cout << right << setw(45) << "Round " << round << endl;
		cout << right << setw(21) << "Your Health: " << player.health << flush;
		cout << right << setw(49) << "Enemy Health: " << enemy.health << endl;
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 11); //light blue
		cout << right << setw(50) << "(1) Divine Power " << endl;
		cout << right << setw(51) << "(2) Healing Touch " << endl;
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 7); //white
		cout << right << setw(50) << "Choose your Ability: " << flush;
		cin >> input;
		while (input < 1 || input >2 || cin.fail()) {	//Input verification checks to ensure appropriate No. is chosen.
			cout << endl;
			cout << right << setw(57) << "Wrong Input! Please type 1 or 2." << endl;
			system("pause");
			system("CLS");
			cin.clear();
			cin.ignore(256, '\n');
			BattleSetUp();
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 10); //light green
			cout << right << setw(45) << "Round " << round << endl;
			cout << right << setw(21) << "Your Health: " << player.health << flush;
			cout << right << setw(49) << "Enemy Health: " << enemy.health << endl;
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 11); //light blue
			cout << right << setw(50) << "(1) Divine Power " << endl;
			cout << right << setw(51) << "(2) Healing Touch " << endl;
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 7); //white
			cout << right << setw(50) << "Choose your Ability: " << flush;
			cin >> input;

		}
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 6); //white
		cout << endl;
		cout << right << setw(53) << "Preparing for Battle..." << endl;
		system("Pause");

		if (input == 1) {
			system("CLS");
			BattleSetUp();
			enemy.health = enemy.health - player.PlayerAttack1();
			enemy.health = (enemy.health < 0) ? 0 : enemy.health;
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 10); //light green
			cout << right << setw(21) << "Your Health: " << player.health << flush;
			cout << right << setw(49) << "Enemy Health: " << enemy.health << endl;
			cout << endl;
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 7); //white
			Sleep(1500);												//using Sleep, it gives the effect of turned based attack system.

			if (enemy.health == 0) {		//to check if enemy health is 0 before it attacks.
				break;						//if it is then break the loop and Player wins.
			}
			else {
				cout << right << setw(59) << "Enemy is preparing to Attack..." << endl;
				Sleep(2000);
				player.health = player.health - enemy.attack();
				player.health = (player.health < 0) ? 0 : player.health;  //Health check to prevent health going below 0.

			}

			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 10); //light green
			cout << right << setw(21) << "Your Health: " << player.health << flush;
			cout << right << setw(49) << "Enemy Health: " << enemy.health << endl;

		}
		else if (input == 2) {
			system("CLS");
			BattleSetUp();
			enemy.health = enemy.health - player.PlayerAttack2();
			enemy.health = (enemy.health < 0) ? 0 : enemy.health;		//Health check to prevent health going below 0.
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 10); //light green
			cout << right << setw(21) << "Your Health: " << player.health << flush;
			cout << right << setw(49) << "Enemy Health: " << enemy.health << endl;
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 7); //white	
			Sleep(1500);

			if (enemy.health == 0) {		//to check if enemy health is 0 before it attacks.
				break;						//if it is then break the loop and Player wins.
			}
			else {
				cout << right << setw(59) << "Enemy is preparing to Attack..." << endl;
				Sleep(2000);
				player.health = player.health - enemy.attack();
				player.health = (player.health < 0) ? 0 : player.health;  //Health check to prevent health going below 0.		

			}

			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 10); //light green
			cout << right << setw(21) << "Your Health: " << player.health << flush;
			cout << right << setw(49) << "Enemy Health: " << enemy.health << endl;
		}
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 7); // white
		system("Pause");
	} while ((player.health > 0) && (enemy.health > 0));	//Repeat Do-While loop untill someone wins (Their health reaches 0).
	BattleSetUp();
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 10); //light green
	cout << right << setw(21) << "Your Health: " << player.health << flush;
	cout << right << setw(49) << "Enemy Health: " << enemy.health << endl;
	if (player.health == 0) //Loop checks if player health is 0 and displays the appropriate output stating who won. 
	{
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 12); //light red
		cout << right << setw(45) << "YOU LOSE!" << endl;
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 7); //white
		cout << right << setw(48) << "Round(s) Played: " << round << endl;
	}
	else
	{
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 11); //light blue
		cout << right << setw(45) << "YOU W0N! " << endl;
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 7); //white
		cout << right << setw(48) << "Round(s) Played: " << round << endl;

	}
	cout << endl;
	cout << right << setw(44) << "(1) Restart" << endl;
	cout << right << setw(41) << "(2) Quit" << endl;
	cout << right << setw(48) << "Choose a Number: " << flush;
	cin >> selection;
	while (selection < 1 || selection > 2 || cin.fail()) {  //Verficiation check on selection to ensure appropriate NO. is chosen.
		cout << endl;
		cout << right << setw(70) << "Wrong Input! Please type a number from the list above." << endl;
		cin.clear();
		cin.ignore(256, '\n');
		cout << right << setw(48) << "Choose a Number: " << flush;
		cin >> selection;
	}
	if (selection == 1) {
		Battle();   //Restarts Battle.
	}
	else {
		exit(0);	//exits game.
	}

}

void HowToPlay()
{
	system("CLS");
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 13); //light purple
	cout << R"(
		 _   _                   _____        ____   _               
		| | | |  ___ __      __ |_   _|___   |  _ \ | |  __ _  _   _ 
		| |_| | / _ \\ \ /\ / /   | | / _ \  | |_) || | / _` || | | |
		|  _  || (_) |\ V  V /    | || (_) | |  __/ | || (_| || |_| |
		|_| |_| \___/  \_/\_/     |_| \___/  |_|    |_| \__,_| \__, |
		                                                       |___/ 
	)" << endl;
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 7); //white
	cout << "* Turned based Battle system." << endl;
	cout << "* You will always attack First. Shortly followed by the enemy." << endl;
	cout << "* Beginning of each Round you will be prompted to select an Ability." << endl;
	cout << "* Abilities are selected by entering the corrosponding number, e.g. 1." << endl;
	cout << "* You and your Enemy both have 2 Abilities and start of with 600 Health." << endl;
	cout << "* To Win, you must defeat your Enemy by reducing its' health to 0." << endl;
	cout << endl;
	cout << endl;
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 11); //light blue
	cout << "* Your Abilities!" << endl;
	cout << "-----------------" << endl;
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 10); //light green
	cout << "(1) Divine Power - Attacks for 170 damage." << endl;
	cout << R"((2) Healing Touch - Attacks for 50 damage and you gain 170 health. 
		   (Unless you've exceeded the maximum Health of 600).)" << endl;
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 14); //light yellow
	cout << endl;
	cout << "* Enemy Abilities!" << endl;
	cout << "------------------" << endl;
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 12); //light red
	cout << "(1) Fire Breath - Attacks for a random damage number between 100-300." << endl;
	cout << "(2) Restore - Gains 300 Health. Enemy has a 25% chance of using this ability." << endl;
	cout << endl;
	cout << endl;
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 6); //dark yellow
	cout << "Ready to Battle?" << endl;
	system("Pause");
	Battle();  //Starts Battle.
}


void Title()
{
	int input = 0;
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 11); //light blue
	system("CLS");
	cout << R"(
	    _____                _                    _    _               
	   |  __ \              | |                  | |  (_)              
	   | |  | | _   _   ___ | |  ___  ___  _ __  | |_  _   ___   _ __  
	   | |  | || | | | / _ \| | / __|/ _ \| '_ \ | __|| | / _ \ | '_ \ 
	   | |__| || |_| ||  __/| || (__|  __/| |_) || |_ | || (_) || | | |
	   |_____/  \__,_| \___||_| \___|\___|| .__/  \__||_| \___/ |_| |_|
	                                      | |                          
	                                      |_|                          

)" << endl;

	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 7); //white
	cout << right << setw(58) << "Version 1." << endl;
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 6); //yellow
	cout << right << setw(58) << "Welcome to a C++ Combat Game!" << endl;
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 2); //red
	cout << right << setw(56) << "Created by Ronil Sedani." << endl;
	cout << endl;
	cout << endl;
	cout << endl;
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 7); //white
	cout << right << setw(51) << "(1) Start Game " << endl;
	cout << right << setw(51) << "(2) How to Play" << endl;
	cout << right << setw(44) << "(3) Quit" << endl;
	cout << endl;
	cout << right << setw(55) << "Please choose a Number: " << flush;
	cin >> input;
	if (input == 1) {
		Battle();		//Starts Battle.
	}
	else if (input == 2) {
		HowToPlay();	//Shows Instructions on how to play.
	}
	else if (input == 3) {
		exit(0);		//exits game.
	}
	else {			//Verification check to ensure appropriate No. is chosen.
		cout << endl;
		cout << right << setw(63) << "Wrong Input! Please type 1, 2 or 3." << endl;
		system("Pause");
		cin.clear();
		cin.ignore(256, '\n');
		Title();	//To loop back and restart function untill appropriate No. is chosen.
	}

}



int main()
{
	Player player;	//Declaring class object.
	Enemy enemy;	//Declaring class object.
	Title();		//Boots up Main Menu/Title Screen.


	return 0;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
