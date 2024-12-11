const board = Array(6).fill().map(() => Array(7).fill(null));
let currentPlayer = "red";

function dropPiece(column) {
    for (let row = 5; row >= 0; row--) {
        if (!board[row][column]) {
            board[row][column] = currentPlayer;
            currentPlayer = currentPlayer === "red" ? "yellow" : "red";
            break;
        }
    }
}
//try