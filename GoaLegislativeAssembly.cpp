//Author:Sabah Sayed
//Roll No.:37
//Title:Implementation of Goa Legislative Assembly using OOP concept
//Start Date:22 july 2024
//Modified Date:22 july 2024
//Description:Implementation of Goa Legislative Assembly using OOP concept.This program has Main class , Member class, Committe class, Bill class.



#include <iostream>
#include <vector>
#include <string>
using namespace std;

// Member class
class Member {
private:
    string name;
    string constituency;

public:
    Member(string name, string constituency) : name(name), constituency(constituency) {}

    string toString() const {
        return "Name: " + name + ", Constituency: " + constituency;
    }
};

// Committee class
class Committee {
private:
    string name;
    string chairman;

public:
    Committee(string name, string chairman) : name(name), chairman(chairman) {}

    string toString() const {
        return "Committee: " + name + ", Chairman: " + chairman;
    }
};

// Bill class
class Bill {
private:
    string title;
    string introducedBy;

public:
    Bill(string title, string introducedBy) : title(title), introducedBy(introducedBy) {}

    string toString() const {
        return "Bill Title: " + title + ", Introduced By: " + introducedBy;
    }
};

void displayMenu() {
    cout << "\nGoa Legislative Assembly Management System\n";
    cout << "1. Add Member\n";
    cout << "2. View Members\n";
    cout << "3. Add Committee\n";
    cout << "4. View Committees\n";
    cout << "5. Add Bill\n";
    cout << "6. View Bills\n";
    cout << "7. Exit\n";
    cout << "Choose an option: ";
}

int main() {
    vector<Member> members;
    vector<Committee> committees;
    vector<Bill> bills;
    int choice;

    while (true) {
        displayMenu();
        cin >> choice;
        cin.ignore(); // consume newline

        switch (choice) {
            case 1: {
                string memberName, constituency;
                cout << "Enter Member Name: ";
                getline(cin, memberName);
                cout << "Enter Constituency: ";
                getline(cin, constituency);
                members.emplace_back(memberName, constituency);
                cout << "Member added successfully.\n";
                break;
            }
            case 2:
                cout << "Members of the Assembly:\n";
                for (const auto& member : members) {
                    cout << member.toString() << endl;
                }
                break;
            case 3: {
                string committeeName, chairman;
                cout << "Enter Committee Name: ";
                getline(cin, committeeName);
                cout << "Enter Chairman: ";
                getline(cin, chairman);
                committees.emplace_back(committeeName, chairman);
                cout << "Committee added successfully.\n";
                break;
            }
            case 4:
                cout << "Committees of the Assembly:\n";
                for (const auto& committee : committees) {
                    cout << committee.toString() << endl;
                }
                break;
            case 5: {
                string billTitle, introducedBy;
                cout << "Enter Bill Title: ";
                getline(cin, billTitle);
                cout << "Enter Introduced By: ";
                getline(cin, introducedBy);
                bills.emplace_back(billTitle, introducedBy);
                cout << "Bill added successfully.\n";
                break;
            }
            case 6:
                cout << "Bills in the Assembly:\n";
                for (const auto& bill : bills) {
                    cout << bill.toString() << endl;
                }
                break;
            case 7:
                cout << "Exiting...\n";
                return 0;
            default:
                cout << "Invalid option. Please try again.\n";
                break;
        }
    }

    return 0;
}
