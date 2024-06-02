using System.Collections.Generic;

namespace XmlValidator
{
    public class SimpleXmlValidator
    {
        public static string DetermineXml(string xml)
        {
            try
            {
                if (string.IsNullOrEmpty(xml) || xml[0] != '<' || xml[xml.Length-1] != '>')
                {
                    return "Invalid";
                }

                Stack<string> stack = new Stack<string>();
                int i = 0;

                while (i < xml.Length)
                {
                    if (xml[i] == '<')
                    {
                        int close = xml.IndexOf('>', i);
                        if (close == -1)
                        {
                            return "Invalid";
                        }
                        string tag = xml.Substring(i + 1, close - i - 1);

                        if (tag.StartsWith("/"))
                        {
                            if (stack.Count == 0 || stack.Peek() != tag.Substring(1))
                            {
                                return "Invalid";
                            }
                            stack.Pop();
                        }
                        else
                        {
                            if (!IsValidTag(tag))
                            {
                                return "Invalid";
                            }
                            stack.Push(tag);
                        }
                        i = close;
                    }
                    i++;
                }

                return stack.Count == 0 ? "Valid" : "Invalid";
            }
            catch (Exception)
            {
                return "Invalid";
            }
        }

        private static bool IsValidTag(string tag)
        {
            if (string.IsNullOrWhiteSpace(tag) || tag.Contains(" ") || tag.Contains("="))
            {
                return false;
            }
            foreach (char c in tag)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
