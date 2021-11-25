// Taak5e.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

int main()
{
    int Cabine;
    int LCabine;
    int HCabine;
    int Wiel;


    cout << "Wat is de lengte van een zijde van de bestuurscabine? ";
    cin >> Cabine;
    cout << "Wat is de lengte van de laadcabine? ";
    cin >> LCabine;
    cout << "Wat is de hoogte van de laadcabine? ";
    cin >> HCabine;
    cout << "Wat is de Diameter van het wiel? ";
    cin >> Wiel;

    cout << "De opp van de vrachtwagen is: " << Cabine * Cabine + LCabine * HCabine + Wiel * Wiel * 3.14 / 4;
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
