using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NewTypingGame.Model
{
    public class SentenceDB
    {
        SqlConnection connection = new SqlConnection(@"Server=.\sqlexpress;Database=TypingGame;Trusted_Connection=True;");

        public List<Line> GetSentence(int difficulty)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Lines WHERE difficulty=@difficulty", connection);
            command.Parameters.AddWithValue("@difficulty", difficulty);
            List<Line> listofLines = new List<Line>();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string lineString = reader.GetString(reader.GetOrdinal("sentence_string"));
                    int lineLength = reader.GetInt32(reader.GetOrdinal("sentence_length"));
                    listofLines.Add(new Line(lineString, lineLength));
                }
            }

            connection.Close();
            return listofLines;
        }

        /// <summary>
        /// Get random sentence from the database
        /// </summary>
        /// <param name="difficulty">User chosen difficulty of sentence</param>
        /// <returns>Sentence object</returns>
        public Line GetRandomLine(int difficulty)
        {
            List<Line> sentList = GetSentence(1);
            Random random = new Random();
            Line randomLine = sentList[random.Next(0, sentList.Count)];
            return randomLine;
        }
    }
}
