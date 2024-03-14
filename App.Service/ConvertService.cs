

using System.Text.RegularExpressions;

namespace App.Service
{
    public class ConvertService
    {
        private const string Pattern = @"^\s*#{1,6}\s\S{1}.*$";
        private Regex _regex;
        public ConvertService()
        {
            _regex = new Regex(Pattern);
        }
        public string MarkdownToHtml(string markdown)
        {
            if(string.IsNullOrEmpty(markdown)) 
                return string.Empty;
            if (_regex.IsMatch(markdown))
            {
                int startIndex = markdown.IndexOf('#');
                int count = markdown.IndexOf(' ', startIndex) - startIndex;
                markdown = markdown.Remove(startIndex, count + 1);
                string html = markdown.Insert(startIndex, string.Format("<h{0}>", count));
                html = string.Format("{0}</h{1}>", html, count);
                return html;
            }
            return markdown;
        }
    }
}
