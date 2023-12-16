namespace DefaultNamespace;

using System;

public class WordSearch
{

    public static bool Dfs(char[][] board, string word, int i, int j, int k)
    {
        if (i < 0 || i >= board.Length || j < 0 || j >= board[0].Length || board[i][j] != word[k])
        {
            return false;
        }

        if (k == word.Length-1)
        {
            return true;
        }
        
        //mark as visited
        char temp = board[i][j];
        board[i][j] = '/';

        bool result = Dfs(board, word, i - 1, j, k + 1)
                      || Dfs(board, word, i + 1, j, k + 1)
                      || Dfs(board, word, i, j - 1, k + 1)
                      || Dfs(board, word, i, j + 1, k + 1);

        board[i][j] = temp;
        
        return result;
    }

    public static bool Exist(char[][] board, string word)
    {
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (Dfs(board, word, i, j, 0))
                {
                    return true;
                }
            }
        }

        return false;
    }
    
}