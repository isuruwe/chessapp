using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Chess
{
    public partial class MainForm : Form, UIBoard
    {
        const int PADDING = 10;
        const string DATA_PATH = "../data/";

        private PictureBox[][] Board;
        Graphics graphics = new Graphics(DATA_PATH);

        private void CreateBoard()
        {
           
            Board = new PictureBox[8][];
            for (int i = 0; i < 8; i++)
            {
                Board[i] = new PictureBox[8];
                for (int j = 0; j < 8; j++)
                {
                    Board[i][j] = new PictureBox();
                    Board[i][j].Parent = this.splitView.Panel1;
                    Board[i][j].Click += BoardClick;
                   // Board[i][j].BackColor = ((j + i) % 2 == 0) ? Color.Black : Color.White;
                    Board[i][j].BackgroundImage = ((j + i) % 2 == 0) ? System.Drawing.Image.FromFile(DATA_PATH+ "blackb.png") : System.Drawing.Image.FromFile(DATA_PATH + "whiteb.png");


                    Board[i][j].SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }

           
            ResizeBoard(null, null);
        }

        private void ResizeBoard(object sender, EventArgs e)
        {
            
            if (Board == null || Board[0] == null || Board[0][0] == null) return;

            
            int val = Math.Min(this.splitView.Panel1.Height - PADDING * 2, this.splitView.Panel1.Width - PADDING * 2);

            
            int width = val / 8;
            int height = val / 8;

           
            int left = (this.splitView.Panel1.Width - val) / 2;
            int top = (this.splitView.Panel1.Height - val) / 2;

            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    Board[i][j].Left = j * width + left;
                    Board[i][j].Top = val - (i + 1) * height + top;
                    Board[i][j].Width = width;
                    Board[i][j].Height = height;
                }
        }

        private void SetPiece(Piece piece, Player player, int letter, int number)
        {
            
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => SetPiece(piece, player, letter, number)));
                return;
            }

            
            if (letter < 0 || letter > 7 || number < 0 || number > 7)
                return; 

            
            if (piece == Piece.NONE)
            {
                Board[number][letter].Image = null;
                Board[number][letter].Invalidate();
                return;
            }

           
            Board[number][letter].Image = graphics.Pieces[player][piece];
            Board[number][letter].Invalidate();
        }

        private void BoardClick(object sender, EventArgs e)
        {
            if (chess != null && !m_checkmate)
            {
               
                for (int i = 0; i < 8; i++)
                    for (int j = 0; j < 8; j++)
                        //Board[i][j].BackColor = ((i + j) % 2 == 0) ? Color.Black : Color.White;
                Board[i][j].BackgroundImage = ((i + j) % 2 == 0) ? System.Drawing.Image.FromFile(DATA_PATH + "blackb.png") : System.Drawing.Image.FromFile(DATA_PATH + "whiteb.png");

                for (int i = 0; i < 8; i++)
                {
                    int k = Array.IndexOf(Board[i], sender);
                    if (k > -1)
                    {
                       
                        if ((!m_manualBoard || m_finalizedBoard) && !m_aigame)
                        {
                            List<position_t> moves = chess.Select(new position_t(k, i));
                            foreach (position_t move in moves)
                            {
                                if ((chess.Board.Grid[move.number][move.letter].player != chess.Turn
                                    && chess.Board.Grid[move.number][move.letter].piece != Piece.NONE)
                                    || LegalMoveSet.isEnPassant(chess.Board, new move_t(chess.Selection, move)))
                                {
                                    
                                   // Board[move.number][move.letter].BackColor = Color.Red;
                                    Board[move.number][move.letter].BackgroundImage = System.Drawing.Image.FromFile(DATA_PATH + "red.png");
                                }
                                else
                                {
                                    
                                   // Board[move.number][move.letter].BackColor = Color.Yellow;
                                    Board[move.number][move.letter].BackgroundImage = System.Drawing.Image.FromFile(DATA_PATH + "yellow.png");
                                }
                            }
                        }
                       
                        else
                        {
                            chess.Board.SetPiece(m_manualPiece, m_manualPlayer, k, i);
                            SetPiece(m_manualPiece, m_manualPlayer, k, i);

                            if (m_manualPiece == Piece.KING)
                            {
                                if (m_manualPlayer == Player.WHITE)
                                {
                                   
                                }
                                else
                                {
                                   
                                }

                                
                            }
                        }
                    }
                }
            }
        }
    }
}
