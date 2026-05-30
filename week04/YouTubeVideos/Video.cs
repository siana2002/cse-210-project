using System;
using System.ComponentModel.DataAnnotations;
using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> _commentList = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _commentList.Add(comment);
    }

    public int NumberOfComments()
    {
        int commentCount = 0;

        foreach (Comment comment in _commentList)
        {
            commentCount = commentCount + 1;
        }

        return commentCount;
    }
}