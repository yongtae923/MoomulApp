using System;
using System.Collections.Generic;

namespace MoomulApp.Models;

public class Box
{
    public Ulid Id { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public string Type { get; set; }
    public DateTimeOffset? OpenedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
    public List<Conversation> Conversations { get; set; }
}