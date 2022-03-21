/*
 * Possible normal moves:
 * 1) Piece can move diagonally left
 * 2) Piece can move diagonally right
 * 3) If enemy piece is in diagonal left and enemy piece in 2 diagonal left, then player piece can't move
 * 4) If enemy piece is in diagonal right and enemy piece in 2 diagonal right, then player piece can't move
 * 5) If piece on left edge of board gamearray[0 , ?] then piece can't move diagonally left
 * 6) If piece on right edge of board gamearray[7 , ?] then piece can't move diagonally right
 * 7) If white piece at top of board gamearray[? , 0] then white piece can't move
 * 8) If white piece at top of board gamearray[? , 7] then white piece can't move
 * 9) If same colored piece in left diagonal to piece, then piece can't move diagonally left
 * 10) If same colored piece in right diagonal to piece, then piece can't move diagonally right
 *
 * Possible capture moves:
 * 1) If enemy piece is in right diagonal and there is no other piece in 2 right diagonal, then player can perform capture move
 * 2) If enemy piece is in left diagonal and there is no other piece in 2 left diagonal, then player can perform capture move
 * 3) If capture move is completed and player piece has possible capture in any diagonal, player can perform capture.
 * 4) Capture moves have no limit to how many can be done sequentially
 * 5) If after capture move there are no other possible capture moves, player turn ends
 *
 *
 * This task should be done in an object orientated way.
 * This means referencing each object in correlation with each other, board, cells and pieces
*/

namespace RussianCheckers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Board game = new Board();
            game.GetBoard();
        }
    }
}