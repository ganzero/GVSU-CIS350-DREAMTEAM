# Overview
 
This document serves as the SRS for the Dream Team’s project. It describes and explains the functional and non-functional requirements for a Checkers game made with Unity and C#. These requirements are composed of distinct categories with specific requirements for each category. Within each category and accompanying requirements, the specifications for creation and implementation of the necessary software are provided.
# Software Requirements
 
The following requirements describe how the software should be implemented, maintained, and function.
 
## Functional Requirements
 
###  Piece 
| ID  | Requirement     | Test Cases |
| :-------------: | :----------: | :----------: |
| FR1 |  There shall be 12 white, round checker pieces and 12 black, round checker pieces with identical designs. | TC5 |
| FR2 |  The game pieces selected by the players shall be highlighted when selected to show the  users their currently selected pieces. | TBD |
| FR3 |  After a piece has reached the opposite side of the board relative to their starting position, the piece shall be “kinged” and a crown shall be displayed on the piece as a symbol.  | TC3 |
| FR4 |  The pieces shall not overlap the squares on the grid.  | TBD |
| FR5 |  The pieces shall not be altered after initial creation.  | TBD |
| … | … |


###  Board 
 
| ID  | Requirement     | Test Cases |
| :-------------: | :----------: | :----------: |
| FR6 |  The checkerboard shall be 2-dimensional. | TBD |
| FR7 |  The pieces shall be 3-dimensional. | TBD |
| FR8 |  The checkerboard shall be composed of an 8x8 grid composed of squares. | TBD |
| FR9 |  The squares in the grid shall be larger than one checkers piece, but not larger than two. | TBD |
| FR10 |  The checkerboard shall not be altered after initial creation.| TBD |
| … | … |

###  Movements 
 
| ID  | Requirement | Test Cases |
| :-------------: | :----------: | :----------: |
| FR11 |  The system shall only allow diagonal movement of pieces. | TBD |
| FR12 |  The pieces shall be allowed to move forward diagonally one square initially until they reach a square on the opposite side of the board relative to their initial starting point. | TC1 |
| FR13 |  If a piece has been kinged, the piece shall be allowed to move diagonally in any direction. | TC4 |
| FR14 |  The pieces shall only move onto empty squares. | TBD |
| FR15 |  The pieces shall be allowed to jump over and capture enemy pieces if there is an empty square directly behind the enemy piece forming a diagonal line. | TC2 |
| … | … |
 
## Non-Functional Requirements
 
###  Game Play 
 
| ID  | Requirement     | Test Cases |
| :-------------: | :----------: | :----------: |
| NFR1 |  The system shall only allow each player to interact with their own pieces. | TBD |
| NFR2 |  A user shall be able to easily select pieces; however, once a piece is moved, the action cannot be undone. | TBD |
| NFR3 |  Pieces shall be destroyed after being captured. | TBD |
| NFR4 |  Players shall choose whether or not to capture or ignore an opponent’s piece if they can capture it. | TBD |
| NFR5 |  Players shall be given an extra turn after capturing an enemy piece. | TBD |
| … | … |

###  System Features 
 
| ID  | Requirement     | Test Cases |
| :-------------: | :----------: | :----------: |
| NFR6 |  A player shall be able to move immediately after the previous player. | TC10 |
| NFR7 |  The game application shall not crash nor shall it crash the device it is installed to when opened by the user. | TC9 |
| NFR8 |  The application shall load on both mobile and desktop. | TC8 |
| NFR9 |  The game shall be available for both Apple and Android mobile devices.| TBD |
| NFR10 |  Upon victory, the game shall reset the board, allowing players to continue until they desire to exit the game.| TC6, TC7 |
| … | … |


###  Multiplayer 
 
| ID  | Requirement     | Test Cases |
| :-------------: | :----------: | :----------: |
| NFR11 |  One to two players shall be allowed to play the same game at the same time.  | TBD |
| NFR12 |  The players shall enter their names in the lobby.  | TBD |
| NFR13 |  The game shall begin with a minimum of one player and a maximum of two players. | TBD |
| NFR14 |  The application shall require the use of Photon.  | TBD |
| NFR15 |  The players shall have the option of joining a room and leaving a room.  | TBD |
| … | … |

# Software Artifacts
 
The following includes links to diagrams, use cases, and timelines used in creating the Checkers project.

* [Capture use case](https://github.com/ganzero/GVSU-CIS350-DREAMTEAM/blob/master/artifacts/use_case_diagrams/Capture.md)
* [Move use case](https://github.com/ganzero/GVSU-CIS350-DREAMTEAM/blob/master/artifacts/use_case_diagrams/Move.md) 
* [King use case](https://github.com/ganzero/GVSU-CIS350-DREAMTEAM/blob/master/artifacts/use_case_diagrams/Crown.md) 
* [Timeline](https://github.com/ganzero/GVSU-CIS350-DREAMTEAM/blob/master/docs/Gantt_Chart.pdf) 
 
# Test Specification
 
Test Cases for Checkers

## Unit tests
  
| ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC1 | Move Piece | Select and move piece to desired location | Click on piece, drag to desired placement, click | Piece moves to selected location | Piece moves to selected location | Pass | FR12 |
 
| ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC2 | Take Piece | Move piece over enemy piece and remove it | Click on piece, drag to opposite side of enemy piece, click | The selected piece moves and the enemy piece is removed | The selected piece moves and the enemy piece is removed | Pass | FR15 |
 
| ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC3 | King Piece | Move piece to the opposite end of the board | Click on piece, drag to the opponent's starting line, click | Piece appears and behaves as a king | Piece appears and behaves as a king | Pass | FR3 |
 
| ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC4 | King Move | Move a king piece one space in any diagonal direction | Click on a king, drag to desired placement, click | King moves backward or forward | King moves backward or forward | Pass | FR13 |
 
## Integration tests

| ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC5 | Piece Placement | Start the game | Click on start game | 24 black and white checker pieces start on squares according to official checker rules | 24 black and white checker pieces start on squares according to official checker rules | Pass | FR1 |
 
| ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC6 | Reset Board | End the game | Win or lose by getting rid of all pieces of a color | Board is reset to starting position is ready for play | Board is cleared of all pieces | Fail | NFR10 |
 
| ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC7 | Stable Board | Take any action | Move, click, drag, and play | The board is unaltered, but pieces may move | The board is unaltered, but pieces may move | Pass | FR10 |

## System tests

| ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC8 | Mobile Play | Load game on mobile | In a mobile browser, visit https://srock2000.itch.io/checkers-win | Game is loaded and may be played | Game is loaded and may be played | Pass | NFR8 |
 
| ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC9 | No Crashes | Play game | Play game on mobile or desktop and try any inputs | Game plays without crashing | Game plays without crashing | Pass | NFR7 |
 
| ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC10 | Player Turn | Move a piece | Current player move a piece | Opponent's turn begins and they may move a piece | Opponent's turn begins and they may move a piece | Pass | NFR6 |



