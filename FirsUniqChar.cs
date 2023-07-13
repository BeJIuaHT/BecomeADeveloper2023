using System.Collections.Generic;

namespace BecomeADeveloper2023
{
    public static class FirsUniqChar
    {
        public static string Finde(string str)
        {
            
            
            var firstUniq = FindeFirst(str);
            return FindeFirst(firstUniq);

            string FindeFirst(string s)
            {
                List<char> list = new List<char>(str.Length / 10);
                var uniq = new Queue<char>();
                var notUniq = new HashSet<char>();
                foreach (char c in s)
                {
                    if (c != ' ') // заповнюемо данні по першому слову доки не знайдемо пробіл
                    {
                        if (!notUniq.Contains(c))
                        {
                            if (!uniq.Contains(c))
                            {
                                uniq.Enqueue(c);
                            }
                            else
                            {
                                notUniq.Add(c);
                            }
                        }
                    }
                    else
                    {
                        if (uniq.Count > 0)
                        {
                            var firstC = uniq.Dequeue();
                            while (notUniq.Contains(firstC)) //шукаемо першу унікальну литеру
                            {
                                if (uniq.Count > 0) 
                                firstC = uniq.Dequeue();
                                else firstC = ' ';
                            }
                            if (firstC != ' ') 
                            {
                                list.Add(firstC); //якшо така є, запамьятовуемо.
                            }
                        }
                        uniq.Clear();
                        notUniq.Clear();
                    }
                    
                }
                if (uniq.Count > 0) //у кінці речення неае пробелив тому треба запамятаті унікальну литеру останньго слова
                {
                    var firstC = uniq.Dequeue();
                    while (notUniq.Contains(firstC))
                    {
                        if (uniq.Count > 0)
                            firstC = uniq.Dequeue();
                        else firstC = ' ';
                    }
                    if (firstC != ' ')
                    {
                        list.Add(firstC);
                    }
                }
                uniq.Clear();
                notUniq.Clear();
                return new string(list.ToArray());
            }
        }
    }
}
