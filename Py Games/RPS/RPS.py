import time
import sys
import random

win_count = 0
lost_count = 0
draw_count = 0


def win():
    print(f'The Game is over: You Won, You have won {win_count} Games')


def lost():
    print(f'The Game is over: You Lost, You have lost {lost_count} Games')


def draw():
    print(f'The Game is over: It was a Draw, You have been draw in {draw_count} Games')


def the_game():
    global draw_count
    global win_count
    global lost_count

    moves = ['rock', 'paper', 'scissor']

    print('Choose Your Attack: Rock, Paper, Scissor')
    attempts = 3
    while True:
        if attempts == 0:
            print('The Game Is Over: Your are TOO DUMB TO CONTINUE NOW FUCK OFF BYE')
            time.sleep(5)
            sys.exit(0)

        player = str(input('Player: ')).lower()
        if player.lower() not in moves:
            print(f'Invalid option! You Have {attempts} attempts left')
            attempts -= 1
        else:
            computer = random.choice(moves)
            print(f'Computer: Chose {computer}')

            if player == computer:
                draw_count += 1
                draw()

            elif player == 'rock' and computer == 'scissor':
                win_count += 1
                win()

            elif player == 'rock' and computer == 'paper':
                lost_count += 1
                lost()

            elif player == 'paper' and computer == 'rock':
                win_count += 1
                win()

            elif player == 'paper' and computer == 'scissor':
                lost_count += 1
                lost()

            elif player == 'scissor' and computer == 'paper':
                win_count += 1
                win()

            elif player == 'scissor' and computer == 'rock':
                lost_count += 1
                lost()
            else:
                pass

            play_again = str(input('Do you wanna play again (y/n) if you want stats type "s"'))
            if play_again.lower() == 'y':
                the_game()
            elif play_again.lower() == 'n':
                print('The Game Is Over Thank You For Playing Goodbye')
                time.sleep(3)
                sys.exit(0)
            elif play_again.lower() == 's':
                print(f'Won games {win_count}')
                print(f'lost games {lost_count}')
                print(f'draw games {draw_count}')
                time.sleep(5)
                the_game()
            else:
                print('The Game Will end now Bye')
                time.sleep(2)
                sys.exit(0)


if __name__ == '__main__':
    the_game()
