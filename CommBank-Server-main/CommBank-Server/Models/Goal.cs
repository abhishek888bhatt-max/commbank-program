using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CommBank.Models;

public class Goal
[BsonId]
[BsonRepresentation(BsonType.ObjectId)]
public string? Id { get; set; }

public string? Name { get; set; }

public ulong TargetAmount { get; set; } = 0;

public double Balance { get; set; } = 0.00;

public DateTime Created { get; set; } = DateTime.Now;

// Optional icon field (TASK REQUIREMENT)
public string? Icon { get; set; } 