
namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionTwo
    {
        public static int GetPitDepth(int[] points)
        {
             int n = points.Length;
             int maxDepth = -1;

            while (i < n - 1)
            {
                while (i < n - 1 && points[i] <= points[i + 1])
                    i++;
                
                int P = i;
                while (i < n - 1 && points[i] > points[i + 1])
                    i++;
                int Q = i;
                while (i < n - 1 && points[i] < points[i + 1])
                    i++;
                int R = i;
                if (P < Q && Q < R && points[P] > 0)
                {
                    int depth = Math.Min(points[P] - points[Q], points[R] - points[Q]);
                    maxDepth = Math.Max(maxDepth, depth);
                }
            }
            return maxDepth;
        }
    }
}
