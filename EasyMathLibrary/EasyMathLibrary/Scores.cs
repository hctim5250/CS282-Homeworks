using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMathLibrary
{
    public enum SortBy
    { Chinese, English, Math, Total }

    public class Scores : IComparable
    {
        #region 屬性的定義

        public int ChineseScores { get; set; }

        public int EnglishScores { get; set; }

        public int MathScores { get; set; }

        private static Random random;

        public static SortBy SortByField;

        public int Total
        {
            get
            {
                return ChineseScores + EnglishScores + MathScores;
            }
        }

        #endregion 屬性的定義

        #region 建構式

        public Scores(int ChineseScores, int EnglishScores, int MathScores)
        {
            this.ChineseScores = ChineseScores;
            this.EnglishScores = EnglishScores;
            this.MathScores = MathScores;
        }

        public Scores()
            : this(0, 0, 0)
        {
        }

        public Scores(Scores scores)
            : this(scores.ChineseScores, scores.EnglishScores, scores.MathScores)
        {
        }

        #endregion 建構式

        public void Print()
        {
            Console.WriteLine("Chinese:{0}, English: {1}, Math: {2}, Total: {3}", this.ChineseScores, this.EnglishScores, this.MathScores, this.Total);
        }

        public static Scores Generate(int min, int max)
        {
            if (EasyMathLibrary.Scores.random == null)
                EasyMathLibrary.Scores.random = new Random();
            int ChineseScores = random.Next(min, max);
            int EnglishScores = random.Next(min, max);
            int MathScores = random.Next(min, max);

            return new Scores(ChineseScores, EnglishScores, MathScores);
        }

        public static Scores[] Generate(int count, int min, int max)
        {
            Scores[] scores = new Scores[count];
            for (int index = 0; index < scores.Length; index++)
            {
                scores[index] = Scores.Generate(min, max);
            }
            return scores;
        }

        public int CompareTo(object obj)
        {
            Scores other = obj as Scores;
            switch (SortByField)
            {
                case SortBy.Chinese:
                    return Compare(this.ChineseScores, other.ChineseScores);

                case SortBy.English:
                    return Compare(this.EnglishScores, other.EnglishScores);

                case SortBy.Math:
                    return Compare(this.MathScores, other.MathScores);

                case SortBy.Total:
                    return Compare(this.Total, other.Total);

                default:
                    return Compare(this.Total, other.Total);
            }
        }

        private int Compare(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a < b)
                return -1;
            else
                return 0;
        }
    }
}