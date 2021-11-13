// Toets 06a99.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

int main()
{
    int Resultaat;
    int OptelWaarde;

    cout << "Wat is de startwoorde voor Resultaat: ";
    cin >> Resultaat;

    while (Resultaat < 123)
    {
        cout << "Wat is de OptelWaarde: ";
        cin >> OptelWaarde;
        Resultaat += OptelWaarde;
    }

    cout << "Het resultaat bedraagt >" << Resultaat << "<";

    cout << endl;
    cout << endl;
    cout << endl;
}