using System;

namespace MoomulApp.Models;

public class Message
{
    public Ulid Id { get; set; }
    public Ulid SenderId { get; set; }
    public string Content { get; set; }
}