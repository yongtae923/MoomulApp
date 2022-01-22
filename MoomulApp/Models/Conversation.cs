using System;
using System.Collections.Generic;

namespace MoomulApp.Models;

public class Conversation
{
    public Ulid Id { get; set; }
    public Ulid StarterId { get; set; }
    public string Title { get; set; }
    public DateTimeOffset? UnpackedAt { get; set; }
    public DateTimeOffset? AnsweredAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
    public List<Message> Messages { get; set; }
}