// Taak 6a1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

int main()
{
    int getal = -1;
	int som = 0;
	int aantal = 0;

	while (getal != 0)
	{
		cout << "geef een getal ";
		cin >> getal;
		som = som + getal;
		aantal = aantal + 1;
	}

	aantal - 1;
	cout << "U totaal getal is " << som << " U heeft " << aantal << " getallen ingeven.";
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
