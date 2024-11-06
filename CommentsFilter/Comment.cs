namespace CommentsFilter;

public class Comment
{
    private string RawComment { get; set; }
    private string SanitizedComment { get; set; }

    public Comment(string rawComment, string sanitizedComment)
    {
        RawComment = rawComment;
        sanitizedComment = sanitizedComment;
    }
}