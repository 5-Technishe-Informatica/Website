// Taak 6a2.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

int main()
{
	int getal1;
	int getal2;
	
	cout << "Geef een getal in. ";
	cin >> getal1;
	cout << "Geef nog een getal in. ";
	cin >> getal2;

	int teller = getal1;
	int som = teller;

	while (teller < getal2)
	{
		teller = teller +1;
		som = som + teller;
	}

	som = som - getal1 - getal2;
	cout << "De som van alle getallen tussen het de ingegeven getallen is. " << som;

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
