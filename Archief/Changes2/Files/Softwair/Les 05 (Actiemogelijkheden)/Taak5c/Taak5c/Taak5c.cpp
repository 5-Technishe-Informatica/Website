// Taak5c.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

int main()
{
    int Lenkte1;
    int Lenkte2;
    int Lenkte3;
    int Lenkte4;

    cout << "Geef lenkte 1: ";
    cin >> Lenkte1;
    cout << "Geef lenkte 2: ";
    cin >> Lenkte2;
    cout << "Geef lenkte 3: ";
    cin >> Lenkte3;
    cout << "Geef lenkte 4: ";
    cin >> Lenkte4;

    cout << "De omtrek van de 4 hoek is: " << Lenkte1 + Lenkte2 + Lenkte3 + Lenkte4;
    
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
