#sentinal loop Guess my Number Program.
# The last question in practice 10.

from random import *


print ("Okay, I'm thinking of a number between 1 and 10.")
usrMesg = "Please enter your guess: "

while( True ):
    randNum = int(random() * 9 + 1)
    
    while ( True ):
        print (usrMesg)
        guess = int(input())
        if ( guess == randNum ):
            break
        else:
            if( guess > randNum ):
                print("Your guess is too high, guess again!")
            else:
                print("Your guess is too low, guess again!")        

    print("Congratulations!")
    
    play_again = input("Do you want to play again ['y' | 'n']: ")
    play_again = play_again.lower()
    if(play_again =='n'):
        break


print("Thank you for playing!")
