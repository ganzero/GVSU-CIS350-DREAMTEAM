# Overview

<Describe the purpose of this document in 1 paragraph of less … hint: it is
your SRS>

# Functional Requirements

1. Piece Requirements
	1. The system shall allow game pieces and board squares will have color codes #000000 for Black and #FF0000 for Red.
	2. There shall be 12 white, round checker pieces and 12 red, round checker pieces with identical designs that will not overlap the parameters of the squares in the grid.
	3. The game piece that the user selects shall be highlighted to show the user their currently selected piece.
	4. Once a player’s piece has reached the opposite side of the board, that piece shall be “kinged” and display a crown to let the player know that the piece is now a king.

2. Board Requirements
	1. The checkerboard shall be 2D and the checker pieces shall be 3D.
	2. The checkers board shall be composed of a standard 8x8 grid made of squares with the alternating colors of black and white.

3. Mechanics
	1. The System shall allow a player to restart a game.

4. Movements
	1. The system shall allow game pieces to jump diagonally over enemy pieces.
	2. The pieces shall only be allowed to move forward diagonally one square until they reach a square on the opposite side of the board relative to their initial starting point.
	3. Upon user request, a king piece shall move one square in any diagonal direction per turn, or jump.


# Non-Functional Requirements
1. Game Play
	1. The System shall allow each player to only interact with their own pieces.
	2. When a user selects any of their pieces it should be easy for them to move it to their desired square, also allow the user to select a different piece easily if they want to move another piece.
	3. Checker pieces shall be removed once the piece has been jumped by the opponent.
	4. Players shall be allowed to choose whether to capture an opponent’s piece or ignore it.
	5. If each player or team only has one piece left, the winner shall be the first player to crown their piece.

2. System Reaction
	1. Once a player makes a move, the other play shall be able to immediately (within 10ms) make a move.
	2. The game application shall not crash nor shall it crash the device it is installed to when opened by the user.

3. System Actions
	1. The game shall have a load and save option for one or more games.
	2. The checkerboard application shall load on both mobile and desktop versions.
	3. The game shall be available for both Apple and Android mobile devices.
	4. The game ends when a player cannot make a move.

4. Maintenance
	1. The source code of the checkers game shall be well organized and well commented so that it will be easy for our team members to perform maintenance and updates on the existing code.
