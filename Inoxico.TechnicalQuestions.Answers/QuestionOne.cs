
namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionOne
    {
        public static int GetLongestSentance(string s)
        { 
            s = "We test coders. Give us a try?";
            		string[] words = s.Split(' ', '.','?');
               
			foreach (var word in words)
				{
    			Console.WriteLine(word);
				}    
        }
    }
}




