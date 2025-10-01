
namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionOne
    {
        public static int GetLongestSentance(string s)
        { 
            string[] sentences = s.Split(new[] { ' ','.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            int max = 0;

            foreach (var sentence in sentences)
            {
                string trimmedSentence = sentence.Trim();
                string[] words = trimmedSentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (words.Length > max) 
				{ 
                    max = words.Length;
                }

            }

        return max;    
        }
    }
}




