import random

def printboard(board):
    print ("\n" + " ".join(board[6:]) + ("\n") +
                  " ".join(board[3:6]) + ("\n") +
                  " ".join(board[0:3]))

def is_line_winner(cells):
   winner = 0
   unique = set(cells)
   for cell in unique:
       if '-' not in unique and len(unique) == 1:
           if 'x' in unique:
              winner = 1
           else:
              winner = 2
   return winner

def is_diag_winner(board):
    winner = 0
    lr = set(board[0::4])
    rl = set(board[2:8:2])
    if len(lr) == 1 and board[0] != '-':
        if board[0] == 'x':
            winner = 1
        else:
            winner = 2
    if len(rl) == 1 and board[2] != '-':
        if board[2] == 'x':
            winner = 1
        else:
            winner = 2
    return winner

def tictactoe():
    board = ['-']*9
    playing = True
    winner = 0
    turn = random.randint(1,2)

    while playing:
        printboard(board)
        index = input('Player {}: '.format(turn))
        if index.isdigit():
            index = int(index) - 1

        if (not isinstance(index, str) and
            index <= len(board) and
            board[index] == '-' ):
            if turn == 1:
                board[index] = 'x'
                turn = 2
            elif turn == 2:
                board[index] = 'o'
                turn = 1
        else:
            print('\nhuh?')

        rows = [board[0:3], board[3:6], board[6:]]
        cols = [board[0::3], board[1::3], board[2::3]]

        for row in rows:
            if is_line_winner(row) > 0:
                winner = is_line_winner(row)
        for col in cols:
            if is_line_winner(col) > 0:
                winner = is_line_winner(col)
        if is_diag_winner(board) > 0:
            winner = is_diag_winner(board)

        if winner > 0:
            playing = False
            printboard(board)
            print('\nWinner: Player {}'.format(winner))
        elif '-' not in board:
            playing = False
            print('\nDRAW!')

over = False
while not over:
    tictactoe()
    answer = input('Play again? (y/n) ')
    if answer.lower() != 'y':
        over = True
