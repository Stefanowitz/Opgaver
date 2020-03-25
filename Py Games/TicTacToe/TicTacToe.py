# ---- Global Variables -------

# Game board
board = ["-", "-", "-",
         "-", "-", "-",
         "-", "-", "-"]

# if game is still going
game_still_going = True

# Who Won? OR tie?
winner = None

# Who's turn is it
current_player = "X"


# Display the game board
def display_board():
    print(board[0] + " | " + board[1] + " | " + board[2])
    print(board[3] + " | " + board[4] + " | " + board[5])
    print(board[6] + " | " + board[7] + " | " + board[8])


# Playe a game of tic tac toe
def play_game():

    # display initial board
    display_board()
    # While the game is still going
    while game_still_going:

        # handle a single turn of an arbitrary player
        handle_turn(current_player)

        # check if the game has ended or not
        check_if_game_over()

        # Filp to the other player
        flip_player()

    # The game has ended
    if winner == "X" or winner == "O":
        print(winner + " Won.")
    elif winner is None:
        print("Tie")


# handle a single turn of an arbitrary player
def handle_turn(player):
    global game_still_going
    print(player + "'s Turn")
    position = input("Choose a position from 1-9: ")
    valid = False
    while not valid:
        if position not in ["1", "2", "3", "4", "5", "6", "7", "8", "9"]:
            position = input("Invalid input: Choose a position from 1-9: ")
            while position not in ["1", "2", "3", "4", "5", "6", "7", "8", "9"]:
                position = input("Are you Stupid i said from 1-9!!!!!: ")
        position = int(position) - 1
        if board[position] == "-":
            valid = True
        else:
            print("That is cheating please. Try again")

    board[position] = player
    display_board()


def check_if_game_over():
    check_for_winner()
    check_if_tie()


def check_for_winner():
    global winner

    # check rows
    row_winner = check_rows()
    # check columns
    columns_winner = check_columns()
    # check diagonals
    diagonals_winner = check_diagonals()

    if row_winner:
        winner = row_winner
    elif columns_winner:
        winner = columns_winner
    elif diagonals_winner:
        winner = diagonals_winner
    else:
        winner = None
    return


def check_rows():
    global game_still_going
    # check if the same value in a row while not empty
    row_1 = board[0] == board[1] == board[2] != "-"
    row_2 = board[3] == board[4] == board[5] != "-"
    row_3 = board[6] == board[7] == board[8] != "-"
    if row_1 or row_2 or row_3:
        game_still_going = False

    # return the winner (X or O)
    if row_1:
        return board[0]
    elif row_2:
        return board[3]
    elif row_3:
        return board[6]
    return


def check_columns():
    global game_still_going
    # check if the same value in a row while not empty
    columns_1 = board[0] == board[3] == board[6] != "-"
    columns_2 = board[1] == board[4] == board[7] != "-"
    columns_3 = board[2] == board[5] == board[8] != "-"
    if columns_1 or columns_2 or columns_3:
        game_still_going = False

    # return the winner (X or O)
    if columns_1:
        return board[0]
    elif columns_2:
        return board[1]
    elif columns_3:
        return board[2]
    return


def check_diagonals():
    global game_still_going
    # check if the same value in a row while not empty
    diagonals_1 = board[0] == board[4] == board[8] != "-"
    diagonals_2 = board[6] == board[4] == board[2] != "-"
    if diagonals_1 or diagonals_2:
        game_still_going = False

    # return the winner (X or O)
    if diagonals_1:
        return board[0]
    elif diagonals_2:
        return board[6]
    return


def check_if_tie():
    global game_still_going
    if "-" not in board:
        game_still_going = False
    return


def flip_player():
    global current_player

    if current_player == "X":
        current_player = "O"
    elif current_player == "O":
        current_player = "X"

    return


play_game()
