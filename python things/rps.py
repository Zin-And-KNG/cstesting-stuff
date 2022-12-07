import random
import time
oops = ["safe", "e", "jik", "dead"]
user_action = input("Enter a choice (rock, paper, scissors): ")
possible_actions = ["rock", "paper", "scissors"]
if user_action not in possible_actions:
    print("you died from gun")
    quit()
computer_action = random.choice(possible_actions)
random_chanse = random.choice(oops)
print("Rock...")
time.sleep(0.5)
print("Paper..")
time.sleep(0.5)
print("Scissors...")
time.sleep(0.5)
print("Shoot!")
time.sleep(0.2)
if random_chanse == "dead":
    print("*BANG*")
    time.sleep(2)
    print("OH SHOOT! I HAD A GUN! (you died)")
    quit()
print(f"\nYou chose {user_action}, computer chose {computer_action}.\n")

if user_action == computer_action:
    print(f"Both players selected {user_action}. It's a tie!")
elif user_action == "rock":
    if computer_action == "scissors":
        print("Rock smashes scissors! You win!")
    else:
        print("Paper covers rock! You lose.")
elif user_action == "paper":
    if computer_action == "rock":
        print("Paper covers rock! You win!")
    else:
        print("Scissors cuts paper! You lose.")
elif user_action == "scissors":
    if computer_action == "paper":
        print("Scissors cuts paper! You win!")
    else:
        print("Rock smashes scissors! You lose.")