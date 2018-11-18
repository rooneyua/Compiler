
namespace Compiler
{
    public class Token
    {
        public const string EOF = "EOF";

        private readonly string value;

        public Token(string value)
        {
            this.value = value;
        }

        public string Value => value;
    }
}
