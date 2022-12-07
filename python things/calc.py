import sys

while True:
    num1 = float(input("What is the first number"))
    num2 = float(input("What is the second number: "))
    oper = input("What Operation: ")
    print("The soloution is:", end=" ")
    if(oper == "/"):
        print(num1 / num2)
        quit()

    elif(oper == "*"): 
        print(num1 * num2)
        quit()

    elif(oper == "+"):
        print(num1 + num2)
        quit()

    elif(oper == "-"):
        print(num1 - num2)
        quit()

    else:
        print("Not a Valid Option.")
        continue



