//Author:Sabah Sayed
//Roll No.:37
//Title:Implementation of Goa Legislative Assembly using OOP concept
//Start Date:22 july 2024
//Modified Date:22 july 2024
//Description:Implementation of Goa Legislative Assembly using OOP concept.This program has Main class, Member class, Committe class, Bill class.

class Member:
    def __init__(self, name, constituency):
        self.name = name
        self.constituency = constituency

    def __str__(self):
        return f"Name: {self.name}, Constituency: {self.constituency}"

class Committee:
    def __init__(self, name, chairman):
        self.name = name
        self.chairman = chairman

    def __str__(self):
        return f"Committee: {self.name}, Chairman: {self.chairman}"

class Bill:
    def __init__(self, title, introduced_by):
        self.title = title
        self.introduced_by = introduced_by

    def __str__(self):
        return f"Bill Title: {self.title}, Introduced By: {self.introduced_by}"

def main():
    members = []
    committees = []
    bills = []

    while True:
        print("\nGoa Legislative Assembly Management System")
        print("1. Add Member")
        print("2. View Members")
        print("3. Add Committee")
        print("4. View Committees")
        print("5. Add Bill")
        print("6. View Bills")
        print("7. Exit")
        choice = input("Choose an option: ")

        if choice == '1':
            name = input("Enter Member Name: ")
            constituency = input("Enter Constituency: ")
            members.append(Member(name, constituency))
            print("Member added successfully.")
        elif choice == '2':
            print("Members of the Assembly:")
            for member in members:
                print(member)
        elif choice == '3':
            name = input("Enter Committee Name: ")
            chairman = input("Enter Chairman: ")
            committees.append(Committee(name, chairman))
            print("Committee added successfully.")
        elif choice == '4':
            print("Committees of the Assembly:")
            for committee in committees:
                print(committee)
        elif choice == '5':
            title = input("Enter Bill Title: ")
            introduced_by = input("Enter Introduced By: ")
            bills.append(Bill(title, introduced_by))
            print("Bill added successfully.")
        elif choice == '6':
            print("Bills in the Assembly:")
            for bill in bills:
                print(bill)
        elif choice == '7':
            print("Exiting...")
            break
        else:
            print("Invalid option. Please try again.")

if __name__ == "__main__":
    main()
