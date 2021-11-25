// taak6a1_6.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

int main()
{
    int g1;
    int g2;
    int g3;
    int reeks;

    cout << "geef het eerste getal: ";
    cin >> g1;
    cout << "geef het tweede getal: ";
    cin >> g2;
    cout << "geef het derde getal: ";
    cin >> g3;

    cout << g2 << "x" << g1 << "=" << g2 * g1 << endl;

    while (g2 != g3) {
        g2++;
        cout << g2 << "x" << g1 << "=" << g2 * g1 << endl;
    }
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
