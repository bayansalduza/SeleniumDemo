using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class StringHelpers
    {
        static public string DetailsTitleCut(string[] detailTitles)
        {
            string title = "";
            for (int i = 0; i < detailTitles.Length; i++)
            {
                if (detailTitles[i].Contains("Favorilerime"))
                {
                    if (detailTitles[i + 1].Contains("Ekle"))
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (j == 0)
                                title += detailTitles[j];
                            else
                                title += " " + detailTitles[j];
                        }
                    }
                    break;
                }
            }
            return title;
        }
    }
}
