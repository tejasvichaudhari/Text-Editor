using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace WebApplication3
{
    public class Model : IModel
    {
        public List<String> setInfo(string text, string operation)
        {
            List<String> l = new List<string>();
            if (operation == "reverse")
            {
                if (text.Trim().Split(' ').Count() == 1)
                {
                    StringBuilder sb = new StringBuilder();

                    char[] textRever = text.Trim().ToCharArray();
                    for (int i = 1; i <= textRever.Count(); i++)
                    {
                        sb.Append(textRever[textRever.Count() - i]);
                    }
                    l.Add("Reverse characters in the word: "+ text.Trim() + ": " +Convert.ToString(sb));

                    //Array.Reverse(textRever);
                    //l.Add(new string(textRever));
                }
                else
                {
                    l.Add("Please enter a single word only.");
                }
            }
            else if (operation== "StringCharReverse")
            {
                string[] textRever = text.Trim().Split(' ');
                StringBuilder sb = new StringBuilder();

                foreach (string str in textRever)
                {
                    char[] textIntermediate = str.ToCharArray();
                    Array.Reverse(textIntermediate);
                    sb.Append(new string(textIntermediate));
                    sb.Append(" ");
                }                
                
                l.Add(Convert.ToString(sb).Trim());

            }
            else if (operation == "StringReverse")
            {
                // tejasvi chaudhari

                string[] textRever = text.Trim().Split(' ');
                StringBuilder sb = new StringBuilder();
                int i;

                for (i = 1; i <= textRever.Count(); i++)
                {
                    sb.Append(textRever[textRever.Count()-i]);
                    sb.Append(" ");
                }

                //foreach (string str in textRever)
                //{
                //    char[] textIntermediate = str.ToCharArray();
                //    //Array.Reverse(textIntermediate);
                //    sb.Append(new string(textIntermediate));
                //    sb.Append(" ");
                //}

                l.Add(Convert.ToString(sb).Trim());

            }
            else if (operation == "StringReverseWithRevChar")
            {
                string[] textRever = text.Trim().Split(' ');
                StringBuilder sb = new StringBuilder();
                int i;

                for (i = 1; i <= textRever.Count(); i++)
                {
                    char[] textIntermediate = textRever[textRever.Count() - i].ToCharArray();
                    Array.Reverse(textIntermediate);
                    sb.Append(new string(textIntermediate));
                    sb.Append(" ");
                }

                //foreach (string str in textRever)
                //{
                //    char[] textIntermediate = str.ToCharArray();
                //    //Array.Reverse(textIntermediate);
                //    sb.Append(new string(textIntermediate));
                //    sb.Append(" ");
                //}

                l.Add(Convert.ToString(sb).Trim());

            }
            return l;
        }

    }
}