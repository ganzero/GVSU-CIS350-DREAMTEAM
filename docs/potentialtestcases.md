# Test Specification (if added)
 
<Description of what this section is>
 
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
